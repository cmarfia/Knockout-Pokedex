using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexImport
{
    public static class DumyJson
    {
        //
        internal static string GameList = @"{
	        ""meta"": {
		        ""limit"": 10,
		        ""next"": ""/api/v1/game/?limit=10&offset=10"",
		        ""offset"": 0,
		        ""previous"": null,
		        ""total_count"": 25
	        },
	        ""objects"": [
		        {
			        ""created"": ""2013-11-03T19:31:10.975452"",
			        ""generation"": 1,
			        ""id"": 1,
			        ""modified"": ""2013-11-03T19:31:10.975393"",
			        ""name"": ""Red(jpn)"",
			        ""release_year"": 1996,
			        ""resource_uri"": ""/api/v1/game/1/""
		        },
		        {
			        ""created"": ""2013-11-03T19:31:20.720917"",
			        ""generation"": 1,
			        ""id"": 2,
			        ""modified"": ""2013-11-03T19:31:20.720871"",
			        ""name"": ""Green(jpn)"",
			        ""release_year"": 1996,
			        ""resource_uri"": ""/api/v1/game/2/""
		        },
		        {
			        ""created"": ""2013-11-03T19:31:43.658706"",
			        ""generation"": 1,
			        ""id"": 3,
			        ""modified"": ""2013-11-03T19:31:43.658656"",
			        ""name"": ""Blue(jpn)"",
			        ""release_year"": 1996,
			        ""resource_uri"": ""/api/v1/game/3/""
		        },
		        {
			        ""created"": ""2013-11-03T19:31:51.827401"",
			        ""generation"": 1,
			        ""id"": 4,
			        ""modified"": ""2013-11-03T19:31:51.827366"",
			        ""name"": ""Red"",
			        ""release_year"": 1998,
			        ""resource_uri"": ""/api/v1/game/4/""
		        },
		        {
			        ""created"": ""2013-11-03T19:32:02.106699"",
			        ""generation"": 1,
			        ""id"": 5,
			        ""modified"": ""2013-11-03T19:32:02.106662"",
			        ""name"": ""Blue"",
			        ""release_year"": 1998,
			        ""resource_uri"": ""/api/v1/game/5/""
		        },
		        {
			        ""created"": ""2013-11-03T19:32:17.359313"",
			        ""generation"": 1,
			        ""id"": 6,
			        ""modified"": ""2013-11-03T19:32:17.359274"",
			        ""name"": ""Yellow"",
			        ""release_year"": 1998,
			        ""resource_uri"": ""/api/v1/game/6/""
		        },
		        {
			        ""created"": ""2013-11-03T19:32:28.615313"",
			        ""generation"": 2,
			        ""id"": 7,
			        ""modified"": ""2013-11-03T19:32:28.615276"",
			        ""name"": ""Gold"",
			        ""release_year"": 1999,
			        ""resource_uri"": ""/api/v1/game/7/""
		        },
		        {
			        ""created"": ""2013-11-03T19:32:35.025188"",
			        ""generation"": 2,
			        ""id"": 8,
			        ""modified"": ""2013-11-03T19:32:35.025149"",
			        ""name"": ""Silver"",
			        ""release_year"": 1999,
			        ""resource_uri"": ""/api/v1/game/8/""
		        },
		        {
			        ""created"": ""2013-11-03T19:32:44.914605"",
			        ""generation"": 2,
			        ""id"": 9,
			        ""modified"": ""2013-11-03T19:32:44.914559"",
			        ""name"": ""Crystal"",
			        ""release_year"": 2000,
			        ""resource_uri"": ""/api/v1/game/9/""
		        },
		        {
			        ""created"": ""2013-11-03T19:32:57.624694"",
			        ""generation"": 3,
			        ""id"": 10,
			        ""modified"": ""2013-11-03T19:32:57.624638"",
			        ""name"": ""Ruby"",
			        ""release_year"": 2002,
			        ""resource_uri"": ""/api/v1/game/10/""
		        }
	        ]
        }";

        internal static string Game = @"{
	        ""created"": ""2013-11-03T19:31:10.975452"",
	        ""generation"": 1,
	        ""id"": 1,
	        ""modified"": ""2013-11-03T19:31:10.975393"",
	        ""name"": ""Red(jpn)"",
	        ""release_year"": 1996,
	        ""resource_uri"": ""/api/v1/game/1/""
        }";

        internal static string Pokedex = @"{
	        ""created"": ""2013-11-09T15:14:48.957604"",
	        ""modified"": ""2013-11-09T15:14:48.957565"",
	        ""name"": ""national"",
	        ""pokemon"": [
		        {
			        ""name"": ""rattata"",
			        ""resource_uri"": ""api/v1/pokemon/19/""
		        },
		        {
			        ""name"": ""charmander"",
			        ""resource_uri"": ""api/v1/pokemon/4/""
		        },
		        {
			        ""name"": ""charmeleon"",
			        ""resource_uri"": ""api/v1/pokemon/5/""
		        },
		        {
			        ""name"": ""wartortle"",
			        ""resource_uri"": ""api/v1/pokemon/8/""
		        },
		        {
			        ""name"": ""blastoise"",
			        ""resource_uri"": ""api/v1/pokemon/9/""
		        },
		        {
			        ""name"": ""caterpie"",
			        ""resource_uri"": ""api/v1/pokemon/10/""
		        },
		        {
			        ""name"": ""metapod"",
			        ""resource_uri"": ""api/v1/pokemon/11/""
		        },
		        {
			        ""name"": ""butterfree"",
			        ""resource_uri"": ""api/v1/pokemon/12/""
		        },
		        {
			        ""name"": ""spearow"",
			        ""resource_uri"": ""api/v1/pokemon/21/""
		        },
		        {
			        ""name"": ""kakuna"",
			        ""resource_uri"": ""api/v1/pokemon/14/""
		        },
		        {
			        ""name"": ""beedrill"",
			        ""resource_uri"": ""api/v1/pokemon/15/""
		        },
		        {
			        ""name"": ""pidgey"",
			        ""resource_uri"": ""api/v1/pokemon/16/""
		        },
		        {
			        ""name"": ""pidgeotto"",
			        ""resource_uri"": ""api/v1/pokemon/17/""
		        },
		        {
			        ""name"": ""pidgeot"",
			        ""resource_uri"": ""api/v1/pokemon/18/""
		        },
		        {
			        ""name"": ""raticate"",
			        ""resource_uri"": ""api/v1/pokemon/20/""
		        },
		        {
			        ""name"": ""fearow"",
			        ""resource_uri"": ""api/v1/pokemon/22/""
		        },
		        {
			        ""name"": ""pikachu"",
			        ""resource_uri"": ""api/v1/pokemon/25/""
		        },
		        {
			        ""name"": ""ekans"",
			        ""resource_uri"": ""api/v1/pokemon/23/""
		        },
		        {
			        ""name"": ""raichu"",
			        ""resource_uri"": ""api/v1/pokemon/26/""
		        },
		        {
			        ""name"": ""arbok"",
			        ""resource_uri"": ""api/v1/pokemon/24/""
		        },
		        {
			        ""name"": ""nidorina"",
			        ""resource_uri"": ""api/v1/pokemon/30/""
		        },
		        {
			        ""name"": ""sandshrew"",
			        ""resource_uri"": ""api/v1/pokemon/27/""
		        },
		        {
			        ""name"": ""nidoran-m"",
			        ""resource_uri"": ""api/v1/pokemon/32/""
		        },
		        {
			        ""name"": ""nidoran-f"",
			        ""resource_uri"": ""api/v1/pokemon/29/""
		        },
		        {
			        ""name"": ""nidoqueen"",
			        ""resource_uri"": ""api/v1/pokemon/31/""
		        },
		        {
			        ""name"": ""nidorino"",
			        ""resource_uri"": ""api/v1/pokemon/33/""
		        },
		        {
			        ""name"": ""nidoking"",
			        ""resource_uri"": ""api/v1/pokemon/34/""
		        },
		        {
			        ""name"": ""clefable"",
			        ""resource_uri"": ""api/v1/pokemon/36/""
		        },
		        {
			        ""name"": ""jigglypuff"",
			        ""resource_uri"": ""api/v1/pokemon/39/""
		        },
		        {
			        ""name"": ""vulpix"",
			        ""resource_uri"": ""api/v1/pokemon/37/""
		        },
		        {
			        ""name"": ""ninetales"",
			        ""resource_uri"": ""api/v1/pokemon/38/""
		        },
		        {
			        ""name"": ""wigglytuff"",
			        ""resource_uri"": ""api/v1/pokemon/40/""
		        },
		        {
			        ""name"": ""zubat"",
			        ""resource_uri"": ""api/v1/pokemon/41/""
		        },
		        {
			        ""name"": ""venonat"",
			        ""resource_uri"": ""api/v1/pokemon/48/""
		        },
		        {
			        ""name"": ""meowth"",
			        ""resource_uri"": ""api/v1/pokemon/52/""
		        },
		        {
			        ""name"": ""golbat"",
			        ""resource_uri"": ""api/v1/pokemon/42/""
		        },
		        {
			        ""name"": ""oddish"",
			        ""resource_uri"": ""api/v1/pokemon/43/""
		        },
		        {
			        ""name"": ""gloom"",
			        ""resource_uri"": ""api/v1/pokemon/44/""
		        },
		        {
			        ""name"": ""vileplume"",
			        ""resource_uri"": ""api/v1/pokemon/45/""
		        },
		        {
			        ""name"": ""paras"",
			        ""resource_uri"": ""api/v1/pokemon/46/""
		        },
		        {
			        ""name"": ""parasect"",
			        ""resource_uri"": ""api/v1/pokemon/47/""
		        },
		        {
			        ""name"": ""venomoth"",
			        ""resource_uri"": ""api/v1/pokemon/49/""
		        },
		        {
			        ""name"": ""diglett"",
			        ""resource_uri"": ""api/v1/pokemon/50/""
		        },
		        {
			        ""name"": ""dugtrio"",
			        ""resource_uri"": ""api/v1/pokemon/51/""
		        },
		        {
			        ""name"": ""persian"",
			        ""resource_uri"": ""api/v1/pokemon/53/""
		        },
		        {
			        ""name"": ""psyduck"",
			        ""resource_uri"": ""api/v1/pokemon/54/""
		        },
		        {
			        ""name"": ""golduck"",
			        ""resource_uri"": ""api/v1/pokemon/55/""
		        },
		        {
			        ""name"": ""mankey"",
			        ""resource_uri"": ""api/v1/pokemon/56/""
		        },
		        {
			        ""name"": ""growlithe"",
			        ""resource_uri"": ""api/v1/pokemon/58/""
		        },
		        {
			        ""name"": ""arcanine"",
			        ""resource_uri"": ""api/v1/pokemon/59/""
		        },
		        {
			        ""name"": ""poliwag"",
			        ""resource_uri"": ""api/v1/pokemon/60/""
		        },
		        {
			        ""name"": ""poliwhirl"",
			        ""resource_uri"": ""api/v1/pokemon/61/""
		        },
		        {
			        ""name"": ""poliwrath"",
			        ""resource_uri"": ""api/v1/pokemon/62/""
		        },
		        {
			        ""name"": ""abra"",
			        ""resource_uri"": ""api/v1/pokemon/63/""
		        },
		        {
			        ""name"": ""kadabra"",
			        ""resource_uri"": ""api/v1/pokemon/64/""
		        },
		        {
			        ""name"": ""machop"",
			        ""resource_uri"": ""api/v1/pokemon/66/""
		        },
		        {
			        ""name"": ""machoke"",
			        ""resource_uri"": ""api/v1/pokemon/67/""
		        },
		        {
			        ""name"": ""machamp"",
			        ""resource_uri"": ""api/v1/pokemon/68/""
		        },
		        {
			        ""name"": ""bellsprout"",
			        ""resource_uri"": ""api/v1/pokemon/69/""
		        },
		        {
			        ""name"": ""ivysaur"",
			        ""resource_uri"": ""api/v1/pokemon/2/""
		        },
		        {
			        ""name"": ""venusaur"",
			        ""resource_uri"": ""api/v1/pokemon/3/""
		        },
		        {
			        ""name"": ""squirtle"",
			        ""resource_uri"": ""api/v1/pokemon/7/""
		        },
		        {
			        ""name"": ""weedle"",
			        ""resource_uri"": ""api/v1/pokemon/13/""
		        },
		        {
			        ""name"": ""graveler"",
			        ""resource_uri"": ""api/v1/pokemon/75/""
		        },
		        {
			        ""name"": ""geodude"",
			        ""resource_uri"": ""api/v1/pokemon/74/""
		        },
		        {
			        ""name"": ""golem"",
			        ""resource_uri"": ""api/v1/pokemon/76/""
		        },
		        {
			        ""name"": ""ponyta"",
			        ""resource_uri"": ""api/v1/pokemon/77/""
		        },
		        {
			        ""name"": ""rapidash"",
			        ""resource_uri"": ""api/v1/pokemon/78/""
		        },
		        {
			        ""name"": ""slowbro"",
			        ""resource_uri"": ""api/v1/pokemon/80/""
		        },
		        {
			        ""name"": ""grimer"",
			        ""resource_uri"": ""api/v1/pokemon/88/""
		        },
		        {
			        ""name"": ""farfetchd"",
			        ""resource_uri"": ""api/v1/pokemon/83/""
		        },
		        {
			        ""name"": ""magnemite"",
			        ""resource_uri"": ""api/v1/pokemon/81/""
		        },
		        {
			        ""name"": ""magneton"",
			        ""resource_uri"": ""api/v1/pokemon/82/""
		        },
		        {
			        ""name"": ""doduo"",
			        ""resource_uri"": ""api/v1/pokemon/84/""
		        },
		        {
			        ""name"": ""seel"",
			        ""resource_uri"": ""api/v1/pokemon/86/""
		        },
		        {
			        ""name"": ""dodrio"",
			        ""resource_uri"": ""api/v1/pokemon/85/""
		        },
		        {
			        ""name"": ""dewgong"",
			        ""resource_uri"": ""api/v1/pokemon/87/""
		        },
		        {
			        ""name"": ""gastly"",
			        ""resource_uri"": ""api/v1/pokemon/92/""
		        },
		        {
			        ""name"": ""cloyster"",
			        ""resource_uri"": ""api/v1/pokemon/91/""
		        },
		        {
			        ""name"": ""muk"",
			        ""resource_uri"": ""api/v1/pokemon/89/""
		        },
		        {
			        ""name"": ""krabby"",
			        ""resource_uri"": ""api/v1/pokemon/98/""
		        },
		        {
			        ""name"": ""haunter"",
			        ""resource_uri"": ""api/v1/pokemon/93/""
		        },
		        {
			        ""name"": ""gengar"",
			        ""resource_uri"": ""api/v1/pokemon/94/""
		        },
		        {
			        ""name"": ""onix"",
			        ""resource_uri"": ""api/v1/pokemon/95/""
		        },
		        {
			        ""name"": ""drowzee"",
			        ""resource_uri"": ""api/v1/pokemon/96/""
		        },
		        {
			        ""name"": ""hypno"",
			        ""resource_uri"": ""api/v1/pokemon/97/""
		        },
		        {
			        ""name"": ""kingler"",
			        ""resource_uri"": ""api/v1/pokemon/99/""
		        },
		        {
			        ""name"": ""voltorb"",
			        ""resource_uri"": ""api/v1/pokemon/100/""
		        },
		        {
			        ""name"": ""electrode"",
			        ""resource_uri"": ""api/v1/pokemon/101/""
		        },
		        {
			        ""name"": ""exeggcute"",
			        ""resource_uri"": ""api/v1/pokemon/102/""
		        },
		        {
			        ""name"": ""exeggutor"",
			        ""resource_uri"": ""api/v1/pokemon/103/""
		        },
		        {
			        ""name"": ""hitmonlee"",
			        ""resource_uri"": ""api/v1/pokemon/106/""
		        },
		        {
			        ""name"": ""cubone"",
			        ""resource_uri"": ""api/v1/pokemon/104/""
		        },
		        {
			        ""name"": ""lickitung"",
			        ""resource_uri"": ""api/v1/pokemon/108/""
		        },
		        {
			        ""name"": ""hitmonchan"",
			        ""resource_uri"": ""api/v1/pokemon/107/""
		        },
		        {
			        ""name"": ""koffing"",
			        ""resource_uri"": ""api/v1/pokemon/109/""
		        },
		        {
			        ""name"": ""weezing"",
			        ""resource_uri"": ""api/v1/pokemon/110/""
		        },
		        {
			        ""name"": ""rhyhorn"",
			        ""resource_uri"": ""api/v1/pokemon/111/""
		        },
		        {
			        ""name"": ""rhydon"",
			        ""resource_uri"": ""api/v1/pokemon/112/""
		        },
		        {
			        ""name"": ""chansey"",
			        ""resource_uri"": ""api/v1/pokemon/113/""
		        },
		        {
			        ""name"": ""kangaskhan"",
			        ""resource_uri"": ""api/v1/pokemon/115/""
		        },
		        {
			        ""name"": ""horsea"",
			        ""resource_uri"": ""api/v1/pokemon/116/""
		        },
		        {
			        ""name"": ""tangela"",
			        ""resource_uri"": ""api/v1/pokemon/114/""
		        },
		        {
			        ""name"": ""seadra"",
			        ""resource_uri"": ""api/v1/pokemon/117/""
		        },
		        {
			        ""name"": ""goldeen"",
			        ""resource_uri"": ""api/v1/pokemon/118/""
		        },
		        {
			        ""name"": ""staryu"",
			        ""resource_uri"": ""api/v1/pokemon/120/""
		        },
		        {
			        ""name"": ""mr-mime"",
			        ""resource_uri"": ""api/v1/pokemon/122/""
		        },
		        {
			        ""name"": ""starmie"",
			        ""resource_uri"": ""api/v1/pokemon/121/""
		        },
		        {
			        ""name"": ""scyther"",
			        ""resource_uri"": ""api/v1/pokemon/123/""
		        },
		        {
			        ""name"": ""pinsir"",
			        ""resource_uri"": ""api/v1/pokemon/127/""
		        },
		        {
			        ""name"": ""jynx"",
			        ""resource_uri"": ""api/v1/pokemon/124/""
		        },
		        {
			        ""name"": ""electabuzz"",
			        ""resource_uri"": ""api/v1/pokemon/125/""
		        },
		        {
			        ""name"": ""magmar"",
			        ""resource_uri"": ""api/v1/pokemon/126/""
		        },
		        {
			        ""name"": ""tauros"",
			        ""resource_uri"": ""api/v1/pokemon/128/""
		        },
		        {
			        ""name"": ""gyarados"",
			        ""resource_uri"": ""api/v1/pokemon/130/""
		        },
		        {
			        ""name"": ""lapras"",
			        ""resource_uri"": ""api/v1/pokemon/131/""
		        },
		        {
			        ""name"": ""ditto"",
			        ""resource_uri"": ""api/v1/pokemon/132/""
		        },
		        {
			        ""name"": ""eevee"",
			        ""resource_uri"": ""api/v1/pokemon/133/""
		        },
		        {
			        ""name"": ""jolteon"",
			        ""resource_uri"": ""api/v1/pokemon/135/""
		        },
		        {
			        ""name"": ""vaporeon"",
			        ""resource_uri"": ""api/v1/pokemon/134/""
		        },
		        {
			        ""name"": ""flareon"",
			        ""resource_uri"": ""api/v1/pokemon/136/""
		        },
		        {
			        ""name"": ""porygon"",
			        ""resource_uri"": ""api/v1/pokemon/137/""
		        },
		        {
			        ""name"": ""omanyte"",
			        ""resource_uri"": ""api/v1/pokemon/138/""
		        },
		        {
			        ""name"": ""victreebel"",
			        ""resource_uri"": ""api/v1/pokemon/71/""
		        },
		        {
			        ""name"": ""tentacool"",
			        ""resource_uri"": ""api/v1/pokemon/72/""
		        },
		        {
			        ""name"": ""tentacruel"",
			        ""resource_uri"": ""api/v1/pokemon/73/""
		        },
		        {
			        ""name"": ""snorlax"",
			        ""resource_uri"": ""api/v1/pokemon/143/""
		        },
		        {
			        ""name"": ""articuno"",
			        ""resource_uri"": ""api/v1/pokemon/144/""
		        },
		        {
			        ""name"": ""mewtwo"",
			        ""resource_uri"": ""api/v1/pokemon/150/""
		        },
		        {
			        ""name"": ""moltres"",
			        ""resource_uri"": ""api/v1/pokemon/146/""
		        },
		        {
			        ""name"": ""totodile"",
			        ""resource_uri"": ""api/v1/pokemon/158/""
		        },
		        {
			        ""name"": ""dratini"",
			        ""resource_uri"": ""api/v1/pokemon/147/""
		        },
		        {
			        ""name"": ""dragonair"",
			        ""resource_uri"": ""api/v1/pokemon/148/""
		        },
		        {
			        ""name"": ""bayleef"",
			        ""resource_uri"": ""api/v1/pokemon/153/""
		        },
		        {
			        ""name"": ""mew"",
			        ""resource_uri"": ""api/v1/pokemon/151/""
		        },
		        {
			        ""name"": ""chikorita"",
			        ""resource_uri"": ""api/v1/pokemon/152/""
		        },
		        {
			        ""name"": ""meganium"",
			        ""resource_uri"": ""api/v1/pokemon/154/""
		        },
		        {
			        ""name"": ""igglybuff"",
			        ""resource_uri"": ""api/v1/pokemon/174/""
		        },
		        {
			        ""name"": ""cyndaquil"",
			        ""resource_uri"": ""api/v1/pokemon/155/""
		        },
		        {
			        ""name"": ""quilava"",
			        ""resource_uri"": ""api/v1/pokemon/156/""
		        },
		        {
			        ""name"": ""typhlosion"",
			        ""resource_uri"": ""api/v1/pokemon/157/""
		        },
		        {
			        ""name"": ""croconaw"",
			        ""resource_uri"": ""api/v1/pokemon/159/""
		        },
		        {
			        ""name"": ""feraligatr"",
			        ""resource_uri"": ""api/v1/pokemon/160/""
		        },
		        {
			        ""name"": ""noctowl"",
			        ""resource_uri"": ""api/v1/pokemon/164/""
		        },
		        {
			        ""name"": ""sentret"",
			        ""resource_uri"": ""api/v1/pokemon/161/""
		        },
		        {
			        ""name"": ""furret"",
			        ""resource_uri"": ""api/v1/pokemon/162/""
		        },
		        {
			        ""name"": ""hoothoot"",
			        ""resource_uri"": ""api/v1/pokemon/163/""
		        },
		        {
			        ""name"": ""ledyba"",
			        ""resource_uri"": ""api/v1/pokemon/165/""
		        },
		        {
			        ""name"": ""ledian"",
			        ""resource_uri"": ""api/v1/pokemon/166/""
		        },
		        {
			        ""name"": ""ariados"",
			        ""resource_uri"": ""api/v1/pokemon/168/""
		        },
		        {
			        ""name"": ""crobat"",
			        ""resource_uri"": ""api/v1/pokemon/169/""
		        },
		        {
			        ""name"": ""chinchou"",
			        ""resource_uri"": ""api/v1/pokemon/170/""
		        },
		        {
			        ""name"": ""lanturn"",
			        ""resource_uri"": ""api/v1/pokemon/171/""
		        },
		        {
			        ""name"": ""pichu"",
			        ""resource_uri"": ""api/v1/pokemon/172/""
		        },
		        {
			        ""name"": ""cleffa"",
			        ""resource_uri"": ""api/v1/pokemon/173/""
		        },
		        {
			        ""name"": ""togepi"",
			        ""resource_uri"": ""api/v1/pokemon/175/""
		        },
		        {
			        ""name"": ""togetic"",
			        ""resource_uri"": ""api/v1/pokemon/176/""
		        },
		        {
			        ""name"": ""natu"",
			        ""resource_uri"": ""api/v1/pokemon/177/""
		        },
		        {
			        ""name"": ""xatu"",
			        ""resource_uri"": ""api/v1/pokemon/178/""
		        },
		        {
			        ""name"": ""mareep"",
			        ""resource_uri"": ""api/v1/pokemon/179/""
		        },
		        {
			        ""name"": ""bellossom"",
			        ""resource_uri"": ""api/v1/pokemon/182/""
		        },
		        {
			        ""name"": ""ampharos"",
			        ""resource_uri"": ""api/v1/pokemon/181/""
		        },
		        {
			        ""name"": ""marill"",
			        ""resource_uri"": ""api/v1/pokemon/183/""
		        },
		        {
			        ""name"": ""hoppip"",
			        ""resource_uri"": ""api/v1/pokemon/187/""
		        },
		        {
			        ""name"": ""sudowoodo"",
			        ""resource_uri"": ""api/v1/pokemon/185/""
		        },
		        {
			        ""name"": ""azumarill"",
			        ""resource_uri"": ""api/v1/pokemon/184/""
		        },
		        {
			        ""name"": ""politoed"",
			        ""resource_uri"": ""api/v1/pokemon/186/""
		        },
		        {
			        ""name"": ""skiploom"",
			        ""resource_uri"": ""api/v1/pokemon/188/""
		        },
		        {
			        ""name"": ""jumpluff"",
			        ""resource_uri"": ""api/v1/pokemon/189/""
		        },
		        {
			        ""name"": ""sunflora"",
			        ""resource_uri"": ""api/v1/pokemon/192/""
		        },
		        {
			        ""name"": ""yanma"",
			        ""resource_uri"": ""api/v1/pokemon/193/""
		        },
		        {
			        ""name"": ""aipom"",
			        ""resource_uri"": ""api/v1/pokemon/190/""
		        },
		        {
			        ""name"": ""sunkern"",
			        ""resource_uri"": ""api/v1/pokemon/191/""
		        },
		        {
			        ""name"": ""wooper"",
			        ""resource_uri"": ""api/v1/pokemon/194/""
		        },
		        {
			        ""name"": ""quagsire"",
			        ""resource_uri"": ""api/v1/pokemon/195/""
		        },
		        {
			        ""name"": ""murkrow"",
			        ""resource_uri"": ""api/v1/pokemon/198/""
		        },
		        {
			        ""name"": ""espeon"",
			        ""resource_uri"": ""api/v1/pokemon/196/""
		        },
		        {
			        ""name"": ""misdreavus"",
			        ""resource_uri"": ""api/v1/pokemon/200/""
		        },
		        {
			        ""name"": ""umbreon"",
			        ""resource_uri"": ""api/v1/pokemon/197/""
		        },
		        {
			        ""name"": ""unown"",
			        ""resource_uri"": ""api/v1/pokemon/201/""
		        },
		        {
			        ""name"": ""wobbuffet"",
			        ""resource_uri"": ""api/v1/pokemon/202/""
		        },
		        {
			        ""name"": ""girafarig"",
			        ""resource_uri"": ""api/v1/pokemon/203/""
		        },
		        {
			        ""name"": ""pineco"",
			        ""resource_uri"": ""api/v1/pokemon/204/""
		        },
		        {
			        ""name"": ""forretress"",
			        ""resource_uri"": ""api/v1/pokemon/205/""
		        },
		        {
			        ""name"": ""dunsparce"",
			        ""resource_uri"": ""api/v1/pokemon/206/""
		        },
		        {
			        ""name"": ""gligar"",
			        ""resource_uri"": ""api/v1/pokemon/207/""
		        },
		        {
			        ""name"": ""kabuto"",
			        ""resource_uri"": ""api/v1/pokemon/140/""
		        },
		        {
			        ""name"": ""aerodactyl"",
			        ""resource_uri"": ""api/v1/pokemon/142/""
		        },
		        {
			        ""name"": ""zapdos"",
			        ""resource_uri"": ""api/v1/pokemon/145/""
		        },
		        {
			        ""name"": ""shuckle"",
			        ""resource_uri"": ""api/v1/pokemon/213/""
		        },
		        {
			        ""name"": ""magcargo"",
			        ""resource_uri"": ""api/v1/pokemon/219/""
		        },
		        {
			        ""name"": ""heracross"",
			        ""resource_uri"": ""api/v1/pokemon/214/""
		        },
		        {
			        ""name"": ""sneasel"",
			        ""resource_uri"": ""api/v1/pokemon/215/""
		        },
		        {
			        ""name"": ""ursaring"",
			        ""resource_uri"": ""api/v1/pokemon/217/""
		        },
		        {
			        ""name"": ""slugma"",
			        ""resource_uri"": ""api/v1/pokemon/218/""
		        },
		        {
			        ""name"": ""swinub"",
			        ""resource_uri"": ""api/v1/pokemon/220/""
		        },
		        {
			        ""name"": ""delibird"",
			        ""resource_uri"": ""api/v1/pokemon/225/""
		        },
		        {
			        ""name"": ""piloswine"",
			        ""resource_uri"": ""api/v1/pokemon/221/""
		        },
		        {
			        ""name"": ""corsola"",
			        ""resource_uri"": ""api/v1/pokemon/222/""
		        },
		        {
			        ""name"": ""remoraid"",
			        ""resource_uri"": ""api/v1/pokemon/223/""
		        },
		        {
			        ""name"": ""houndour"",
			        ""resource_uri"": ""api/v1/pokemon/228/""
		        },
		        {
			        ""name"": ""octillery"",
			        ""resource_uri"": ""api/v1/pokemon/224/""
		        },
		        {
			        ""name"": ""mantine"",
			        ""resource_uri"": ""api/v1/pokemon/226/""
		        },
		        {
			        ""name"": ""porygon2"",
			        ""resource_uri"": ""api/v1/pokemon/233/""
		        },
		        {
			        ""name"": ""skarmory"",
			        ""resource_uri"": ""api/v1/pokemon/227/""
		        },
		        {
			        ""name"": ""houndoom"",
			        ""resource_uri"": ""api/v1/pokemon/229/""
		        },
		        {
			        ""name"": ""kingdra"",
			        ""resource_uri"": ""api/v1/pokemon/230/""
		        },
		        {
			        ""name"": ""phanpy"",
			        ""resource_uri"": ""api/v1/pokemon/231/""
		        },
		        {
			        ""name"": ""stantler"",
			        ""resource_uri"": ""api/v1/pokemon/234/""
		        },
		        {
			        ""name"": ""donphan"",
			        ""resource_uri"": ""api/v1/pokemon/232/""
		        },
		        {
			        ""name"": ""smoochum"",
			        ""resource_uri"": ""api/v1/pokemon/238/""
		        },
		        {
			        ""name"": ""smeargle"",
			        ""resource_uri"": ""api/v1/pokemon/235/""
		        },
		        {
			        ""name"": ""tyrogue"",
			        ""resource_uri"": ""api/v1/pokemon/236/""
		        },
		        {
			        ""name"": ""elekid"",
			        ""resource_uri"": ""api/v1/pokemon/239/""
		        },
		        {
			        ""name"": ""magby"",
			        ""resource_uri"": ""api/v1/pokemon/240/""
		        },
		        {
			        ""name"": ""miltank"",
			        ""resource_uri"": ""api/v1/pokemon/241/""
		        },
		        {
			        ""name"": ""blissey"",
			        ""resource_uri"": ""api/v1/pokemon/242/""
		        },
		        {
			        ""name"": ""raikou"",
			        ""resource_uri"": ""api/v1/pokemon/243/""
		        },
		        {
			        ""name"": ""suicune"",
			        ""resource_uri"": ""api/v1/pokemon/245/""
		        },
		        {
			        ""name"": ""entei"",
			        ""resource_uri"": ""api/v1/pokemon/244/""
		        },
		        {
			        ""name"": ""larvitar"",
			        ""resource_uri"": ""api/v1/pokemon/246/""
		        },
		        {
			        ""name"": ""pupitar"",
			        ""resource_uri"": ""api/v1/pokemon/247/""
		        },
		        {
			        ""name"": ""swampert"",
			        ""resource_uri"": ""api/v1/pokemon/260/""
		        },
		        {
			        ""name"": ""lugia"",
			        ""resource_uri"": ""api/v1/pokemon/249/""
		        },
		        {
			        ""name"": ""sceptile"",
			        ""resource_uri"": ""api/v1/pokemon/254/""
		        },
		        {
			        ""name"": ""ho-oh"",
			        ""resource_uri"": ""api/v1/pokemon/250/""
		        },
		        {
			        ""name"": ""celebi"",
			        ""resource_uri"": ""api/v1/pokemon/251/""
		        },
		        {
			        ""name"": ""treecko"",
			        ""resource_uri"": ""api/v1/pokemon/252/""
		        },
		        {
			        ""name"": ""grovyle"",
			        ""resource_uri"": ""api/v1/pokemon/253/""
		        },
		        {
			        ""name"": ""torchic"",
			        ""resource_uri"": ""api/v1/pokemon/255/""
		        },
		        {
			        ""name"": ""wurmple"",
			        ""resource_uri"": ""api/v1/pokemon/265/""
		        },
		        {
			        ""name"": ""combusken"",
			        ""resource_uri"": ""api/v1/pokemon/256/""
		        },
		        {
			        ""name"": ""blaziken"",
			        ""resource_uri"": ""api/v1/pokemon/257/""
		        },
		        {
			        ""name"": ""mudkip"",
			        ""resource_uri"": ""api/v1/pokemon/258/""
		        },
		        {
			        ""name"": ""marshtomp"",
			        ""resource_uri"": ""api/v1/pokemon/259/""
		        },
		        {
			        ""name"": ""poochyena"",
			        ""resource_uri"": ""api/v1/pokemon/261/""
		        },
		        {
			        ""name"": ""linoone"",
			        ""resource_uri"": ""api/v1/pokemon/264/""
		        },
		        {
			        ""name"": ""silcoon"",
			        ""resource_uri"": ""api/v1/pokemon/266/""
		        },
		        {
			        ""name"": ""mightyena"",
			        ""resource_uri"": ""api/v1/pokemon/262/""
		        },
		        {
			        ""name"": ""beautifly"",
			        ""resource_uri"": ""api/v1/pokemon/267/""
		        },
		        {
			        ""name"": ""cascoon"",
			        ""resource_uri"": ""api/v1/pokemon/268/""
		        },
		        {
			        ""name"": ""dustox"",
			        ""resource_uri"": ""api/v1/pokemon/269/""
		        },
		        {
			        ""name"": ""lotad"",
			        ""resource_uri"": ""api/v1/pokemon/270/""
		        },
		        {
			        ""name"": ""ludicolo"",
			        ""resource_uri"": ""api/v1/pokemon/272/""
		        },
		        {
			        ""name"": ""lombre"",
			        ""resource_uri"": ""api/v1/pokemon/271/""
		        },
		        {
			        ""name"": ""seedot"",
			        ""resource_uri"": ""api/v1/pokemon/273/""
		        },
		        {
			        ""name"": ""shiftry"",
			        ""resource_uri"": ""api/v1/pokemon/275/""
		        },
		        {
			        ""name"": ""nuzleaf"",
			        ""resource_uri"": ""api/v1/pokemon/274/""
		        },
		        {
			        ""name"": ""granbull"",
			        ""resource_uri"": ""api/v1/pokemon/210/""
		        },
		        {
			        ""name"": ""taillow"",
			        ""resource_uri"": ""api/v1/pokemon/276/""
		        },
		        {
			        ""name"": ""qwilfish"",
			        ""resource_uri"": ""api/v1/pokemon/211/""
		        },
		        {
			        ""name"": ""scizor"",
			        ""resource_uri"": ""api/v1/pokemon/212/""
		        },
		        {
			        ""name"": ""surskit"",
			        ""resource_uri"": ""api/v1/pokemon/283/""
		        },
		        {
			        ""name"": ""ralts"",
			        ""resource_uri"": ""api/v1/pokemon/280/""
		        },
		        {
			        ""name"": ""kirlia"",
			        ""resource_uri"": ""api/v1/pokemon/281/""
		        },
		        {
			        ""name"": ""masquerain"",
			        ""resource_uri"": ""api/v1/pokemon/284/""
		        },
		        {
			        ""name"": ""nincada"",
			        ""resource_uri"": ""api/v1/pokemon/290/""
		        },
		        {
			        ""name"": ""slaking"",
			        ""resource_uri"": ""api/v1/pokemon/289/""
		        },
		        {
			        ""name"": ""shroomish"",
			        ""resource_uri"": ""api/v1/pokemon/285/""
		        },
		        {
			        ""name"": ""breloom"",
			        ""resource_uri"": ""api/v1/pokemon/286/""
		        },
		        {
			        ""name"": ""vigoroth"",
			        ""resource_uri"": ""api/v1/pokemon/288/""
		        },
		        {
			        ""name"": ""ninjask"",
			        ""resource_uri"": ""api/v1/pokemon/291/""
		        },
		        {
			        ""name"": ""exploud"",
			        ""resource_uri"": ""api/v1/pokemon/295/""
		        },
		        {
			        ""name"": ""whismur"",
			        ""resource_uri"": ""api/v1/pokemon/293/""
		        },
		        {
			        ""name"": ""delcatty"",
			        ""resource_uri"": ""api/v1/pokemon/301/""
		        },
		        {
			        ""name"": ""loudred"",
			        ""resource_uri"": ""api/v1/pokemon/294/""
		        },
		        {
			        ""name"": ""nosepass"",
			        ""resource_uri"": ""api/v1/pokemon/299/""
		        },
		        {
			        ""name"": ""makuhita"",
			        ""resource_uri"": ""api/v1/pokemon/296/""
		        },
		        {
			        ""name"": ""hariyama"",
			        ""resource_uri"": ""api/v1/pokemon/297/""
		        },
		        {
			        ""name"": ""azurill"",
			        ""resource_uri"": ""api/v1/pokemon/298/""
		        },
		        {
			        ""name"": ""skitty"",
			        ""resource_uri"": ""api/v1/pokemon/300/""
		        },
		        {
			        ""name"": ""sableye"",
			        ""resource_uri"": ""api/v1/pokemon/302/""
		        },
		        {
			        ""name"": ""aron"",
			        ""resource_uri"": ""api/v1/pokemon/304/""
		        },
		        {
			        ""name"": ""mawile"",
			        ""resource_uri"": ""api/v1/pokemon/303/""
		        },
		        {
			        ""name"": ""plusle"",
			        ""resource_uri"": ""api/v1/pokemon/311/""
		        },
		        {
			        ""name"": ""aggron"",
			        ""resource_uri"": ""api/v1/pokemon/306/""
		        },
		        {
			        ""name"": ""lairon"",
			        ""resource_uri"": ""api/v1/pokemon/305/""
		        },
		        {
			        ""name"": ""medicham"",
			        ""resource_uri"": ""api/v1/pokemon/308/""
		        },
		        {
			        ""name"": ""electrike"",
			        ""resource_uri"": ""api/v1/pokemon/309/""
		        },
		        {
			        ""name"": ""manectric"",
			        ""resource_uri"": ""api/v1/pokemon/310/""
		        },
		        {
			        ""name"": ""volbeat"",
			        ""resource_uri"": ""api/v1/pokemon/313/""
		        },
		        {
			        ""name"": ""minun"",
			        ""resource_uri"": ""api/v1/pokemon/312/""
		        },
		        {
			        ""name"": ""illumise"",
			        ""resource_uri"": ""api/v1/pokemon/314/""
		        },
		        {
			        ""name"": ""roselia"",
			        ""resource_uri"": ""api/v1/pokemon/315/""
		        },
		        {
			        ""name"": ""gulpin"",
			        ""resource_uri"": ""api/v1/pokemon/316/""
		        },
		        {
			        ""name"": ""sharpedo"",
			        ""resource_uri"": ""api/v1/pokemon/319/""
		        },
		        {
			        ""name"": ""swalot"",
			        ""resource_uri"": ""api/v1/pokemon/317/""
		        },
		        {
			        ""name"": ""carvanha"",
			        ""resource_uri"": ""api/v1/pokemon/318/""
		        },
		        {
			        ""name"": ""wailmer"",
			        ""resource_uri"": ""api/v1/pokemon/320/""
		        },
		        {
			        ""name"": ""camerupt"",
			        ""resource_uri"": ""api/v1/pokemon/323/""
		        },
		        {
			        ""name"": ""numel"",
			        ""resource_uri"": ""api/v1/pokemon/322/""
		        },
		        {
			        ""name"": ""grumpig"",
			        ""resource_uri"": ""api/v1/pokemon/326/""
		        },
		        {
			        ""name"": ""torkoal"",
			        ""resource_uri"": ""api/v1/pokemon/324/""
		        },
		        {
			        ""name"": ""spoink"",
			        ""resource_uri"": ""api/v1/pokemon/325/""
		        },
		        {
			        ""name"": ""spinda"",
			        ""resource_uri"": ""api/v1/pokemon/327/""
		        },
		        {
			        ""name"": ""trapinch"",
			        ""resource_uri"": ""api/v1/pokemon/328/""
		        },
		        {
			        ""name"": ""vibrava"",
			        ""resource_uri"": ""api/v1/pokemon/329/""
		        },
		        {
			        ""name"": ""flygon"",
			        ""resource_uri"": ""api/v1/pokemon/330/""
		        },
		        {
			        ""name"": ""swablu"",
			        ""resource_uri"": ""api/v1/pokemon/333/""
		        },
		        {
			        ""name"": ""cacnea"",
			        ""resource_uri"": ""api/v1/pokemon/331/""
		        },
		        {
			        ""name"": ""cacturne"",
			        ""resource_uri"": ""api/v1/pokemon/332/""
		        },
		        {
			        ""name"": ""altaria"",
			        ""resource_uri"": ""api/v1/pokemon/334/""
		        },
		        {
			        ""name"": ""solrock"",
			        ""resource_uri"": ""api/v1/pokemon/338/""
		        },
		        {
			        ""name"": ""whiscash"",
			        ""resource_uri"": ""api/v1/pokemon/340/""
		        },
		        {
			        ""name"": ""lunatone"",
			        ""resource_uri"": ""api/v1/pokemon/337/""
		        },
		        {
			        ""name"": ""seviper"",
			        ""resource_uri"": ""api/v1/pokemon/336/""
		        },
		        {
			        ""name"": ""barboach"",
			        ""resource_uri"": ""api/v1/pokemon/339/""
		        },
		        {
			        ""name"": ""corphish"",
			        ""resource_uri"": ""api/v1/pokemon/341/""
		        },
		        {
			        ""name"": ""crawdaunt"",
			        ""resource_uri"": ""api/v1/pokemon/342/""
		        },
		        {
			        ""name"": ""baltoy"",
			        ""resource_uri"": ""api/v1/pokemon/343/""
		        },
		        {
			        ""name"": ""claydol"",
			        ""resource_uri"": ""api/v1/pokemon/344/""
		        },
		        {
			        ""name"": ""lileep"",
			        ""resource_uri"": ""api/v1/pokemon/345/""
		        },
		        {
			        ""name"": ""pelipper"",
			        ""resource_uri"": ""api/v1/pokemon/279/""
		        },
		        {
			        ""name"": ""wingull"",
			        ""resource_uri"": ""api/v1/pokemon/278/""
		        },
		        {
			        ""name"": ""slakoth"",
			        ""resource_uri"": ""api/v1/pokemon/287/""
		        },
		        {
			        ""name"": ""banette"",
			        ""resource_uri"": ""api/v1/pokemon/354/""
		        },
		        {
			        ""name"": ""milotic"",
			        ""resource_uri"": ""api/v1/pokemon/350/""
		        },
		        {
			        ""name"": ""duskull"",
			        ""resource_uri"": ""api/v1/pokemon/355/""
		        },
		        {
			        ""name"": ""kecleon"",
			        ""resource_uri"": ""api/v1/pokemon/352/""
		        },
		        {
			        ""name"": ""shuppet"",
			        ""resource_uri"": ""api/v1/pokemon/353/""
		        },
		        {
			        ""name"": ""dusclops"",
			        ""resource_uri"": ""api/v1/pokemon/356/""
		        },
		        {
			        ""name"": ""chimecho"",
			        ""resource_uri"": ""api/v1/pokemon/358/""
		        },
		        {
			        ""name"": ""absol"",
			        ""resource_uri"": ""api/v1/pokemon/359/""
		        },
		        {
			        ""name"": ""wynaut"",
			        ""resource_uri"": ""api/v1/pokemon/360/""
		        },
		        {
			        ""name"": ""snorunt"",
			        ""resource_uri"": ""api/v1/pokemon/361/""
		        },
		        {
			        ""name"": ""glalie"",
			        ""resource_uri"": ""api/v1/pokemon/362/""
		        },
		        {
			        ""name"": ""spheal"",
			        ""resource_uri"": ""api/v1/pokemon/363/""
		        },
		        {
			        ""name"": ""sealeo"",
			        ""resource_uri"": ""api/v1/pokemon/364/""
		        },
		        {
			        ""name"": ""relicanth"",
			        ""resource_uri"": ""api/v1/pokemon/369/""
		        },
		        {
			        ""name"": ""gorebyss"",
			        ""resource_uri"": ""api/v1/pokemon/368/""
		        },
		        {
			        ""name"": ""walrein"",
			        ""resource_uri"": ""api/v1/pokemon/365/""
		        },
		        {
			        ""name"": ""clamperl"",
			        ""resource_uri"": ""api/v1/pokemon/366/""
		        },
		        {
			        ""name"": ""huntail"",
			        ""resource_uri"": ""api/v1/pokemon/367/""
		        },
		        {
			        ""name"": ""bagon"",
			        ""resource_uri"": ""api/v1/pokemon/371/""
		        },
		        {
			        ""name"": ""luvdisc"",
			        ""resource_uri"": ""api/v1/pokemon/370/""
		        },
		        {
			        ""name"": ""shelgon"",
			        ""resource_uri"": ""api/v1/pokemon/372/""
		        },
		        {
			        ""name"": ""beldum"",
			        ""resource_uri"": ""api/v1/pokemon/374/""
		        },
		        {
			        ""name"": ""groudon"",
			        ""resource_uri"": ""api/v1/pokemon/383/""
		        },
		        {
			        ""name"": ""metang"",
			        ""resource_uri"": ""api/v1/pokemon/375/""
		        },
		        {
			        ""name"": ""registeel"",
			        ""resource_uri"": ""api/v1/pokemon/379/""
		        },
		        {
			        ""name"": ""metagross"",
			        ""resource_uri"": ""api/v1/pokemon/376/""
		        },
		        {
			        ""name"": ""regirock"",
			        ""resource_uri"": ""api/v1/pokemon/377/""
		        },
		        {
			        ""name"": ""regice"",
			        ""resource_uri"": ""api/v1/pokemon/378/""
		        },
		        {
			        ""name"": ""latias"",
			        ""resource_uri"": ""api/v1/pokemon/380/""
		        },
		        {
			        ""name"": ""latios"",
			        ""resource_uri"": ""api/v1/pokemon/381/""
		        },
		        {
			        ""name"": ""kyogre"",
			        ""resource_uri"": ""api/v1/pokemon/382/""
		        },
		        {
			        ""name"": ""rayquaza"",
			        ""resource_uri"": ""api/v1/pokemon/384/""
		        },
		        {
			        ""name"": ""jirachi"",
			        ""resource_uri"": ""api/v1/pokemon/385/""
		        },
		        {
			        ""name"": ""turtwig"",
			        ""resource_uri"": ""api/v1/pokemon/387/""
		        },
		        {
			        ""name"": ""torterra"",
			        ""resource_uri"": ""api/v1/pokemon/389/""
		        },
		        {
			        ""name"": ""grotle"",
			        ""resource_uri"": ""api/v1/pokemon/388/""
		        },
		        {
			        ""name"": ""chimchar"",
			        ""resource_uri"": ""api/v1/pokemon/390/""
		        },
		        {
			        ""name"": ""staraptor"",
			        ""resource_uri"": ""api/v1/pokemon/398/""
		        },
		        {
			        ""name"": ""shinx"",
			        ""resource_uri"": ""api/v1/pokemon/403/""
		        },
		        {
			        ""name"": ""monferno"",
			        ""resource_uri"": ""api/v1/pokemon/391/""
		        },
		        {
			        ""name"": ""infernape"",
			        ""resource_uri"": ""api/v1/pokemon/392/""
		        },
		        {
			        ""name"": ""piplup"",
			        ""resource_uri"": ""api/v1/pokemon/393/""
		        },
		        {
			        ""name"": ""empoleon"",
			        ""resource_uri"": ""api/v1/pokemon/395/""
		        },
		        {
			        ""name"": ""prinplup"",
			        ""resource_uri"": ""api/v1/pokemon/394/""
		        },
		        {
			        ""name"": ""starly"",
			        ""resource_uri"": ""api/v1/pokemon/396/""
		        },
		        {
			        ""name"": ""staravia"",
			        ""resource_uri"": ""api/v1/pokemon/397/""
		        },
		        {
			        ""name"": ""kricketot"",
			        ""resource_uri"": ""api/v1/pokemon/401/""
		        },
		        {
			        ""name"": ""bidoof"",
			        ""resource_uri"": ""api/v1/pokemon/399/""
		        },
		        {
			        ""name"": ""kricketune"",
			        ""resource_uri"": ""api/v1/pokemon/402/""
		        },
		        {
			        ""name"": ""luxio"",
			        ""resource_uri"": ""api/v1/pokemon/404/""
		        },
		        {
			        ""name"": ""luxray"",
			        ""resource_uri"": ""api/v1/pokemon/405/""
		        },
		        {
			        ""name"": ""budew"",
			        ""resource_uri"": ""api/v1/pokemon/406/""
		        },
		        {
			        ""name"": ""roserade"",
			        ""resource_uri"": ""api/v1/pokemon/407/""
		        },
		        {
			        ""name"": ""cranidos"",
			        ""resource_uri"": ""api/v1/pokemon/408/""
		        },
		        {
			        ""name"": ""rampardos"",
			        ""resource_uri"": ""api/v1/pokemon/409/""
		        },
		        {
			        ""name"": ""shieldon"",
			        ""resource_uri"": ""api/v1/pokemon/410/""
		        },
		        {
			        ""name"": ""bastiodon"",
			        ""resource_uri"": ""api/v1/pokemon/411/""
		        },
		        {
			        ""name"": ""burmy"",
			        ""resource_uri"": ""api/v1/pokemon/412/""
		        },
		        {
			        ""name"": ""mothim"",
			        ""resource_uri"": ""api/v1/pokemon/414/""
		        },
		        {
			        ""name"": ""feebas"",
			        ""resource_uri"": ""api/v1/pokemon/349/""
		        },
		        {
			        ""name"": ""anorith"",
			        ""resource_uri"": ""api/v1/pokemon/347/""
		        },
		        {
			        ""name"": ""armaldo"",
			        ""resource_uri"": ""api/v1/pokemon/348/""
		        },
		        {
			        ""name"": ""castform"",
			        ""resource_uri"": ""api/v1/pokemon/351/""
		        },
		        {
			        ""name"": ""cherubi"",
			        ""resource_uri"": ""api/v1/pokemon/420/""
		        },
		        {
			        ""name"": ""mismagius"",
			        ""resource_uri"": ""api/v1/pokemon/429/""
		        },
		        {
			        ""name"": ""ambipom"",
			        ""resource_uri"": ""api/v1/pokemon/424/""
		        },
		        {
			        ""name"": ""cherrim"",
			        ""resource_uri"": ""api/v1/pokemon/421/""
		        },
		        {
			        ""name"": ""gastrodon"",
			        ""resource_uri"": ""api/v1/pokemon/423/""
		        },
		        {
			        ""name"": ""drifblim"",
			        ""resource_uri"": ""api/v1/pokemon/426/""
		        },
		        {
			        ""name"": ""drifloon"",
			        ""resource_uri"": ""api/v1/pokemon/425/""
		        },
		        {
			        ""name"": ""buneary"",
			        ""resource_uri"": ""api/v1/pokemon/427/""
		        },
		        {
			        ""name"": ""lopunny"",
			        ""resource_uri"": ""api/v1/pokemon/428/""
		        },
		        {
			        ""name"": ""chingling"",
			        ""resource_uri"": ""api/v1/pokemon/433/""
		        },
		        {
			        ""name"": ""honchkrow"",
			        ""resource_uri"": ""api/v1/pokemon/430/""
		        },
		        {
			        ""name"": ""glameow"",
			        ""resource_uri"": ""api/v1/pokemon/431/""
		        },
		        {
			        ""name"": ""purugly"",
			        ""resource_uri"": ""api/v1/pokemon/432/""
		        },
		        {
			        ""name"": ""stunky"",
			        ""resource_uri"": ""api/v1/pokemon/434/""
		        },
		        {
			        ""name"": ""skuntank"",
			        ""resource_uri"": ""api/v1/pokemon/435/""
		        },
		        {
			        ""name"": ""happiny"",
			        ""resource_uri"": ""api/v1/pokemon/440/""
		        },
		        {
			        ""name"": ""bronzor"",
			        ""resource_uri"": ""api/v1/pokemon/436/""
		        },
		        {
			        ""name"": ""bronzong"",
			        ""resource_uri"": ""api/v1/pokemon/437/""
		        },
		        {
			        ""name"": ""bonsly"",
			        ""resource_uri"": ""api/v1/pokemon/438/""
		        },
		        {
			        ""name"": ""mime-jr"",
			        ""resource_uri"": ""api/v1/pokemon/439/""
		        },
		        {
			        ""name"": ""spiritomb"",
			        ""resource_uri"": ""api/v1/pokemon/442/""
		        },
		        {
			        ""name"": ""gible"",
			        ""resource_uri"": ""api/v1/pokemon/443/""
		        },
		        {
			        ""name"": ""lucario"",
			        ""resource_uri"": ""api/v1/pokemon/448/""
		        },
		        {
			        ""name"": ""gabite"",
			        ""resource_uri"": ""api/v1/pokemon/444/""
		        },
		        {
			        ""name"": ""garchomp"",
			        ""resource_uri"": ""api/v1/pokemon/445/""
		        },
		        {
			        ""name"": ""drapion"",
			        ""resource_uri"": ""api/v1/pokemon/452/""
		        },
		        {
			        ""name"": ""hippopotas"",
			        ""resource_uri"": ""api/v1/pokemon/449/""
		        },
		        {
			        ""name"": ""munchlax"",
			        ""resource_uri"": ""api/v1/pokemon/446/""
		        },
		        {
			        ""name"": ""riolu"",
			        ""resource_uri"": ""api/v1/pokemon/447/""
		        },
		        {
			        ""name"": ""hippowdon"",
			        ""resource_uri"": ""api/v1/pokemon/450/""
		        },
		        {
			        ""name"": ""croagunk"",
			        ""resource_uri"": ""api/v1/pokemon/453/""
		        },
		        {
			        ""name"": ""toxicroak"",
			        ""resource_uri"": ""api/v1/pokemon/454/""
		        },
		        {
			        ""name"": ""carnivine"",
			        ""resource_uri"": ""api/v1/pokemon/455/""
		        },
		        {
			        ""name"": ""lumineon"",
			        ""resource_uri"": ""api/v1/pokemon/457/""
		        },
		        {
			        ""name"": ""finneon"",
			        ""resource_uri"": ""api/v1/pokemon/456/""
		        },
		        {
			        ""name"": ""mantyke"",
			        ""resource_uri"": ""api/v1/pokemon/458/""
		        },
		        {
			        ""name"": ""snover"",
			        ""resource_uri"": ""api/v1/pokemon/459/""
		        },
		        {
			        ""name"": ""abomasnow"",
			        ""resource_uri"": ""api/v1/pokemon/460/""
		        },
		        {
			        ""name"": ""electivire"",
			        ""resource_uri"": ""api/v1/pokemon/466/""
		        },
		        {
			        ""name"": ""weavile"",
			        ""resource_uri"": ""api/v1/pokemon/461/""
		        },
		        {
			        ""name"": ""lickilicky"",
			        ""resource_uri"": ""api/v1/pokemon/463/""
		        },
		        {
			        ""name"": ""rhyperior"",
			        ""resource_uri"": ""api/v1/pokemon/464/""
		        },
		        {
			        ""name"": ""magnezone"",
			        ""resource_uri"": ""api/v1/pokemon/462/""
		        },
		        {
			        ""name"": ""magmortar"",
			        ""resource_uri"": ""api/v1/pokemon/467/""
		        },
		        {
			        ""name"": ""togekiss"",
			        ""resource_uri"": ""api/v1/pokemon/468/""
		        },
		        {
			        ""name"": ""yanmega"",
			        ""resource_uri"": ""api/v1/pokemon/469/""
		        },
		        {
			        ""name"": ""leafeon"",
			        ""resource_uri"": ""api/v1/pokemon/470/""
		        },
		        {
			        ""name"": ""glaceon"",
			        ""resource_uri"": ""api/v1/pokemon/471/""
		        },
		        {
			        ""name"": ""gliscor"",
			        ""resource_uri"": ""api/v1/pokemon/472/""
		        },
		        {
			        ""name"": ""mamoswine"",
			        ""resource_uri"": ""api/v1/pokemon/473/""
		        },
		        {
			        ""name"": ""porygon-z"",
			        ""resource_uri"": ""api/v1/pokemon/474/""
		        },
		        {
			        ""name"": ""gallade"",
			        ""resource_uri"": ""api/v1/pokemon/475/""
		        },
		        {
			        ""name"": ""probopass"",
			        ""resource_uri"": ""api/v1/pokemon/476/""
		        },
		        {
			        ""name"": ""dusknoir"",
			        ""resource_uri"": ""api/v1/pokemon/477/""
		        },
		        {
			        ""name"": ""froslass"",
			        ""resource_uri"": ""api/v1/pokemon/478/""
		        },
		        {
			        ""name"": ""rotom"",
			        ""resource_uri"": ""api/v1/pokemon/479/""
		        },
		        {
			        ""name"": ""uxie"",
			        ""resource_uri"": ""api/v1/pokemon/480/""
		        },
		        {
			        ""name"": ""mesprit"",
			        ""resource_uri"": ""api/v1/pokemon/481/""
		        },
		        {
			        ""name"": ""dialga"",
			        ""resource_uri"": ""api/v1/pokemon/483/""
		        },
		        {
			        ""name"": ""vespiquen"",
			        ""resource_uri"": ""api/v1/pokemon/416/""
		        },
		        {
			        ""name"": ""pachirisu"",
			        ""resource_uri"": ""api/v1/pokemon/417/""
		        },
		        {
			        ""name"": ""buizel"",
			        ""resource_uri"": ""api/v1/pokemon/418/""
		        },
		        {
			        ""name"": ""floatzel"",
			        ""resource_uri"": ""api/v1/pokemon/419/""
		        },
		        {
			        ""name"": ""victini"",
			        ""resource_uri"": ""api/v1/pokemon/494/""
		        },
		        {
			        ""name"": ""darkrai"",
			        ""resource_uri"": ""api/v1/pokemon/491/""
		        },
		        {
			        ""name"": ""shaymin-land"",
			        ""resource_uri"": ""api/v1/pokemon/492/""
		        },
		        {
			        ""name"": ""arceus"",
			        ""resource_uri"": ""api/v1/pokemon/493/""
		        },
		        {
			        ""name"": ""snivy"",
			        ""resource_uri"": ""api/v1/pokemon/495/""
		        },
		        {
			        ""name"": ""serperior"",
			        ""resource_uri"": ""api/v1/pokemon/497/""
		        },
		        {
			        ""name"": ""servine"",
			        ""resource_uri"": ""api/v1/pokemon/496/""
		        },
		        {
			        ""name"": ""patrat"",
			        ""resource_uri"": ""api/v1/pokemon/504/""
		        },
		        {
			        ""name"": ""tepig"",
			        ""resource_uri"": ""api/v1/pokemon/498/""
		        },
		        {
			        ""name"": ""pignite"",
			        ""resource_uri"": ""api/v1/pokemon/499/""
		        },
		        {
			        ""name"": ""emboar"",
			        ""resource_uri"": ""api/v1/pokemon/500/""
		        },
		        {
			        ""name"": ""oshawott"",
			        ""resource_uri"": ""api/v1/pokemon/501/""
		        },
		        {
			        ""name"": ""dewott"",
			        ""resource_uri"": ""api/v1/pokemon/502/""
		        },
		        {
			        ""name"": ""watchog"",
			        ""resource_uri"": ""api/v1/pokemon/505/""
		        },
		        {
			        ""name"": ""lillipup"",
			        ""resource_uri"": ""api/v1/pokemon/506/""
		        },
		        {
			        ""name"": ""herdier"",
			        ""resource_uri"": ""api/v1/pokemon/507/""
		        },
		        {
			        ""name"": ""stoutland"",
			        ""resource_uri"": ""api/v1/pokemon/508/""
		        },
		        {
			        ""name"": ""purrloin"",
			        ""resource_uri"": ""api/v1/pokemon/509/""
		        },
		        {
			        ""name"": ""liepard"",
			        ""resource_uri"": ""api/v1/pokemon/510/""
		        },
		        {
			        ""name"": ""pansage"",
			        ""resource_uri"": ""api/v1/pokemon/511/""
		        },
		        {
			        ""name"": ""simisage"",
			        ""resource_uri"": ""api/v1/pokemon/512/""
		        },
		        {
			        ""name"": ""pansear"",
			        ""resource_uri"": ""api/v1/pokemon/513/""
		        },
		        {
			        ""name"": ""panpour"",
			        ""resource_uri"": ""api/v1/pokemon/515/""
		        },
		        {
			        ""name"": ""simipour"",
			        ""resource_uri"": ""api/v1/pokemon/516/""
		        },
		        {
			        ""name"": ""roggenrola"",
			        ""resource_uri"": ""api/v1/pokemon/524/""
		        },
		        {
			        ""name"": ""munna"",
			        ""resource_uri"": ""api/v1/pokemon/517/""
		        },
		        {
			        ""name"": ""musharna"",
			        ""resource_uri"": ""api/v1/pokemon/518/""
		        },
		        {
			        ""name"": ""pidove"",
			        ""resource_uri"": ""api/v1/pokemon/519/""
		        },
		        {
			        ""name"": ""tranquill"",
			        ""resource_uri"": ""api/v1/pokemon/520/""
		        },
		        {
			        ""name"": ""unfezant"",
			        ""resource_uri"": ""api/v1/pokemon/521/""
		        },
		        {
			        ""name"": ""blitzle"",
			        ""resource_uri"": ""api/v1/pokemon/522/""
		        },
		        {
			        ""name"": ""zebstrika"",
			        ""resource_uri"": ""api/v1/pokemon/523/""
		        },
		        {
			        ""name"": ""boldore"",
			        ""resource_uri"": ""api/v1/pokemon/525/""
		        },
		        {
			        ""name"": ""gigalith"",
			        ""resource_uri"": ""api/v1/pokemon/526/""
		        },
		        {
			        ""name"": ""woobat"",
			        ""resource_uri"": ""api/v1/pokemon/527/""
		        },
		        {
			        ""name"": ""swoobat"",
			        ""resource_uri"": ""api/v1/pokemon/528/""
		        },
		        {
			        ""name"": ""drilbur"",
			        ""resource_uri"": ""api/v1/pokemon/529/""
		        },
		        {
			        ""name"": ""excadrill"",
			        ""resource_uri"": ""api/v1/pokemon/530/""
		        },
		        {
			        ""name"": ""audino"",
			        ""resource_uri"": ""api/v1/pokemon/531/""
		        },
		        {
			        ""name"": ""conkeldurr"",
			        ""resource_uri"": ""api/v1/pokemon/534/""
		        },
		        {
			        ""name"": ""timburr"",
			        ""resource_uri"": ""api/v1/pokemon/532/""
		        },
		        {
			        ""name"": ""tympole"",
			        ""resource_uri"": ""api/v1/pokemon/535/""
		        },
		        {
			        ""name"": ""palpitoad"",
			        ""resource_uri"": ""api/v1/pokemon/536/""
		        },
		        {
			        ""name"": ""seismitoad"",
			        ""resource_uri"": ""api/v1/pokemon/537/""
		        },
		        {
			        ""name"": ""throh"",
			        ""resource_uri"": ""api/v1/pokemon/538/""
		        },
		        {
			        ""name"": ""sawk"",
			        ""resource_uri"": ""api/v1/pokemon/539/""
		        },
		        {
			        ""name"": ""sewaddle"",
			        ""resource_uri"": ""api/v1/pokemon/540/""
		        },
		        {
			        ""name"": ""swadloon"",
			        ""resource_uri"": ""api/v1/pokemon/541/""
		        },
		        {
			        ""name"": ""venipede"",
			        ""resource_uri"": ""api/v1/pokemon/543/""
		        },
		        {
			        ""name"": ""whirlipede"",
			        ""resource_uri"": ""api/v1/pokemon/544/""
		        },
		        {
			        ""name"": ""basculin-red-striped"",
			        ""resource_uri"": ""api/v1/pokemon/550/""
		        },
		        {
			        ""name"": ""scolipede"",
			        ""resource_uri"": ""api/v1/pokemon/545/""
		        },
		        {
			        ""name"": ""cottonee"",
			        ""resource_uri"": ""api/v1/pokemon/546/""
		        },
		        {
			        ""name"": ""whimsicott"",
			        ""resource_uri"": ""api/v1/pokemon/547/""
		        },
		        {
			        ""name"": ""petilil"",
			        ""resource_uri"": ""api/v1/pokemon/548/""
		        },
		        {
			        ""name"": ""lilligant"",
			        ""resource_uri"": ""api/v1/pokemon/549/""
		        },
		        {
			        ""name"": ""sandile"",
			        ""resource_uri"": ""api/v1/pokemon/551/""
		        },
		        {
			        ""name"": ""krokorok"",
			        ""resource_uri"": ""api/v1/pokemon/552/""
		        },
		        {
			        ""name"": ""manaphy"",
			        ""resource_uri"": ""api/v1/pokemon/490/""
		        },
		        {
			        ""name"": ""regigigas"",
			        ""resource_uri"": ""api/v1/pokemon/486/""
		        },
		        {
			        ""name"": ""giratina-altered"",
			        ""resource_uri"": ""api/v1/pokemon/487/""
		        },
		        {
			        ""name"": ""cofagrigus"",
			        ""resource_uri"": ""api/v1/pokemon/563/""
		        },
		        {
			        ""name"": ""crustle"",
			        ""resource_uri"": ""api/v1/pokemon/558/""
		        },
		        {
			        ""name"": ""tirtouga"",
			        ""resource_uri"": ""api/v1/pokemon/564/""
		        },
		        {
			        ""name"": ""scraggy"",
			        ""resource_uri"": ""api/v1/pokemon/559/""
		        },
		        {
			        ""name"": ""scrafty"",
			        ""resource_uri"": ""api/v1/pokemon/560/""
		        },
		        {
			        ""name"": ""sigilyph"",
			        ""resource_uri"": ""api/v1/pokemon/561/""
		        },
		        {
			        ""name"": ""yamask"",
			        ""resource_uri"": ""api/v1/pokemon/562/""
		        },
		        {
			        ""name"": ""zoroark"",
			        ""resource_uri"": ""api/v1/pokemon/571/""
		        },
		        {
			        ""name"": ""carracosta"",
			        ""resource_uri"": ""api/v1/pokemon/565/""
		        },
		        {
			        ""name"": ""zorua"",
			        ""resource_uri"": ""api/v1/pokemon/570/""
		        },
		        {
			        ""name"": ""archen"",
			        ""resource_uri"": ""api/v1/pokemon/566/""
		        },
		        {
			        ""name"": ""archeops"",
			        ""resource_uri"": ""api/v1/pokemon/567/""
		        },
		        {
			        ""name"": ""trubbish"",
			        ""resource_uri"": ""api/v1/pokemon/568/""
		        },
		        {
			        ""name"": ""minccino"",
			        ""resource_uri"": ""api/v1/pokemon/572/""
		        },
		        {
			        ""name"": ""cinccino"",
			        ""resource_uri"": ""api/v1/pokemon/573/""
		        },
		        {
			        ""name"": ""gothita"",
			        ""resource_uri"": ""api/v1/pokemon/574/""
		        },
		        {
			        ""name"": ""gothorita"",
			        ""resource_uri"": ""api/v1/pokemon/575/""
		        },
		        {
			        ""name"": ""gothitelle"",
			        ""resource_uri"": ""api/v1/pokemon/576/""
		        },
		        {
			        ""name"": ""solosis"",
			        ""resource_uri"": ""api/v1/pokemon/577/""
		        },
		        {
			        ""name"": ""duosion"",
			        ""resource_uri"": ""api/v1/pokemon/578/""
		        },
		        {
			        ""name"": ""vanillite"",
			        ""resource_uri"": ""api/v1/pokemon/582/""
		        },
		        {
			        ""name"": ""reuniclus"",
			        ""resource_uri"": ""api/v1/pokemon/579/""
		        },
		        {
			        ""name"": ""swanna"",
			        ""resource_uri"": ""api/v1/pokemon/581/""
		        },
		        {
			        ""name"": ""vanillish"",
			        ""resource_uri"": ""api/v1/pokemon/583/""
		        },
		        {
			        ""name"": ""vanilluxe"",
			        ""resource_uri"": ""api/v1/pokemon/584/""
		        },
		        {
			        ""name"": ""deerling"",
			        ""resource_uri"": ""api/v1/pokemon/585/""
		        },
		        {
			        ""name"": ""sawsbuck"",
			        ""resource_uri"": ""api/v1/pokemon/586/""
		        },
		        {
			        ""name"": ""karrablast"",
			        ""resource_uri"": ""api/v1/pokemon/588/""
		        },
		        {
			        ""name"": ""emolga"",
			        ""resource_uri"": ""api/v1/pokemon/587/""
		        },
		        {
			        ""name"": ""foongus"",
			        ""resource_uri"": ""api/v1/pokemon/590/""
		        },
		        {
			        ""name"": ""escavalier"",
			        ""resource_uri"": ""api/v1/pokemon/589/""
		        },
		        {
			        ""name"": ""amoonguss"",
			        ""resource_uri"": ""api/v1/pokemon/591/""
		        },
		        {
			        ""name"": ""frillish"",
			        ""resource_uri"": ""api/v1/pokemon/592/""
		        },
		        {
			        ""name"": ""galvantula"",
			        ""resource_uri"": ""api/v1/pokemon/596/""
		        },
		        {
			        ""name"": ""jellicent"",
			        ""resource_uri"": ""api/v1/pokemon/593/""
		        },
		        {
			        ""name"": ""joltik"",
			        ""resource_uri"": ""api/v1/pokemon/595/""
		        },
		        {
			        ""name"": ""alomomola"",
			        ""resource_uri"": ""api/v1/pokemon/594/""
		        },
		        {
			        ""name"": ""ferroseed"",
			        ""resource_uri"": ""api/v1/pokemon/597/""
		        },
		        {
			        ""name"": ""ferrothorn"",
			        ""resource_uri"": ""api/v1/pokemon/598/""
		        },
		        {
			        ""name"": ""tynamo"",
			        ""resource_uri"": ""api/v1/pokemon/602/""
		        },
		        {
			        ""name"": ""klink"",
			        ""resource_uri"": ""api/v1/pokemon/599/""
		        },
		        {
			        ""name"": ""eelektrik"",
			        ""resource_uri"": ""api/v1/pokemon/603/""
		        },
		        {
			        ""name"": ""klang"",
			        ""resource_uri"": ""api/v1/pokemon/600/""
		        },
		        {
			        ""name"": ""eelektross"",
			        ""resource_uri"": ""api/v1/pokemon/604/""
		        },
		        {
			        ""name"": ""elgyem"",
			        ""resource_uri"": ""api/v1/pokemon/605/""
		        },
		        {
			        ""name"": ""beheeyem"",
			        ""resource_uri"": ""api/v1/pokemon/606/""
		        },
		        {
			        ""name"": ""litwick"",
			        ""resource_uri"": ""api/v1/pokemon/607/""
		        },
		        {
			        ""name"": ""lampent"",
			        ""resource_uri"": ""api/v1/pokemon/608/""
		        },
		        {
			        ""name"": ""chandelure"",
			        ""resource_uri"": ""api/v1/pokemon/609/""
		        },
		        {
			        ""name"": ""axew"",
			        ""resource_uri"": ""api/v1/pokemon/610/""
		        },
		        {
			        ""name"": ""cubchoo"",
			        ""resource_uri"": ""api/v1/pokemon/613/""
		        },
		        {
			        ""name"": ""haxorus"",
			        ""resource_uri"": ""api/v1/pokemon/612/""
		        },
		        {
			        ""name"": ""beartic"",
			        ""resource_uri"": ""api/v1/pokemon/614/""
		        },
		        {
			        ""name"": ""cryogonal"",
			        ""resource_uri"": ""api/v1/pokemon/615/""
		        },
		        {
			        ""name"": ""shelmet"",
			        ""resource_uri"": ""api/v1/pokemon/616/""
		        },
		        {
			        ""name"": ""accelgor"",
			        ""resource_uri"": ""api/v1/pokemon/617/""
		        },
		        {
			        ""name"": ""stunfisk"",
			        ""resource_uri"": ""api/v1/pokemon/618/""
		        },
		        {
			        ""name"": ""mienfoo"",
			        ""resource_uri"": ""api/v1/pokemon/619/""
		        },
		        {
			        ""name"": ""mienshao"",
			        ""resource_uri"": ""api/v1/pokemon/620/""
		        },
		        {
			        ""name"": ""darumaka"",
			        ""resource_uri"": ""api/v1/pokemon/554/""
		        },
		        {
			        ""name"": ""maractus"",
			        ""resource_uri"": ""api/v1/pokemon/556/""
		        },
		        {
			        ""name"": ""darmanitan-standard"",
			        ""resource_uri"": ""api/v1/pokemon/555/""
		        },
		        {
			        ""name"": ""dwebble"",
			        ""resource_uri"": ""api/v1/pokemon/557/""
		        },
		        {
			        ""name"": ""bisharp"",
			        ""resource_uri"": ""api/v1/pokemon/625/""
		        },
		        {
			        ""name"": ""bouffalant"",
			        ""resource_uri"": ""api/v1/pokemon/626/""
		        },
		        {
			        ""name"": ""rufflet"",
			        ""resource_uri"": ""api/v1/pokemon/627/""
		        },
		        {
			        ""name"": ""deino"",
			        ""resource_uri"": ""api/v1/pokemon/633/""
		        },
		        {
			        ""name"": ""vullaby"",
			        ""resource_uri"": ""api/v1/pokemon/629/""
		        },
		        {
			        ""name"": ""mandibuzz"",
			        ""resource_uri"": ""api/v1/pokemon/630/""
		        },
		        {
			        ""name"": ""heatmor"",
			        ""resource_uri"": ""api/v1/pokemon/631/""
		        },
		        {
			        ""name"": ""durant"",
			        ""resource_uri"": ""api/v1/pokemon/632/""
		        },
		        {
			        ""name"": ""chesnaught"",
			        ""resource_uri"": ""api/v1/pokemon/652/""
		        },
		        {
			        ""name"": ""hydreigon"",
			        ""resource_uri"": ""api/v1/pokemon/635/""
		        },
		        {
			        ""name"": ""larvesta"",
			        ""resource_uri"": ""api/v1/pokemon/636/""
		        },
		        {
			        ""name"": ""volcarona"",
			        ""resource_uri"": ""api/v1/pokemon/637/""
		        },
		        {
			        ""name"": ""cobalion"",
			        ""resource_uri"": ""api/v1/pokemon/638/""
		        },
		        {
			        ""name"": ""terrakion"",
			        ""resource_uri"": ""api/v1/pokemon/639/""
		        },
		        {
			        ""name"": ""thundurus-incarnate"",
			        ""resource_uri"": ""api/v1/pokemon/642/""
		        },
		        {
			        ""name"": ""virizion"",
			        ""resource_uri"": ""api/v1/pokemon/640/""
		        },
		        {
			        ""name"": ""reshiram"",
			        ""resource_uri"": ""api/v1/pokemon/643/""
		        },
		        {
			        ""name"": ""zekrom"",
			        ""resource_uri"": ""api/v1/pokemon/644/""
		        },
		        {
			        ""name"": ""landorus-incarnate"",
			        ""resource_uri"": ""api/v1/pokemon/645/""
		        },
		        {
			        ""name"": ""kyurem"",
			        ""resource_uri"": ""api/v1/pokemon/646/""
		        },
		        {
			        ""name"": ""keldeo-ordinary"",
			        ""resource_uri"": ""api/v1/pokemon/647/""
		        },
		        {
			        ""name"": ""meloetta-aria"",
			        ""resource_uri"": ""api/v1/pokemon/648/""
		        },
		        {
			        ""name"": ""genesect"",
			        ""resource_uri"": ""api/v1/pokemon/649/""
		        },
		        {
			        ""name"": ""chespin"",
			        ""resource_uri"": ""api/v1/pokemon/650/""
		        },
		        {
			        ""name"": ""quilladin"",
			        ""resource_uri"": ""api/v1/pokemon/651/""
		        },
		        {
			        ""name"": ""fennekin"",
			        ""resource_uri"": ""api/v1/pokemon/653/""
		        },
		        {
			        ""name"": ""braixen"",
			        ""resource_uri"": ""api/v1/pokemon/654/""
		        },
		        {
			        ""name"": ""fletchinder"",
			        ""resource_uri"": ""api/v1/pokemon/662/""
		        },
		        {
			        ""name"": ""delphox"",
			        ""resource_uri"": ""api/v1/pokemon/655/""
		        },
		        {
			        ""name"": ""froakie"",
			        ""resource_uri"": ""api/v1/pokemon/656/""
		        },
		        {
			        ""name"": ""frogadier"",
			        ""resource_uri"": ""api/v1/pokemon/657/""
		        },
		        {
			        ""name"": ""greninja"",
			        ""resource_uri"": ""api/v1/pokemon/658/""
		        },
		        {
			        ""name"": ""bunnelby"",
			        ""resource_uri"": ""api/v1/pokemon/659/""
		        },
		        {
			        ""name"": ""diggersby"",
			        ""resource_uri"": ""api/v1/pokemon/660/""
		        },
		        {
			        ""name"": ""fletchling"",
			        ""resource_uri"": ""api/v1/pokemon/661/""
		        },
		        {
			        ""name"": ""talonflame"",
			        ""resource_uri"": ""api/v1/pokemon/663/""
		        },
		        {
			        ""name"": ""vivillon"",
			        ""resource_uri"": ""api/v1/pokemon/666/""
		        },
		        {
			        ""name"": ""scatterbug"",
			        ""resource_uri"": ""api/v1/pokemon/664/""
		        },
		        {
			        ""name"": ""florges"",
			        ""resource_uri"": ""api/v1/pokemon/671/""
		        },
		        {
			        ""name"": ""spewpa"",
			        ""resource_uri"": ""api/v1/pokemon/665/""
		        },
		        {
			        ""name"": ""litleo"",
			        ""resource_uri"": ""api/v1/pokemon/667/""
		        },
		        {
			        ""name"": ""flabebe"",
			        ""resource_uri"": ""api/v1/pokemon/669/""
		        },
		        {
			        ""name"": ""floette"",
			        ""resource_uri"": ""api/v1/pokemon/670/""
		        },
		        {
			        ""name"": ""skiddo"",
			        ""resource_uri"": ""api/v1/pokemon/672/""
		        },
		        {
			        ""name"": ""gogoat"",
			        ""resource_uri"": ""api/v1/pokemon/673/""
		        },
		        {
			        ""name"": ""pancham"",
			        ""resource_uri"": ""api/v1/pokemon/674/""
		        },
		        {
			        ""name"": ""meowstic-male"",
			        ""resource_uri"": ""api/v1/pokemon/678/""
		        },
		        {
			        ""name"": ""furfrou"",
			        ""resource_uri"": ""api/v1/pokemon/676/""
		        },
		        {
			        ""name"": ""espurr"",
			        ""resource_uri"": ""api/v1/pokemon/677/""
		        },
		        {
			        ""name"": ""honedge"",
			        ""resource_uri"": ""api/v1/pokemon/679/""
		        },
		        {
			        ""name"": ""doublade"",
			        ""resource_uri"": ""api/v1/pokemon/680/""
		        },
		        {
			        ""name"": ""spritzee"",
			        ""resource_uri"": ""api/v1/pokemon/682/""
		        },
		        {
			        ""name"": ""swirlix"",
			        ""resource_uri"": ""api/v1/pokemon/684/""
		        },
		        {
			        ""name"": ""aromatisse"",
			        ""resource_uri"": ""api/v1/pokemon/683/""
		        },
		        {
			        ""name"": ""slurpuff"",
			        ""resource_uri"": ""api/v1/pokemon/685/""
		        },
		        {
			        ""name"": ""inkay"",
			        ""resource_uri"": ""api/v1/pokemon/686/""
		        },
		        {
			        ""name"": ""malamar"",
			        ""resource_uri"": ""api/v1/pokemon/687/""
		        },
		        {
			        ""name"": ""binacle"",
			        ""resource_uri"": ""api/v1/pokemon/688/""
		        },
		        {
			        ""name"": ""aegislash"",
			        ""resource_uri"": ""api/v1/pokemon/681/""
		        },
		        {
			        ""name"": ""golett"",
			        ""resource_uri"": ""api/v1/pokemon/622/""
		        },
		        {
			        ""name"": ""golurk"",
			        ""resource_uri"": ""api/v1/pokemon/623/""
		        },
		        {
			        ""name"": ""pawniard"",
			        ""resource_uri"": ""api/v1/pokemon/624/""
		        },
		        {
			        ""name"": ""braviary"",
			        ""resource_uri"": ""api/v1/pokemon/628/""
		        },
		        {
			        ""name"": ""clawitzer"",
			        ""resource_uri"": ""api/v1/pokemon/693/""
		        },
		        {
			        ""name"": ""sylveon"",
			        ""resource_uri"": ""api/v1/pokemon/700/""
		        },
		        {
			        ""name"": ""tyrunt"",
			        ""resource_uri"": ""api/v1/pokemon/696/""
		        },
		        {
			        ""name"": ""dedenne"",
			        ""resource_uri"": ""api/v1/pokemon/702/""
		        },
		        {
			        ""name"": ""tyrantrum"",
			        ""resource_uri"": ""api/v1/pokemon/697/""
		        },
		        {
			        ""name"": ""carbink"",
			        ""resource_uri"": ""api/v1/pokemon/703/""
		        },
		        {
			        ""name"": ""amaura"",
			        ""resource_uri"": ""api/v1/pokemon/698/""
		        },
		        {
			        ""name"": ""aurorus"",
			        ""resource_uri"": ""api/v1/pokemon/699/""
		        },
		        {
			        ""name"": ""hawlucha"",
			        ""resource_uri"": ""api/v1/pokemon/701/""
		        },
		        {
			        ""name"": ""goodra"",
			        ""resource_uri"": ""api/v1/pokemon/706/""
		        },
		        {
			        ""name"": ""klefki"",
			        ""resource_uri"": ""api/v1/pokemon/707/""
		        },
		        {
			        ""name"": ""goomy"",
			        ""resource_uri"": ""api/v1/pokemon/704/""
		        },
		        {
			        ""name"": ""phantump"",
			        ""resource_uri"": ""api/v1/pokemon/708/""
		        },
		        {
			        ""name"": ""sliggoo"",
			        ""resource_uri"": ""api/v1/pokemon/705/""
		        },
		        {
			        ""name"": ""noibat"",
			        ""resource_uri"": ""api/v1/pokemon/714/""
		        },
		        {
			        ""name"": ""trevenant"",
			        ""resource_uri"": ""api/v1/pokemon/709/""
		        },
		        {
			        ""name"": ""pumpkaboo-average"",
			        ""resource_uri"": ""api/v1/pokemon/710/""
		        },
		        {
			        ""name"": ""bergmite"",
			        ""resource_uri"": ""api/v1/pokemon/712/""
		        },
		        {
			        ""name"": ""gourgeist-average"",
			        ""resource_uri"": ""api/v1/pokemon/711/""
		        },
		        {
			        ""name"": ""avalugg"",
			        ""resource_uri"": ""api/v1/pokemon/713/""
		        },
		        {
			        ""name"": ""noivern"",
			        ""resource_uri"": ""api/v1/pokemon/715/""
		        },
		        {
			        ""name"": ""zygarde"",
			        ""resource_uri"": ""api/v1/pokemon/718/""
		        },
		        {
			        ""name"": ""xerneas"",
			        ""resource_uri"": ""api/v1/pokemon/716/""
		        },
		        {
			        ""name"": ""yveltal"",
			        ""resource_uri"": ""api/v1/pokemon/717/""
		        },
		        {
			        ""name"": ""deoxys-defense"",
			        ""resource_uri"": ""api/v1/pokemon/10002/""
		        },
		        {
			        ""name"": ""deoxys-attack"",
			        ""resource_uri"": ""api/v1/pokemon/10001/""
		        },
		        {
			        ""name"": ""skrelp"",
			        ""resource_uri"": ""api/v1/pokemon/690/""
		        },
		        {
			        ""name"": ""heliolisk"",
			        ""resource_uri"": ""api/v1/pokemon/695/""
		        },
		        {
			        ""name"": ""deoxys-speed"",
			        ""resource_uri"": ""api/v1/pokemon/10003/""
		        },
		        {
			        ""name"": ""wormadam-sandy"",
			        ""resource_uri"": ""api/v1/pokemon/10004/""
		        },
		        {
			        ""name"": ""castform-rainy"",
			        ""resource_uri"": ""api/v1/pokemon/10014/""
		        },
		        {
			        ""name"": ""rotom-heat"",
			        ""resource_uri"": ""api/v1/pokemon/10008/""
		        },
		        {
			        ""name"": ""wormadam-trash"",
			        ""resource_uri"": ""api/v1/pokemon/10005/""
		        },
		        {
			        ""name"": ""shaymin-sky"",
			        ""resource_uri"": ""api/v1/pokemon/10006/""
		        },
		        {
			        ""name"": ""rotom-wash"",
			        ""resource_uri"": ""api/v1/pokemon/10009/""
		        },
		        {
			        ""name"": ""rotom-frost"",
			        ""resource_uri"": ""api/v1/pokemon/10010/""
		        },
		        {
			        ""name"": ""rotom-fan"",
			        ""resource_uri"": ""api/v1/pokemon/10011/""
		        },
		        {
			        ""name"": ""rotom-mow"",
			        ""resource_uri"": ""api/v1/pokemon/10012/""
		        },
		        {
			        ""name"": ""castform-sunny"",
			        ""resource_uri"": ""api/v1/pokemon/10013/""
		        },
		        {
			        ""name"": ""basculin-blue-striped"",
			        ""resource_uri"": ""api/v1/pokemon/10016/""
		        },
		        {
			        ""name"": ""darmanitan-zen"",
			        ""resource_uri"": ""api/v1/pokemon/10017/""
		        },
		        {
			        ""name"": ""meloetta-pirouette"",
			        ""resource_uri"": ""api/v1/pokemon/10018/""
		        },
		        {
			        ""name"": ""thundurus-therian"",
			        ""resource_uri"": ""api/v1/pokemon/10020/""
		        },
		        {
			        ""name"": ""tornadus-therian"",
			        ""resource_uri"": ""api/v1/pokemon/10019/""
		        },
		        {
			        ""name"": ""landorus-therian"",
			        ""resource_uri"": ""api/v1/pokemon/10021/""
		        },
		        {
			        ""name"": ""kyurem-white"",
			        ""resource_uri"": ""api/v1/pokemon/10023/""
		        },
		        {
			        ""name"": ""aegislash-blade"",
			        ""resource_uri"": ""api/v1/pokemon/10026/""
		        },
		        {
			        ""name"": ""kyurem-black"",
			        ""resource_uri"": ""api/v1/pokemon/10022/""
		        },
		        {
			        ""name"": ""keldeo-resolute"",
			        ""resource_uri"": ""api/v1/pokemon/10024/""
		        },
		        {
			        ""name"": ""meowstic-female"",
			        ""resource_uri"": ""api/v1/pokemon/10025/""
		        },
		        {
			        ""name"": ""pumpkaboo-small"",
			        ""resource_uri"": ""api/v1/pokemon/10027/""
		        },
		        {
			        ""name"": ""alakazam-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10037/""
		        },
		        {
			        ""name"": ""pumpkaboo-large"",
			        ""resource_uri"": ""api/v1/pokemon/10028/""
		        },
		        {
			        ""name"": ""pumpkaboo-super"",
			        ""resource_uri"": ""api/v1/pokemon/10029/""
		        },
		        {
			        ""name"": ""gourgeist-small"",
			        ""resource_uri"": ""api/v1/pokemon/10030/""
		        },
		        {
			        ""name"": ""gourgeist-large"",
			        ""resource_uri"": ""api/v1/pokemon/10031/""
		        },
		        {
			        ""name"": ""gourgeist-super"",
			        ""resource_uri"": ""api/v1/pokemon/10032/""
		        },
		        {
			        ""name"": ""venusaur-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10033/""
		        },
		        {
			        ""name"": ""charizard-mega-x"",
			        ""resource_uri"": ""api/v1/pokemon/10034/""
		        },
		        {
			        ""name"": ""charizard-mega-y"",
			        ""resource_uri"": ""api/v1/pokemon/10035/""
		        },
		        {
			        ""name"": ""blastoise-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10036/""
		        },
		        {
			        ""name"": ""clauncher"",
			        ""resource_uri"": ""api/v1/pokemon/692/""
		        },
		        {
			        ""name"": ""shellder"",
			        ""resource_uri"": ""api/v1/pokemon/90/""
		        },
		        {
			        ""name"": ""alakazam"",
			        ""resource_uri"": ""api/v1/pokemon/65/""
		        },
		        {
			        ""name"": ""kabutops"",
			        ""resource_uri"": ""api/v1/pokemon/141/""
		        },
		        {
			        ""name"": ""leavanny"",
			        ""resource_uri"": ""api/v1/pokemon/542/""
		        },
		        {
			        ""name"": ""snubbull"",
			        ""resource_uri"": ""api/v1/pokemon/209/""
		        },
		        {
			        ""name"": ""dragonite"",
			        ""resource_uri"": ""api/v1/pokemon/149/""
		        },
		        {
			        ""name"": ""steelix"",
			        ""resource_uri"": ""api/v1/pokemon/208/""
		        },
		        {
			        ""name"": ""tyranitar"",
			        ""resource_uri"": ""api/v1/pokemon/248/""
		        },
		        {
			        ""name"": ""swellow"",
			        ""resource_uri"": ""api/v1/pokemon/277/""
		        },
		        {
			        ""name"": ""wailord"",
			        ""resource_uri"": ""api/v1/pokemon/321/""
		        },
		        {
			        ""name"": ""cradily"",
			        ""resource_uri"": ""api/v1/pokemon/346/""
		        },
		        {
			        ""name"": ""deoxys-normal"",
			        ""resource_uri"": ""api/v1/pokemon/386/""
		        },
		        {
			        ""name"": ""azelf"",
			        ""resource_uri"": ""api/v1/pokemon/482/""
		        },
		        {
			        ""name"": ""wormadam-plant"",
			        ""resource_uri"": ""api/v1/pokemon/413/""
		        },
		        {
			        ""name"": ""krookodile"",
			        ""resource_uri"": ""api/v1/pokemon/553/""
		        },
		        {
			        ""name"": ""ducklett"",
			        ""resource_uri"": ""api/v1/pokemon/580/""
		        },
		        {
			        ""name"": ""gengar-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10038/""
		        },
		        {
			        ""name"": ""pinsir-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10040/""
		        },
		        {
			        ""name"": ""kangaskhan-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10039/""
		        },
		        {
			        ""name"": ""barbaracle"",
			        ""resource_uri"": ""api/v1/pokemon/689/""
		        },
		        {
			        ""name"": ""gyarados-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10041/""
		        },
		        {
			        ""name"": ""ampharos-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10045/""
		        },
		        {
			        ""name"": ""aerodactyl-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10042/""
		        },
		        {
			        ""name"": ""mewtwo-mega-x"",
			        ""resource_uri"": ""api/v1/pokemon/10043/""
		        },
		        {
			        ""name"": ""mewtwo-mega-y"",
			        ""resource_uri"": ""api/v1/pokemon/10044/""
		        },
		        {
			        ""name"": ""scizor-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10046/""
		        },
		        {
			        ""name"": ""medicham-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10054/""
		        },
		        {
			        ""name"": ""heracross-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10047/""
		        },
		        {
			        ""name"": ""houndoom-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10048/""
		        },
		        {
			        ""name"": ""tyranitar-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10049/""
		        },
		        {
			        ""name"": ""blaziken-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10050/""
		        },
		        {
			        ""name"": ""gardevoir-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10051/""
		        },
		        {
			        ""name"": ""mawile-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10052/""
		        },
		        {
			        ""name"": ""aggron-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10053/""
		        },
		        {
			        ""name"": ""manectric-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10055/""
		        },
		        {
			        ""name"": ""banette-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10056/""
		        },
		        {
			        ""name"": ""absol-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10057/""
		        },
		        {
			        ""name"": ""garchomp-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10058/""
		        },
		        {
			        ""name"": ""lucario-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10059/""
		        },
		        {
			        ""name"": ""clefairy"",
			        ""resource_uri"": ""api/v1/pokemon/35/""
		        },
		        {
			        ""name"": ""abomasnow-mega"",
			        ""resource_uri"": ""api/v1/pokemon/10060/""
		        },
		        {
			        ""name"": ""bulbasaur"",
			        ""resource_uri"": ""api/v1/pokemon/1/""
		        },
		        {
			        ""name"": ""charizard"",
			        ""resource_uri"": ""api/v1/pokemon/6/""
		        },
		        {
			        ""name"": ""omastar"",
			        ""resource_uri"": ""api/v1/pokemon/139/""
		        },
		        {
			        ""name"": ""seaking"",
			        ""resource_uri"": ""api/v1/pokemon/119/""
		        },
		        {
			        ""name"": ""flaaffy"",
			        ""resource_uri"": ""api/v1/pokemon/180/""
		        },
		        {
			        ""name"": ""shedinja"",
			        ""resource_uri"": ""api/v1/pokemon/292/""
		        },
		        {
			        ""name"": ""tropius"",
			        ""resource_uri"": ""api/v1/pokemon/357/""
		        },
		        {
			        ""name"": ""combee"",
			        ""resource_uri"": ""api/v1/pokemon/415/""
		        },
		        {
			        ""name"": ""shellos"",
			        ""resource_uri"": ""api/v1/pokemon/422/""
		        },
		        {
			        ""name"": ""skorupi"",
			        ""resource_uri"": ""api/v1/pokemon/451/""
		        },
		        {
			        ""name"": ""heatran"",
			        ""resource_uri"": ""api/v1/pokemon/485/""
		        },
		        {
			        ""name"": ""palkia"",
			        ""resource_uri"": ""api/v1/pokemon/484/""
		        },
		        {
			        ""name"": ""simisear"",
			        ""resource_uri"": ""api/v1/pokemon/514/""
		        },
		        {
			        ""name"": ""tornadus-incarnate"",
			        ""resource_uri"": ""api/v1/pokemon/641/""
		        },
		        {
			        ""name"": ""fraxure"",
			        ""resource_uri"": ""api/v1/pokemon/611/""
		        },
		        {
			        ""name"": ""druddigon"",
			        ""resource_uri"": ""api/v1/pokemon/621/""
		        },
		        {
			        ""name"": ""pangoro"",
			        ""resource_uri"": ""api/v1/pokemon/675/""
		        },
		        {
			        ""name"": ""helioptile"",
			        ""resource_uri"": ""api/v1/pokemon/694/""
		        },
		        {
			        ""name"": ""dragalge"",
			        ""resource_uri"": ""api/v1/pokemon/691/""
		        },
		        {
			        ""name"": ""weepinbell"",
			        ""resource_uri"": ""api/v1/pokemon/70/""
		        },
		        {
			        ""name"": ""sandslash"",
			        ""resource_uri"": ""api/v1/pokemon/28/""
		        },
		        {
			        ""name"": ""samurott"",
			        ""resource_uri"": ""api/v1/pokemon/503/""
		        },
		        {
			        ""name"": ""primeape"",
			        ""resource_uri"": ""api/v1/pokemon/57/""
		        },
		        {
			        ""name"": ""teddiursa"",
			        ""resource_uri"": ""api/v1/pokemon/216/""
		        },
		        {
			        ""name"": ""salamence"",
			        ""resource_uri"": ""api/v1/pokemon/373/""
		        },
		        {
			        ""name"": ""giratina-origin"",
			        ""resource_uri"": ""api/v1/pokemon/10007/""
		        },
		        {
			        ""name"": ""gurdurr"",
			        ""resource_uri"": ""api/v1/pokemon/533/""
		        },
		        {
			        ""name"": ""slowpoke"",
			        ""resource_uri"": ""api/v1/pokemon/79/""
		        },
		        {
			        ""name"": ""hitmontop"",
			        ""resource_uri"": ""api/v1/pokemon/237/""
		        },
		        {
			        ""name"": ""bibarel"",
			        ""resource_uri"": ""api/v1/pokemon/400/""
		        },
		        {
			        ""name"": ""marowak"",
			        ""resource_uri"": ""api/v1/pokemon/105/""
		        },
		        {
			        ""name"": ""castform-snowy"",
			        ""resource_uri"": ""api/v1/pokemon/10015/""
		        },
		        {
			        ""name"": ""zigzagoon"",
			        ""resource_uri"": ""api/v1/pokemon/263/""
		        },
		        {
			        ""name"": ""garbodor"",
			        ""resource_uri"": ""api/v1/pokemon/569/""
		        },
		        {
			        ""name"": ""magikarp"",
			        ""resource_uri"": ""api/v1/pokemon/129/""
		        },
		        {
			        ""name"": ""chatot"",
			        ""resource_uri"": ""api/v1/pokemon/441/""
		        },
		        {
			        ""name"": ""gardevoir"",
			        ""resource_uri"": ""api/v1/pokemon/282/""
		        },
		        {
			        ""name"": ""spinarak"",
			        ""resource_uri"": ""api/v1/pokemon/167/""
		        },
		        {
			        ""name"": ""klinklang"",
			        ""resource_uri"": ""api/v1/pokemon/601/""
		        },
		        {
			        ""name"": ""tangrowth"",
			        ""resource_uri"": ""api/v1/pokemon/465/""
		        },
		        {
			        ""name"": ""meditite"",
			        ""resource_uri"": ""api/v1/pokemon/307/""
		        },
		        {
			        ""name"": ""slowking"",
			        ""resource_uri"": ""api/v1/pokemon/199/""
		        },
		        {
			        ""name"": ""cresselia"",
			        ""resource_uri"": ""api/v1/pokemon/488/""
		        },
		        {
			        ""name"": ""zangoose"",
			        ""resource_uri"": ""api/v1/pokemon/335/""
		        },
		        {
			        ""name"": ""phione"",
			        ""resource_uri"": ""api/v1/pokemon/489/""
		        },
		        {
			        ""name"": ""zweilous"",
			        ""resource_uri"": ""api/v1/pokemon/634/""
		        },
		        {
			        ""name"": ""pyroar"",
			        ""resource_uri"": ""api/v1/pokemon/668/""
		        }
	        ],
	        ""resource_uri"": ""/api/v1/pokedex/1/""
        }";

        internal static string Pokemon = @"	{
		    ""abilities"": [
			    {
				    ""name"": ""chlorophyll"",
				    ""resource_uri"": ""/api/v1/ability/34/""
			    },
			    {
				    ""name"": ""overgrow"",
				    ""resource_uri"": ""/api/v1/ability/65/""
			    }
		    ],
		    ""attack"": 49,
		    ""catch_rate"": 0,
		    ""created"": ""2013-11-03T15:05:41.260678"",
		    ""defense"": 49,
		    ""descriptions"": [
			    {
				    ""name"": ""bulbasaur_gen_1"",
				    ""resource_uri"": ""/api/v1/description/4/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_1"",
				    ""resource_uri"": ""/api/v1/description/5/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_1"",
				    ""resource_uri"": ""/api/v1/description/6/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_2"",
				    ""resource_uri"": ""/api/v1/description/7/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_2"",
				    ""resource_uri"": ""/api/v1/description/8/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_3"",
				    ""resource_uri"": ""/api/v1/description/9/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_3"",
				    ""resource_uri"": ""/api/v1/description/10/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_3"",
				    ""resource_uri"": ""/api/v1/description/11/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_4"",
				    ""resource_uri"": ""/api/v1/description/12/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_4"",
				    ""resource_uri"": ""/api/v1/description/13/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_4"",
				    ""resource_uri"": ""/api/v1/description/14/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_5"",
				    ""resource_uri"": ""/api/v1/description/15/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_1"",
				    ""resource_uri"": ""/api/v1/description/2/""
			    },
			    {
				    ""name"": ""bulbasaur_gen_1"",
				    ""resource_uri"": ""/api/v1/description/3/""
			    }
		    ],
		    ""egg_cycles"": 0,
		    ""egg_groups"": [
			    {
				    ""name"": ""Plant"",
				    ""resource_uri"": ""/api/v1/egg/7/""
			    },
			    {
				    ""name"": ""Monster"",
				    ""resource_uri"": ""/api/v1/egg/1/""
			    }
		    ],
		    ""ev_yield"": ""1 special attack"",
		    ""evolutions"": [
			    {
				    ""level"": 16,
				    ""method"": ""level_up"",
				    ""resource_uri"": ""/api/v1/pokemon/2/"",
				    ""to"": ""Ivysaur""
			    }
		    ],
		    ""exp"": 64,
		    ""growth_rate"": ""medium slow"",
		    ""happiness"": 0,
		    ""height"": ""7"",
		    ""hp"": 45,
		    ""male_female_ratio"": ""87.5/12.5"",
		    ""modified"": ""2013-11-30T13:59:47.261100"",
		    ""moves"": [
			    {
				    ""learn_type"": ""tutor"",
				    ""name"": ""Bind"",
				    ""resource_uri"": ""/api/v1/move/20/""
			    },
			    {
				    ""learn_type"": ""tutor"",
				    ""name"": ""Grass-pledge"",
				    ""resource_uri"": ""/api/v1/move/520/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Echoed-voice"",
				    ""resource_uri"": ""/api/v1/move/497/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Round"",
				    ""resource_uri"": ""/api/v1/move/496/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Venoshock"",
				    ""resource_uri"": ""/api/v1/move/474/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Power-whip"",
				    ""resource_uri"": ""/api/v1/move/438/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Sludge"",
				    ""resource_uri"": ""/api/v1/move/124/""
			    },
			    {
				    ""learn_type"": ""tutor"",
				    ""name"": ""String-shot"",
				    ""resource_uri"": ""/api/v1/move/81/""
			    },
			    {
				    ""learn_type"": ""tutor"",
				    ""name"": ""Knock-off"",
				    ""resource_uri"": ""/api/v1/move/282/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Grass-knot"",
				    ""resource_uri"": ""/api/v1/move/447/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Captivate"",
				    ""resource_uri"": ""/api/v1/move/445/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Leaf-storm"",
				    ""resource_uri"": ""/api/v1/move/437/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Energy-ball"",
				    ""resource_uri"": ""/api/v1/move/412/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 37,
				    ""name"": ""Seed-bomb"",
				    ""resource_uri"": ""/api/v1/move/402/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 31,
				    ""name"": ""Worry-seed"",
				    ""resource_uri"": ""/api/v1/move/388/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Natural-gift"",
				    ""resource_uri"": ""/api/v1/move/363/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Ingrain"",
				    ""resource_uri"": ""/api/v1/move/275/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Nature-power"",
				    ""resource_uri"": ""/api/v1/move/267/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Amnesia"",
				    ""resource_uri"": ""/api/v1/move/133/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Magical-leaf"",
				    ""resource_uri"": ""/api/v1/move/345/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Bullet-seed"",
				    ""resource_uri"": ""/api/v1/move/331/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Grasswhistle"",
				    ""resource_uri"": ""/api/v1/move/320/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Secret-power"",
				    ""resource_uri"": ""/api/v1/move/290/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Facade"",
				    ""resource_uri"": ""/api/v1/move/263/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Rock-smash"",
				    ""resource_uri"": ""/api/v1/move/249/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Sludge-bomb"",
				    ""resource_uri"": ""/api/v1/move/188/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Strength"",
				    ""resource_uri"": ""/api/v1/move/70/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Sunny-day"",
				    ""resource_uri"": ""/api/v1/move/241/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Hidden-power"",
				    ""resource_uri"": ""/api/v1/move/237/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 39,
				    ""name"": ""Synthesis"",
				    ""resource_uri"": ""/api/v1/move/235/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 25,
				    ""name"": ""Sweet-scent"",
				    ""resource_uri"": ""/api/v1/move/230/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Safeguard"",
				    ""resource_uri"": ""/api/v1/move/219/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Frustration"",
				    ""resource_uri"": ""/api/v1/move/218/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Return"",
				    ""resource_uri"": ""/api/v1/move/216/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Sleep-talk"",
				    ""resource_uri"": ""/api/v1/move/214/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Attract"",
				    ""resource_uri"": ""/api/v1/move/213/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Fury-cutter"",
				    ""resource_uri"": ""/api/v1/move/210/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Swagger"",
				    ""resource_uri"": ""/api/v1/move/207/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Charm"",
				    ""resource_uri"": ""/api/v1/move/204/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Endure"",
				    ""resource_uri"": ""/api/v1/move/203/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Giga-drain"",
				    ""resource_uri"": ""/api/v1/move/202/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Mud-slap"",
				    ""resource_uri"": ""/api/v1/move/189/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Protect"",
				    ""resource_uri"": ""/api/v1/move/182/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Curse"",
				    ""resource_uri"": ""/api/v1/move/174/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Snore"",
				    ""resource_uri"": ""/api/v1/move/173/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Flash"",
				    ""resource_uri"": ""/api/v1/move/148/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Skull-bash"",
				    ""resource_uri"": ""/api/v1/move/130/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Light-screen"",
				    ""resource_uri"": ""/api/v1/move/113/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Defense-curl"",
				    ""resource_uri"": ""/api/v1/move/111/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Petal-dance"",
				    ""resource_uri"": ""/api/v1/move/80/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Headbutt"",
				    ""resource_uri"": ""/api/v1/move/29/""
			    },
			    {
				    ""learn_type"": ""egg move"",
				    ""name"": ""Razor-wind"",
				    ""resource_uri"": ""/api/v1/move/13/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Substitute"",
				    ""resource_uri"": ""/api/v1/move/164/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Rest"",
				    ""resource_uri"": ""/api/v1/move/156/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Bide"",
				    ""resource_uri"": ""/api/v1/move/117/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Reflect"",
				    ""resource_uri"": ""/api/v1/move/115/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Double-team"",
				    ""resource_uri"": ""/api/v1/move/104/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Mimic"",
				    ""resource_uri"": ""/api/v1/move/102/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Rage"",
				    ""resource_uri"": ""/api/v1/move/99/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Toxic"",
				    ""resource_uri"": ""/api/v1/move/92/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 41,
				    ""name"": ""Sleep-powder"",
				    ""resource_uri"": ""/api/v1/move/79/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 20,
				    ""name"": ""Poisonpowder"",
				    ""resource_uri"": ""/api/v1/move/77/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 48,
				    ""name"": ""Solarbeam"",
				    ""resource_uri"": ""/api/v1/move/76/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 27,
				    ""name"": ""Razor-leaf"",
				    ""resource_uri"": ""/api/v1/move/75/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 34,
				    ""name"": ""Growth"",
				    ""resource_uri"": ""/api/v1/move/74/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 7,
				    ""name"": ""Leech-seed"",
				    ""resource_uri"": ""/api/v1/move/73/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Mega-drain"",
				    ""resource_uri"": ""/api/v1/move/72/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 1,
				    ""name"": ""Growl"",
				    ""resource_uri"": ""/api/v1/move/45/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Double-edge"",
				    ""resource_uri"": ""/api/v1/move/38/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Take-down"",
				    ""resource_uri"": ""/api/v1/move/36/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Body-slam"",
				    ""resource_uri"": ""/api/v1/move/34/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 1,
				    ""name"": ""Tackle"",
				    ""resource_uri"": ""/api/v1/move/33/""
			    },
			    {
				    ""learn_type"": ""level up"",
				    ""level"": 13,
				    ""name"": ""Vine-whip"",
				    ""resource_uri"": ""/api/v1/move/22/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Cut"",
				    ""resource_uri"": ""/api/v1/move/15/""
			    },
			    {
				    ""learn_type"": ""machine"",
				    ""name"": ""Swords-dance"",
				    ""resource_uri"": ""/api/v1/move/14/""
			    }
		    ],
		    ""name"": ""Bulbasaur"",
		    ""national_id"": 1,
		    ""pkdx_id"": 1,
		    ""resource_uri"": ""/api/v1/pokemon/1/"",
		    ""sp_atk"": 65,
		    ""sp_def"": 65,
		    ""species"": ""seed pokemon"",
		    ""speed"": 45,
		    ""sprites"": [
			    {
				    ""name"": ""bulbasaur"",
				    ""resource_uri"": ""/api/v1/sprite/2/""
			    },
			    {
				    ""name"": ""bulbasaur"",
				    ""resource_uri"": ""/api/v1/sprite/1/""
			    }
		    ],
		    ""total"": 0,
		    ""types"": [
			    {
				    ""name"": ""poison"",
				    ""resource_uri"": ""/api/v1/type/4/""
			    },
			    {
				    ""name"": ""grass"",
				    ""resource_uri"": ""/api/v1/type/12/""
			    }
		    ],
		    ""weight"": ""69""
	    }";

        internal static string TypeList = @"		{
			""meta"": {
				""limit"": 10,
				""next"": ""/api/v1/type/?limit=10&offset=10"",
				""offset"": 0,
				""previous"": null,
				""total_count"": 20
			},
			""objects"": [
				{
					""created"": ""2013-11-02T12:08:58.787000"",
					""id"": 1,
					""ineffective"": [
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					],
					""modified"": ""2013-11-02T13:09:51.769000"",
					""name"": ""Normal"",
					""no_effect"": [
						{
							""name"": ""ghost"",
							""resource_uri"": ""/api/v1/type/8/""
						}
					],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/1/"",
					""super_effective"": [],
					""weakness"": [
						{
							""name"": ""fighting"",
							""resource_uri"": ""/api/v1/type/2/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:04.348000"",
					""id"": 2,
					""ineffective"": [
						{
							""name"": ""poison"",
							""resource_uri"": ""/api/v1/type/4/""
						},
						{
							""name"": ""flying"",
							""resource_uri"": ""/api/v1/type/3/""
						},
						{
							""name"": ""psychic"",
							""resource_uri"": ""/api/v1/type/14/""
						},
						{
							""name"": ""bug"",
							""resource_uri"": ""/api/v1/type/7/""
						},
						{
							""name"": ""fairy"",
							""resource_uri"": ""/api/v1/type/18/""
						}
					],
					""modified"": ""2013-11-02T12:09:04.348000"",
					""name"": ""Fighting"",
					""no_effect"": [
						{
							""name"": ""ghost"",
							""resource_uri"": ""/api/v1/type/8/""
						}
					],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/2/"",
					""super_effective"": [
						{
							""name"": ""normal"",
							""resource_uri"": ""/api/v1/type/1/""
						},
						{
							""name"": ""ice"",
							""resource_uri"": ""/api/v1/type/15/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						},
						{
							""name"": ""dark"",
							""resource_uri"": ""/api/v1/type/17/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					],
					""weakness"": [
						{
							""name"": ""flying"",
							""resource_uri"": ""/api/v1/type/3/""
						},
						{
							""name"": ""psychic"",
							""resource_uri"": ""/api/v1/type/14/""
						},
						{
							""name"": ""fairy"",
							""resource_uri"": ""/api/v1/type/18/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:07.305000"",
					""id"": 3,
					""ineffective"": [
						{
							""name"": ""electric"",
							""resource_uri"": ""/api/v1/type/13/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					],
					""modified"": ""2013-11-02T13:14:44.369000"",
					""name"": ""Flying"",
					""no_effect"": [],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/3/"",
					""super_effective"": [
						{
							""name"": ""grass"",
							""resource_uri"": ""/api/v1/type/12/""
						},
						{
							""name"": ""fighting"",
							""resource_uri"": ""/api/v1/type/2/""
						},
						{
							""name"": ""bug"",
							""resource_uri"": ""/api/v1/type/7/""
						}
					],
					""weakness"": [
						{
							""name"": ""electric"",
							""resource_uri"": ""/api/v1/type/13/""
						},
						{
							""name"": ""ice"",
							""resource_uri"": ""/api/v1/type/15/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:13.301000"",
					""id"": 4,
					""ineffective"": [
						{
							""name"": ""poison"",
							""resource_uri"": ""/api/v1/type/4/""
						},
						{
							""name"": ""ground"",
							""resource_uri"": ""/api/v1/type/5/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						},
						{
							""name"": ""ghost"",
							""resource_uri"": ""/api/v1/type/8/""
						}
					],
					""modified"": ""2013-11-02T12:09:13.301000"",
					""name"": ""Poison"",
					""no_effect"": [
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/4/"",
					""super_effective"": [
						{
							""name"": ""grass"",
							""resource_uri"": ""/api/v1/type/12/""
						},
						{
							""name"": ""fairy"",
							""resource_uri"": ""/api/v1/type/18/""
						}
					],
					""weakness"": [
						{
							""name"": ""ground"",
							""resource_uri"": ""/api/v1/type/5/""
						},
						{
							""name"": ""psychic"",
							""resource_uri"": ""/api/v1/type/14/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:19.446000"",
					""id"": 5,
					""ineffective"": [
						{
							""name"": ""ground"",
							""resource_uri"": ""/api/v1/type/5/""
						},
						{
							""name"": ""bug"",
							""resource_uri"": ""/api/v1/type/7/""
						}
					],
					""modified"": ""2013-11-02T12:09:19.446000"",
					""name"": ""Ground"",
					""no_effect"": [
						{
							""name"": ""flying"",
							""resource_uri"": ""/api/v1/type/3/""
						}
					],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/5/"",
					""super_effective"": [
						{
							""name"": ""fire"",
							""resource_uri"": ""/api/v1/type/10/""
						},
						{
							""name"": ""electric"",
							""resource_uri"": ""/api/v1/type/13/""
						},
						{
							""name"": ""poison"",
							""resource_uri"": ""/api/v1/type/4/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					],
					""weakness"": [
						{
							""name"": ""water"",
							""resource_uri"": ""/api/v1/type/11/""
						},
						{
							""name"": ""grass"",
							""resource_uri"": ""/api/v1/type/12/""
						},
						{
							""name"": ""ice"",
							""resource_uri"": ""/api/v1/type/15/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:21.887000"",
					""id"": 6,
					""ineffective"": [
						{
							""name"": ""fighting"",
							""resource_uri"": ""/api/v1/type/2/""
						},
						{
							""name"": ""ground"",
							""resource_uri"": ""/api/v1/type/5/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					],
					""modified"": ""2013-11-02T12:09:21.887000"",
					""name"": ""Rock"",
					""no_effect"": [],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/6/"",
					""super_effective"": [
						{
							""name"": ""fire"",
							""resource_uri"": ""/api/v1/type/10/""
						},
						{
							""name"": ""ice"",
							""resource_uri"": ""/api/v1/type/15/""
						},
						{
							""name"": ""flying"",
							""resource_uri"": ""/api/v1/type/3/""
						},
						{
							""name"": ""bug"",
							""resource_uri"": ""/api/v1/type/7/""
						}
					],
					""weakness"": [
						{
							""name"": ""water"",
							""resource_uri"": ""/api/v1/type/11/""
						},
						{
							""name"": ""grass"",
							""resource_uri"": ""/api/v1/type/12/""
						},
						{
							""name"": ""fighting"",
							""resource_uri"": ""/api/v1/type/2/""
						},
						{
							""name"": ""ground"",
							""resource_uri"": ""/api/v1/type/5/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:28.395000"",
					""id"": 7,
					""ineffective"": [
						{
							""name"": ""fighting"",
							""resource_uri"": ""/api/v1/type/2/""
						},
						{
							""name"": ""poison"",
							""resource_uri"": ""/api/v1/type/4/""
						},
						{
							""name"": ""flying"",
							""resource_uri"": ""/api/v1/type/3/""
						},
						{
							""name"": ""ghost"",
							""resource_uri"": ""/api/v1/type/8/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						},
						{
							""name"": ""fairy"",
							""resource_uri"": ""/api/v1/type/18/""
						}
					],
					""modified"": ""2013-11-02T12:09:28.395000"",
					""name"": ""Bug"",
					""no_effect"": [],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/7/"",
					""super_effective"": [
						{
							""name"": ""grass"",
							""resource_uri"": ""/api/v1/type/12/""
						},
						{
							""name"": ""psychic"",
							""resource_uri"": ""/api/v1/type/14/""
						},
						{
							""name"": ""dark"",
							""resource_uri"": ""/api/v1/type/17/""
						}
					],
					""weakness"": [
						{
							""name"": ""fire"",
							""resource_uri"": ""/api/v1/type/10/""
						},
						{
							""name"": ""flying"",
							""resource_uri"": ""/api/v1/type/3/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:35.820000"",
					""id"": 8,
					""ineffective"": [
						{
							""name"": ""dark"",
							""resource_uri"": ""/api/v1/type/17/""
						}
					],
					""modified"": ""2013-11-02T12:09:35.820000"",
					""name"": ""Ghost"",
					""no_effect"": [
						{
							""name"": ""normal"",
							""resource_uri"": ""/api/v1/type/1/""
						}
					],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/8/"",
					""super_effective"": [
						{
							""name"": ""psychic"",
							""resource_uri"": ""/api/v1/type/14/""
						},
						{
							""name"": ""ghost"",
							""resource_uri"": ""/api/v1/type/8/""
						}
					],
					""weakness"": [
						{
							""name"": ""ghost"",
							""resource_uri"": ""/api/v1/type/8/""
						},
						{
							""name"": ""dark"",
							""resource_uri"": ""/api/v1/type/17/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:41.060000"",
					""id"": 9,
					""ineffective"": [
						{
							""name"": ""fire"",
							""resource_uri"": ""/api/v1/type/10/""
						},
						{
							""name"": ""water"",
							""resource_uri"": ""/api/v1/type/11/""
						},
						{
							""name"": ""electric"",
							""resource_uri"": ""/api/v1/type/13/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					],
					""modified"": ""2013-11-02T12:09:41.060000"",
					""name"": ""Steel"",
					""no_effect"": [],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/9/"",
					""super_effective"": [
						{
							""name"": ""ice"",
							""resource_uri"": ""/api/v1/type/15/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						},
						{
							""name"": ""fairy"",
							""resource_uri"": ""/api/v1/type/18/""
						}
					],
					""weakness"": [
						{
							""name"": ""fire"",
							""resource_uri"": ""/api/v1/type/10/""
						},
						{
							""name"": ""fighting"",
							""resource_uri"": ""/api/v1/type/2/""
						},
						{
							""name"": ""ground"",
							""resource_uri"": ""/api/v1/type/5/""
						}
					]
				},
				{
					""created"": ""2013-11-02T12:09:46.396000"",
					""id"": 10,
					""ineffective"": [
						{
							""name"": ""fire"",
							""resource_uri"": ""/api/v1/type/10/""
						},
						{
							""name"": ""water"",
							""resource_uri"": ""/api/v1/type/11/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						},
						{
							""name"": ""dragon"",
							""resource_uri"": ""/api/v1/type/16/""
						}
					],
					""modified"": ""2013-11-02T12:09:46.396000"",
					""name"": ""Fire"",
					""no_effect"": [],
					""resistance"": [],
					""resource_uri"": ""/api/v1/type/10/"",
					""super_effective"": [
						{
							""name"": ""grass"",
							""resource_uri"": ""/api/v1/type/12/""
						},
						{
							""name"": ""ice"",
							""resource_uri"": ""/api/v1/type/15/""
						},
						{
							""name"": ""bug"",
							""resource_uri"": ""/api/v1/type/7/""
						},
						{
							""name"": ""steel"",
							""resource_uri"": ""/api/v1/type/9/""
						}
					],
					""weakness"": [
						{
							""name"": ""water"",
							""resource_uri"": ""/api/v1/type/11/""
						},
						{
							""name"": ""rock"",
							""resource_uri"": ""/api/v1/type/6/""
						},
						{
							""name"": ""ground"",
							""resource_uri"": ""/api/v1/type/5/""
						}
					]
				}
			]
		}";

        internal static string Type = @"		{
			""created"": ""2013-11-02T12:09:07.305000"",
			""id"": 3,
			""ineffective"": [
				{
					""name"": ""electric"",
					""resource_uri"": ""/api/v1/type/13/""
				},
				{
					""name"": ""rock"",
					""resource_uri"": ""/api/v1/type/6/""
				},
				{
					""name"": ""steel"",
					""resource_uri"": ""/api/v1/type/9/""
				}
			],
			""modified"": ""2013-11-02T13:14:44.369000"",
			""name"": ""Flying"",
			""no_effect"": [],
			""resistance"": [],
			""resource_uri"": ""/api/v1/type/3/"",
			""super_effective"": [
				{
					""name"": ""grass"",
					""resource_uri"": ""/api/v1/type/12/""
				},
				{
					""name"": ""fighting"",
					""resource_uri"": ""/api/v1/type/2/""
				},
				{
					""name"": ""bug"",
					""resource_uri"": ""/api/v1/type/7/""
				}
			],
			""weakness"": [
				{
					""name"": ""electric"",
					""resource_uri"": ""/api/v1/type/13/""
				},
				{
					""name"": ""ice"",
					""resource_uri"": ""/api/v1/type/15/""
				},
				{
					""name"": ""rock"",
					""resource_uri"": ""/api/v1/type/6/""
				}
			]
		}";

        internal static string MoveList = @"		{
			""meta"": {
				""limit"": 10,
				""next"": ""/api/v1/move/?limit=10&offset=10"",
				""offset"": 0,
				""previous"": null,
				""total_count"": 625
			},
			""objects"": [
				{
					""accuracy"": 85,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.493769"",
					""description"": ""Inflicts regular damage."",
					""id"": 5,
					""modified"": ""2013-12-24T15:24:29.669820"",
					""name"": ""Mega-punch"",
					""power"": 80,
					""pp"": 20,
					""resource_uri"": ""/api/v1/move/5/""
				},
				{
					""accuracy"": 100,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.497135"",
					""description"": ""Inflicts regular damage.  After the battle ends, the winner receives five times the user's level in extra money for each time this move was used."",
					""id"": 6,
					""modified"": ""2013-12-24T15:24:29.676149"",
					""name"": ""Pay-day"",
					""power"": 40,
					""pp"": 20,
					""resource_uri"": ""/api/v1/move/6/""
				},
				{
					""accuracy"": 100,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.503161"",
					""description"": ""Inflicts regular damage.  Has a 10% chance to freeze the target."",
					""id"": 8,
					""modified"": ""2013-12-24T15:24:29.687639"",
					""name"": ""Ice-punch"",
					""power"": 75,
					""pp"": 15,
					""resource_uri"": ""/api/v1/move/8/""
				},
				{
					""accuracy"": 100,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.507629"",
					""description"": ""Inflicts regular damage."",
					""id"": 10,
					""modified"": ""2013-12-24T15:24:29.699389"",
					""name"": ""Scratch"",
					""power"": 40,
					""pp"": 35,
					""resource_uri"": ""/api/v1/move/10/""
				},
				{
					""accuracy"": 100,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.509751"",
					""description"": ""Inflicts regular damage."",
					""id"": 11,
					""modified"": ""2013-12-24T15:24:29.705323"",
					""name"": ""Vicegrip"",
					""power"": 55,
					""pp"": 30,
					""resource_uri"": ""/api/v1/move/11/""
				},
				{
					""accuracy"": 0,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.516991"",
					""description"": ""Raises the user's Attack by two stages."",
					""id"": 14,
					""modified"": ""2013-12-24T15:24:29.722955"",
					""name"": ""Swords-dance"",
					""power"": 0,
					""pp"": 30,
					""resource_uri"": ""/api/v1/move/14/""
				},
				{
					""accuracy"": 95,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.519610"",
					""description"": ""Inflicts regular damage."",
					""id"": 15,
					""modified"": ""2013-12-24T15:24:29.728206"",
					""name"": ""Cut"",
					""power"": 50,
					""pp"": 30,
					""resource_uri"": ""/api/v1/move/15/""
				},
				{
					""accuracy"": 100,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.526176"",
					""description"": ""Inflicts regular damage.\n\nIf the target is under the effect of bounce, fly, or sky-drop, this move will hit with double power."",
					""id"": 16,
					""modified"": ""2013-12-24T15:24:29.734492"",
					""name"": ""Gust"",
					""power"": 40,
					""pp"": 35,
					""resource_uri"": ""/api/v1/move/16/""
				},
				{
					""accuracy"": 100,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.528672"",
					""description"": ""Inflicts regular damage."",
					""id"": 17,
					""modified"": ""2013-12-24T15:24:29.739670"",
					""name"": ""Wing-attack"",
					""power"": 60,
					""pp"": 35,
					""resource_uri"": ""/api/v1/move/17/""
				},
				{
					""accuracy"": 75,
					""category"": """",
					""created"": ""2013-11-03T15:06:09.538455"",
					""description"": ""Inflicts regular damage."",
					""id"": 21,
					""modified"": ""2013-12-24T15:24:29.761713"",
					""name"": ""Slam"",
					""power"": 80,
					""pp"": 20,
					""resource_uri"": ""/api/v1/move/21/""
				}
			]
		}";

        internal static string Move = @"		{
			""accuracy"": 100,
			""category"": """",
			""created"": ""2013-11-03T15:06:09.507629"",
			""description"": ""Inflicts regular damage."",
			""id"": 10,
			""modified"": ""2013-12-24T15:24:29.699389"",
			""name"": ""Scratch"",
			""power"": 40,
			""pp"": 35,
			""resource_uri"": ""/api/v1/move/10/""
		}";

        internal static string AbilityList = @"		{
			""meta"": {
				""limit"": 10,
				""next"": ""/api/v1/ability/?limit=10&offset=10"",
				""offset"": 0,
				""previous"": null,
				""total_count"": 248
			},
			""objects"": [
				{
					""created"": ""2013-11-03T15:05:59.481261"",
					""description"": """",
					""id"": 1,
					""modified"": ""2013-11-03T15:05:59.481206"",
					""name"": ""Stench"",
					""resource_uri"": ""/api/v1/ability/1/""
				},
				{
					""created"": ""2013-11-03T15:05:59.488571"",
					""description"": """",
					""id"": 2,
					""modified"": ""2013-11-03T15:05:59.488514"",
					""name"": ""Drizzle"",
					""resource_uri"": ""/api/v1/ability/2/""
				},
				{
					""created"": ""2013-11-03T15:05:59.494373"",
					""description"": """",
					""id"": 3,
					""modified"": ""2013-11-03T15:05:59.494317"",
					""name"": ""Speed-boost"",
					""resource_uri"": ""/api/v1/ability/3/""
				},
				{
					""created"": ""2013-11-03T15:05:59.496513"",
					""description"": """",
					""id"": 4,
					""modified"": ""2013-11-03T15:05:59.496466"",
					""name"": ""Battle-armor"",
					""resource_uri"": ""/api/v1/ability/4/""
				},
				{
					""created"": ""2013-11-03T15:05:59.500388"",
					""description"": """",
					""id"": 5,
					""modified"": ""2013-11-03T15:05:59.500336"",
					""name"": ""Sturdy"",
					""resource_uri"": ""/api/v1/ability/5/""
				},
				{
					""created"": ""2013-11-03T15:05:59.502413"",
					""description"": """",
					""id"": 6,
					""modified"": ""2013-11-03T15:05:59.502370"",
					""name"": ""Damp"",
					""resource_uri"": ""/api/v1/ability/6/""
				},
				{
					""created"": ""2013-11-03T15:05:59.504309"",
					""description"": """",
					""id"": 7,
					""modified"": ""2013-11-03T15:05:59.504270"",
					""name"": ""Limber"",
					""resource_uri"": ""/api/v1/ability/7/""
				},
				{
					""created"": ""2013-11-03T15:05:59.505962"",
					""description"": """",
					""id"": 8,
					""modified"": ""2013-11-03T15:05:59.505922"",
					""name"": ""Sand-veil"",
					""resource_uri"": ""/api/v1/ability/8/""
				},
				{
					""created"": ""2013-11-03T15:05:59.507657"",
					""description"": """",
					""id"": 9,
					""modified"": ""2013-11-03T15:05:59.507616"",
					""name"": ""Static"",
					""resource_uri"": ""/api/v1/ability/9/""
				},
				{
					""created"": ""2013-11-03T15:05:59.509374"",
					""description"": """",
					""id"": 10,
					""modified"": ""2013-11-03T15:05:59.509335"",
					""name"": ""Volt-absorb"",
					""resource_uri"": ""/api/v1/ability/10/""
				}
			]
		}";

        internal static string Ability = @"		{
			""created"": ""2013-11-03T15:05:59.496513"",
			""description"": """",
			""id"": 4,
			""modified"": ""2013-11-03T15:05:59.496466"",
			""name"": ""Battle-armor"",
			""resource_uri"": ""/api/v1/ability/4/""
		}";

        internal static string DescriptionList = @"		{
			""meta"": {
				""limit"": 10,
				""next"": ""/api/v1/description/?limit=10&offset=10"",
				""offset"": 0,
				""previous"": null,
				""total_count"": 6609
			},
			""objects"": [
				{
					""created"": ""2013-12-24T17:14:38.322623"",
					""description"": ""The seed on its back is filled with nutrients. The seed grows steadily larger as its body grows."",
					""games"": [
						{
							""name"": ""red"",
							""resource_uri"": ""/api/v1/game/4/""
						}
					],
					""id"": 4,
					""modified"": ""2014-01-18T14:29:52.996997"",
					""name"": ""Bulbasaur_gen_1"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/4/""
				},
				{
					""created"": ""2013-12-24T17:14:38.333479"",
					""description"": ""It carries a seed on its back right from birth. As it grows older, the seed also grows larger."",
					""games"": [
						{
							""name"": ""blue"",
							""resource_uri"": ""/api/v1/game/5/""
						}
					],
					""id"": 5,
					""modified"": ""2014-01-18T14:29:53.001038"",
					""name"": ""Bulbasaur_gen_1"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/5/""
				},
				{
					""created"": ""2013-12-24T17:14:38.343645"",
					""description"": ""While it is young, it uses the nutrients that are stored in the seeds on its back in order to grow."",
					""games"": [
						{
							""name"": ""yellow"",
							""resource_uri"": ""/api/v1/game/6/""
						}
					],
					""id"": 6,
					""modified"": ""2014-01-18T14:29:53.004011"",
					""name"": ""Bulbasaur_gen_1"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/6/""
				},
				{
					""created"": ""2013-12-24T17:14:38.545769"",
					""description"": ""The bulb on its back grows as it absorbs nutrients. The bulb gives off a pleasant aroma when it blooms."",
					""games"": [
						{
							""name"": ""yellow"",
							""resource_uri"": ""/api/v1/game/6/""
						}
					],
					""id"": 20,
					""modified"": ""2014-01-18T14:29:53.006737"",
					""name"": ""Ivysaur_gen_1"",
					""pokemon"": {
						""name"": ""ivysaur"",
						""resource_uri"": ""/api/v1/pokemon/2/""
					},
					""resource_uri"": ""/api/v1/description/20/""
				},
				{
					""created"": ""2013-12-24T17:14:38.354099"",
					""description"": ""BULBASAUR can be seen napping in bright sunlight. There is a seed on its back. By soaking up the suns rays, the seed grows progressively larger."",
					""games"": [
						{
							""name"": ""gold"",
							""resource_uri"": ""/api/v1/game/7/""
						},
						{
							""name"": ""silver"",
							""resource_uri"": ""/api/v1/game/8/""
						}
					],
					""id"": 7,
					""modified"": ""2014-01-18T14:29:53.009764"",
					""name"": ""Bulbasaur_gen_2"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/7/""
				},
				{
					""created"": ""2013-12-24T17:14:38.376041"",
					""description"": ""BULBASAUR can be seen napping in bright sunlight. There is a seed on its back. By soaking up the suns rays, the seed grows progressively larger."",
					""games"": [
						{
							""name"": ""crystal"",
							""resource_uri"": ""/api/v1/game/9/""
						}
					],
					""id"": 8,
					""modified"": ""2014-01-18T14:29:53.012482"",
					""name"": ""Bulbasaur_gen_2"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/8/""
				},
				{
					""created"": ""2013-12-24T17:14:38.385897"",
					""description"": ""There is a plant seed on its back right from the day this POKMON is born. The seed slowly grows larger."",
					""games"": [
						{
							""name"": ""ruby"",
							""resource_uri"": ""/api/v1/game/10/""
						}
					],
					""id"": 9,
					""modified"": ""2014-01-18T14:29:53.015161"",
					""name"": ""Bulbasaur_gen_3"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/9/""
				},
				{
					""created"": ""2013-12-24T17:14:38.398525"",
					""description"": ""A strange seed was planted on its back at birth. The plant sprouts and grows with this POKMON."",
					""games"": [
						{
							""name"": ""sapphire"",
							""resource_uri"": ""/api/v1/game/11/""
						}
					],
					""id"": 10,
					""modified"": ""2014-01-18T14:29:53.018183"",
					""name"": ""Bulbasaur_gen_3"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/10/""
				},
				{
					""created"": ""2013-12-24T17:14:38.408935"",
					""description"": ""For some time after its birth, it grows by gaining nourishment from the seed on its back."",
					""games"": [
						{
							""name"": ""fire-red"",
							""resource_uri"": ""/api/v1/game/12/""
						},
						{
							""name"": ""leaf-green"",
							""resource_uri"": ""/api/v1/game/13/""
						},
						{
							""name"": ""emerald"",
							""resource_uri"": ""/api/v1/game/14/""
						}
					],
					""id"": 11,
					""modified"": ""2014-01-18T14:29:53.020825"",
					""name"": ""Bulbasaur_gen_3"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/11/""
				},
				{
					""created"": ""2013-12-24T17:14:38.438595"",
					""description"": ""The seed on its back is filled with nutrients. The seed grows steadily larger as its body grows."",
					""games"": [
						{
							""name"": ""diamond"",
							""resource_uri"": ""/api/v1/game/15/""
						}
					],
					""id"": 12,
					""modified"": ""2014-01-18T14:29:53.023535"",
					""name"": ""Bulbasaur_gen_4"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/description/12/""
				}
			]
		}";

        internal static string Description = @"		{
			""created"": ""2013-12-24T17:14:38.398525"",
			""description"": ""A strange seed was planted on its back at birth. The plant sprouts and grows with this POKMON."",
			""games"": [
				{
					""name"": ""sapphire"",
					""resource_uri"": ""/api/v1/game/11/""
				}
			],
			""id"": 10,
			""modified"": ""2014-01-18T14:29:53.018183"",
			""name"": ""Bulbasaur_gen_3"",
			""pokemon"": {
				""name"": ""bulbasaur"",
				""resource_uri"": ""/api/v1/pokemon/1/""
			},
			""resource_uri"": ""/api/v1/description/10/""
		}";

        internal static string SpriteList = @"		{
			""meta"": {
				""limit"": 10,
				""next"": ""/api/v1/sprite/?limit=10&offset=10"",
				""offset"": 0,
				""previous"": null,
				""total_count"": 719
			},
			""objects"": [
				{
					""created"": ""2013-11-04T13:26:13.772349"",
					""id"": 1,
					""image"": ""/media/img/1383571573.78.png"",
					""modified"": ""2013-11-04T13:26:13.772310"",
					""name"": ""Bulbasaur_red_blue"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/sprite/1/""
				},
				{
					""created"": ""2013-11-16T17:20:39.964632"",
					""id"": 2,
					""image"": ""/media/img/1.png"",
					""modified"": ""2013-11-16T17:20:39.964589"",
					""name"": ""Bulbasaur_auto"",
					""pokemon"": {
						""name"": ""bulbasaur"",
						""resource_uri"": ""/api/v1/pokemon/1/""
					},
					""resource_uri"": ""/api/v1/sprite/2/""
				},
				{
					""created"": ""2013-11-16T17:20:39.971718"",
					""id"": 3,
					""image"": ""/media/img/2.png"",
					""modified"": ""2013-11-16T17:20:39.971678"",
					""name"": ""Ivysaur_auto"",
					""pokemon"": {
						""name"": ""ivysaur"",
						""resource_uri"": ""/api/v1/pokemon/2/""
					},
					""resource_uri"": ""/api/v1/sprite/3/""
				},
				{
					""created"": ""2013-11-16T17:20:39.975433"",
					""id"": 4,
					""image"": ""/media/img/3.png"",
					""modified"": ""2013-11-16T17:20:39.975388"",
					""name"": ""Venusaur_auto"",
					""pokemon"": {
						""name"": ""venusaur"",
						""resource_uri"": ""/api/v1/pokemon/3/""
					},
					""resource_uri"": ""/api/v1/sprite/4/""
				},
				{
					""created"": ""2013-11-16T17:20:39.979374"",
					""id"": 5,
					""image"": ""/media/img/4.png"",
					""modified"": ""2013-11-16T17:20:39.979346"",
					""name"": ""Charmander_auto"",
					""pokemon"": {
						""name"": ""charmander"",
						""resource_uri"": ""/api/v1/pokemon/4/""
					},
					""resource_uri"": ""/api/v1/sprite/5/""
				},
				{
					""created"": ""2013-11-16T17:20:39.983030"",
					""id"": 6,
					""image"": ""/media/img/5.png"",
					""modified"": ""2013-11-16T17:20:39.983002"",
					""name"": ""Charmeleon_auto"",
					""pokemon"": {
						""name"": ""charmeleon"",
						""resource_uri"": ""/api/v1/pokemon/5/""
					},
					""resource_uri"": ""/api/v1/sprite/6/""
				},
				{
					""created"": ""2013-11-16T17:20:39.987235"",
					""id"": 7,
					""image"": ""/media/img/6.png"",
					""modified"": ""2013-11-16T17:20:39.987207"",
					""name"": ""Charizard_auto"",
					""pokemon"": {
						""name"": ""charizard"",
						""resource_uri"": ""/api/v1/pokemon/6/""
					},
					""resource_uri"": ""/api/v1/sprite/7/""
				},
				{
					""created"": ""2013-11-16T17:20:39.991007"",
					""id"": 8,
					""image"": ""/media/img/7.png"",
					""modified"": ""2013-11-16T17:20:39.990978"",
					""name"": ""Squirtle_auto"",
					""pokemon"": {
						""name"": ""squirtle"",
						""resource_uri"": ""/api/v1/pokemon/7/""
					},
					""resource_uri"": ""/api/v1/sprite/8/""
				},
				{
					""created"": ""2013-11-16T17:20:39.994499"",
					""id"": 9,
					""image"": ""/media/img/8.png"",
					""modified"": ""2013-11-16T17:20:39.994470"",
					""name"": ""Wartortle_auto"",
					""pokemon"": {
						""name"": ""wartortle"",
						""resource_uri"": ""/api/v1/pokemon/8/""
					},
					""resource_uri"": ""/api/v1/sprite/9/""
				},
				{
					""created"": ""2013-11-16T17:20:39.998065"",
					""id"": 10,
					""image"": ""/media/img/9.png"",
					""modified"": ""2013-11-16T17:20:39.998036"",
					""name"": ""Blastoise_auto"",
					""pokemon"": {
						""name"": ""blastoise"",
						""resource_uri"": ""/api/v1/pokemon/9/""
					},
					""resource_uri"": ""/api/v1/sprite/10/""
				}
			]
		}";

        internal static string Sprite = @"		{
			""created"": ""2013-11-16T17:20:39.998065"",
			""id"": 10,
			""image"": ""/media/img/9.png"",
			""modified"": ""2013-11-16T17:20:39.998036"",
			""name"": ""Blastoise_auto"",
			""pokemon"": {
				""name"": ""blastoise"",
				""resource_uri"": ""/api/v1/pokemon/9/""
			},
			""resource_uri"": ""/api/v1/sprite/10/""
		}";
        
    }
}
