using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Arrokuda : Pokemon
	{
		public override string Name => "Arrokuda";
		public override int Generation => 8;
		public override string PokedexEntry => "If it sees any movement around it, this Pokémon charges for it straightaway, leading with its sharply pointed jaw. It's very proud of that jaw.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PropellerTail;
		public override Stats BaseStats => new Stats() {
			HP = 41,
			Attack = 63,
			Defense = 40,
			SpecialAttack = 40,
			SpecialDefense = 30,
			Speed = 66
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.AquaJet, },
			[6] = new List<Move>() { MoveFactory.FuryAttack, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.Agility, },
			[24] = new List<Move>() { MoveFactory.Dive, },
			[30] = new List<Move>() { MoveFactory.LaserFocus, },
			[36] = new List<Move>() { MoveFactory.Crunch, },
			[42] = new List<Move>() { MoveFactory.Liquidation, },
			[48] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
