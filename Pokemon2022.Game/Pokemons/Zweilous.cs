using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zweilous : Pokemon
	{
		public override string Name => "Zweilous";
		public override int Generation => 5;
		public override string PokedexEntry => "Since their two heads do not get along and compete with each other for food, they always eat too much.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hustle, };
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 85,
			Defense = 70,
			SpecialAttack = 65,
			SpecialDefense = 70,
			Speed = 58
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.DoubleHit, MoveFactory.FocusEnergy, MoveFactory.DragonBreath, MoveFactory.Bite, },
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
			[66] = new List<Move>() { MoveFactory.Outrage, },
		};
	}
}
