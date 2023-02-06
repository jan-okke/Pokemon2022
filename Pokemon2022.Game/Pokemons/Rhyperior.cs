using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rhyperior : Pokemon
	{
		public override string Name => "Rhyperior";
		public override int Generation => 4;
		public override string PokedexEntry => "It puts rocks in holes in its palms and uses its muscles to shoot them. Geodude are shot at rare times.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LightningRod, AbilityFactory.SolidRock, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 115,
			Attack = 140,
			Defense = 130,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
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
			[75] = new List<Move>() { MoveFactory.RockWrecker, },
		};
	}
}
