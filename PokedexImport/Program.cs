using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using LitJson;

namespace PokedexImport
{
    class Program
    {
        private static readonly string BaseApiUri = "http://pokeapi.co";
        private static readonly string PokedexApiUri = "/api/v1/pokedex/1/";
        private static readonly string TypesApiUri = "/api/v1/type/";
        private static readonly string MovesApiUri = "/api/v1/move/";
        private static readonly string AbilitiesApiUri = "/api/v1/ability/";
        private static readonly string DescroptionsApiUri = "/api/v1/description/";
        private static readonly string SpritesApiUri = "/api/v1/sprite/";
        private static readonly string GamesApiUri = "/api/v1/game/";
        private static readonly int BaseLimit = 10;

        internal static WebClient client = new WebClient();

        /// <summary>
        /// Item1 -> Pokemon 
        /// Item2 -> Evolutions JsonData
        /// </summary>
        private static List<Tuple<Pokemon, JsonData>> Pokedex = new List<Tuple<Pokemon, JsonData>>();

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Start - Populate Games");
                PopulateGames();
                Console.WriteLine("End - Populate Games\r\n");

                Console.WriteLine("Start - Populate Descriptions");
                PopulateDescriptions();
                Console.WriteLine("End - Populate Descriptions\r\n");

                Console.WriteLine("Start - Populate Abilities");
                PopulateAbilities();
                Console.WriteLine("End - Populate Abilities\r\n");

                Console.WriteLine("Start - Populate Moves");
                PopulateMoves();
                Console.WriteLine("End - Populate Moves\r\n");

                Console.WriteLine("Start - Populate Sprites");
                PopulateSprites();
                Console.WriteLine("End - Populate Sprites\r\n");

                Console.WriteLine("Start - Populate Types");
                PopulateTypes();
                Console.WriteLine("End - Populate Types\r\n");

                Console.WriteLine("Start - Populate Pokedex");
                PopulatePokedex();
                Console.WriteLine("End - Populate Pokedex\r\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void PopulateMoves()
        {
#if !DEBUG
            JsonData moveList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}?limit={2}", BaseApiUri, MovesApiUri, BaseLimit)));
#endif

#if DEBUG
            JsonData moveList = JsonMapper.ToObject(DumyJson.MoveList);
#endif

            JsonData meta = null;
            JsonData objects = null;
            string nextUri = null;

            moveList.TryGetValue("meta", out meta);
            moveList.TryGetValue("objects", out objects);

            using (var context = new PokedexDataContext())
            {
                while (meta != null && objects != null)
                {
                    if (objects.IsArray)
                    {
                        foreach (JsonData moveObj in objects)
                        {
                            var pkId = -1;

                            if (moveObj.Contains("id"))
                            {
                                pkId = moveObj["id"] != null && moveObj["id"].IsInt ? (int)moveObj["id"] : -1;
                            }

                            if (!context.Moves.Any(g => g.PkApiId == pkId))
                            {
                                var game = new Move();

                                game.PkApiId = pkId;

                                if (moveObj.Contains("name"))
                                {
                                    game.Name = moveObj["name"] != null && moveObj["name"].IsString ? moveObj["name"].ToString() : string.Empty;
                                }

                                if (moveObj.Contains("description"))
                                {
                                    game.Description = moveObj["description"] != null && moveObj["description"].IsString ? moveObj["description"].ToString() : string.Empty;
                                }

                                if (moveObj.Contains("category"))
                                {
                                    game.Category = moveObj["category"] != null && moveObj["category"].IsString ? moveObj["category"].ToString() : string.Empty;
                                }

                                if (moveObj.Contains("power"))
                                {
                                    game.Power = moveObj["power"] != null && moveObj["power"].IsInt ? (int)moveObj["power"] : -1;
                                }

                                if (moveObj.Contains("pp"))
                                {
                                    game.PP = moveObj["pp"] != null && moveObj["pp"].IsInt ? (int)moveObj["pp"] : -1;
                                }

                                if (moveObj.Contains("accuracy"))
                                {
                                    game.Accuracy = moveObj["accuracy"] != null && moveObj["accuracy"].IsInt ? (int)moveObj["accuracy"] : -1;
                                }

                                if (moveObj.Contains("modified"))
                                {
                                    game.ModifiedDate = moveObj["modified"] != null && moveObj["modified"].IsString ? DateTime.Parse(moveObj["modified"].ToString()) : new DateTime();
                                }

                                if (moveObj.Contains("resource_uri"))
                                {
                                    game.ResourceUri = moveObj["resource_uri"] != null && moveObj["resource_uri"].IsString ? moveObj["resource_uri"].ToString() : string.Empty;
                                }

                                context.Moves.InsertOnSubmit(game);
                            }
                        }
                    }

#if DEBUG
                    nextUri = null;
#endif
#if !DEBUG
                    nextUri = meta["next"] != null && meta["next"].IsString ? meta["next"].ToString() : null;
#endif

                    if (nextUri != null)
                    {
#if !DEBUG
                        moveList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}", BaseApiUri, nextUri)));
                        moveList.TryGetValue("meta", out meta);
                        moveList.TryGetValue("objects", out objects);
#endif
                    }
                    else
                    {
                        meta = null;
                        objects = null;
                    }
                }

                context.SubmitChanges();
            }
        }

        private static void PopulateTypes()
        {
#if !DEBUG
            JsonData typeList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}?limit={2}", BaseApiUri, TypesApiUri, BaseLimit)));
#endif

#if DEBUG
            JsonData typeList = JsonMapper.ToObject(DumyJson.TypeList);
#endif

            JsonData meta = null;
            JsonData objects = null;
            string nextUri = null;
            List<Tuple<Type, JsonData>> ineffectiveTypes = new List<Tuple<Type, JsonData>>();
            List<Tuple<Type, JsonData>> noEffectTypes = new List<Tuple<Type, JsonData>>();
            List<Tuple<Type, JsonData>> resistanceTypes = new List<Tuple<Type, JsonData>>();
            List<Tuple<Type, JsonData>> superEffectiveTypes = new List<Tuple<Type, JsonData>>();
            List<Tuple<Type, JsonData>> weaknessTypes = new List<Tuple<Type, JsonData>>();

