using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shiinotic : Pokemon
	{
		public override string Name => "Shiinotic";
		public override int Generation => 7;
		public override string PokedexEntry => "It puts its prey to sleep and siphons off their vitality through the tip of its arms. If one of its kind is weakened, it helps by sending it vitality.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Illuminate, AbilityFactory.EffectSpore, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 45,
			Defense = 80,
			SpecialAttack = 90,
			SpecialDefense = 100,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Astonish, MoveFactory.ConfuseRay, MoveFactory.Ingrain, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.SleepPowder, },
			[20] = new List<Move>() { MoveFactory.Moonlight, },
			[27] = new List<Move>() { MoveFactory.StrengthSap, },
			[32] = new List<Move>() { MoveFactory.GigaDrain, },
			[38] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[44] = new List<Move>() { MoveFactory.Spore, },
			[50] = new List<Move>() { MoveFactory.Moonblast, },
			[56] = new List<Move>() { MoveFactory.DreamEater, },
		};
	}
}
