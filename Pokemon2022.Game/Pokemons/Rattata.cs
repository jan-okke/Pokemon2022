using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rattata : Pokemon
	{
		public override string Name => "Rattata";
		public override int Generation => 1;
		public override string PokedexEntry => "A Rattata is cautious in the extreme. Even while it is asleep, it constantly moves its ears and listens for danger. It will make its nest anywhere.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 56,
			Defense = 35,
			SpecialAttack = 25,
			SpecialDefense = 35,
			Speed = 72
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.QuickAttack, },
			[7] = new List<Move>() { MoveFactory.FocusEnergy, },
			[10] = new List<Move>() { MoveFactory.Bite, },
			[13] = new List<Move>() { MoveFactory.LaserFocus, },
			[16] = new List<Move>() { MoveFactory.TakeDown, },
			[19] = new List<Move>() { MoveFactory.Assurance, },
			[22] = new List<Move>() { MoveFactory.Crunch, },
			[25] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.SuperFang, },
			[31] = new List<Move>() { MoveFactory.DoubleEdge, },
			[34] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}