            typeList.TryGetValue("meta", out meta);
            typeList.TryGetValue("objects", out objects);

            using (var context = new PokedexDataContext())
            {
                while (meta != null && objects != null)
                {
                    if (objects.IsArray)
                    {
                        foreach (JsonData typeObj in objects)
                        {
                            var pkId = -1;

                            if (typeObj.Contains("id"))
                            {
                                pkId = typeObj["id"] != null && typeObj["id"].IsInt ? (int)typeObj["id"] : -1;
                            }

                            if (!context.Types.Any(g => g.PkApiId == pkId))
                            {
                                var type = new Type();

                                type.PkApiId = pkId;

                                if (typeObj.Contains("name"))
                                {
                                    type.Name = typeObj["name"] != null && typeObj["name"].IsString ? typeObj["name"].ToString() : string.Empty;
                                }

                                if (typeObj.Contains("modified"))
                                {
                                    type.ModifiedDate = typeObj["modified"] != null && typeObj["modified"].IsString ? DateTime.Parse(typeObj["modified"].ToString()) : new DateTime();
                                }

                                if (typeObj.Contains("resource_uri"))
                                {
                                    type.ResourceUri = typeObj["resource_uri"] != null && typeObj["resource_uri"].IsString ? typeObj["resource_uri"].ToString() : string.Empty;
                                }

                                context.Types.InsertOnSubmit(type);

                                if (typeObj.Contains("ineffective"))
                                {
                                    JsonData ineffective = typeObj["ineffective"] != null && typeObj["ineffective"].IsArray ? typeObj["ineffective"] : null;

                                    if (ineffective != null)
                                    {
                                        ineffectiveTypes.Add(Tuple.Create(type, ineffective));
                                    }
                                }

                                if (typeObj.Contains("no_effect"))
                                {
                                    JsonData noEffect = typeObj["no_effect"] != null && typeObj["no_effect"].IsArray ? typeObj["no_effect"] : null;

                                    if (noEffect != null)
                                    {
                                        noEffectTypes.Add(Tuple.Create(type, noEffect));
                                    }
                                }

                                if (typeObj.Contains("resistance"))
                                {
                                    JsonData resistance = typeObj["resistance"] != null && typeObj["resistance"].IsArray ? typeObj["resistance"] : null;

                                    if (resistance != null)
                                    {
                                        resistanceTypes.Add(Tuple.Create(type, resistance));
                                    }
                                }

                                if (typeObj.Contains("super_effective"))
                                {
                                    JsonData superEffective = typeObj["super_effective"] != null && typeObj["super_effective"].IsArray ? typeObj["super_effective"] : null;

                                    if (superEffective != null)
                                    {
                                        superEffectiveTypes.Add(Tuple.Create(type, superEffective));
                                    }
                                }

                                if (typeObj.Contains("weakness"))
                                {
                                    JsonData weakness = typeObj["weakness"] != null && typeObj["weakness"].IsArray ? typeObj["weakness"] : null;

                                    if (weakness != null)
                                    {
                                        weaknessTypes.Add(Tuple.Create(type, weakness));
                                    }
                                }                                
                            }
                            else
                            {
                                var type = context.Types.First(d => d.PkApiId == pkId);

                                if (typeObj.Contains("ineffective"))
                                {
                                    JsonData ineffective = typeObj["ineffective"] != null && typeObj["ineffective"].IsArray ? typeObj["ineffective"] : null;

                                    if (ineffective != null)
                                    {
                                        ineffectiveTypes.Add(Tuple.Create(type, ineffective));
                                    }
                                }

                                if (typeObj.Contains("no_effect"))
                                {
                                    JsonData noEffect = typeObj["no_effect"] != null && typeObj["no_effect"].IsArray ? typeObj["no_effect"] : null;

                                    if (noEffect != null)
                                    {
                                        noEffectTypes.Add(Tuple.Create(type, noEffect));
                                    }
                                }

                                if (typeObj.Contains("resistance"))
                                {
                                    JsonData resistance = typeObj["resistance"] != null && typeObj["resistance"].IsArray ? typeObj["resistance"] : null;

                                    if (resistance != null)
                                    {
                                        resistanceTypes.Add(Tuple.Create(type, resistance));
                                    }
                                }

                                if (typeObj.Contains("super_effective"))
                                {
                                    JsonData superEffective = typeObj["super_effective"] != null && typeObj["super_effective"].IsArray ? typeObj["super_effective"] : null;

                                    if (superEffective != null)
                                    {
                                        superEffectiveTypes.Add(Tuple.Create(type, superEffective));
                                    }
                                }

                                if (typeObj.Contains("weakness"))
                                {
                                    JsonData weakness = typeObj["weakness"] != null && typeObj["weakness"].IsArray ? typeObj["weakness"] : null;

                                    if (weakness != null)
                                    {
                                        weaknessTypes.Add(Tuple.Create(type, weakness));
                                    }
                                }       
                            }
                        }
                    }

#if DEBUG
                    nextUri = null;
#endif
#if !DEBUG
                    nextUri = meta["next"] != null && meta["next"].IsString ? meta["next"].ToString() : null;
#endif

                    if (nextUri != null)
                    {
#if !DEBUG
                        typeList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}", BaseApiUri, nextUri)));
                        typeList.TryGetValue("meta", out meta);
                        typeList.TryGetValue("objects", out objects);
#endif
                    }
                    else
                    {
                        meta = null;
                        objects = null;
                    }
                }

                context.SubmitChanges();

                #region Ineffective Types

                Console.WriteLine("\r\n...Start - Populating Ineffective Types");

