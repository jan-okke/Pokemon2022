using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Thwackey : Pokemon
	{
		public override string Name => "Thwackey";
		public override int Generation => 8;
		public override string PokedexEntry => "When it's drumming out rapid beats in battle, it gets so caught up in the rhythm that it won't even notice that it's already knocked out its opponent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.GrassySurge;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 85,
			Defense = 70,
			SpecialAttack = 55,
			SpecialDefense = 60,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DoubleHit, },
			[1] = new List<Move>() { MoveFactory.DoubleHit, MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.BranchPoke, MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[19] = new List<Move>() { MoveFactory.Screech, },
			[24] = new List<Move>() { MoveFactory.KnockOff, },
			[30] = new List<Move>() { MoveFactory.Slam, },
			[36] = new List<Move>() { MoveFactory.Uproar, },
			[42] = new List<Move>() { MoveFactory.WoodHammer, },
			[48] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}
