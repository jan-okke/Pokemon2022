using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Eelektrik : Pokemon
	{
		public override string Name => "Eelektrik";
		public override int Generation => 5;
		public override string PokedexEntry => "These Pokémon have a big appetite. When they spot their prey, they attack it and paralyze it with electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 85,
			Defense = 70,
			SpecialAttack = 75,
			SpecialDefense = 70,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Crunch, },
			[1] = new List<Move>() { MoveFactory.Crunch, MoveFactory.Headbutt, MoveFactory.ThunderWave, MoveFactory.Spark, MoveFactory.ChargeBeam, },
			[9] = new List<Move>() { MoveFactory.Bind, },
			[19] = new List<Move>() { MoveFactory.Acid, },
			[29] = new List<Move>() { MoveFactory.Discharge, },
			[44] = new List<Move>() { MoveFactory.Thunderbolt, },
			[49] = new List<Move>() { MoveFactory.AcidSpray, },
			[54] = new List<Move>() { MoveFactory.Coil, },
			[59] = new List<Move>() { MoveFactory.WildCharge, },
			[64] = new List<Move>() { MoveFactory.GastroAcid, },
			[69] = new List<Move>() { MoveFactory.ZapCannon, },
			[74] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}