                foreach (var ineffective in ineffectiveTypes)
                {
                    var typeId = ineffective.Item1.TypeId;
                    var typeEffectId = context.TypeEffects.First(tE => tE.Name == "ineffective").TypeEffectId;

                    foreach (JsonData typeObj in ineffective.Item2)
                    {
                        var typeName = "";
                        var typeResourceUri = "";

                        if (typeObj.Contains("name"))
                        {
                            typeName = typeObj["name"] != null && typeObj["name"].IsString ? typeObj["name"].ToString() : string.Empty;
                        }

                        if (typeObj.Contains("resource_uri"))
                        {
                            typeResourceUri = typeObj["resource_uri"] != null && typeObj["resource_uri"].IsString ? typeObj["resource_uri"].ToString() : string.Empty;
                        }

                        if (string.IsNullOrEmpty(typeName) && string.IsNullOrEmpty(typeResourceUri))
                        {
                            continue;
                        }

                        var type = context.Types.FirstOrDefault(t => t.Name == typeName && t.ResourceUri == typeResourceUri);

                        if (type == null || context.TypeToTypeEffects.Any(ttt => ttt.TypeId == typeId && ttt.AgainstTypeId == type.TypeId && ttt.TypeEffectId == typeEffectId))
                        {
                            continue;
                        }

                        var typeToTypeEffect = new TypeToTypeEffect
                        {
                            TypeId = typeId,
                            AgainstTypeId = type.TypeId,
                            TypeEffectId = typeEffectId
                        };

                        context.TypeToTypeEffects.InsertOnSubmit(typeToTypeEffect);
                    }
                }

                context.SubmitChanges();

                Console.WriteLine("...End - Populating Ineffective Types\r\n");

                #endregion

                #region No Effect Types

                Console.WriteLine("\r\n...Start - Populating No Effect Types");

                foreach (var noeffect in noEffectTypes)
                {
                    var typeId = noeffect.Item1.TypeId;
                    var typeEffectId = context.TypeEffects.First(tE => tE.Name == "no_effect").TypeEffectId;

                    foreach (JsonData typeObj in noeffect.Item2)
                    {
                        var typeName = "";
                        var typeResourceUri = "";

                        if (typeObj.Contains("name"))
                        {
                            typeName = typeObj["name"] != null && typeObj["name"].IsString ? typeObj["name"].ToString() : string.Empty;
                        }

                        if (typeObj.Contains("resource_uri"))
                        {
                            typeResourceUri = typeObj["resource_uri"] != null && typeObj["resource_uri"].IsString ? typeObj["resource_uri"].ToString() : string.Empty;
                        }

                        if (string.IsNullOrEmpty(typeName) && string.IsNullOrEmpty(typeResourceUri))
                        {
                            continue;
                        }

                        var type = context.Types.FirstOrDefault(t => t.Name == typeName && t.ResourceUri == typeResourceUri);

                        if (type == null || context.TypeToTypeEffects.Any(ttt => ttt.TypeId == typeId && ttt.AgainstTypeId == type.TypeId && ttt.TypeEffectId == typeEffectId))
                        {
                            continue;
                        }

                        var typeToTypeEffect = new TypeToTypeEffect
                        {
                            TypeId = typeId,
                            AgainstTypeId = type.TypeId,
                            TypeEffectId = typeEffectId
                        };

                        context.TypeToTypeEffects.InsertOnSubmit(typeToTypeEffect);
                    }
                }

                context.SubmitChanges();

                Console.WriteLine("...End - Populating No Effect Types\r\n");

                #endregion

                #region Resistance Types

                Console.WriteLine("\r\n...Start - Populating Resistance Types");

                foreach (var resistance in resistanceTypes)
                {
                    var typeId = resistance.Item1.TypeId;
                    var typeEffectId = context.TypeEffects.First(tE => tE.Name == "resistance").TypeEffectId;

                    foreach (JsonData typeObj in resistance.Item2)
                    {
                        var typeName = "";
                        var typeResourceUri = "";

                        if (typeObj.Contains("name"))
                        {
                            typeName = typeObj["name"] != null && typeObj["name"].IsString ? typeObj["name"].ToString() : string.Empty;
                        }

                        if (typeObj.Contains("resource_uri"))
                        {
                            typeResourceUri = typeObj["resource_uri"] != null && typeObj["resource_uri"].IsString ? typeObj["resource_uri"].ToString() : string.Empty;
                        }

                        if (string.IsNullOrEmpty(typeName) && string.IsNullOrEmpty(typeResourceUri))
                        {
                            continue;
                        }

                        var type = context.Types.FirstOrDefault(t => t.Name == typeName && t.ResourceUri == typeResourceUri);

                        if (type == null || context.TypeToTypeEffects.Any(ttt => ttt.TypeId == typeId && ttt.AgainstTypeId == type.TypeId && ttt.TypeEffectId == typeEffectId))
                        {
                            continue;
                        }

                        var typeToTypeEffect = new TypeToTypeEffect
                        {
                            TypeId = typeId,
                            AgainstTypeId = type.TypeId,
                            TypeEffectId = typeEffectId
                        };

                        context.TypeToTypeEffects.InsertOnSubmit(typeToTypeEffect);
                    }
                }

                context.SubmitChanges();

                Console.WriteLine("...End - Populating Resistance Types\r\n");

                #endregion

                #region Super Effective Types

                Console.WriteLine("\r\n...Start - Populating Super Effective Types");

                foreach (var superEffective in superEffectiveTypes)
                {
                    var typeId = superEffective.Item1.TypeId;
                    var typeEffectId = context.TypeEffects.First(tE => tE.Name == "super_effective").TypeEffectId;

                    foreach (JsonData typeObj in superEffective.Item2)
                    {
                        var typeName = "";
                        var typeResourceUri = "";

                        if (typeObj.Contains("name"))
                        {
                            typeName = typeObj["name"] != null && typeObj["name"].IsString ? typeObj["name"].ToString() : string.Empty;
                        }

                        if (typeObj.Contains("resource_uri"))
                        {
                            typeResourceUri = typeObj["resource_uri"] != null && typeObj["resource_uri"].IsString ? typeObj["resource_uri"].ToString() : string.Empty;
                        }

                        if (string.IsNullOrEmpty(typeName) && string.IsNullOrEmpty(typeResourceUri))
                        {
                            continue;
                        }

                        var type = context.Types.FirstOrDefault(t => t.Name == typeName && t.ResourceUri == typeResourceUri);

                        if (type == null || context.TypeToTypeEffects.Any(ttt => ttt.TypeId == typeId && ttt.AgainstTypeId == type.TypeId && ttt.TypeEffectId == typeEffectId))
                        {
                            continue;
                        }

                        var typeToTypeEffect = new TypeToTypeEffect
                        {
                            TypeId = typeId,
                            AgainstTypeId = type.TypeId,
                            TypeEffectId = typeEffectId
                        };

                        context.TypeToTypeEffects.InsertOnSubmit(typeToTypeEffect);
                    }
                }

