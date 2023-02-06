using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hydreigon : Pokemon
	{
		public override string Name => "Hydreigon";
		public override int Generation => 5;
		public override string PokedexEntry => "The heads on their arms do not have brains. They use all three heads to consume and destroy everything.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 92,
			Attack = 105,
			Defense = 90,
			SpecialAttack = 125,
			SpecialDefense = 90,
			Speed = 98
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.DoubleHit, MoveFactory.TriAttack, MoveFactory.FocusEnergy, MoveFactory.DragonBreath, MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.Roar, },
			[16] = new List<Move>() { MoveFactory.Assurance, },
			[20] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.WorkUp, },
			[28] = new List<Move>() { MoveFactory.Slam, },
			[32] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.ScaryFace, },
			[40] = new List<Move>() { MoveFactory.DragonPulse, },
			[44] = new List<Move>() { MoveFactory.BodySlam, },
			[48] = new List<Move>() { MoveFactory.HyperVoice, },
			[54] = new List<Move>() { MoveFactory.DragonRush, },
			[60] = new List<Move>() { MoveFactory.NastyPlot, },
			[68] = new List<Move>() { MoveFactory.Outrage, },
			[76] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
