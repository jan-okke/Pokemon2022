using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Alomomola : Pokemon
	{
		public override string Name => "Alomomola";
		public override int Generation => 5;
		public override string PokedexEntry => "Floating in the open sea is how they live. When they find a wounded Pokémon, they embrace it and bring it to shore.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Healer, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 165,
			Attack = 75,
			Defense = 80,
			SpecialAttack = 40,
			SpecialDefense = 45,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PlayNice, MoveFactory.HydroPump, MoveFactory.WideGuard, MoveFactory.HealingWish, MoveFactory.HelpingHand, MoveFactory.Pound, MoveFactory.WaterSport, },
			[5] = new List<Move>() { MoveFactory.AquaRing, },
			[9] = new List<Move>() { MoveFactory.AquaJet, },
			[13] = new List<Move>() { MoveFactory.DoubleSlap, },
			[17] = new List<Move>() { MoveFactory.HealPulse, },
			[21] = new List<Move>() { MoveFactory.Protect, },
			[25] = new List<Move>() { MoveFactory.WaterPulse, },
			[29] = new List<Move>() { MoveFactory.WakeUpSlap, },
			[33] = new List<Move>() { MoveFactory.Soak, },
			[37] = new List<Move>() { MoveFactory.Wish, },
			[41] = new List<Move>() { MoveFactory.Brine, },
			[45] = new List<Move>() { MoveFactory.Safeguard, },
			[49] = new List<Move>() { MoveFactory.Whirlpool, },
			[53] = new List<Move>() { MoveFactory.HelpingHand, },
			[57] = new List<Move>() { MoveFactory.HealingWish, },
			[61] = new List<Move>() { MoveFactory.WideGuard, },
			[65] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
