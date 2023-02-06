using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cottonee : Pokemon
	{
		public override string Name => "Cottonee";
		public override int Generation => 5;
		public override string PokedexEntry => "They go wherever the wind takes them. On rainy days, their bodies are heavier, so they take shelter beneath big trees.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Prankster, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Chlorophyll;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 27,
			Defense = 60,
			SpecialAttack = 37,
			SpecialDefense = 50,
			Speed = 66
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.HelpingHand, },
			[3] = new List<Move>() { MoveFactory.FairyWind, },
			[6] = new List<Move>() { MoveFactory.StunSpore, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[18] = new List<Move>() { MoveFactory.Growth, },
			[21] = new List<Move>() { MoveFactory.PoisonPowder, },
			[24] = new List<Move>() { MoveFactory.GigaDrain, },
			[27] = new List<Move>() { MoveFactory.Charm, },
			[30] = new List<Move>() { MoveFactory.LeechSeed, },
			[33] = new List<Move>() { MoveFactory.CottonSpore, },
			[36] = new List<Move>() { MoveFactory.EnergyBall, },
			[39] = new List<Move>() { MoveFactory.SunnyDay, },
			[42] = new List<Move>() { MoveFactory.Endeavor, },
			[45] = new List<Move>() { MoveFactory.CottonGuard, },
			[48] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}
