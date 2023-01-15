using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Entities.Names;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

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
        public static bool DoesTakeDamageFromStatus(this Pokemon pokemon, PokemonStatusSecondary status)
        {
            return status switch
            {
                PokemonStatusSecondary.Trapped => false,
                PokemonStatusSecondary.Confused => false,
                PokemonStatusSecondary.LeechSeed => true,
                _ => throw new ArgumentException("The given status was not a valid status."),
            };
        }
        public static bool IsFaster(this Pokemon pokemon, Pokemon otherPokemon)
        {
            return pokemon.CalculateModifiedStat(Stat.Speed) > otherPokemon.CalculateModifiedStat(Stat.Speed);
        }
        public static int CalculateModifiedStat(this Pokemon pokemon, Stat stat)
        {
            return stat switch
            {
                Stat.HP => (int)pokemon.Stats.HP,
                Stat.Attack => (int)(pokemon.Stats.Attack * Calculations.CalculateStatStageMod((int)pokemon.StatStages.Attack)),
                Stat.Defense => (int)(pokemon.Stats.Defense * Calculations.CalculateStatStageMod((int)pokemon.StatStages.Defense)),
                Stat.SpecialAttack => (int)(pokemon.Stats.SpecialAttack * Calculations.CalculateStatStageMod((int)pokemon.StatStages.SpecialAttack)),
                Stat.SpecialDefense => (int)(pokemon.Stats.SpecialDefense * Calculations.CalculateStatStageMod((int)pokemon.StatStages.SpecialDefense)),
                Stat.Speed => (int)(pokemon.Stats.Speed * Calculations.CalculateStatStageMod((int)pokemon.StatStages.Speed)),
                _ => throw new ArgumentException("Invalid Stat given"),
            };
        }
        public static void RaiseStat(this Pokemon pokemon, Stat stat, int amount)
        {
            if (amount < 0) throw new ArgumentException("Amount was less than 0");
            switch (stat)
            {
                case Stat.HP:
                    throw new ArgumentException("Stat was given as HP which can not be raised");
                case Stat.Attack:
                    pokemon.StatStages.Attack += Math.Min(amount, 6 - pokemon.StatStages.Attack);
                    break;
                case Stat.Defense:
                    pokemon.StatStages.Defense += Math.Min(amount, 6 - pokemon.StatStages.Defense);
                    break;
                case Stat.SpecialAttack:
                    pokemon.StatStages.SpecialAttack += Math.Min(amount, 6 - pokemon.StatStages.SpecialAttack);
                    break;
                case Stat.SpecialDefense:
                    pokemon.StatStages.SpecialDefense += Math.Min(amount, 6 - pokemon.StatStages.SpecialDefense);
                    break;
                case Stat.Speed:
                    pokemon.StatStages.Speed += Math.Min(amount, 6 - pokemon.StatStages.Speed);
                    break;
                default:
                    throw new ArgumentException("Stat was invalid");
            }
        }
        public static void LowerStat(this Pokemon pokemon, Stat stat, int amount)
        {
            if (amount < 0) throw new ArgumentException("Amount was less than 0");
            switch (stat)
            {
                case Stat.HP:
                    throw new ArgumentException("Stat was given as HP which can not be lowered");
                case Stat.Attack:
                    pokemon.StatStages.Attack -= Math.Min(amount, 6 + pokemon.StatStages.Attack);
                    break;
                case Stat.Defense:
                    pokemon.StatStages.Defense -= Math.Min(amount, 6 + pokemon.StatStages.Defense);
                    break;
                case Stat.SpecialAttack:
                    pokemon.StatStages.SpecialAttack -= Math.Min(amount, 6 + pokemon.StatStages.SpecialAttack);
                    break;
                case Stat.SpecialDefense:
                    pokemon.StatStages.SpecialDefense -= Math.Min(amount, 6 + pokemon.StatStages.SpecialDefense);
                    break;
                case Stat.Speed:
                    pokemon.StatStages.Speed -= Math.Min(amount, 6 + pokemon.StatStages.Speed);
                    break;
                default:
                    throw new ArgumentException("Stat was invalid");
            }
        }
        public static int GetBST(this Pokemon pokemon)
        {
            return pokemon.BaseStats.GetSum();
        }
    }
}
