using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Turtwig : Pokemon
	{
		public override string Name => "Turtwig";
		public override int Generation => 4;
		public override string PokedexEntry => "Made from soil, the shell on its back hardens when it drinks water. It lives along lakes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShellArmor;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 68,
			Defense = 64,
			SpecialAttack = 45,
			SpecialDefense = 55,
			Speed = 31
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.Withdraw, },
			[6] = new List<Move>() { MoveFactory.Leafage, },
			[10] = new List<Move>() { MoveFactory.Growth, },
			[13] = new List<Move>() { MoveFactory.RazorLeaf, },
			[17] = new List<Move>() { MoveFactory.Curse, },
			[21] = new List<Move>() { MoveFactory.Bite, },
			[25] = new List<Move>() { MoveFactory.MegaDrain, },
			[29] = new List<Move>() { MoveFactory.LeechSeed, },
			[33] = new List<Move>() { MoveFactory.Synthesis, },
			[37] = new List<Move>() { MoveFactory.Crunch, },
			[41] = new List<Move>() { MoveFactory.GigaDrain, },
			[45] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}
