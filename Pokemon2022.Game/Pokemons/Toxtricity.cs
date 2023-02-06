using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Toxtricity : Pokemon
	{
		public override string Name => "Toxtricity";
		public override int Generation => 8;
		public override string PokedexEntry => "When this Pokémon sounds as if it's strumming a guitar, it's actually clawing at the protrusions on its chest to generate electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PunkRock, AbilityFactory.Plus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Technician;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 98,
			Defense = 70,
			SpecialAttack = 114,
			SpecialDefense = 70,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Spark, },
			[1] = new List<Move>() { MoveFactory.Spark, MoveFactory.EerieImpulse, MoveFactory.Belch, MoveFactory.TearfulLook, MoveFactory.Nuzzle, MoveFactory.Growl, MoveFactory.Flail, MoveFactory.Acid, MoveFactory.ThunderShock, MoveFactory.AcidSpray, MoveFactory.Leer, MoveFactory.NobleRoar, },
			[4] = new List<Move>() { MoveFactory.Charge, },
			[8] = new List<Move>() { MoveFactory.ShockWave, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[16] = new List<Move>() { MoveFactory.Taunt, },
			[20] = new List<Move>() { MoveFactory.Venoshock, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.Swagger, },
			[32] = new List<Move>() { MoveFactory.Toxic, },
			[36] = new List<Move>() { MoveFactory.Discharge, },
			[40] = new List<Move>() { MoveFactory.PoisonJab, },
			[44] = new List<Move>() { MoveFactory.Overdrive, },
			[48] = new List<Move>() { MoveFactory.Boomburst, },
			[52] = new List<Move>() { MoveFactory.ShiftGear, },
		};
	}
}