                context.SubmitChanges();

                Console.WriteLine("...End - Populating Super Effective Types\r\n");

                #endregion

                #region Weakness Types

                Console.WriteLine("\r\n...Start - Populating Weakness Types");

                foreach (var weakness in weaknessTypes)
                {
                    var typeId = weakness.Item1.TypeId;
                    var typeEffectId = context.TypeEffects.First(tE => tE.Name == "weakness").TypeEffectId;

                    foreach (JsonData typeObj in weakness.Item2)
                    {
                        var typeName = "";
                        var typeResourceUri = "";

                        if (typeObj.Contains("name"))
                        {
                            typeName = typeObj["name"] != null && typeObj["name"].IsString ? typeObj["name"].ToString() : string.Empty;
                        }

                        if (typeObj.Contains("resource_uri"))
                        {
                            typeResourceUri = typeObj["resource_uri"] != null && typeObj["resource_uri"].IsString ? typeObj["resource_uri"].ToString() : string.Empty;
                        }

                        if (string.IsNullOrEmpty(typeName) && string.IsNullOrEmpty(typeResourceUri))
                        {
                            continue;
                        }

                        var type = context.Types.FirstOrDefault(t => t.Name == typeName && t.ResourceUri == typeResourceUri);

                        if (type == null || context.TypeToTypeEffects.Any(ttt => ttt.TypeId == typeId && ttt.AgainstTypeId == type.TypeId && ttt.TypeEffectId == typeEffectId))
                        {
                            continue;
                        }

                        var typeToTypeEffect = new TypeToTypeEffect
                        {
                            TypeId = typeId,
                            AgainstTypeId = type.TypeId,
                            TypeEffectId = typeEffectId
                        };

                        context.TypeToTypeEffects.InsertOnSubmit(typeToTypeEffect);
                    }
                }

                context.SubmitChanges();

                Console.WriteLine("...End - Populating Weakness Types\r\n");

                #endregion
            }
        }

        private static void PopulateSprites()
        {
#if !DEBUG
            JsonData spriteList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}?limit={2}", BaseApiUri, SpritesApiUri, BaseLimit)));
#endif

#if DEBUG
            JsonData spriteList = JsonMapper.ToObject(DumyJson.SpriteList);
#endif

            JsonData meta = null;
            JsonData objects = null;
            string nextUri = null;

            spriteList.TryGetValue("meta", out meta);
            spriteList.TryGetValue("objects", out objects);

            using (var context = new PokedexDataContext())
            {
                while (meta != null && objects != null)
                {
                    if (objects.IsArray)
                    {
                        foreach (JsonData spriteObj in objects)
                        {
                            var pkId = -1;

                            if (spriteObj.Contains("id"))
                            {
                                pkId = spriteObj["id"] != null && spriteObj["id"].IsInt ? (int)spriteObj["id"] : -1;
                            }

                            if (!context.Sprites.Any(g => g.PkApiId == pkId))
                            {
                                var sprite = new Sprite();

                                sprite.PkApiId = pkId;

                                if (spriteObj.Contains("image"))
                                {
                                    var imageUrl = spriteObj["image"] != null && spriteObj["image"].IsString ? spriteObj["image"].ToString() : string.Empty;

                                    sprite.Image = ConvertImageURLToBase64(string.Format("{0}{1}", BaseApiUri, imageUrl));
                                }

                                if (spriteObj.Contains("modified"))
                                {
                                    sprite.ModifiedDate = spriteObj["modified"] != null && spriteObj["modified"].IsString ? DateTime.Parse(spriteObj["modified"].ToString()) : new DateTime();
                                }

                                if (spriteObj.Contains("resource_uri"))
                                {
                                    sprite.ResourceUri = spriteObj["resource_uri"] != null && spriteObj["resource_uri"].IsString ? spriteObj["resource_uri"].ToString() : string.Empty;
                                }

                                context.Sprites.InsertOnSubmit(sprite);
                            }
                        }
                    }

#if DEBUG
                    nextUri = null;
#endif
#if !DEBUG
                    nextUri = meta["next"] != null && meta["next"].IsString ? meta["next"].ToString() : null;
#endif

                    if (nextUri != null)
                    {
#if !DEBUG
                        spriteList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}", BaseApiUri, nextUri)));
                        spriteList.TryGetValue("meta", out meta);
                        spriteList.TryGetValue("objects", out objects);
#endif
                    }
                    else
                    {
                        meta = null;
                        objects = null;
                    }
                }

                context.SubmitChanges();
            }
        }

        private static void PopulateGames()
        {
#if !DEBUG
            JsonData gameList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}?limit={2}", BaseApiUri, GamesApiUri, BaseLimit)));
#endif

#if DEBUG
            JsonData gameList = JsonMapper.ToObject(DumyJson.GameList);
#endif
            
            JsonData meta = null;
            JsonData objects = null;
            string nextUri = null;

            gameList.TryGetValue("meta", out meta);
            gameList.TryGetValue("objects", out objects);

            using (var context = new PokedexDataContext())
            {
                while (meta != null && objects != null)
                {
                    if (objects.IsArray)
                    {
                        foreach (JsonData gameObj in objects)
                        {
                            var pkId = -1;
                            
                            if (gameObj.Contains("id"))
                            {
                                pkId = gameObj["id"] != null && gameObj["id"].IsInt ? (int)gameObj["id"] : -1;
                            }

                            if (!context.Games.Any(g => g.PkApiId == pkId))
                            {
                                var game = new Game();

                                game.PkApiId = pkId;

                                if (gameObj.Contains("name"))
                                {
                                    game.Name = gameObj["name"] != null && gameObj["name"].IsString ? gameObj["name"].ToString() : string.Empty;
                                }

                                if (gameObj.Contains("generation"))
                                {
                                    game.Generation = gameObj["generation"] != null && gameObj["generation"].IsInt ? (int)gameObj["generation"] : -1;
                                }

                                if (gameObj.Contains("release_year"))
                                {
                                    game.ReleaseYear = gameObj["release_year"] != null && gameObj["release_year"].IsInt ? (int)gameObj["release_year"] : -1;
                                }

                                if (gameObj.Contains("modified"))
                                {
                                    game.ModifiedDate = gameObj["modified"] != null && gameObj["modified"].IsString ? DateTime.Parse(gameObj["modified"].ToString()) : new DateTime();
                                }

                                if (gameObj.Contains("resource_uri"))
                                {
                                    game.ResourceUri = gameObj["resource_uri"] != null && gameObj["resource_uri"].IsString ? gameObj["resource_uri"].ToString() : string.Empty;
                                }

                                context.Games.InsertOnSubmit(game);
                            }
                        }
                    }

#if DEBUG
                    nextUri = null;
#endif
#if !DEBUG
                    nextUri = meta["next"] != null && meta["next"].IsString ? meta["next"].ToString() : null;
#endif

                    if (nextUri != null)
                    {
#if !DEBUG
                        gameList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}", BaseApiUri, nextUri)));
                        gameList.TryGetValue("meta", out meta);
                        gameList.TryGetValue("objects", out objects);
#endif
                    }
                    else
                    {
                        meta = null;
                        objects = null;
                    }
                }

                context.SubmitChanges();
            }
        }

        private static void PopulateDescriptions()
        {
#if !DEBUG
            JsonData descriptionList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}?limit={2}", BaseApiUri, DescroptionsApiUri, BaseLimit)));
