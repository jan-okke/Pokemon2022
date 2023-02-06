using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gible : Pokemon
	{
		public override string Name => "Gible";
		public override int Generation => 4;
		public override string PokedexEntry => "It nests in small, horizontal holes in cave walls. It pounces to catch prey that stray too close.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RoughSkin;
		public override Stats BaseStats => new Stats() {
			HP = 58,
			Attack = 70,
			Defense = 45,
			SpecialAttack = 40,
			SpecialDefense = 45,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SandTomb, MoveFactory.Tackle, },
			[6] = new List<Move>() { MoveFactory.SandAttack, },
			[12] = new List<Move>() { MoveFactory.DragonBreath, },
			[18] = new List<Move>() { MoveFactory.Bulldoze, },
			[25] = new List<Move>() { MoveFactory.Bite, },
			[30] = new List<Move>() { MoveFactory.Slash, },
			[36] = new List<Move>() { MoveFactory.DragonClaw, },
			[42] = new List<Move>() { MoveFactory.Dig, },
			[48] = new List<Move>() { MoveFactory.Sandstorm, },
			[54] = new List<Move>() { MoveFactory.TakeDown, },
			[60] = new List<Move>() { MoveFactory.DragonRush, },
		};
	}
}
