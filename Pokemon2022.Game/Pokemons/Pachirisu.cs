using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pachirisu : Pokemon
	{
		public override string Name => "Pachirisu";
		public override int Generation => 4;
		public override string PokedexEntry => "It makes fur balls that crackle with static electricity. It stores them with berries in tree holes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.Pickup, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VoltAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 45,
			Defense = 70,
			SpecialAttack = 45,
			SpecialDefense = 90,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.BabyDollEyes, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.Charm, },
			[13] = new List<Move>() { MoveFactory.Spark, },
			[17] = new List<Move>() { MoveFactory.Endure, },
			[19] = new List<Move>() { MoveFactory.Nuzzle, },
			[21] = new List<Move>() { MoveFactory.Swift, },
			[25] = new List<Move>() { MoveFactory.ElectroBall, },
			[29] = new List<Move>() { MoveFactory.SweetKiss, },
			[33] = new List<Move>() { MoveFactory.ThunderWave, },
			[37] = new List<Move>() { MoveFactory.SuperFang, },
			[41] = new List<Move>() { MoveFactory.Discharge, },
			[45] = new List<Move>() { MoveFactory.LastResort, },
			[49] = new List<Move>() { MoveFactory.Thunder, },
		};
	}
}
