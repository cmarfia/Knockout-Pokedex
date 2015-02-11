;(function ($, ko) {
    'use strict';

    window.Pokedex = function (module) {
        module.PokedexViewModel = function(data) {
            var self = this;

            self.pokedex = ko.observableArray();
            self.activePokemon = ko.observable(0).syncWith("activatePokemon");
            self.totalRecords = ko.observable(data.totalRecords);
            self.pager = ko.pager(self.totalRecords);
            self.pager().PageSize(5);

            self.activatePokemon = function () {
                self.activePokemon(this.pokemonId());
            }

            self.pager().CurrentPage.subscribe(function () {
                self.getData();
            });

            ko.postbox.subscribe("activatePokemon", function (newValue) {
                if (newValue == 0) {
                    self.pager().CurrentPage(1);
                }
            });

            self.getData = function () {
                $.ajax({
                    url: 'api/pokedex/GetPokedex',
                    type: "GET",
                    data: { pageNumber: self.pager().CurrentPage(), pageSize: self.pager().PageSize() },
                    dataType: "json"
                })
                .done(function (data) {
                    self.pokedex.removeAll();

                    $.each(data.pokemon, function (idx, item) {
                        self.pokedex.push(new Pokemon(item));
                    });
                });
            }
        }

        var Pokemon = function (data) {
            var self = this;

            self.attack = ko.observable(data.attack);
            self.defense = ko.observable(data.defense);
            self.height = ko.observable(data.height);
            self.hp = ko.observable(data.hp);
            self.image = ko.observable(data.image !== null && data.image !== '' ? data.image : '');
            self.name = ko.observable(data.name);
            self.pkId = ko.observable(data.pkId);
            self.pokemonId = ko.observable(data.pokemonId);
            self.spAttack = ko.observable(data.spAttack);
            self.spDefense = ko.observable(data.spDefense);
            self.speed = ko.observable(data.speed);
            self.weight = ko.observable(data.weight);

            self.displayName = ko.computed(function () {
                return '#' + self.pkId() + ' ' + self.name();
            });

            self.imageSrc = ko.computed(function () {
                return 'data:image/png;base64,' + self.image();
            });            
        }

        $(function () {
            $.ajax({
                url: 'api/pokedex/GetPokedex',
                type: "GET",
                data: { pageNumber: 1, pageSize: 5 },
                dataType: "json"
            })
            .done(function (data) {
                var vm = new module.PokedexViewModel(data);
                
                $.each(data.pokemon, function (idx, item) {
                    vm.pokedex.push(new Pokemon(item));
                });

                ko.applyBindings(vm, document.getElementById('pokedex-grid'));
            });

        });
        
        return module;
    }(window.Pokedex || {});
}(jQuery, ko));