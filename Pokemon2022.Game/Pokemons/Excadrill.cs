using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Excadrill : Pokemon
	{
		public override string Name => "Excadrill";
		public override int Generation => 5;
		public override string PokedexEntry => "More than 300 feet below the surface, they build mazelike nests. Their activity can be destructive to subway tunnels.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandRush, AbilityFactory.SandForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MoldBreaker;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 135,
			Defense = 60,
			SpecialAttack = 50,
			SpecialDefense = 65,
			Speed = 88
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.HornDrill, },
			[1] = new List<Move>() { MoveFactory.HornDrill, MoveFactory.MudSlap, MoveFactory.RapidSpin, MoveFactory.Scratch, MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.MetalClaw, },
			[20] = new List<Move>() { MoveFactory.Sandstorm, },
			[24] = new List<Move>() { MoveFactory.CrushClaw, },
			[28] = new List<Move>() { MoveFactory.RockSlide, },
			[34] = new List<Move>() { MoveFactory.Dig, },
			[40] = new List<Move>() { MoveFactory.SwordsDance, },
			[46] = new List<Move>() { MoveFactory.DrillRun, },
			[52] = new List<Move>() { MoveFactory.Earthquake, },
			[58] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}
