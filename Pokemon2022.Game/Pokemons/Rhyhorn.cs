using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rhyhorn : Pokemon
	{
		public override string Name => "Rhyhorn";
		public override int Generation => 1;
		public override string PokedexEntry => "Once it starts running, it doesn't stop. Its tiny brain makes it so stupid that it can't remember why it started running in the first place.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LightningRod, AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 85,
			Defense = 95,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SmackDown, },
			[10] = new List<Move>() { MoveFactory.Bulldoze, },
			[15] = new List<Move>() { MoveFactory.HornAttack, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.Stomp, },
			[30] = new List<Move>() { MoveFactory.RockBlast, },
			[35] = new List<Move>() { MoveFactory.DrillRun, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[45] = new List<Move>() { MoveFactory.Earthquake, },
			[50] = new List<Move>() { MoveFactory.StoneEdge, },
			[55] = new List<Move>() { MoveFactory.Megahorn, },
			[60] = new List<Move>() { MoveFactory.HornDrill, },
		};
	}
}
