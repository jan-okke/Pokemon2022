using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Extensions;
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
        public Pokemon PlayerCurrentPokemon;
        public Pokemon EnemyCurrentPokemon;
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
            PlayerCurrentPokemon = new();
            EnemyCurrentPokemon = new();
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
                PlayerParty = PlayerParty.Clone(),
                EnemyParty = EnemyParty.Clone(),
                PlayerSide = PlayerSide,
                EnemySide = EnemySide,
                PlayerCurrentPokemon = PlayerCurrentPokemon.Clone(),
                EnemyCurrentPokemon = EnemyCurrentPokemon.Clone(),
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
