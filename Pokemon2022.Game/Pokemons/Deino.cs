using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Deino : Pokemon
	{
		public override string Name => "Deino";
		public override int Generation => 5;
		public override string PokedexEntry => "They cannot see, so they tackle and bite to learn about their surroundings. Their bodies are covered in wounds.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hustle, };
		public override Stats BaseStats => new Stats() {
			HP = 52,
			Attack = 65,
			Defense = 50,
			SpecialAttack = 45,
			SpecialDefense = 50,
			Speed = 38
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.FocusEnergy, },
			[4] = new List<Move>() { MoveFactory.DragonBreath, },
			[8] = new List<Move>() { MoveFactory.Bite, },
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
			[52] = new List<Move>() { MoveFactory.DragonRush, },
			[56] = new List<Move>() { MoveFactory.NastyPlot, },
			[60] = new List<Move>() { MoveFactory.Outrage, },
		};
	}
}
