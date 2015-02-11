; (function (factory) {
    'use strict';

    //CommonJS
    if (typeof require === "function" && typeof exports === "object" && typeof module === "object") {
        factory(require("jquery"), require("knockout"), exports);
        //AMD
    } else if (typeof define === "function" && define.amd) {
        define(["jquery", "knockout", "exports"], factory);
        //normal script tag
    } else {
        factory(jQuery, ko, window.Pokedex || {});
    }
}(function ($, ko, exports, undefined) {
    exports.WizardViewModel = function () {
        var self = this;

        self.activePokemon = ko.observable(0).syncWith("activatePokemon");
        self.next = ko.observable(new Navigation(null));
        self.previous = ko.observable(new Navigation(null));
        self.visible = ko.observable(false);

        ko.postbox.subscribe("activatePokemon", function (newValue) {
            if (newValue != 0) {
                self.getData();
            }
            self.visible(newValue != 0);
        });

        self.showNext = function () {
            self.activePokemon(self.next().pokemonId());
        }

        self.showPrevious = function () {
            self.activePokemon(self.previous().pokemonId());
        }

        self.backToPokedex = function () {
            self.activePokemon(0);
        }        
        
        self.getData = function () {
            $.ajax({
                url: 'api/pokedex/GetNavigationByPokemon',
                type: "GET",
                data: { pokemonId: self.activePokemon() },
                dataType: "json"
            })
            .done(function (data) {
                self.next(new Navigation(data.next));
                self.previous(new Navigation(data.previous));
            });
        }
    }

    var Navigation = function (data) {
        var self = this;

        self.hasData = data != null;
        self.pokemonId = ko.observable(self.hasData ? data.pokemonId : 0);
        self.pkId = ko.observable(self.hasData ? data.pkId : 0);
        self.name = ko.observable(self.hasData ? data.name : '');
        self.image = ko.observable(self.hasData ? data.image : '');

        self.displayName = ko.computed(function () {
            return '#' + self.pkId() + ' ' + self.name();
        });

        self.imageSrc = ko.computed(function () {
            return 'data:image/png;base64,' + self.image();
        });
    };

    $(function () {
        ko.applyBindings(new exports.WizardViewModel(), document.getElementById('wizard-display'));
    });
}));