using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rhydon : Pokemon
	{
		public override string Name => "Rhydon";
		public override int Generation => 1;
		public override string PokedexEntry => "Its horn, which rotates like a drill, destroys tall buildings with one strike. It stands on its hind legs, and its brain is well developed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LightningRod, AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 105,
			Attack = 130,
			Defense = 120,
			SpecialAttack = 45,
			SpecialDefense = 45,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.HammerArm, },
			[1] = new List<Move>() { MoveFactory.HammerArm, MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.SmackDown, MoveFactory.Bulldoze, },
			[15] = new List<Move>() { MoveFactory.HornAttack, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.Stomp, },
			[30] = new List<Move>() { MoveFactory.RockBlast, },
			[35] = new List<Move>() { MoveFactory.DrillRun, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[47] = new List<Move>() { MoveFactory.Earthquake, },
			[54] = new List<Move>() { MoveFactory.StoneEdge, },
			[61] = new List<Move>() { MoveFactory.Megahorn, },
			[68] = new List<Move>() { MoveFactory.HornDrill, },
		};
	}
}
