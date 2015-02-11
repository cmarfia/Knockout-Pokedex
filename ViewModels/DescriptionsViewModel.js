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
    exports.DescriptionViewModel = function () {
        var self = this;

        self.activePokemon = ko.observable(0).syncWith("activatePokemon");
        self.descriptions = ko.observableArray();
        self.visible = ko.observable(false);

        ko.postbox.subscribe("activatePokemon", function (newValue) {
            if (newValue != 0) {
                self.getData();
            }
            self.visible(newValue != 0);
        });

        self.getData = function () {
            $.ajax({
                url: 'api/pokedex/GetDescriptionsByPokemon',
                type: "GET",
                data: { pokemonId: self.activePokemon() },
                dataType: "json"
            })
            .done(function (data) {

                self.descriptions.removeAll();

                $.each(data, function (idx, item) {
                    self.descriptions.push(new Description(item));
                });              
            });
        }
    }

    var Description = function (data) {
        var self = this;

        self.descriptionId = ko.observable(data.descriptionId);
        self.description = ko.observable(data.description);
        self.games = ko.observableArray();

        $.each(data.games, function (idx, item) {
            self.games.push(new Game(item));
        });

        self.numGames = ko.computed(function () {
            return self.games().length;
        });
        
    },
    Game = function (data) {
        var self = this;

        self.gameId = data.gameId;
        self.name = data.name;
        self.generation = data.generation;
        self.releaseYear = data.releaseYear;
    };   

    $(function () {
        ko.applyBindings(new exports.DescriptionViewModel(), document.getElementById('descriptions-display'));
    });
}));