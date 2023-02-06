using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Boltund : Pokemon
	{
		public override string Name => "Boltund";
		public override int Generation => 8;
		public override string PokedexEntry => "This Pokémon generates electricity and channels it into its legs to keep them going strong. Boltund can run nonstop for three full days.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.StrongJaw, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Competitive;
		public override Stats BaseStats => new Stats() {
			HP = 69,
			Attack = 90,
			Defense = 60,
			SpecialAttack = 90,
			SpecialDefense = 60,
			Speed = 121
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Electrify, MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.Nuzzle, MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.Roar, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[28] = new List<Move>() { MoveFactory.Charm, },
			[34] = new List<Move>() { MoveFactory.Crunch, },
			[41] = new List<Move>() { MoveFactory.Charge, },
			[48] = new List<Move>() { MoveFactory.WildCharge, },
			[55] = new List<Move>() { MoveFactory.PlayRough, },
			[62] = new List<Move>() { MoveFactory.ElectricTerrain, },
		};
	}
}
