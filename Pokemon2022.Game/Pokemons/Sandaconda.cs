using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sandaconda : Pokemon
	{
		public override string Name => "Sandaconda";
		public override int Generation => 8;
		public override string PokedexEntry => "Its unique style of coiling allows it to blast sand out of its sand sac more efficiently.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandSpit, AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 107,
			Defense = 125,
			SpecialAttack = 65,
			SpecialDefense = 70,
			Speed = 71
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SkullBash, MoveFactory.Wrap, MoveFactory.SandAttack, MoveFactory.Minimize, MoveFactory.BrutalSwing, },
			[15] = new List<Move>() { MoveFactory.Bulldoze, },
			[20] = new List<Move>() { MoveFactory.Headbutt, },
			[25] = new List<Move>() { MoveFactory.Glare, },
			[30] = new List<Move>() { MoveFactory.Dig, },
			[35] = new List<Move>() { MoveFactory.Sandstorm, },
			[42] = new List<Move>() { MoveFactory.Slam, },
			[49] = new List<Move>() { MoveFactory.Coil, },
			[51] = new List<Move>() { MoveFactory.SandTomb, },
		};
	}
}
