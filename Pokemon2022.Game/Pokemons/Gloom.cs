using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gloom : Pokemon
	{
		public override string Name => "Gloom";
		public override int Generation => 1;
		public override string PokedexEntry => "A horribly noxious honey drools from its mouth. One whiff of the honey can result in memory loss. Some fans are said to enjoy this overwhelming stink, however.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Stench;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 65,
			Defense = 70,
			SpecialAttack = 85,
			SpecialDefense = 75,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Growth, MoveFactory.Acid, MoveFactory.SweetScent, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[14] = new List<Move>() { MoveFactory.PoisonPowder, },
			[16] = new List<Move>() { MoveFactory.StunSpore, },
			[18] = new List<Move>() { MoveFactory.SleepPowder, },
			[20] = new List<Move>() { MoveFactory.GigaDrain, },
			[26] = new List<Move>() { MoveFactory.Toxic, },
			[32] = new List<Move>() { MoveFactory.Moonblast, },
			[38] = new List<Move>() { MoveFactory.GrassyTerrain, },
			[44] = new List<Move>() { MoveFactory.Moonlight, },
			[50] = new List<Move>() { MoveFactory.PetalDance, },
		};
	}
}
