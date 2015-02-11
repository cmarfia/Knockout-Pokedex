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
    exports.StatsViewModel = function () {
        var self = this;

        self.activePokemon = ko.observable(0).syncWith("activatePokemon");
        self.pokemon = ko.observable(new Pokemon());
        self.visible = ko.observable(false);
        
        ko.postbox.subscribe("activatePokemon", function (newValue) {
            if (newValue != 0) {
                self.getData();
            }
            self.visible(newValue != 0);
        });
        
        self.getData = function () {
            $.ajax({
                url: 'api/pokedex/GetPokemon',
                type: "GET",
                data: { pokemonId: self.activePokemon() },
                dataType: "json"
            })
            .done(function (data) {
                self.pokemon(new Pokemon(data));
            });
        }
    }

    var Pokemon = function (data) {
        var self = this;

        // Check for null
        data = data || {};

        self.pokemonId = ko.observable(data.pokemonId);
        self.pkId = ko.observable(data.pkId);
        self.name = ko.observable(data.name);
        self.attack = ko.observable(data.attack);
        self.defense = ko.observable(data.defense);
        self.hp = ko.observable(data.hp);
        self.maxHp = ko.observable(data.maxHp);
        self.spAttack = ko.observable(data.spAttack);
        self.spDefense = ko.observable(data.spDefense);
        self.speed = ko.observable(data.speed);
        self.maxSpeed = ko.observable(data.maxSpeed);
        self.maxSpDefense = ko.observable(data.maxSpDefense);
        self.maxSpAttack = ko.observable(data.maxSpAttack);
        self.maxDefense = ko.observable(data.maxDefense);
        self.maxAttack = ko.observable(data.maxAttack);

        self.height = ko.observable(data.height || data.height == 0 ? data.height : 'N/A');
        self.weight = ko.observable(data.weight || data.weight == 0 ? data.weight : 'N/A');

        self.displayName = ko.computed(function () {
            return '#' + self.pkId() + ' ' + self.name();
        });

        self.hpWidth = ko.computed(function () {
            return 'width: ' + ((self.hp() / self.maxHp()) * 100) + '%;';
        });

        self.attackWidth = ko.computed(function () {
            return 'width: ' + ((self.attack() / self.maxAttack()) * 100) + '%;';
        });

        self.defenseWidth = ko.computed(function () {
            return 'width: ' + ((self.defense() / self.maxDefense()) * 100) + '%;';
        });

        self.spAttackWidth = ko.computed(function () {
            return 'width: ' + ((self.spAttack() / self.maxSpAttack()) * 100) + '%;';
        });

        self.spDefenseWidth = ko.computed(function () {
            return 'width: ' + ((self.spDefense() / self.maxSpDefense()) * 100) + '%;';
        });

        self.speedWidth = ko.computed(function () {
            return 'width: ' + ((self.speed() / self.maxSpeed()) * 100) + '%;';
        });
    };

    $(function () {
        ko.applyBindings(new exports.StatsViewModel(), document.getElementById('stats-display'));
    });
}));