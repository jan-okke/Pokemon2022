using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Grotle : Pokemon
	{
		public override string Name => "Grotle";
		public override int Generation => 4;
		public override string PokedexEntry => "It lives along water in forests. In the daytime, it leaves the forest to sunbathe its treed shell.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShellArmor;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 89,
			Defense = 85,
			SpecialAttack = 55,
			SpecialDefense = 65,
			Speed = 36
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Withdraw, MoveFactory.Absorb, },
			[5] = new List<Move>() { MoveFactory.Withdraw, },
			[6] = new List<Move>() { MoveFactory.Leafage, },
			[10] = new List<Move>() { MoveFactory.Growth, },
			[13] = new List<Move>() { MoveFactory.RazorLeaf, },
			[17] = new List<Move>() { MoveFactory.Curse, },
			[22] = new List<Move>() { MoveFactory.Bite, },
			[27] = new List<Move>() { MoveFactory.MegaDrain, },
			[32] = new List<Move>() { MoveFactory.LeechSeed, },
			[37] = new List<Move>() { MoveFactory.Synthesis, },
			[42] = new List<Move>() { MoveFactory.Crunch, },
			[47] = new List<Move>() { MoveFactory.GigaDrain, },
			[52] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}
