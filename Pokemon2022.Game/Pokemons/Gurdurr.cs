using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gurdurr : Pokemon
	{
		public override string Name => "Gurdurr";
		public override int Generation => 5;
		public override string PokedexEntry => "They strengthen their bodies by carrying steel beams. They show off their big muscles to their friends.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IronFist;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 105,
			Defense = 85,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Leer, MoveFactory.LowKick, MoveFactory.RockThrow, },
			[12] = new List<Move>() { MoveFactory.FocusEnergy, },
			[16] = new List<Move>() { MoveFactory.BulkUp, },
			[20] = new List<Move>() { MoveFactory.RockSlide, },
			[24] = new List<Move>() { MoveFactory.Slam, },
			[30] = new List<Move>() { MoveFactory.ScaryFace, },
			[36] = new List<Move>() { MoveFactory.DynamicPunch, },
			[42] = new List<Move>() { MoveFactory.HammerArm, },
			[48] = new List<Move>() { MoveFactory.StoneEdge, },
			[54] = new List<Move>() { MoveFactory.Superpower, },
			[60] = new List<Move>() { MoveFactory.FocusPunch, },
		};
	}
}
