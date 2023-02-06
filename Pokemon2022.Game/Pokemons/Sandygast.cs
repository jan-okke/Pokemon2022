using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sandygast : Pokemon
	{
		public override string Name => "Sandygast";
		public override int Generation => 7;
		public override string PokedexEntry => "It likes the shovel on its head, so Sandygast will get serious and fight any children who come to take it back.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterCompaction, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 55,
			Defense = 80,
			SpecialAttack = 70,
			SpecialDefense = 45,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.Astonish, },
			[10] = new List<Move>() { MoveFactory.SandTomb, },
			[15] = new List<Move>() { MoveFactory.MegaDrain, },
			[20] = new List<Move>() { MoveFactory.SandAttack, },
			[25] = new List<Move>() { MoveFactory.Bulldoze, },
			[30] = new List<Move>() { MoveFactory.Hypnosis, },
			[35] = new List<Move>() { MoveFactory.GigaDrain, },
			[40] = new List<Move>() { MoveFactory.IronDefense, },
			[45] = new List<Move>() { MoveFactory.ShadowBall, },
			[50] = new List<Move>() { MoveFactory.EarthPower, },
			[55] = new List<Move>() { MoveFactory.ShoreUp, },
			[60] = new List<Move>() { MoveFactory.Sandstorm, },
		};
	}
}
