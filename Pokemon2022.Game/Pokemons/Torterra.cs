using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Torterra : Pokemon
	{
		public override string Name => "Torterra";
		public override int Generation => 4;
		public override string PokedexEntry => "Small Pokémon occasionally gather on its unmoving back to begin building their nests.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShellArmor;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 109,
			Defense = 105,
			SpecialAttack = 75,
			SpecialDefense = 85,
			Speed = 56
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Earthquake, },
			[1] = new List<Move>() { MoveFactory.Earthquake, MoveFactory.WoodHammer, MoveFactory.Tackle, MoveFactory.Withdraw, MoveFactory.Absorb, MoveFactory.RazorLeaf, },
			[5] = new List<Move>() { MoveFactory.Withdraw, },
			[6] = new List<Move>() { MoveFactory.Leafage, },
			[10] = new List<Move>() { MoveFactory.Growth, },
			[13] = new List<Move>() { MoveFactory.RazorLeaf, },
			[17] = new List<Move>() { MoveFactory.Curse, },
			[22] = new List<Move>() { MoveFactory.Bite, },
			[27] = new List<Move>() { MoveFactory.MegaDrain, },
			[33] = new List<Move>() { MoveFactory.LeechSeed, },
			[39] = new List<Move>() { MoveFactory.Synthesis, },
			[45] = new List<Move>() { MoveFactory.Crunch, },
			[51] = new List<Move>() { MoveFactory.GigaDrain, },
			[57] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}
