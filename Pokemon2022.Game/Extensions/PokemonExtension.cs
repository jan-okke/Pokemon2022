using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Entities.Names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class PokemonExtension
    {
        public static double GetHPPercentage(this Pokemon pokemon)
        {
            return pokemon.CurrentHP / pokemon.Stats.HP;
        }
        public static void HealHP(this Pokemon pokemon)
        {
            pokemon.CurrentHP = (int)pokemon.Stats.HP;
        }
        public static void HealHP(this Pokemon pokemon, int amount)
        {
            pokemon.CurrentHP += amount;
            if (pokemon.CurrentHP > (int)pokemon.Stats.HP) pokemon.CurrentHP = (int)pokemon.Stats.HP;
        }
        public static bool TakeDamage(this Pokemon pokemon, int amount)
        {
            pokemon.CurrentHP -= amount;
            if (pokemon.CurrentHP < 0) pokemon.CurrentHP = 0;
            return pokemon.IsAlive();
        }
        public static bool IsAlive(this Pokemon pokemon)
        {
            pokemon.IsAlive = pokemon.CurrentHP > 0;
            return pokemon.IsAlive;
        }
        public static string GetDisplayName(this Pokemon pokemon)
        {
            if (pokemon.Nickname is null) return pokemon.Name;
            return pokemon.Nickname;
        }
        public static void Dynamax(this Pokemon pokemon)
        {
            pokemon.IsDynamaxed = true;
            pokemon.DynamaxTurns = 0;
            // load graphics
        }
        public static bool CanEvolve(this Pokemon pokemon, int level)
        {
            throw new NotImplementedException();
        }
        public static List<Move> GetMovesAtLevel(this Pokemon pokemon, int level)
        {
            return pokemon.LevelUpLearnset[level];
        }
        public static bool DoesTakeDamageFromWeather(this Pokemon pokemon, Weather weather)
        {
            return weather switch
            {
                Weather.None => false,
                Weather.Rain => false,
                Weather.Sun => false,
                Weather.Hail => !pokemon.Types.Contains(PokemonType.Ice) && pokemon.Ability.Name != AbilityNames.ICEBODY && pokemon.Ability.Name != AbilityNames.SNOWCLOAK && pokemon.Ability.Name != AbilityNames.MAGICGUARD && pokemon.Ability.Name != AbilityNames.OVERCOAT && pokemon.HeldItem.Name != ItemNames.SAFETYGOGGLES,
                Weather.Sand => !pokemon.Types.Contains(PokemonType.Ground) & !pokemon.Types.Contains(PokemonType.Steel) & !pokemon.Types.Contains(PokemonType.Rock) && pokemon.Ability.Name != AbilityNames.SANDFORCE && pokemon.Ability.Name != AbilityNames.SANDRUSH && pokemon.Ability.Name != AbilityNames.SANDVEIL && pokemon.Ability.Name != AbilityNames.MAGICGUARD && pokemon.Ability.Name != AbilityNames.OVERCOAT && pokemon.HeldItem.Name != ItemNames.SAFETYGOGGLES,
                Weather.HeavyRain => false,
                Weather.HarshSun => false,
                Weather.DeltaStream => false,
                _ => throw new ArgumentException("The given weather was not a valid weather."),
            };
        }
        public static bool DoesTakeDamageFromStatus(this Pokemon pokemon, PokemonStatus status)
        {
            return status switch
            {
                PokemonStatus.None => false,
                PokemonStatus.BadlyPoisoned => true,
                PokemonStatus.Poisoned => true,
                PokemonStatus.Paralyzed => false,
                PokemonStatus.Frozen => false,
                PokemonStatus.Sleeping => false,
                _ => throw new ArgumentException("The given status was not a valid status."),
            };
        }
    }
}
