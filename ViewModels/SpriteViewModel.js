;(function ($, ko) {
    'use strict';

    window.Pokedex = function (module) {
        module.SpriteViewModel = function() {
            var self = this;

            self.sprites = ko.observableArray();
            self.activePokemon = ko.observable(0).syncWith("activatePokemon");

            ko.postbox.subscribe("activatePokemon", function (newValue) {
                if (newValue != 0) {
                    self.getData();
                }
            });

            self.getData = function () {
                $.ajax({
                    url: 'api/pokedex/GetSpritesByPokemon',
                    type: "GET",
                    data: { pokemonId: self.activePokemon() },
                    dataType: "json"
                })
                .done(function (data) {

                    self.sprites.removeAll();

                    $.each(data, function (idx, item) {
                        self.sprites.push(new Sprite(item));
                    });
                });
            }
        }

        var Sprite = function (data) {
            var self = this;

            self.spriteId = ko.observable(data.spriteId);
            self.image = ko.observable(data.image !== null && data.image !== '' ? data.image : '');
            
            self.imageSrc = ko.computed(function () {
                return 'data:image/png;base64,' + self.image();
            });
        }        

        $(function () {
            ko.applyBindings(new module.SpriteViewModel(), document.getElementById('sprites-display'));
        });

        return module;
    }(window.Pokedex || {});
}(jQuery, ko));