#endif

#if DEBUG
            JsonData descriptionList = JsonMapper.ToObject(DumyJson.DescriptionList);
#endif

            JsonData meta = null;
            JsonData objects = null;
            string nextUri = null;
            List<Tuple<Description, JsonData>> descriptions = new List<Tuple<Description, JsonData>>();

            descriptionList.TryGetValue("meta", out meta);
            descriptionList.TryGetValue("objects", out objects);

            using (var context = new PokedexDataContext())
            {
                while (meta != null && objects != null)
                {
                    if (objects.IsArray)
                    {
                        foreach (JsonData descriptionObj in objects)
                        {
                            var pkId = -1;

                            if (descriptionObj.Contains("id"))
                            {
                                pkId = descriptionObj["id"] != null && descriptionObj["id"].IsInt ? (int)descriptionObj["id"] : -1;
                            }

                            if (!context.Descriptions.Any(d => d.PkApiId == pkId))
                            {
                                var description = new Description();

                                description.PkApiId = pkId;

                                if (descriptionObj.Contains("description"))
                                {
                                    description.Description1 = descriptionObj["description"] != null && descriptionObj["description"].IsString ? descriptionObj["description"].ToString() : string.Empty;
                                }

                                if (descriptionObj.Contains("modified"))
                                {
                                    description.ModifiedDate = descriptionObj["modified"] != null && descriptionObj["modified"].IsString ? DateTime.Parse(descriptionObj["modified"].ToString()) : new DateTime();
                                }

                                if (descriptionObj.Contains("resource_uri"))
                                {
                                    description.ResourceUri = descriptionObj["resource_uri"] != null && descriptionObj["resource_uri"].IsString ? descriptionObj["resource_uri"].ToString() : string.Empty;
                                }

                                context.Descriptions.InsertOnSubmit(description);

                                if (descriptionObj.Contains("games"))
                                {
                                    JsonData games = descriptionObj["games"] != null && descriptionObj["games"].IsArray ? descriptionObj["games"] : null;

                                    if (games != null)
                                    {
                                        descriptions.Add(Tuple.Create(description, games));
                                    }
                                }
                            }
                            else
                            {
                                var description = context.Descriptions.First(d => d.PkApiId == pkId);

                                if (descriptionObj.Contains("games"))
                                {
                                    JsonData games = descriptionObj["games"] != null && descriptionObj["games"].IsArray ? descriptionObj["games"] : null;

                                    if (games != null)
                                    {
                                        descriptions.Add(Tuple.Create(description, games));
                                    }
                                }
                            }
                        }
                    }

#if DEBUG
                    nextUri = null;
#endif
#if !DEBUG
                    nextUri = meta["next"] != null && meta["next"].IsString ? meta["next"].ToString() : null;
#endif

                    if (nextUri != null)
                    {
#if !DEBUG
                        descriptionList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}", BaseApiUri, nextUri)));
                        descriptionList.TryGetValue("meta", out meta);
                        descriptionList.TryGetValue("objects", out objects);
#endif
                    }
                    else
                    {
                        meta = null;
                        objects = null;
                    }
                }

                context.SubmitChanges();

                Console.WriteLine("\r\n...Start - Populating Description Game");

                foreach (var description in descriptions)
                {
                    var descriptionId = description.Item1.DescriptionId;

                    foreach (JsonData gameObj in description.Item2)
                    {
                        var gameName = "";
                        var gameResourceUri = "";

                        if (gameObj.Contains("name"))
                        {
                            gameName = gameObj["name"] != null && gameObj["name"].IsString ? gameObj["name"].ToString() : string.Empty;
                        }

                        if (gameObj.Contains("resource_uri"))
                        {
                            gameResourceUri = gameObj["resource_uri"] != null && gameObj["resource_uri"].IsString ? gameObj["resource_uri"].ToString() : string.Empty;
                        }

                        if (string.IsNullOrEmpty(gameName) && string.IsNullOrEmpty(gameResourceUri))
                        {
                            continue;
                        }

                        var game = context.Games.FirstOrDefault(g => g.Name == gameName && g.ResourceUri == gameResourceUri);

                        if (game == null || context.DescriptionGames.Any(dG => dG.GameId == game.GameId && dG.DescriptionId == descriptionId))
                        {
                            continue;
                        }

                        var descriptionGame = new DescriptionGame
                            {
                                DescriptionId = descriptionId,
                                GameId = game.GameId
                            };

                        context.DescriptionGames.InsertOnSubmit(descriptionGame);
                    }
                }

                context.SubmitChanges();

                Console.WriteLine("...End - Populating Description Game\r\n");
            }
        }

        private static void PopulateAbilities()
        {
#if !DEBUG
            JsonData abilityList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}?limit={2}", BaseApiUri, AbilitiesApiUri, BaseLimit)));
#endif

#if DEBUG
            JsonData abilityList = JsonMapper.ToObject(DumyJson.AbilityList);
