using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Floatzel : Pokemon
	{
		public override string Name => "Floatzel";
		public override int Generation => 4;
		public override string PokedexEntry => "It floats using its well-developed flotation sac. It assists in the rescues of drowning people.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterVeil;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 105,
			Defense = 55,
			SpecialAttack = 85,
			SpecialDefense = 50,
			Speed = 115
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.IceFang, MoveFactory.Crunch, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.QuickAttack, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.TailWhip, },
			[11] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.WaterGun, },
			[18] = new List<Move>() { MoveFactory.Bite, },
			[21] = new List<Move>() { MoveFactory.Swift, },
			[24] = new List<Move>() { MoveFactory.AquaJet, },
			[29] = new List<Move>() { MoveFactory.DoubleHit, },
			[35] = new List<Move>() { MoveFactory.Whirlpool, },
			[41] = new List<Move>() { MoveFactory.Waterfall, },
			[46] = new List<Move>() { MoveFactory.AquaTail, },
			[51] = new List<Move>() { MoveFactory.Agility, },
			[57] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
