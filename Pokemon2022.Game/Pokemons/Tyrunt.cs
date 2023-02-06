using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tyrunt : Pokemon
	{
		public override string Name => "Tyrunt";
		public override int Generation => 6;
		public override string PokedexEntry => "Its immense jaws have enough destructive force that it can chew up an automobile. It lived 100 million years ago.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.StrongJaw, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sturdy;
		public override Stats BaseStats => new Stats() {
			HP = 58,
			Attack = 89,
			Defense = 77,
			SpecialAttack = 45,
			SpecialDefense = 45,
			Speed = 48
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.Roar, },
			[8] = new List<Move>() { MoveFactory.AncientPower, },
			[12] = new List<Move>() { MoveFactory.Charm, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.DragonTail, },
			[24] = new List<Move>() { MoveFactory.Stomp, },
			[28] = new List<Move>() { MoveFactory.RockSlide, },
			[32] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.DragonClaw, },
			[40] = new List<Move>() { MoveFactory.Thrash, },
			[44] = new List<Move>() { MoveFactory.Earthquake, },
			[48] = new List<Move>() { MoveFactory.HornDrill, },
		};
	}
}
