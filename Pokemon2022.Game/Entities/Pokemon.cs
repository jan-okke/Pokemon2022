using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Pokemon2022.Game.Entities
{
    public class Pokemon
    {
        public string Name;
        public Stats BaseStats;
        public PokemonType[] Types;
        public List<Ability> AvailableAbilities;
        public Ability AvailableHiddenAbility;
        public string PokedexEntry;
        public Dictionary<int, List<Move>> LevelUpLearnset;

        public string? Nickname;
        public bool IsAlive;
        public bool IsDynamaxed;
        public bool IsMinimized;
        public bool IsUnderground;
        public bool IsUnderwater;

        public int CurrentHP;
        public PokemonStatus Status;
        public List<Move> Moves;
        public Ability Ability;
        public int Level;
        public int Experience;
        public Stats IVs;
        public Stats EVs;
        public Stats Stats;
        public Stats StatStages;
        public Item HeldItem;
        public PokemonGender Gender;
        public PokemonNature Nature;

        public BitmapImage BackSprite;
        public BitmapImage FrontSprite;
        public Pokemon()
        {
            Name = string.Empty;
            Nickname = null;
            PokedexEntry = string.Empty;
            BaseStats = new Stats();
            Types = new PokemonType[2];
            AvailableAbilities = new List<Ability>();
            AvailableHiddenAbility = new Ability();
            LevelUpLearnset = new();

            Status = new PokemonStatus();
            Moves = new List<Move>();
            Ability = new Ability();
            IVs = new Stats();
            EVs = new Stats();
            Stats = new Stats();
            StatStages = new Stats();
            HeldItem = new Item();
            Gender = PokemonGender.Genderless;
            Nature = PokemonNature.None;

            BackSprite = new BitmapImage();
            FrontSprite = new BitmapImage();

            IsAlive = true;
            IsDynamaxed = false;
            IsMinimized = false;
            IsUnderground = false;
            IsUnderwater = false;
        }
        public void CalculateStats()
        {
            Stats.HP = Calculations.CalculateStat(this, Stat.HP);
            Stats.Attack = Calculations.CalculateStat(this, Stat.Attack);
            Stats.Defense = Calculations.CalculateStat(this, Stat.Defense);
            Stats.SpecialAttack = Calculations.CalculateStat(this, Stat.SpecialAttack);
            Stats.SpecialDefense = Calculations.CalculateStat(this, Stat.SpecialDefense);
            Stats.Speed = Calculations.CalculateStat(this, Stat.Speed);
        }
        public Pokemon Clone()
        {
            return new Pokemon()
            {
                Name = Name,
                Nickname = Nickname,
                BaseStats = BaseStats,
                Types = Types,
                AvailableAbilities = AvailableAbilities,
                AvailableHiddenAbility = AvailableHiddenAbility,
                PokedexEntry = PokedexEntry,
                LevelUpLearnset = LevelUpLearnset,

                IsAlive = IsAlive,
                IsDynamaxed = IsDynamaxed,
                IsMinimized = IsMinimized,
                IsUnderground = IsUnderground,
                IsUnderwater = IsUnderwater,

                CurrentHP = CurrentHP,
                Status = Status,
                Moves = Moves,
                Ability = Ability,
                Level = Level,
                Experience = Experience,
                IVs = IVs,
                EVs = EVs,
                Stats = Stats,
                StatStages = StatStages,
                HeldItem = HeldItem,
                Gender = Gender,
                Nature = Nature,

                BackSprite = BackSprite,
                FrontSprite = FrontSprite
            };
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
