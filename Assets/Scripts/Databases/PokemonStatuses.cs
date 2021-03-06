﻿using PBS.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PBS.Databases
{
    public class PokemonStatuses
    {
        //create an object of SingleObject
        private static PokemonStatuses singleton = new PokemonStatuses();

        //make the constructor private so that this class cannot be
        //instantiated
        private PokemonStatuses() { }

        //Get the only object available
        public static PokemonStatuses instance
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
        private Dictionary<string, PokemonStatus> database = new Dictionary<string, PokemonStatus>
        {
            // Null / Placeholder
            {"",
                new PokemonStatus(
                    ID: "",
                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.NonStick
                    }
                    ) },

            // NON-VOLATILE

            // Healthy
            {"healthy",
                new PokemonStatus(
                    ID: "healthy",
                    conditionName: "Healthy",

                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.IsDefault,
                        PokemonSTag.NonVolatile,
                    },

                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.NonVolatile(priority: 0),
                    }
                    ) },

            // Burn
            {"burn",
                new PokemonStatus(
                    ID: "burn",
                    conditionName: "Burn", shortName: "BRN",
                    inflictTextID: "status-burn-start",
                    healTextID: "status-burn-end",
                    alreadyTextID: "status-burn-already",
                    failTextID: "status-burn-fail",

                    defaultTurns: new Effects.General.DefaultTurns(turns: -1),
                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.NonVolatile,
                        PokemonSTag.TurnsDecreaseOnEnd,
                    },
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.NonVolatile(),
                        new Effects.PokemonStatuses.TypeImmunity(
                            filters: new Effects.Filter.FilterEffect[]
                            {
                                new Effects.Filter.TypeList(
                                    targetType: Effects.Filter.TypeList.TargetType.Pokemon,
                                    types: new string[] { "fire" },
                                    invert: true
                                    ),
                            }
                            ),
                        new Effects.PokemonStatuses.HPLoss(
                            displayText: "status-burn-hploss",
                            hpLossPercent: 1f/16
                            ),
                        new Effects.PokemonStatuses.Burn(
                            statScale: new Effects.General.StatScale(
                                scaleMap: new Dictionary<PokemonStats, float>
                                {
                                    { PokemonStats.Attack, 0.5f },
                                })
                            )
                    }
                    ) },

            // Freeze
            {"freeze",
                new PokemonStatus(
                    ID: "freeze",
                    conditionName: "Freeze",
                    shortName: "FRZ",
                    inflictTextID: "status-freeze-start",
                    healTextID: "status-freeze-heal",
                    alreadyTextID: "status-freeze-already",
                    failTextID: "status-freeze-fail",

                    defaultTurns: new Effects.General.DefaultTurns(turns: -1),
                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.NonVolatile,
                        PokemonSTag.TurnsDecreaseOnEnd,
                    },
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.NonVolatile(),
                        new Effects.PokemonStatuses.Freeze(
                            thawMoveTypes: new string[] { "fire" }),
                        new Effects.PokemonStatuses.TypeImmunity(
                            filters: new Effects.Filter.FilterEffect[]
                            {
                                new Effects.Filter.TypeList(
                                    targetType: Effects.Filter.TypeList.TargetType.Pokemon,
                                    types: new string[] { "ice", },
                                    invert: true
                                    ),
                            }
                            ),
                    }
                    ) },

            // Paralysis
            {"paralysis",
                new PokemonStatus(
                    ID: "paralysis",
                    conditionName: "Paralysis",
                    shortName: "PRZ",
                    inflictTextID: "status-paralysis-start",
                    healTextID: "status-paralysis-end",
                    alreadyTextID: "status-paralysis-already",
                    failTextID: "status-paralysis-fail",

                    defaultTurns: new Effects.General.DefaultTurns(turns: -1),
                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.NonVolatile,
                        PokemonSTag.TurnsDecreaseOnEnd,
                    },
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.NonVolatile(),
                        new Effects.PokemonStatuses.Paralysis(),
                        new Effects.PokemonStatuses.Burn(
                            statScale: new Effects.General.StatScale(
                                scaleMap: new Dictionary<PokemonStats, float>
                                {
                                    { PokemonStats.Speed, 0.5f },
                                })
                            ),
                        new Effects.PokemonStatuses.TypeImmunity(
                            filters: new Effects.Filter.FilterEffect[]
                            {
                                new Effects.Filter.TypeList(
                                    targetType: Effects.Filter.TypeList.TargetType.Pokemon,
                                    types: new string[] { "electric", },
                                    invert: true
                                    ),
                            }
                            ),
                    }
                    ) },

            // Poison
            {"poison",
                new PokemonStatus(
                    ID: "poison",
                    conditionName: "Poison", shortName: "PSN",
                    inflictTextID: "status-poison-start",
                    healTextID: "status-poison-end",
                    alreadyTextID: "status-poison-already",
                    failTextID: "status-poison-fail",

                    defaultTurns: new Effects.General.DefaultTurns(turns: -1),
                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.NonVolatile,
                        PokemonSTag.TurnsDecreaseOnEnd,
                    },
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.NonVolatile(),
                        new Effects.PokemonStatuses.HPLoss(
                            displayText: "status-poison-hploss",
                            hpLossPercent: 1f/8
                            ),
                        new Effects.PokemonStatuses.TypeImmunity(
                            filters: new Effects.Filter.FilterEffect[]
                            {
                                new Effects.Filter.TypeList(
                                    targetType: Effects.Filter.TypeList.TargetType.Pokemon,
                                    types: new string[] { "poison", "steel" },
                                    invert: true
                                    ),
                            }
                            ),
                    }
                    ) },

            // Toxic / Badly Poisoned
            {"poison2",
                new PokemonStatus(
                    ID: "poison2",
                    baseID: "poison",
                    conditionName: "Toxic Poison", shortName: "TXC",
                    inflictTextID: "status-toxic-start",
                    healTextID: "status-poison-end",
                    alreadyTextID: "status-poison-already",
                    failTextID: "status-poison-fail",

                    defaultTurns: new Effects.General.DefaultTurns(turns: -1),

                    combineBaseTags: true,
                    combineBaseEffects: true,
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.HPLoss(
                            displayText: "status-poison-hploss",
                            hpLossPercent: 1f/16,
                            toxicStack: true
                            ),
                    }
                    ) },

            // Sleep
            {"sleep",
                new PokemonStatus(
                    ID: "sleep",
                    conditionName: "Sleep", shortName: "SLP",
                    inflictTextID: "status-sleep-start",
                    healTextID: "status-sleep-end",
                    alreadyTextID: "status-sleep-already",
                    failTextID: "status-sleep-fail",

                    defaultTurns: new Effects.General.DefaultTurns(useTurnRange: true, lowestTurns: 1, highestTurns: 3),
                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.NonVolatile,
                        PokemonSTag.TurnsDecreaseOnMove
                    },
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.NonVolatile(),
                        new Effects.PokemonStatuses.Sleep(),
                    }
                    ) },


            // VOLATILE
        
            // Bound
            {"bound",
                new PokemonStatus(
                    ID: "bound",
                    conditionName: "Bound",

                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.NonStick,
                        PokemonSTag.RequiresPokemonCauseInBattle,
                        PokemonSTag.TurnsDecreaseOnEnd,
                    },

                    conditionEffects: new PokemonCEff[]
                    {
                        new PokemonCEff(
                            effectType: PokemonSEType.Bound,
                            effectTiming: PokemonSETiming.EndOfTurn,
                            floatParams: new float[] { 1f/16 },
                            stringParams: new string[]
                            {
                                "status-bound-inflict",
                                "status-bound-hploss",
                                "status-bound-end",
                                "status-bound-switch",
                            }
                            ),
                    }
                    ) },

            // Confusion
            {"confusion",
                new PokemonStatus(
                    ID: "confusion",
                    conditionName: "Confusion",
                    inflictTextID: "status-inflict-confusion",
                    healTextID: "status-heal-confusion",
                    alreadyTextID: "status-already-confusion",
                    failTextID: "status-fail-confusion",

                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.NonStick,
                        PokemonSTag.TurnsDecreaseOnMove
                    },

                    conditionEffects: new PokemonCEff[]
                    {
                        new PokemonCEff(
                            effectType: PokemonSEType.Confusion,
                            boolParams: new bool[] { true },
                            floatParams: new float[] { 1f/3, 40 },
                            stringParams: new string[] { "DEFAULT", "DEFAULT" }
                            ),
                        new PokemonCEff(
                            effectType: PokemonSEType.DefaultTurnsLeft,
                            boolParams: new bool[] { true },
                            floatParams: new float[] { 2, 5 }
                            ),
                    }
                    ) },

            // Encore
            {"encore",
                new PokemonStatus(
                    ID: "encore",
                    conditionName: "Encore",
                    statusTags: new PokemonSTag[]
                    {
                        PokemonSTag.TurnsDecreaseOnEnd
                    },

                    conditionEffects: new PokemonCEff[]
                    {
                        new PokemonCEff(
                            effectType: PokemonSEType.Encore,
                            stringParams: new string[] { "DEFAULT" }
                            ),
                        new PokemonCEff(
                            effectType: PokemonSEType.DefaultTurnsLeft,
                            boolParams: new bool[] { false },
                            floatParams: new float[] { 4, 0 }
                            ),
                    }
                    ) },

            // Defense Curl
            {"defensecurl",
                new PokemonStatus(
                    ID: "defensecurl",
                    conditionName: "Defense Curl",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.DefenseCurl(),
                    }
                    ) },

            // Disable
            {"disable",
                new PokemonStatus(
                    ID: "disable",
                    conditionName: "Disable",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Disable(
                            defaultTurns: new Effects.General.DefaultTurns(turns: 4)
                            ),
                    }
                    ) },

            // Electrify
            {"electrify",
                new PokemonStatus(
                    ID: "electrify",
                    conditionName: "Electrify",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Electrify(),
                    }
                    ) },

            // Embargo
            {"embargo",
                new PokemonStatus(
                    ID: "embargo",
                    conditionName: "Embargo",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Embargo(
                            defaultTurns: new Effects.General.DefaultTurns(turns: 5)
                            ),
                    }
                    ) },

            // Flinch
            {"flinch",
                new PokemonStatus(
                    ID: "flinch",
                    conditionName: "Flinch",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Flinch(),
                    }
                    ) },

            // Heal Block
            {"healblock",
                new PokemonStatus(
                    ID: "healblock",
                    conditionName: "Heal Block",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.HealBlock(
                            defaultTurns: new Effects.General.DefaultTurns(turns: 5)
                            ),
                    }
                    ) },

            // Identification
            {"identification",
                new PokemonStatus(
                    ID: "identification",
                    conditionName: "identification",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Identification(
                            types: new string[] { "ghost" }
                            ),
                    }
                    ) },

            // Imprison
            {"imprison",
                new PokemonStatus(
                    ID: "imprison",
                    conditionName: "Imprison",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Imprison(),
                    }
                    ) },

            // Infatuation
            {"infatuation",
                new PokemonStatus(
                    ID: "infatuation",
                    conditionName: "Infatuation",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Infatuation(),
                    }
                    ) },

            // Perish Song
            {"perishsong",
                new PokemonStatus(
                    ID: "perishsong",
                    conditionName: "Perish Song",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.PerishSong(),
                    }
                    ) },

            // Tar Shot
            {"tarshot",
                new PokemonStatus(
                    ID: "tarshot",
                    conditionName: "Tar Shot",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.TarShot(
                            startText: "status-tarshot",
                            weaknesses: new string[] { "fire" }
                            )
                    }
                    ) },

            // Taunt
            {"taunt",
                new PokemonStatus(
                    ID: "taunt",
                    conditionName: "Taunt",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Taunt(
                            defaultTurns: new Effects.General.DefaultTurns(turns: 3)
                            ),
                    }
                    ) },

            // Torment
            {"torment",
                new PokemonStatus(
                    ID: "torment",
                    conditionName: "Torment",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Torment(
                            defaultTurns: new Effects.General.DefaultTurns(turns: -1)
                            ),
                    }
                    ) },

            // Yawn
            {"yawn",
                new PokemonStatus(
                    ID: "yawn",
                    conditionName: "Yawn",
                    effectsNew: new Effects.PokemonStatuses.PokemonSE[]
                    {
                        new Effects.PokemonStatuses.Yawn(
                            statusID: "sleep",
                            turnsLeft: 1
                            ),
                    }
                    ) },

        };

        // Methods
        public PokemonStatus GetStatusData(string ID)
        {
            if (database.ContainsKey(ID))
            {
                return database[ID];
            }
            Debug.LogWarning("Could not find move with ID: " + ID);
            return database[""];
        }
        public PokemonStatus GetDefaultStatusData()
        {
            return GetStatusData("healthy");
        }
    }
}