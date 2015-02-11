using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PokedexApi.Models;

namespace PokedexApi.Controllers
{
    public class PokedexController : ApiController
    {
        public HttpResponseMessage GetPokedex(int pageNumber, int pageSize)
        {
            try
            {
                object result = null;

                using (var context = new PokedexDataContext())
                {
                    var preFilteredData =
                        (from p in context.Pokemons
                         let s = p.PokemonSprites.Select(ps => ps.Sprite).FirstOrDefault()
                         where s != null
                         orderby p.PkApiId
                         select new { Pokemon = p, Sprite = s });

                    var totalRecords = preFilteredData.Count();
                    var data = preFilteredData.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();


                    result = new
                                 {
                                     totalRecords = totalRecords,
                                     pokemon = (from d in data
                                                select
                                                    new
                                                        {
                                                            pokemonId = d.Pokemon.PokemonId,
                                                            pkId = d.Pokemon.PkApiId,
                                                            name = d.Pokemon.Name,
                                                            height = d.Pokemon.Height,
                                                            weight = d.Pokemon.Weight,
                                                            hp = d.Pokemon.Hp,
                                                            attack = d.Pokemon.Attack,
                                                            defense = d.Pokemon.Defense,
                                                            spAttack = d.Pokemon.SpAttack,
                                                            spDefense = d.Pokemon.SpDefense,
                                                            speed = d.Pokemon.Speed,
                                                            image = d.Sprite != null ? d.Sprite.Image : string.Empty
                                                        })
                                 };
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetPokemon(int pokemonId)
        {
            try
            {
                object result = null;

                using (var context = new PokedexDataContext())
                {
                    var MaxHP = (from p in context.Pokemons
                                 orderby p.Hp descending
                                 select p.Hp).FirstOrDefault();

                    var MaxAttack = (from p in context.Pokemons
                                 orderby p.Attack descending
                                     select p.Attack).FirstOrDefault();

                    var MaxDefense = (from p in context.Pokemons
                                 orderby p.Defense descending
                                 select p.Defense).FirstOrDefault();

                    var MaxSPAttack = (from p in context.Pokemons
                                 orderby p.SpAttack descending
                                 select p.SpAttack).FirstOrDefault();

                    var MaxSPDefense = (from p in context.Pokemons
                                        orderby p.SpDefense descending
                                        select p.SpDefense).FirstOrDefault();

                    var MaxSpeed = (from p in context.Pokemons
                                        orderby p.Speed descending
                                        select p.Speed).FirstOrDefault();
                    

                    result = (from pokemon in context.Pokemons
                              where pokemon.PokemonId == pokemonId
                              select new
                              {
                                  pokemonId = pokemon.PokemonId,
                                  pkId = pokemon.PkApiId,
                                  name = pokemon.Name,
                                  hp = pokemon.Hp,
                                  maxHp = MaxHP,
                                  attack = pokemon.Attack,
                                  maxAttack = MaxAttack,
                                  defense = pokemon.Defense,
                                  maxDefense = MaxDefense,
                                  spAttack = pokemon.SpAttack,
                                  maxSpAttack = MaxSPAttack,
                                  spDefense = pokemon.SpDefense,
                                  maxSpDefense = MaxSPDefense,
                                  speed = pokemon.Speed,
                                  maxSpeed = MaxSpeed,
                                  height = pokemon.Height,
                                  weight = pokemon.Weight,
                                  species = pokemon.Species,
                                  catchRate = pokemon.CatchRate,
                                  maleToFemale = pokemon.MaleToFemale
                              }).FirstOrDefault();
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetSpritesByPokemon(int pokemonId)
        {
            try
            {
                object results = null;

                using (var context = new PokedexDataContext())
                {
                    var sprites =
                        (from s in context.Sprites
                         join ps in context.PokemonSprites on s.SpriteId equals ps.SpriteId
                         where ps.PokemonId == pokemonId
                         select s).Take(1).ToList();

                    results = (from sprite in sprites
                               select new
                               {
                                   spriteId = sprite.SpriteId,
                                   image = sprite.Image
                               });
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, results);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetSprite(int spriteId)
        {
            try
            {
                object result = null;

                using (var context = new PokedexDataContext())
                {
                    result = (from sprite in context.Sprites
                              where sprite.SpriteId == spriteId
                              select new 
                              { 
                                  spriteId = sprite.SpriteId, 
                                  image = sprite.Image 
                              }).FirstOrDefault();
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetDescriptionsByPokemon(int pokemonId)
        {
            try
            {
                object results = null;

                using (var context = new PokedexDataContext())
                {
                    var descriptions = (from d in context.Descriptions
                                        join pd in context.PokemonDescriptions on d.DescriptionId equals pd.DescriptionId
                                        where pd.PokemonId == pokemonId
                                        select new
                                        {
                                            descriptionId = d.DescriptionId,
                                            description = d.Description1,
                                            games = d.DescriptionGames.Select(dg => new { 
                                                gameId = dg.Game.GameId,
                                                name = dg.Game.Name,
                                                generation = dg.Game.Generation,
                                                releaseYear = dg.Game.ReleaseYear
                                            })
                                        }).ToList();

                    results = descriptions;
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, results);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetDescription(int descriptionId)
        {
            try
            {
                object result = null;

                using (var context = new PokedexDataContext())
                {
                    result = (from description in context.Descriptions
                              where description.DescriptionId == descriptionId
                              select new
                              {
                                  descriptionId = description.DescriptionId,
                                  description = description.Description1,
                                  games = description.DescriptionGames.Select(dg => new
                                  {
                                      gameId = dg.Game.GameId,
                                      name = dg.Game.Name,
                                      generation = dg.Game.Generation,
                                      releaseYear = dg.Game.ReleaseYear
                                  })
                              }).FirstOrDefault();
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetTypesByPokemon(int pokemonId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetTypesByPokemon");
        }

        public HttpResponseMessage GetType(int typeId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetType");
        }

        public HttpResponseMessage GetMovesByPokemon(int pokemonId)
        {
            try
            {
                object results = null;

                using (var context = new PokedexDataContext())
                {
                    var moves = (from m in context.Moves
                                 join pm in context.PokemonMoves on m.MoveId equals pm.MoveId
                                 where pm.PokemonId == pokemonId
                                 select new
                                 {
                                     moveId = m.MoveId,
                                     name = m.Name,
                                     description = m.Description,
                                     category = m.Category,
                                     power = m.Power,
                                     pp = m.PP,
                                     accuracy = m.Accuracy,
                                     learnType = pm.LearnType,
                                     level = pm.PokemonLevel
                                 }).ToList();

                    results = moves;
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, results);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetMove(int moveId)
        {
            try
            {
                object result = null;

                using (var context = new PokedexDataContext())
                {
                    result = (from move in context.Moves
                              join pm in context.PokemonMoves on move.MoveId equals pm.MoveId
                              where move.MoveId == moveId
                               select new
                               {
                                   moveId = move.MoveId,
                                   name = move.Name,
                                   description = move.Description,
                                   category = move.Category,
                                   power = move.Power,
                                   pp = move.PP,
                                   accuracy = move.Accuracy,
                                   learnType = pm.LearnType,
                                   level = pm.PokemonLevel
                               }).FirstOrDefault();
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetAbilitiesByPokemon(int pokemonId)
        {
            try
            {
                object results = null;

                using (var context = new PokedexDataContext())
                {
                    var abilities = (from a in context.Abilities
                                     join pa in context.PokemonAbilities on a.AbilityId equals pa.AbilityId
                                     where pa.PokemonId == pokemonId
                                     select a).ToList();

                    results = (from ability in abilities
                               select new
                                {
                                    abilityId = ability.AbilityId,
                                    name = ability.Name,
                                    description = ability.Description
                                });
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, results);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetAbility(int abilityId)
        {
            try
            {
                object result = null;

                using (var context = new PokedexDataContext())
                {
                    result = (from ability in context.Abilities
                              where ability.AbilityId == abilityId
                              select new
                              {
                                  abilityId = ability.AbilityId,
                                  name = ability.Name,
                                  description = ability.Description
                              }).FirstOrDefault();
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage GetEvolutionChainByPokemon(int pokemonId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetTypesByPokemon");
        }

        public HttpResponseMessage GetNavigationByPokemon(int pokemonId)
        {
            try
            {
                object result = null;

                using (var context = new PokedexDataContext())
                {
                    var current = (from pokemon in context.Pokemons
                                   where pokemon.PokemonId == pokemonId
                                   select pokemon).FirstOrDefault();

                    if (current != null)
                    {
                        var previous = (from pokemon in context.Pokemons
                                        where pokemon.PkApiId == (current.PkApiId - 1)
                                        let sprite = pokemon.PokemonSprites.Select(ps => ps.Sprite).FirstOrDefault()
                                        select new
                                        {
                                            pokemonId = pokemon.PokemonId,
                                            pkId = pokemon.PkApiId,
                                            name = pokemon.Name,
                                            image = sprite != null ? sprite.Image : string.Empty
                                        }).FirstOrDefault();

                        var next = (from pokemon in context.Pokemons
                                    where pokemon.PkApiId == (current.PkApiId + 1)
                                    let sprite = pokemon.PokemonSprites.Select(ps => ps.Sprite).FirstOrDefault()
                                    select new
                                    {
                                        pokemonId = pokemon.PokemonId,
                                        pkId = pokemon.PkApiId,
                                        name = pokemon.Name,
                                        image = sprite != null ? sprite.Image : string.Empty
                                    }).FirstOrDefault();

                        result = new
                        {
                            previous = previous,
                            next = next
                        };
                    }
                }

                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}