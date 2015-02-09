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
            List<dynamic> result = new List<dynamic>();

            using (var context = new PokedexDataContext())
            {
                var data = (from p in context.Pokemons
                               orderby p.PkApiId
                               select new { Pokemon = p, Sprite = p.PokemonSprites.Select(ps => ps.Sprite).FirstOrDefault() })
                               .Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize).ToList();

                result = (from pokemonObj in (from d in data
                                           select new
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
                          select pokemonObj as dynamic
                          ).ToList();
            }

            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }

        public HttpResponseMessage GetPokemon(int pokemonId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetPokemon");
        }

        public HttpResponseMessage GetSpritesByPokemon(int pokemonId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetSpritesByPokemon");
        }

        public HttpResponseMessage GetSprite(int spriteId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetSprite");
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
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetAbilitiesByPokemon");
        }

        public HttpResponseMessage GetAbility(int abilityId)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, "GetAbility");
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