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
        public virtual string Name { get; }
        public virtual Stats BaseStats { get; }
        public virtual PokemonType[] Types { get; }
        public virtual List<Ability> AvailableAbilities { get; }
        public virtual Ability AvailableHiddenAbility { get; }
        
        public virtual string PokedexEntry { get; }
        public virtual int Generation { get; }
        public virtual Dictionary<int, List<Move>> LevelUpLearnset { get; }

        public string? Nickname;
        public bool IsAlive;
        public bool IsDynamaxed;
        public bool IsMinimized;
        public bool IsUnderground;
        public bool IsUnderwater;

        public int CurrentHP;
        public PokemonStatus Status;
        public int StatusTurn;
        public List<PokemonStatusSecondary> SecondaryStatusList;
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

        public int DynamaxTurns;

        public BitmapImage BackSprite;
        public BitmapImage FrontSprite;
        public static T NewPokemon<T>(string name)
        {
            name = "Pokemon2022.Game.Pokemons." + name;
            Type? t = Type.GetType(name);
            if (t is null) throw new ArgumentException(null, nameof(name));
            object? obj = Activator.CreateInstance(t);
            if (obj is null) throw new NotImplementedException();
            return (T)obj;
        }
        public static Pokemon NewPokemon(string name)
        {
            name = "Pokemon2022.Game.Pokemons." + name;
            Type? t = Type.GetType(name);
            if (t is null) throw new ArgumentException(null, nameof(name));
            object? obj = Activator.CreateInstance(t);
            if (obj is null) throw new NotImplementedException();
            return (Pokemon)obj;
        }
        public Pokemon()
        {
            Status = new PokemonStatus();
            StatusTurn = 0;
            SecondaryStatusList = new List<PokemonStatusSecondary>();
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

            DynamaxTurns = 0;
        }

        public Pokemon Clone()
        {
            return this.Copy();
        }

        //public Pokemon()
        //{
        //    Name = string.Empty;
        //    Nickname = null;
        //    PokedexEntry = string.Empty;
        //    BaseStats = new Stats();
        //    Types = new PokemonType[2];
        //    AvailableAbilities = new List<Ability>();
        //    AvailableHiddenAbility = new Ability();
        //    LevelUpLearnset = new();

        //    Status = new PokemonStatus();
        //    StatusTurn = 0;
        //    SecondaryStatusList = new List<PokemonStatusSecondary>();
        //    Moves = new List<Move>();
        //    Ability = new Ability();
        //    IVs = new Stats();
        //    EVs = new Stats();
        //    Stats = new Stats();
        //    StatStages = new Stats();
        //    HeldItem = new Item();
        //    Gender = PokemonGender.Genderless;
        //    Nature = PokemonNature.None;

        //    BackSprite = new BitmapImage();
        //    FrontSprite = new BitmapImage();

        //    IsAlive = true;
        //    IsDynamaxed = false;
        //    IsMinimized = false;
        //    IsUnderground = false;
        //    IsUnderwater = false;

        //    DynamaxTurns = 0;
        //}
        //public Pokemon Clone()
        //{
        //    return new Pokemon()
        //    {
        //        //Name = Name,
        //        //Nickname = Nickname,
        //        //BaseStats = BaseStats,
        //        //Types = Types,
        //        //AvailableAbilities = AvailableAbilities,
        //        //AvailableHiddenAbility = AvailableHiddenAbility,
        //        //PokedexEntry = PokedexEntry,
        //        //Generation= Generation,
        //        //LevelUpLearnset = LevelUpLearnset,

        //        //IsAlive = IsAlive,
        //        //IsDynamaxed = IsDynamaxed,
        //        //IsMinimized = IsMinimized,
        //        //IsUnderground = IsUnderground,
        //        //IsUnderwater = IsUnderwater,

        //        //DynamaxTurns = DynamaxTurns,

        //        //CurrentHP = CurrentHP,
        //        //Status = Status,
        //        //StatusTurn = StatusTurn,
        //        //SecondaryStatusList = SecondaryStatusList,
        //        //Moves = Moves,
        //        //Ability = Ability,
        //        //Level = Level,
        //        //Experience = Experience,
        //        //IVs = IVs,
        //        //EVs = EVs,
        //        //Stats = Stats,
        //        //StatStages = StatStages,
        //        //HeldItem = HeldItem,
        //        //Gender = Gender,
        //        //Nature = Nature,

        //        //BackSprite = BackSprite,
        //        //FrontSprite = FrontSprite
        //    };
        //}
        public override string ToString() => Name;
    }
}
