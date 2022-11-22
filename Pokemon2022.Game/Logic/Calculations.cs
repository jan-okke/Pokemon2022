using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Entities.Exceptions;
using Pokemon2022.Game.Entities.Names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Pokemon2022.Game.Logic
{
    public class Calculations
    {
        public static decimal GetHPPercentage(Pokemon pokemon)
        {
            return (decimal)((pokemon.CurrentHP * 100) / pokemon.Stats.HP);
        }
        private static decimal GetBerryMod(Item berry, PokemonType moveType, decimal effectivity, bool empoweredEffect)
        {
            return 1; // TODO
        }
        private static decimal GetTypeEnhancingItemMod(Item item, PokemonType moveType, string pokemonName)
        {
            // https://bulbapedia.bulbagarden.net/wiki/Type-enhancing_item
            return 1; // TODO
        }
        private static bool IsPokemonFullHP(Pokemon pokemon)
        {
            return pokemon.CurrentHP == pokemon.Stats.HP;
        }
        private static bool PokemonHasRemoveableItem(Pokemon pokemon)
        {
            return false; // TODO
        }
        private static bool IsPokemonGrounded(Battle battle, Pokemon pokemon)
        {
            // https://bulbapedia.bulbagarden.net/wiki/Grounded
            if (pokemon.HeldItem.Name == ItemNames.IRONBALL) return true;
            // Ingrain, Smack Down, Roost, Thousand Arrows TODO => true
            if (battle.GravityActive) return true;
            if (pokemon.Types[0] == PokemonType.Flying || pokemon.Types[1] == PokemonType.Flying) return false;
            if (pokemon.Ability.Name == AbilityNames.LEVITATE) return false;
            if (pokemon.HeldItem.Name == ItemNames.AIRBALLOON) return false;
            // Magnet Rise, Telekenesis => false
            return true;
        }
        private static bool HasMoveAdditionalEffect(Move move)
        {
            // https://bulbapedia.bulbagarden.net/wiki/Additional_effect
            return false; // TODO
        }
        private static decimal GetMovePower(Battle battle, Pokemon attacker, Pokemon defender, Move move)
        {
            // https://bulbapedia.bulbagarden.net/wiki/Power
            decimal power = move.BasePower;
            // Facade
            if (move.Name == MoveNames.FACADE && attacker.Status != PokemonStatus.None) power *= 2;
            // Venoshock
            if (move.Name == MoveNames.VENOSHOCK && defender.Status == PokemonStatus.Poisoned || move.Name == MoveNames.VENOSHOCK && defender.Status == PokemonStatus.BadlyPoisoned) power *= 2;
            // Retaliate TODO
            // Fusion Flare && Fusion Bolt TODO
            // Lash Out TODO
            // Solar Blade and Solar Beam => TODO: if weather surpressed by Cloud Nine / Air Lock
            if (move.Name == MoveNames.SOLARBLADE && battle.Weather == Weather.Rain || move.Name == MoveNames.SOLARBLADE && battle.Weather == Weather.Hail || move.Name == MoveNames.SOLARBLADE && battle.Weather == Weather.Sand || move.Name == MoveNames.SOLARBLADE && battle.Weather == Weather.HeavyRain) power *= 0.5m;
            if (move.Name == MoveNames.SOLARBEAM && battle.Weather == Weather.Rain || move.Name == MoveNames.SOLARBEAM && battle.Weather == Weather.Hail || move.Name == MoveNames.SOLARBEAM && battle.Weather == Weather.Sand || move.Name == MoveNames.SOLARBEAM && battle.Weather == Weather.HeavyRain) power *= 0.5m;
            // Knock Off
            if (move.Name == MoveNames.KNOCKOFF && PokemonHasRemoveableItem(defender)) power *= 1.5m;
            // Grav Apple
            if (move.Name == MoveNames.GRAVAPPLE && battle.GravityActive) power *= 1.5m;
            // Misty Explosion
            if (move.Name == MoveNames.MISTYEXPLOSION && battle.Terrain == Terrain.Fairy && IsPokemonGrounded(battle, attacker)) power *= 1.5m;
            // Expanding Force
            if (move.Name == MoveNames.EXPANDINGFORCE && battle.Terrain == Terrain.Psychic && IsPokemonGrounded(battle, attacker)) power *= 1.5m;
            // 2* if last used move was charge and elec move type => TODO
            // 1.5* if me first stolen, 1.5* if under effect of helping hand => TODO
            // Mud Sport and Water Sport
            if (battle.EnemySide.HasMudSport && move.MoveType == PokemonType.Electric) power *= (1.0m / 3.0m);
            if (battle.EnemySide.HasWaterSport && move.MoveType == PokemonType.Fire) power *= (1.0m / 3.0m);
            // Grass Terrain Debuff
            if (battle.Terrain == Terrain.Grass && move.Name == MoveNames.EARTHQUAKE && IsPokemonGrounded(battle, defender) || battle.Terrain == Terrain.Grass && move.Name == MoveNames.MAGNITUDE && IsPokemonGrounded(battle, defender) || battle.Terrain == Terrain.Grass && move.Name == MoveNames.BULLDOZE && IsPokemonGrounded(battle, defender)) power *= 0.5m;
            // Fairy Terrain Debuff
            if (battle.Terrain == Terrain.Fairy && move.MoveType == PokemonType.Dragon && IsPokemonGrounded(battle, defender)) power *= 0.5m;
            // Grass Terrain Buff
            if (battle.Terrain == Terrain.Grass && move.MoveType == PokemonType.Grass && IsPokemonGrounded(battle, attacker)) power *= 1.3m;
            // Electric Terrain Buff
            if (battle.Terrain == Terrain.Electric && move.MoveType == PokemonType.Electric && IsPokemonGrounded(battle, attacker)) power *= 1.3m;
            // Psychic Terrain Buff
            if (battle.Terrain == Terrain.Psychic && move.MoveType == PokemonType.Psychic && IsPokemonGrounded(battle, attacker)) power *= 1.3m;
            // Rivalry
            if (attacker.Ability.Name == AbilityNames.RIVALRY && attacker.Gender == PokemonGender.Male && defender.Gender == PokemonGender.Male || attacker.Ability.Name == AbilityNames.RIVALRY && attacker.Gender == PokemonGender.Female && defender.Gender == PokemonGender.Female) power *= 1.25m;
            if (attacker.Ability.Name == AbilityNames.RIVALRY && attacker.Gender == PokemonGender.Male && defender.Gender == PokemonGender.Female || attacker.Ability.Name == AbilityNames.RIVALRY && attacker.Gender == PokemonGender.Female && defender.Gender == PokemonGender.Male) power *= 0.75m;
            // Reckless
            if (attacker.Ability.Name == AbilityNames.RECKLESS && move.IsRecoilMove) power *= 1.2m;
            // Iron Fist
            if (attacker.Ability.Name == AbilityNames.IRONFIST && move.IsPunchingMove) power *= 1.2m;
            // Normalize
            if (attacker.Ability.Name == AbilityNames.NORMALIZE) power *= 1.2m; // TODO this also changes the move to normal type (which should be checked earlier)
            // Other Type Change Abilities => TODO change type before?
            if (attacker.Ability.Name == AbilityNames.AERILATE && move.MoveType == PokemonType.Normal) power *= 1.2m;
            if (attacker.Ability.Name == AbilityNames.PIXILATE && move.MoveType == PokemonType.Normal) power *= 1.2m;
            if (attacker.Ability.Name == AbilityNames.REFRIGERATE && move.MoveType == PokemonType.Normal) power *= 1.2m;
            if (attacker.Ability.Name == AbilityNames.GALVANIZE && move.MoveType == PokemonType.Normal) power *= 1.2m;
            // Analytic if opponent moved before => TODO * 1.3
            // Sand Force => TODO if weather not nullified by cloud nine or air lock
            if (attacker.Ability.Name == AbilityNames.SANDFORCE && battle.Weather == Weather.Sand && move.MoveType == PokemonType.Ground || attacker.Ability.Name == AbilityNames.SANDFORCE && battle.Weather == Weather.Sand && move.MoveType == PokemonType.Rock || attacker.Ability.Name == AbilityNames.SANDFORCE && battle.Weather == Weather.Sand && move.MoveType == PokemonType.Steel) power *= 1.3m;
            // Sheer Force
            if (attacker.Ability.Name == AbilityNames.SHEERFORCE && HasMoveAdditionalEffect(move)) power *= 1.3m;
            // Tough Claws
            if (attacker.Ability.Name == AbilityNames.TOUGHCLAWS && move.IsContactMove) power *= 1.3m;
            // if ally has battery and special => 1.3 TODO
            // if ally has power spot => 1.3 TODO
            // Punk Rock
            if (attacker.Ability.Name == AbilityNames.PUNKROCK && move.IsSoundMove) power *= 1.3m;
            // Fairy and Dark Aura
            if (battle.FairyAuraActive && move.MoveType == PokemonType.Fairy && attacker.Ability.Name != AbilityNames.MOLDBREAKER && attacker.Ability.Name != AbilityNames.TURBOBLAZE && attacker.Ability.Name != AbilityNames.TERAVOLT) { if (battle.AuraBreakActive) power *= 0.75m; else power *= (4.0m / 3.0m); }
            if (battle.DarkAuraActive && move.MoveType == PokemonType.Dark && attacker.Ability.Name != AbilityNames.MOLDBREAKER && attacker.Ability.Name != AbilityNames.TURBOBLAZE && attacker.Ability.Name != AbilityNames.TERAVOLT) { if (battle.AuraBreakActive) power *= 0.75m; else power *= (4.0m / 3.0m); }
            // Strong Jaw
            if (attacker.Ability.Name == AbilityNames.STRONGJAW && move.IsBitingMove) power *= 1.5m;
            // Mega Launcher
            if (attacker.Ability.Name == AbilityNames.MEGALAUNCHER && move.IsAuraMove || attacker.Ability.Name == AbilityNames.MEGALAUNCHER && move.IsPulseMove) power *= 1.5m;
            // Technician
            if (attacker.Ability.Name == AbilityNames.TECHNICIAN && move.BasePower < 60) power *= 1.5m;
            // Toxic Boost
            if (attacker.Ability.Name == AbilityNames.TOXICBOOST && attacker.Status == PokemonStatus.Poisoned && move.Category == MoveCategory.Physical || attacker.Ability.Name == AbilityNames.TOXICBOOST && attacker.Status == PokemonStatus.BadlyPoisoned && move.Category == MoveCategory.Physical) power *= 1.5m;
            // Flare Boost
            if (attacker.Ability.Name == AbilityNames.FLAREBOOST && attacker.Status == PokemonStatus.Burned && move.Category == MoveCategory.Special) power *= 1.5m;
            // Steely Spirit TODO => this also gets applied if ally has it and it stacks multiplictive
            if (attacker.Ability.Name == AbilityNames.STEELYSPIRIT && move.MoveType == PokemonType.Steel) power *= 1.5m;
            // Heat Proof
            if (defender.Ability.Name == AbilityNames.HEATPROOF && move.MoveType == PokemonType.Fire && attacker.Ability.Name != AbilityNames.MOLDBREAKER && attacker.Ability.Name != AbilityNames.TURBOBLAZE && attacker.Ability.Name != AbilityNames.TERAVOLT) power *= 0.5m;
            // Dry Skin
            if (defender.Ability.Name == AbilityNames.DRYSKIN && move.MoveType == PokemonType.Fire && attacker.Ability.Name != AbilityNames.MOLDBREAKER && attacker.Ability.Name != AbilityNames.TURBOBLAZE && attacker.Ability.Name != AbilityNames.TERAVOLT) power *= 1.25m;
            // Muscle Band and Wise Glasses
            if (attacker.HeldItem.Name == ItemNames.MUSCLEBAND && move.Category == MoveCategory.Physical) power *= 1.1m;
            if (attacker.HeldItem.Name == ItemNames.WISEGLASSES && move.Category == MoveCategory.Special) power *= 1.1m;
            // Type Enhancing Items
            power *= GetTypeEnhancingItemMod(attacker.HeldItem, move.MoveType, attacker.Name);
            // 
            return power;
        }
        private static int GetAttack(Pokemon attacker, Move move)
        {
            // TODO ignore drops when crit
            switch (move.Category)
            {
                case MoveCategory.Physical:
                    return (int)(attacker.Stats.Attack * CalculateStatStageMod((int)attacker.StatStages.Attack));
                case MoveCategory.Special:
                    return (int)(attacker.Stats.SpecialAttack * CalculateStatStageMod((int)attacker.StatStages.SpecialAttack));
            }
            throw new InvalidCategoryException(move.Category);
        }
        private static int GetDefense(Pokemon defender, Move move)
        {
            // TODO ignore boosts when crit
            switch (move.Category)
            {
                case MoveCategory.Physical:
                    return (int)(defender.Stats.Defense * CalculateStatStageMod((int)defender.StatStages.Defense));
                case MoveCategory.Special:
                    return (int)(defender.Stats.SpecialDefense * CalculateStatStageMod((int)defender.StatStages.SpecialDefense));
            }
            throw new InvalidCategoryException(move.Category);
        }
        private static decimal GetTargetMod(Battle battle, Move move)
        {
            if (BattleLogic.IsMultiTargetBattle(battle) && BattleLogic.IsMultiTargetMove(move)) return 0.75m;
            return 1;
        }
        private static decimal GetWeatherMod(Battle battle, Move move)
        {
            // TODO => Cloud Nine.
            if (battle.Weather == Weather.Rain && move.MoveType == PokemonType.Water) return 1.5m;
            if (battle.Weather == Weather.Rain && move.MoveType == PokemonType.Fire) return 0.5m;
            if (battle.Weather == Weather.Sun && move.MoveType == PokemonType.Fire) return 1.5m;
            if (battle.Weather == Weather.Sun && move.MoveType == PokemonType.Water) return 0.5m;
            if (battle.Weather == Weather.HeavyRain && move.MoveType == PokemonType.Water) return 1.5m;
            if (battle.Weather == Weather.HeavyRain && move.MoveType == PokemonType.Fire) return 0;
            if (battle.Weather == Weather.HarshSun && move.MoveType == PokemonType.Fire) return 1.5m;
            if (battle.Weather == Weather.HarshSun && move.MoveType == PokemonType.Water) return 0;
            return 1;
        }
        private static decimal GetCritMod(Pokemon attacker, Move move)
        {
            return 1; // TODO
        }
        private static decimal GetRandMod()
        {
            Random random = new();
            return random.Next(0, 16) * 0.01m + 0.85m;
        }
        private static decimal GetStabMod(Pokemon attacker, Move move)
        {
            if (move.MoveType == attacker.Types[0] || move.MoveType == attacker.Types[1])
            {
                if (attacker.Ability.Name == AbilityNames.ADAPTABILITY) return 2;
                return 1.5m;
            }
            return 1;
        }
        public static decimal GetEffMod(PokemonType attackingType, PokemonType defendingType)
        {
            switch (attackingType)
            {
                case PokemonType.None:
                    return 1;
                case PokemonType.Normal:
                    if (defendingType == PokemonType.Rock || defendingType == PokemonType.Steel) return 0.5m;
                    if (defendingType == PokemonType.Ghost) return 0;
                    return 1;
                case PokemonType.Fighting:
                    if (defendingType == PokemonType.Normal || defendingType == PokemonType.Rock || defendingType == PokemonType.Ice || defendingType == PokemonType.Dark) return 2;
                    if (defendingType == PokemonType.Flying || defendingType == PokemonType.Poison || defendingType == PokemonType.Bug || defendingType == PokemonType.Psychic || defendingType == PokemonType.Fairy) return 0.5m;
                    if (defendingType == PokemonType.Ghost) return 0;
                    return 1;
                case PokemonType.Flying:
                    if (defendingType == PokemonType.Fighting || defendingType == PokemonType.Bug || defendingType == PokemonType.Grass) return 2;
                    if (defendingType == PokemonType.Rock || defendingType == PokemonType.Steel || defendingType == PokemonType.Electric) return 0.5m;
                    return 1;
                case PokemonType.Poison:
                    if (defendingType == PokemonType.Grass || defendingType == PokemonType.Fairy) return 2;
                    if (defendingType == PokemonType.Poison || defendingType == PokemonType.Ground || defendingType == PokemonType.Rock || defendingType == PokemonType.Ghost) return 0.5m;
                    if (defendingType == PokemonType.Steel) return 0;
                    return 1;
                case PokemonType.Ground:
                    if (defendingType == PokemonType.Poison || defendingType == PokemonType.Rock || defendingType == PokemonType.Steel || defendingType == PokemonType.Fire || defendingType == PokemonType.Fire || defendingType == PokemonType.Electric) return 2;
                    if (defendingType == PokemonType.Bug || defendingType == PokemonType.Grass) return 0.5m;
                    if (defendingType == PokemonType.Flying) return 0;
                    return 1;
                case PokemonType.Rock:
                    if (defendingType == PokemonType.Flying || defendingType == PokemonType.Bug || defendingType == PokemonType.Fire || defendingType == PokemonType.Ice) return 2;
                    if (defendingType == PokemonType.Fighting || defendingType == PokemonType.Ground || defendingType == PokemonType.Steel) return 0.5m;
                    return 1;
                case PokemonType.Bug:
                    if (defendingType == PokemonType.Grass || defendingType == PokemonType.Psychic || defendingType == PokemonType.Dark) return 2;
                    if (defendingType == PokemonType.Fighting || defendingType == PokemonType.Flying || defendingType == PokemonType.Poison || defendingType == PokemonType.Ghost || defendingType == PokemonType.Steel || defendingType == PokemonType.Fire || defendingType == PokemonType.Fairy) return 0.5m;
                    return 1;
                case PokemonType.Ghost:
                    if (defendingType == PokemonType.Ghost || defendingType == PokemonType.Psychic) return 2;
                    if (defendingType == PokemonType.Dark) return 0.5m;
                    if (defendingType == PokemonType.Normal) return 0;
                    return 1;
                case PokemonType.Steel:
                    if (defendingType == PokemonType.Rock || defendingType == PokemonType.Ice || defendingType == PokemonType.Fairy) return 2;
                    if (defendingType == PokemonType.Steel || defendingType == PokemonType.Fire || defendingType == PokemonType.Water || defendingType == PokemonType.Electric) return 0.5m;
                    return 1;
                case PokemonType.Fire:
                    if (defendingType == PokemonType.Bug || defendingType == PokemonType.Steel || defendingType == PokemonType.Grass || defendingType == PokemonType.Ice) return 2;
                    if (defendingType == PokemonType.Rock || defendingType == PokemonType.Fire || defendingType == PokemonType.Water || defendingType == PokemonType.Dragon) return 0.5m;
                    return 1;
                case PokemonType.Water:
                    if (defendingType == PokemonType.Ground || defendingType == PokemonType.Rock || defendingType == PokemonType.Fire) return 2;
                    if (defendingType == PokemonType.Water || defendingType == PokemonType.Grass || defendingType == PokemonType.Dragon) return 0.5m;
                    return 1;
                case PokemonType.Grass:
                    if (defendingType == PokemonType.Ground || defendingType == PokemonType.Rock || defendingType == PokemonType.Water) return 2;
                    if (defendingType == PokemonType.Flying || defendingType == PokemonType.Poison || defendingType == PokemonType.Bug || defendingType == PokemonType.Steel || defendingType == PokemonType.Fire || defendingType == PokemonType.Grass || defendingType == PokemonType.Dragon) return 0.5m;
                    return 1;
                case PokemonType.Electric:
                    if (defendingType == PokemonType.Flying || defendingType == PokemonType.Water) return 2;
                    if (defendingType == PokemonType.Grass || defendingType == PokemonType.Electric || defendingType == PokemonType.Dragon) return 0.5m;
                    if (defendingType == PokemonType.Ground) return 0;
                    return 1;
                case PokemonType.Psychic:
                    if (defendingType == PokemonType.Fighting || defendingType == PokemonType.Poison) return 2;
                    if (defendingType == PokemonType.Steel || defendingType == PokemonType.Psychic) return 0.5m;
                    if (defendingType == PokemonType.Dark) return 0;
                    return 1;
                case PokemonType.Ice:
                    if (defendingType == PokemonType.Flying || defendingType == PokemonType.Ground || defendingType == PokemonType.Grass || defendingType == PokemonType.Dragon) return 2;
                    if (defendingType == PokemonType.Steel || defendingType == PokemonType.Fire || defendingType == PokemonType.Water || defendingType == PokemonType.Ice) return 0.5m;
                    return 1;
                case PokemonType.Dragon:
                    if (defendingType == PokemonType.Dragon) return 2;
                    if (defendingType == PokemonType.Steel) return 0.5m;
                    if (defendingType == PokemonType.Fairy) return 0;
                    return 1;
                case PokemonType.Dark:
                    if (defendingType == PokemonType.Ghost || defendingType == PokemonType.Psychic) return 2;
                    if (defendingType == PokemonType.Fighting || defendingType == PokemonType.Dark || defendingType == PokemonType.Fairy) return 0.5m;
                    return 1;
                case PokemonType.Fairy:
                    if (defendingType == PokemonType.Fighting || defendingType == PokemonType.Dragon || defendingType == PokemonType.Dark) return 2;
                    if (defendingType == PokemonType.Poison || defendingType == PokemonType.Steel || defendingType == PokemonType.Fire) return 0.5m;
                    return 1;
                default:
                    throw new InvalidPokemonTypeException(attackingType);
            }
        }
        public static decimal GetEffMod(Pokemon defender, Move move)
        {
            return GetEffMod(move.MoveType, defender.Types[0]) * GetEffMod(move.MoveType, defender.Types[1]);
        }
        private static decimal GetBurnMod(Pokemon attacker, Move move)
        {
            if (attacker.Status == PokemonStatus.Burned && attacker.Ability.Name != AbilityNames.GUTS && move.Category == MoveCategory.Physical && move.Name != MoveNames.FACADE) return 0.5m;
            return 1;
        }
        private static decimal GetOtherMod(Battle battle, Pokemon attacker, Pokemon defender, Move move)
        {
            decimal mod = 1;
            // Dynamax Vulnerability
            if (move.Name == MoveNames.BEHEMOTHBLADE && defender.IsDynamaxed) mod *= 2;
            if (move.Name == MoveNames.BEHEMOTHBASH && defender.IsDynamaxed) mod *= 2;
            if (move.Name == MoveNames.DYNAMAXCANNON && defender.IsDynamaxed) mod *= 2;
            // Minimize Vulnerability
            if (move.TramplesMinimize && defender.IsMinimized) mod *= 2;
            // Underground Vulnerability
            if (move.Name == MoveNames.EARTHQUAKE && defender.IsUnderground) mod *= 2;
            if (move.Name == MoveNames.MAGNITUDE && defender.IsUnderground) mod *= 2;
            // Underwater Vulnerability
            if (move.Name == MoveNames.SURF && defender.IsUnderwater) mod *= 2;
            if (move.Name == MoveNames.WHIRLPOOL && defender.IsUnderwater) mod *= 2;
            // Reflect Lightscreen Auroraveil
            if (move.Category == MoveCategory.Physical && battle.EnemySide.HasReflect || move.Category == MoveCategory.Physical && battle.EnemySide.HasAuroraVeil) mod *= 0.5m;
            if (move.Category == MoveCategory.Special && battle.EnemySide.HasLightScreen || move.Category == MoveCategory.Special && battle.EnemySide.HasAuroraVeil) mod *= 0.5m;
            // Multiscale & Shadow Shield
            if (defender.Ability.Name == AbilityNames.MULTISCALE && IsPokemonFullHP(defender) || defender.Ability.Name == AbilityNames.SHADOWSHIELD && IsPokemonFullHP(defender)) mod *= 0.5m;
            // Fluffy => TODO: if defender.Ability is not ignored => * 1
            if (defender.Ability.Name == AbilityNames.FLUFFY && move.IsContactMove && attacker.Ability.Name != AbilityNames.LONGREACH) mod *= 0.5m;
            // Punk Rock
            if (defender.Ability.Name == AbilityNames.PUNKROCK && move.IsSoundMove && attacker.Ability.Name != AbilityNames.MOLDBREAKER && attacker.Ability.Name != AbilityNames.TURBOBLAZE && attacker.Ability.Name != AbilityNames.TERAVOLT) mod *= 0.5m;
            // Ice Scales => TODO: if defender.Ability is not ignored => * 1
            if (defender.Ability.Name == AbilityNames.ICESCALES && move.Category == MoveCategory.Special) mod *= 0.5m;
            // Friend Guard => TODO if ally has it => * 0.75;
            if (defender.Ability.Name == AbilityNames.FRIENDGUARD) { }
            // Reduced Damage from supereffective moves => TODO: if defender.Ability is not ignored => * 1 (unless Prism Armor which cant be ignored)
            if (defender.Ability.Name == AbilityNames.FILTER && GetEffMod(defender, move) > 1) mod *= 0.75m;
            if (defender.Ability.Name == AbilityNames.SOLIDROCK && GetEffMod(defender, move) > 1) mod *= 0.75m;
            if (defender.Ability.Name == AbilityNames.PRISMARMOR && GetEffMod(defender, move) > 1) mod *= 0.75m;
            // Neuroforce
            if (attacker.Ability.Name == AbilityNames.NEUROFORCE && GetEffMod(defender, move) > 1) mod *= 1.25m;
            // Sniper does 1.5 * extra damage on crit (todo)
            // Tinted Lens
            if (attacker.Ability.Name == AbilityNames.TINTEDLENS && GetEffMod(defender, move) < 1) mod *= 2;
            // Fluffy again TODO: if defender.Ability is not ignored => * 1
            if (defender.Ability.Name == AbilityNames.FLUFFY && move.MoveType == PokemonType.Fire) mod *= 2;
            // Berries
            mod *= GetBerryMod(defender.HeldItem, move.MoveType, GetEffMod(defender, move), defender.Ability.Name == AbilityNames.RIPEN);
            // Expert Belt
            if (attacker.HeldItem.Name == ItemNames.EXPERTBELT && GetEffMod(defender, move) > 1) mod *= 1.2m;
            // Life Orb
            if (attacker.HeldItem.Name == ItemNames.LIFEORB) mod *= 1.3m;
            // Metronome => TODO
            return mod;
        }
        private static decimal GetZMod()
        {
            return 1; // TODO
        }
        public static int CalculateDamage(Battle battle, Pokemon attacker, Pokemon defender, Move move)
        {
            if (move.Category == MoveCategory.Status) return 0;
            decimal power = GetMovePower(battle, attacker, defender, move);
            int attack = GetAttack(attacker, move);
            int defense = GetDefense(defender, move);
            decimal targetMod = GetTargetMod(battle, move);
            decimal parentalBondMod = 1; // TODO
            decimal weatherMod = GetWeatherMod(battle, move);
            decimal critMod = GetCritMod(attacker, move);
            decimal randMod = GetRandMod();
            decimal stabMod = GetStabMod(attacker, move);
            decimal effMod = GetEffMod(defender, move);
            decimal burnMod = GetBurnMod(attacker, move);
            decimal otherMod = GetOtherMod(battle, attacker, defender, move);
            decimal zMoveMod = GetZMod();
            return (int)Math.Floor(Math.Floor(Math.Floor(attacker.Level * 0.4m + 2) * power * attack / (defense * 50) + 2) * targetMod * parentalBondMod * weatherMod * critMod * randMod * stabMod * effMod * burnMod * otherMod * zMoveMod);
        }
        private static double CalculateNatureMod(Pokemon pokemon, Stat stat)
        {
            return 1; // TODO
        }
        public static int CalculateStat(Pokemon pokemon, Stat stat)
        {
            switch (stat)
            {
                case Stat.HP:
                    return (int)Math.Floor((2 * pokemon.BaseStats.HP + pokemon.IVs.HP + (pokemon.EVs.HP / 4)) * pokemon.Level / 100) + pokemon.Level + 10;
                case Stat.Attack:
                    return (int)Math.Floor((int)Math.Floor((2 * pokemon.BaseStats.Attack + pokemon.IVs.Attack + (pokemon.EVs.Attack / 4)) * pokemon.Level / 100) + 5 * CalculateNatureMod(pokemon, stat));
                case Stat.Defense:
                    return (int)Math.Floor((int)Math.Floor((2 * pokemon.BaseStats.Defense + pokemon.IVs.Defense + (pokemon.EVs.Defense / 4)) * pokemon.Level / 100) + 5 * CalculateNatureMod(pokemon, stat));
                case Stat.SpecialAttack:
                    return (int)Math.Floor((int)Math.Floor((2 * pokemon.BaseStats.SpecialAttack + pokemon.IVs.SpecialAttack + (pokemon.EVs.SpecialAttack / 4)) * pokemon.Level / 100) + 5 * CalculateNatureMod(pokemon, stat));
                case Stat.SpecialDefense:
                    return (int)Math.Floor((int)Math.Floor((2 * pokemon.BaseStats.SpecialDefense + pokemon.IVs.SpecialDefense + (pokemon.EVs.SpecialDefense / 4)) * pokemon.Level / 100) + 5 * CalculateNatureMod(pokemon, stat));
                case Stat.Speed:
                    return (int)Math.Floor((int)Math.Floor((2 * pokemon.BaseStats.Speed + pokemon.IVs.Speed + (pokemon.EVs.Speed / 4)) * pokemon.Level / 100) + 5 * CalculateNatureMod(pokemon, stat));
            }
            throw new InvalidStatException(stat);
        }
        public static double CalculateStatStageMod(int value)
        {
            return 1;
        }
    }
}
