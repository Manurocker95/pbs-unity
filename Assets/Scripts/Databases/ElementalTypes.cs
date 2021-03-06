﻿using PBS.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PBS.Databases
{
    public class ElementalTypes
    {
        //create an object of SingleObject
        private static ElementalTypes singleton = new ElementalTypes();

        //make the constructor private so that this class cannot be
        //instantiated
        private ElementalTypes() { }

        //Get the only object available
        public static ElementalTypes instance
        {
            get
            {
                return singleton;
            }
            private set
            {
                singleton = value;
            }
        }

        // Database
        private Dictionary<string, Data.ElementalType> database = new Dictionary<string, Data.ElementalType>
    {
        // Null / Placeholder
        {"",
            new Data.ElementalType(
                ID: "",
                typeName: "???"
                ) },

        {"bug",
            new Data.ElementalType(
                ID: "bug",
                typeName: "Bug",
                typeColor: "#80ffc0",
                maxMove: "maxflutterby",

                resistances: new List<string>
                {
                    "fighting",
                    "grass",
                    "ground",
                },
                weaknesses: new List<string>
                {
                    "fire",
                    "flying",
                    "rock",
                }
                ) },

        {"dark",
            new Data.ElementalType(
                ID: "dark",
                typeName: "Dark",
                typeColor: "#404040",
                maxMove: "maxdarkness",

                resistances: new List<string>
                {
                    "dark",
                    "ghost",
                },
                weaknesses: new List<string>
                {
                    "bug",
                    "fairy",
                    "fighting",
                },
                immunities: new List<string>
                {
                    "psychic",
                }
                ) },

        {"dragon",
            new Data.ElementalType(
                ID: "dragon",
                typeName: "Dragon",
                typeColor: "#a080ff",
                maxMove: "maxwyrmwind",

                resistances: new List<string>
                {
                    "electric",
                    "fire",
                    "grass",
                    "water",
                },
                weaknesses: new List<string>
                {
                    "dragon",
                    "fairy",
                    "ice",
                }
                ) },

        {"electric",
            new Data.ElementalType(
                ID: "electric",
                typeName: "Electric",
                typeColor: "#ffff00",
                maxMove: "maxlightning",

                resistances: new List<string>
                {
                    "electric",
                    "flying",
                    "steel",
                },
                weaknesses: new List<string>
                {
                    "ground",
                }
                ) },

        {"fairy",
            new Data.ElementalType(
                ID: "fairy",
                typeName: "Fairy",
                typeColor: "#ffa0fc",
                maxMove: "maxstarfall",

                resistances: new List<string>
                {
                    "bug",
                    "dark",
                    "fighting",
                },
                weaknesses: new List<string>
                {
                    "poison",
                    "steel",
                },
                immunities: new List<string>
                {
                    "dragon",
                }
                ) },

        {"fighting",
            new Data.ElementalType(
                ID: "fighting",
                typeName: "Fighting",
                typeColor: "#c04040",
                maxMove: "maxknuckle",

                resistances: new List<string>
                {
                    "bug",
                    "dark",
                    "rock",
                },
                weaknesses: new List<string>
                {
                    "fairy",
                    "flying",
                    "psychic",
                }
                ) },

        {"fire",
            new Data.ElementalType(
                ID: "fire",
                typeName: "Fire",
                typeColor: "#ff0000",
                maxMove: "maxflare",

                resistances: new List<string>
                {
                    "bug",
                    "fairy",
                    "fire",
                    "grass",
                    "ice",
                    "steel",
                },
                weaknesses: new List<string>
                {
                    "ground",
                    "rock",
                    "water",
                }
                ) },

        {"flying",
            new Data.ElementalType(
                ID: "flying",
                typeName: "Flying",
                typeColor: "#80ffe0",
                maxMove: "maxairstream",

                tags: new TypeTag[]
                {
                    TypeTag.Airborne
                },

                resistances: new List<string>
                {
                    "bug",
                    "fighting",
                    "grass",
                },
                weaknesses: new List<string>
                {
                    "electric",
                    "ice",
                    "rock",
                },
                immunities: new List<string>
                {
                    "ground",
                }
                ) },

        {"ghost",
            new Data.ElementalType(
                ID: "ghost",
                typeName: "Ghost",
                typeColor: "#8060a0",
                maxMove: "maxphantasm",

                resistances: new List<string>
                {
                    "bug",
                    "poison",
                },
                weaknesses: new List<string>
                {
                    "dark",
                    "ghost",
                },
                immunities: new List<string>
                {
                    "fighting",
                    "normal",
                },

                tags: new TypeTag[]
                {
                    TypeTag.CannotTrap
                }
                ) },

        {"grass",
            new Data.ElementalType(
                ID: "grass",
                typeName: "Grass",
                typeColor: "#00ff00",
                maxMove: "maxovergrowth",

                resistances: new List<string>
                {
                    "electric",
                    "grass",
                    "ground",
                    "water",
                },
                weaknesses: new List<string>
                {
                    "bug",
                    "fire",
                    "flying",
                    "ice",
                    "poison",
                }
                ) },

        {"ground",
            new Data.ElementalType(
                ID: "ground",
                typeName: "Ground",
                typeColor: "#ffa05c",
                maxMove: "maxquake",

                tags: new TypeTag[]
                {
                    TypeTag.Grounded
                },

                resistances: new List<string>
                {
                    "poison",
                    "rock",
                },
                weaknesses: new List<string>
                {
                    "grass",
                    "ice",
                    "water",
                },
                immunities: new List<string>
                {
                    "electric",
                }
                ) },

        {"ice",
            new Data.ElementalType(
                ID: "ice",
                typeName: "Ice",
                typeColor: "#c0e0fc",
                maxMove: "maxhailstorm",

                resistances: new List<string>
                {
                    "ice",
                },
                weaknesses: new List<string>
                {
                    "fighting",
                    "fire",
                    "rock",
                    "steel",
                }
                ) },

        {"normal",
            new Data.ElementalType(
                ID: "normal",
                typeName: "Normal",
                typeColor: "#ffc0a0",
                maxMove: "maxstrike",

                weaknesses: new List<string>
                {
                    "fighting",
                },
                immunities: new List<string>
                {
                    "ghost",
                }
                ) },

        {"poison",
            new Data.ElementalType(
                ID: "poison",
                typeName: "Poison",
                typeColor: "#bf00ff",
                maxMove: "maxooze",

                resistances: new List<string>
                {
                    "bug",
                    "fairy",
                    "fighting",
                    "grass",
                    "poison",
                },
                weaknesses: new List<string>
                {
                    "ground",
                    "psychic",
                }
                ) },

        {"psychic",
            new Data.ElementalType(
                ID: "psychic",
                typeName: "Psychic",
                typeColor: "#ff60ff",
                maxMove: "maxmindstorm",

                resistances: new List<string>
                {
                    "fighting",
                    "psychic",
                },
                weaknesses: new List<string>
                {
                    "dark",
                    "ghost",
                }
                ) },

        {"rock",
            new Data.ElementalType(
                ID: "rock",
                typeName: "Rock",
                typeColor: "#804000",
                maxMove: "maxrockfall",

                resistances: new List<string>
                {
                    "fire",
                    "flying",
                    "normal",
                    "poison",
                },
                weaknesses: new List<string>
                {
                    "fighting",
                    "grass",
                    "ground",
                    "steel",
                    "water",
                }
                ) },

        {"steel",
            new Data.ElementalType(
                ID: "steel",
                typeName: "Steel",
                typeColor: "#d0d0e0",
                maxMove: "maxsteelspike",

                resistances: new List<string>
                {
                    "bug",
                    "dragon",
                    "fairy",
                    "flying",
                    "grass",
                    "ice",
                    "normal",
                    "psychic",
                    "rock",
                    "steel",
                },
                weaknesses: new List<string>
                {
                    "fighting",
                    "fire",
                    "ground",
                },
                immunities: new List<string>
                {
                    "poison",
                }
                ) },

        {"water",
            new Data.ElementalType(
                ID: "water",
                typeName: "Water",
                typeColor: "#4040ff",
                maxMove: "maxgeyser",

                resistances: new List<string>
                {
                    "fire",
                    "ice",
                    "steel",
                    "water",
                },
                weaknesses: new List<string>
                {
                    "electric",
                    "grass",
                }
                ) },
    };

        // Methods
        public Data.ElementalType GetTypeData(string ID)
        {
            if (database.ContainsKey(ID))
            {
                return database[ID];
            }
            Debug.LogWarning("Could not find type with ID: " + ID);
            return database[""];
        }

        public List<string> GetAllTypes(bool filterBaseOnly = false)
        {
            List<string> allTypes = new List<string>(database.Keys);
            for (int i = 0; i < allTypes.Count; i++)
            {
                Data.ElementalType typeData = GetTypeData(allTypes[i]);

                if (string.IsNullOrEmpty(typeData.ID))
                {
                    bool removeType = true;

                    if (filterBaseOnly && !string.IsNullOrEmpty(typeData.baseID))
                    {
                        removeType = false;
                    }

                    if (removeType)
                    {
                        allTypes.RemoveAt(i);
                        i--;
                    }
                }
            }
            return new List<string>(allTypes);
        }
    }
}