using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sunkern : Pokemon
	{
		public override string Name => "Sunkern";
		public override int Generation => 2;
		public override string PokedexEntry => "Sunkern try to minimize movement to conserve the nutrients they have stored in their bodies for evolution. They will not eat, subsisting only on morning dew.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.SolarPower, };
		public override Ability AvailableHiddenAbility => AbilityFactory.EarlyBird;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 30,
			Defense = 30,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growth, },
			[4] = new List<Move>() { MoveFactory.Ingrain, },
			[7] = new List<Move>() { MoveFactory.Absorb, },
			[10] = new List<Move>() { MoveFactory.MegaDrain, },
			[13] = new List<Move>() { MoveFactory.LeechSeed, },
			[16] = new List<Move>() { MoveFactory.RazorLeaf, },
			[19] = new List<Move>() { MoveFactory.WorrySeed, },
			[22] = new List<Move>() { MoveFactory.GigaDrain, },
			[25] = new List<Move>() { MoveFactory.Endeavor, },
			[28] = new List<Move>() { MoveFactory.Synthesis, },
			[34] = new List<Move>() { MoveFactory.SolarBeam, },
			[37] = new List<Move>() { MoveFactory.DoubleEdge, },
			[40] = new List<Move>() { MoveFactory.SunnyDay, },
			[43] = new List<Move>() { MoveFactory.SeedBomb, },
		};
	}
}
