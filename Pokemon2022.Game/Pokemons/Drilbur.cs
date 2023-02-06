using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drilbur : Pokemon
	{
		public override string Name => "Drilbur";
		public override int Generation => 5;
		public override string PokedexEntry => "It makes its way swiftly through the soil by putting both claws together and rotating at high speed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandRush, AbilityFactory.SandForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MoldBreaker;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 85,
			Defense = 40,
			SpecialAttack = 30,
			SpecialDefense = 45,
			Speed = 68
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.RapidSpin, },
			[4] = new List<Move>() { MoveFactory.Scratch, },
			[8] = new List<Move>() { MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.MetalClaw, },
			[20] = new List<Move>() { MoveFactory.Sandstorm, },
			[24] = new List<Move>() { MoveFactory.CrushClaw, },
			[28] = new List<Move>() { MoveFactory.RockSlide, },
			[32] = new List<Move>() { MoveFactory.Dig, },
			[36] = new List<Move>() { MoveFactory.SwordsDance, },
			[40] = new List<Move>() { MoveFactory.DrillRun, },
			[44] = new List<Move>() { MoveFactory.Earthquake, },
			[48] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}
