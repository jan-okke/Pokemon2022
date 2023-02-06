using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Carracosta : Pokemon
	{
		public override string Name => "Carracosta";
		public override int Generation => 5;
		public override string PokedexEntry => "Incredible jaw strength enables them to chew up steel beams and rocks along with their prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SolidRock, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 74,
			Attack = 108,
			Defense = 133,
			SpecialAttack = 83,
			SpecialDefense = 65,
			Speed = 32
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Withdraw, MoveFactory.Protect, MoveFactory.AquaJet, },
			[9] = new List<Move>() { MoveFactory.SmackDown, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.WideGuard, },
			[21] = new List<Move>() { MoveFactory.Brine, },
			[24] = new List<Move>() { MoveFactory.RockSlide, },
			[27] = new List<Move>() { MoveFactory.Crunch, },
			[30] = new List<Move>() { MoveFactory.Curse, },
			[33] = new List<Move>() { MoveFactory.IronDefense, },
			[36] = new List<Move>() { MoveFactory.AquaTail, },
			[41] = new List<Move>() { MoveFactory.RainDance, },
			[46] = new List<Move>() { MoveFactory.HydroPump, },
			[51] = new List<Move>() { MoveFactory.ShellSmash, },
		};
	}
}