#endif

            JsonData meta = null;
            JsonData objects = null;
            string nextUri = null;

            abilityList.TryGetValue("meta", out meta);
            abilityList.TryGetValue("objects", out objects);

            using (var context = new PokedexDataContext())
            {
                while (meta != null && objects != null)
                {
                    if (objects.IsArray)
                    {
                        foreach (JsonData abilityObj in objects)
                        {
                            var pkId = -1;

                            if (abilityObj.Contains("id"))
                            {
                                pkId = abilityObj["id"] != null && abilityObj["id"].IsInt ? (int)abilityObj["id"] : -1;
                            }

                            if (!context.Abilities.Any(g => g.PkApiId == pkId))
                            {
                                var ability = new Ability();

                                ability.PkApiId = pkId;

                                if (abilityObj.Contains("name"))
                                {
                                    ability.Name = abilityObj["name"] != null && abilityObj["name"].IsString ? abilityObj["name"].ToString() : string.Empty;
                                }

                                if (abilityObj.Contains("description"))
                                {
                                    ability.Description = abilityObj["description"] != null && abilityObj["description"].IsString ? abilityObj["description"].ToString() : string.Empty;
                                }

                                if (abilityObj.Contains("modified"))
                                {
                                    ability.ModifiedDate = abilityObj["modified"] != null && abilityObj["modified"].IsString ? DateTime.Parse(abilityObj["modified"].ToString()) : new DateTime();
                                }

                                if (abilityObj.Contains("resource_uri"))
                                {
                                    ability.ResourceUri = abilityObj["resource_uri"] != null && abilityObj["resource_uri"].IsString ? abilityObj["resource_uri"].ToString() : string.Empty;
                                }

                                context.Abilities.InsertOnSubmit(ability);
                            }
                        }
                    }

#if DEBUG
                    nextUri = null;
#endif
#if !DEBUG
                    nextUri = meta["next"] != null && meta["next"].IsString ? meta["next"].ToString() : null;
#endif

                    if (nextUri != null)
                    {
#if !DEBUG
                        abilityList = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}", BaseApiUri, nextUri)));
                        abilityList.TryGetValue("meta", out meta);
                        abilityList.TryGetValue("objects", out objects);
#endif
                    }
                    else
                    {
                        meta = null;
                        objects = null;
                    }
                }

                context.SubmitChanges();
            }
        }

        private static void PopulatePokedex()
        {
#if !DEBUG
            JsonData pokedex = JsonMapper.ToObject(client.DownloadString(string.Format("{0}{1}?limit={2}", BaseApiUri, PokedexApiUri, BaseLimit)));
#endif

#if DEBUG
            JsonData pokedex = JsonMapper.ToObject(DumyJson.Pokedex);
#endif
            JsonData pokemonList = null;

            pokedex.TryGetValue("pokemon", out pokemonList);

            if (pokemonList == null)
            {
                return;
            }

            using (var context = new PokedexDataContext())
            {
                foreach (JsonData pokemonListObj in pokemonList)
                {

                    var pokemonName = "";
                    var pokemonResourceUri = "";

                    if (pokemonListObj.Contains("name"))
                    {
                        pokemonName = pokemonListObj["name"] != null && pokemonListObj["name"].IsString ? pokemonListObj["name"].ToString() : string.Empty;
                    }

                    if (pokemonListObj.Contains("resource_uri"))
                    {
                        pokemonResourceUri = pokemonListObj["resource_uri"] != null && pokemonListObj["resource_uri"].IsString ? pokemonListObj["resource_uri"].ToString() : string.Empty;
                    }

                    if (string.IsNullOrEmpty(pokemonName) && string.IsNullOrEmpty(pokemonResourceUri))
                    {
                        continue;
                    }

                    if (!context.Pokemons.Any(t => t.Name == pokemonName && t.ResourceUri == pokemonResourceUri))
                    {
                        var populatedPokemon = PopulatePokemon(context, pokemonResourceUri);

                        if (populatedPokemon != null)
                        {
                            Pokedex.Add(populatedPokemon);
                        }
                    }
                }

                foreach (var pokemonEvolutionList in Pokedex)
                {
                    if (pokemonEvolutionList == null)
                    {
                        continue;
                    }

                    foreach (JsonData evolutionObj in pokemonEvolutionList.Item2)
                    {
                        int? level = null;
                        var method = string.Empty;
                        var resourceUri = "";
                        
                        if (evolutionObj.Contains("resource_uri"))
                        {
                            resourceUri = evolutionObj["resource_uri"] != null && evolutionObj["resource_uri"].IsString ? evolutionObj["resource_uri"].ToString() : string.Empty;
                        }

                        if (evolutionObj.Contains("level"))
                        {
                            level = evolutionObj["level"] != null && evolutionObj["level"].IsInt ? (int)evolutionObj["level"] : -1;
                        }

                        if (evolutionObj.Contains("method"))
                        {
                            method = evolutionObj["method"] != null && evolutionObj["method"].IsString ? evolutionObj["method"].ToString() : string.Empty;
                        }
                        
                        if (string.IsNullOrEmpty(resourceUri))
                        {
                            continue;
                        }

                        var pokemon = context.Pokemons.FirstOrDefault(m => m.ResourceUri == resourceUri);

                        if (pokemon == null)
                        {
                            continue;
                        }

                        var evolution = new PokemonEvolution
                        {
                            FromPokemonId = pokemonEvolutionList.Item1.PokemonId,
                            ToPokemonId = pokemon.PokemonId,
                            PokemonLevel = level,
                            Method = method
                        };

                        context.PokemonEvolutions.InsertOnSubmit(evolution);
                    }
                }

                context.SubmitChanges();
            }
        }

        private static Tuple<Pokemon, JsonData> PopulatePokemon(PokedexDataContext context, string uriPath)
        {
#if !DEBUG
            JsonData pokemonObj = JsonMapper.ToObject(client.DownloadString(string.Format("{0}/{1}", BaseApiUri, uriPath)));
#endif

#if DEBUG
            JsonData pokemonObj = JsonMapper.ToObject(DumyJson.Pokemon);
#endif
            var pokemon = new Pokemon();

            if (pokemonObj.Contains("pkdx_id"))
            {
                pokemon.PkApiId = pokemonObj["pkdx_id"] != null && pokemonObj["pkdx_id"].IsInt ? (int)pokemonObj["pkdx_id"] : -1;
            }

            if (pokemonObj.Contains("name"))
            {
                pokemon.Name = pokemonObj["name"] != null && pokemonObj["name"].IsString ? pokemonObj["name"].ToString() : string.Empty;
            }

            if (pokemonObj.Contains("hp"))
            {
                pokemon.Hp = pokemonObj["hp"] != null && pokemonObj["hp"].IsInt ? (int)pokemonObj["hp"] : -1;
            }

            if (pokemonObj.Contains("attack"))
            {
                pokemon.Attack = pokemonObj["attack"] != null && pokemonObj["attack"].IsInt ? (int)pokemonObj["attack"] : -1;
            }

            if (pokemonObj.Contains("defense"))
            {
                pokemon.Defense = pokemonObj["defense"] != null && pokemonObj["defense"].IsInt ? (int)pokemonObj["defense"] : -1;
            }

            if (pokemonObj.Contains("sp_atk"))
            {
                pokemon.SpAttack = pokemonObj["sp_atk"] != null && pokemonObj["sp_atk"].IsInt ? (int)pokemonObj["sp_atk"] : -1;
            }

            if (pokemonObj.Contains("sp_def"))
            {
                pokemon.SpDefense = pokemonObj["sp_def"] != null && pokemonObj["sp_def"].IsInt ? (int)pokemonObj["sp_def"] : -1;
            }

            if (pokemonObj.Contains("speed"))
            {
                pokemon.Speed = pokemonObj["speed"] != null && pokemonObj["speed"].IsInt ? (int)pokemonObj["speed"] : -1;
            }

            if (pokemonObj.Contains("catch_rate"))
            {
                pokemon.CatchRate = pokemonObj["catch_rate"] != null && pokemonObj["catch_rate"].IsInt ? (int)pokemonObj["catch_rate"] : -1;
            }

            if (pokemonObj.Contains("happiness"))
            {
                pokemon.Happiness = pokemonObj["happiness"] != null && pokemonObj["happiness"].IsInt ? (int)pokemonObj["happiness"] : -1;
            }

            if (pokemonObj.Contains("height"))
            {
                pokemon.Height = pokemonObj["height"] != null && pokemonObj["height"].IsString ? pokemonObj["height"].ToString() : string.Empty;
            }

            if (pokemonObj.Contains("weight"))
            {
                pokemon.Weight = pokemonObj["weight"] != null && pokemonObj["weight"].IsString ? pokemonObj["weight"].ToString() : string.Empty;
            }

            if (pokemonObj.Contains("species"))
            {
                pokemon.Species = pokemonObj["species"] != null && pokemonObj["species"].IsString ? pokemonObj["species"].ToString() : string.Empty;
            }

            if (pokemonObj.Contains("male_female_ratio"))
            {
                pokemon.MaleToFemale = pokemonObj["male_female_ratio"] != null && pokemonObj["male_female_ratio"].IsString ? pokemonObj["male_female_ratio"].ToString() : string.Empty;
            }
            
            if (pokemonObj.Contains("modified"))
            {
                pokemon.ModifiedDate = pokemonObj["modified"] != null && pokemonObj["modified"].IsString ? DateTime.Parse(pokemonObj["modified"].ToString()) : new DateTime();
            }

            if (pokemonObj.Contains("resource_uri"))
            {
                pokemon.ResourceUri = pokemonObj["resource_uri"] != null && pokemonObj["resource_uri"].IsString ? pokemonObj["resource_uri"].ToString() : string.Empty;
            }

            context.Pokemons.InsertOnSubmit(pokemon);

            context.SubmitChanges();

            #region Abilities

            Console.WriteLine("\r\n...Start - Populating Pokemon Abilities");

            JsonData abilityList = null;

            pokemonObj.TryGetValue("abilities", out abilityList);

            if (abilityList != null)
            {
                foreach (JsonData abilityObj in abilityList)
                {
                    var name = "";
                    var resourceUri = "";

                    if (abilityObj.Contains("name"))
                    {
                        name = abilityObj["name"] != null && abilityObj["name"].IsString ? abilityObj["name"].ToString() : string.Empty;
                    }

                    if (abilityObj.Contains("resource_uri"))
                    {
                        resourceUri = abilityObj["resource_uri"] != null && abilityObj["resource_uri"].IsString ? abilityObj["resource_uri"].ToString() : string.Empty;
                    }

                    if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(resourceUri))
                    {
                        continue;
                    }

                    var ability = context.Abilities.FirstOrDefault(a => a.Name == name && a.ResourceUri == resourceUri);

                    if (ability == null || context.PokemonAbilities.Any(pa => pa.PokemonId == pokemon.PokemonId && pa.AbilityId == ability.AbilityId))
                    {
                        continue;
                    }

                    var pokemonAbility = new PokemonAbility
                    {
                        PokemonId = pokemon.PokemonId,
                        AbilityId = ability.AbilityId
                    };

                    context.PokemonAbilities.InsertOnSubmit(pokemonAbility);
                }
            }

            Console.WriteLine("...End - Populating Pokemon Abilities \r\n");
            #endregion

            #region Descriptions

            Console.WriteLine("\r\n...Start - Populating Pokemon Descriptions");

            JsonData descriptionsList = null;

            pokemonObj.TryGetValue("descriptions", out descriptionsList);

            if (descriptionsList != null)
            {
                foreach (JsonData descriptionObj in descriptionsList)
                {
                    var name = "";
                    var resourceUri = "";

                    if (descriptionObj.Contains("name"))
                    {
                        name = descriptionObj["name"] != null && descriptionObj["name"].IsString ? descriptionObj["name"].ToString() : string.Empty;
                    }

                    if (descriptionObj.Contains("resource_uri"))
                    {
                        resourceUri = descriptionObj["resource_uri"] != null && descriptionObj["resource_uri"].IsString ? descriptionObj["resource_uri"].ToString() : string.Empty;
                    }

                    if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(resourceUri))
                    {
                        continue;
                    }

                    var description = context.Descriptions.FirstOrDefault(a => a.ResourceUri == resourceUri);

                    if (description == null || context.PokemonDescriptions.Any(pa => pa.PokemonId == pokemon.PokemonId && pa.DescriptionId == description.DescriptionId))
                    {
                        continue;
                    }

                    var pokemonDescription = new PokemonDescription
                    {
                        PokemonId = pokemon.PokemonId,
                        DescriptionId = description.DescriptionId
                    };

                    context.PokemonDescriptions.InsertOnSubmit(pokemonDescription);
                }
            }

            Console.WriteLine("...End - Populating Pokemon Descriptions \r\n");
            #endregion

            #region Moves

            Console.WriteLine("\r\n...Start - Populating Pokemon Moves");

            JsonData movesList = null;

            pokemonObj.TryGetValue("moves", out movesList);

            if (movesList != null)
            {
                foreach (JsonData moveObj in movesList)
                {
                    var name = "";
                    var resourceUri = "";
                    var learnType = "";
                    int? level = null;

                    if (moveObj.Contains("name"))
                    {
                        name = moveObj["name"] != null && moveObj["name"].IsString ? moveObj["name"].ToString() : string.Empty;
                    }

                    if (moveObj.Contains("resource_uri"))
                    {
                        resourceUri = moveObj["resource_uri"] != null && moveObj["resource_uri"].IsString ? moveObj["resource_uri"].ToString() : string.Empty;
                    }

                    if (moveObj.Contains("learn_type"))
                    {
                        learnType = moveObj["learn_type"] != null && moveObj["learn_type"].IsString ? moveObj["learn_type"].ToString() : string.Empty;
                    }

                    if (pokemonObj.Contains("level"))
                    {
                        level = pokemonObj["level"] != null && pokemonObj["level"].IsInt ? (int)pokemonObj["level"] : -1;
                    }

                    if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(resourceUri))
                    {
                        continue;
                    }

                    var move = context.Moves.FirstOrDefault(m => m.Name == name &&  m.ResourceUri == resourceUri);

                    if (move == null || context.PokemonMoves.Any(pm => pm.PokemonId == pokemon.PokemonId && pm.MoveId == move.MoveId))
                    {
                        continue;
                    }

                    var pokemonMove = new PokemonMove
                    {
                        PokemonId = pokemon.PokemonId,
                        MoveId = move.MoveId,
                        LearnType = learnType,
                        PokemonLevel = level                        
                    };

                    context.PokemonMoves.InsertOnSubmit(pokemonMove);
                }
            }

            Console.WriteLine("...End - Populating Pokemon Moves \r\n");
            #endregion

            #region Sprites

            Console.WriteLine("\r\n...Start - Populating Pokemon Sprite");

            JsonData spriteList = null;

            pokemonObj.TryGetValue("sprites", out spriteList);

            if (spriteList != null)
            {
                foreach (JsonData spriteObj in spriteList)
                {
                    var name = "";
                    var resourceUri = "";

                    if (spriteObj.Contains("name"))
                    {
                        name = spriteObj["name"] != null && spriteObj["name"].IsString ? spriteObj["name"].ToString() : string.Empty;
                    }

                    if (spriteObj.Contains("resource_uri"))
                    {
                        resourceUri = spriteObj["resource_uri"] != null && spriteObj["resource_uri"].IsString ? spriteObj["resource_uri"].ToString() : string.Empty;
                    }

                    if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(resourceUri))
                    {
                        continue;
                    }

                    var sprite = context.Sprites.FirstOrDefault(s => s.ResourceUri == resourceUri);

                    if (sprite == null || context.PokemonSprites.Any(ps => ps.PokemonId == pokemon.PokemonId && ps.SpriteId == sprite.SpriteId))
                    {
                        continue;
                    }

                    var pokemonMove = new PokemonSprite
                    {
                        PokemonId = pokemon.PokemonId,
                        SpriteId = sprite.SpriteId,
                    };

                    context.PokemonSprites.InsertOnSubmit(pokemonMove);
                }
            }

            Console.WriteLine("...End - Populating Pokemon Sprites \r\n");
            #endregion

            #region Types

            Console.WriteLine("\r\n...Start - Populating Pokemon Types");

            JsonData typeList = null;

            pokemonObj.TryGetValue("types", out typeList);

            if (typeList != null)
            {
                foreach (JsonData typeObj in typeList)
                {
                    var name = "";
                    var resourceUri = "";

                    if (typeObj.Contains("name"))
                    {
                        name = typeObj["name"] != null && typeObj["name"].IsString ? typeObj["name"].ToString() : string.Empty;
                    }

                    if (typeObj.Contains("resource_uri"))
                    {
                        resourceUri = typeObj["resource_uri"] != null && typeObj["resource_uri"].IsString ? typeObj["resource_uri"].ToString() : string.Empty;
                    }

                    if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(resourceUri))
                    {
                        continue;
                    }

                    var type = context.Types.FirstOrDefault(t => t.Name == name && t.ResourceUri == resourceUri);

                    if (type == null || context.PokemonTypes.Any(pt => pt.PokemonId == pokemon.PokemonId && pt.PokemonTypeId == type.TypeId))
                    {
                        continue;
                    }

                    var pokemonType = new PokemonType
                    {
                        PokemonId = pokemon.PokemonId,
                        TypeId = type.TypeId,
                    };

                    context.PokemonTypes.InsertOnSubmit(pokemonType);
                }
            }

            Console.WriteLine("...End - Populating Pokemon Types \r\n");
            #endregion

            context.SubmitChanges();

            return Tuple.Create(pokemon, pokemonObj["evolutions"]);
        }

        public static string ConvertImageURLToBase64(string url)
        {
            StringBuilder _sb = new StringBuilder();

            byte[] _bytes = GetImage(url);

            if (_bytes == null)
            {
                return string.Empty;
            }

            _sb.Append(Convert.ToBase64String(_bytes, 0, _bytes.Length));

            return _sb.ToString();
        }

        private static byte[] GetImage(string url)
        {
            Stream stream = null;
            byte[] buf;

            try
            {
                var req = (HttpWebRequest)HttpWebRequest.Create(url);
                var response = (HttpWebResponse)req.GetResponse();
                stream = response.GetResponseStream();

                using (BinaryReader br = new BinaryReader(stream))
                {
                    int len = (int)(response.ContentLength);
                    buf = br.ReadBytes(len);
                    br.Close();
                }

                stream.Close();
                response.Close();
            }
            catch (Exception)
            {
                buf = null;
            }

            return (buf);
        }
    }
}
