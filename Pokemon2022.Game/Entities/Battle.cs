﻿using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities
{
    public class Battle
    {
        public int Turn;
        public PokemonParty PlayerParty;
        public PokemonParty EnemyParty;
        public BattlerSide PlayerSide;
        public BattlerSide EnemySide;
        public Weather Weather;
        public Terrain Terrain;
        public bool IsWildBattle;
        public bool IsTrainerBattle;
        public BattleType BattleType;

        public bool GravityActive;
        public bool FairyAuraActive;
        public bool DarkAuraActive;
        public bool AuraBreakActive;

        public int WeatherTurns;
        public int TerrainTurns;
        public int GravityTurns;

        public BattleLog Log;

        public Battle()
        {
            Turn = 0;
            PlayerParty = new();
            EnemyParty = new();
            PlayerSide = new();
            EnemySide = new();
            Weather = Weather.None;
            Terrain = Terrain.None;
            IsWildBattle = false;
            IsTrainerBattle = false;

            GravityActive = false;
            FairyAuraActive = false;
            DarkAuraActive = false;
            AuraBreakActive = false;

            WeatherTurns = 0;
            TerrainTurns = 0;
            GravityTurns = 0;

            Log = new();
        }
        public Battle Clone()
        {
            return new()
            {
                Turn = Turn,
                PlayerParty = PlayerParty,
                EnemyParty = EnemyParty,
                PlayerSide = PlayerSide,
                EnemySide = EnemySide,
                Weather = Weather,
                Terrain = Terrain,
                IsWildBattle = IsWildBattle,
                IsTrainerBattle = IsTrainerBattle,
                BattleType = BattleType,

                GravityActive = GravityActive,
                FairyAuraActive = FairyAuraActive,
                DarkAuraActive = DarkAuraActive,
                AuraBreakActive = AuraBreakActive,

                WeatherTurns = WeatherTurns,
                TerrainTurns = TerrainTurns,
                GravityTurns = GravityTurns,

                Log = Log,
            };
        }
    }
}