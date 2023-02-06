using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Porygon2 : Pokemon
	{
		public override string Name => "Porygon2";
		public override int Generation => 2;
		public override string PokedexEntry => "It was created by humans using the power of science. It has been given artificial intelligence that enables it to learn new gestures and emotions on its own.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Trace, AbilityFactory.Download, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 80,
			Defense = 90,
			SpecialAttack = 105,
			SpecialDefense = 95,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DefenseCurl, MoveFactory.Tackle, MoveFactory.Conversion, MoveFactory.Recycle, MoveFactory.MagnetRise, },
			[15] = new List<Move>() { MoveFactory.ThunderShock, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.Conversion2, },
			[30] = new List<Move>() { MoveFactory.Agility, },
			[35] = new List<Move>() { MoveFactory.Recover, },
			[40] = new List<Move>() { MoveFactory.Discharge, },
			[45] = new List<Move>() { MoveFactory.TriAttack, },
			[50] = new List<Move>() { MoveFactory.MagicCoat, },
			[55] = new List<Move>() { MoveFactory.LockOn, },
			[60] = new List<Move>() { MoveFactory.ZapCannon, },
			[65] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
