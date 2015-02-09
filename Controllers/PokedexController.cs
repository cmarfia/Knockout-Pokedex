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
                         orderby p.PkApiId
                         select new { Pokemon = p, Sprite = p.PokemonSprites.Select(ps => ps.Sprite).FirstOrDefault() });

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
                                                            sprite = d.Sprite != null ? d.Sprite.Image : string.Empty
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
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetPokemon");
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
                         select s).ToList();

                    results = (from sprite in sprites select new { spriteId = sprite.SpriteId, image = sprite.Image });
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
                              select new { spriteId = sprite.SpriteId, image = sprite.Image }).FirstOrDefault();
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
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetDescriptionsByPokemon");
        }

        public HttpResponseMessage GetDescription(int descriptionId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetDescription");
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
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetMovesByPokemon");
        }

        public HttpResponseMessage GetMove(int moveId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetMove");
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
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetEvolutionChainByPokemon");
        }

        public HttpResponseMessage GetNavigationByPokemon(int pokemonId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetNavigationByPokemon");
        }
    }
}