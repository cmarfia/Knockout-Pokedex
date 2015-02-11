;(function (factory) {
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
    exports.MovesViewModel = function () {
        var self = this;

        self.activePokemon = ko.observable(0).syncWith("activatePokemon");
        self.moves = ko.observableArray().distinct('learnType');;
        self.visible = ko.observable(false);
        self.learnTypes = ['egg move', 'level up', 'machine', 'tutor', 'other'];

        ko.postbox.subscribe("activatePokemon", function (newValue) {
            if (newValue != 0) {
                self.getData();
            }
            self.visible(newValue != 0);
        });

        self.getData = function () {
            $.ajax({
                url: 'api/pokedex/GetMovesByPokemon',
                type: "GET",
                data: { pokemonId: self.activePokemon() },
                dataType: "json"
            })
            .done(function (data) {

                self.moves.removeAll();

                $.each(data, function (idx, item) {
                    self.moves.push(new Move(item));
                });
            });
        }
    }

    var Move = function (data) {
        var self = this;

        self.moveId = ko.observable(data.moveId);
        self.name = ko.observable(data.name);
        self.description = ko.observable(data.description);
        self.category = ko.observable(data.category);
        self.power = ko.observable(data.power);
        self.pp = ko.observable(data.pp);
        self.accuracy = ko.observable(data.accuracy);
        self.learnType = ko.observable(data.learnType);
    };

    ko.observableArray.fn.distinct = function (prop) {
        var target = this;
        target.index = {};
        target.index[prop] = ko.observable({});

        ko.computed(function () {
            //rebuild index
            var propIndex = {};

            ko.utils.arrayForEach(target(), function (item) {
                var key = ko.utils.unwrapObservable(item[prop]);
                if (key) {
                    propIndex[key] = propIndex[key] || [];
                    propIndex[key].push(item);
                }
            });

            target.index[prop](propIndex);
        });

        return target;
    };
    
    $(function () {
        ko.applyBindings(new exports.MovesViewModel(), document.getElementById('moves-display'));
    });
}));