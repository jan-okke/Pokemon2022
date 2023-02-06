using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sawsbuck : Pokemon
	{
		public override string Name => "Sawsbuck";
		public override int Generation => 5;
		public override string PokedexEntry => "The plants growing on its horns change according to the season. The leaders of the herd possess magnificent horns.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.SapSipper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SereneGrace;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 100,
			Defense = 70,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.HornLeech, },
			[1] = new List<Move>() { MoveFactory.HornLeech, MoveFactory.Megahorn, MoveFactory.Tackle, MoveFactory.Camouflage, MoveFactory.Growl, MoveFactory.SandAttack, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.DoubleKick, },
			[13] = new List<Move>() { MoveFactory.LeechSeed, },
			[16] = new List<Move>() { MoveFactory.FeintAttack, },
			[20] = new List<Move>() { MoveFactory.TakeDown, },
			[24] = new List<Move>() { MoveFactory.JumpKick, },
			[28] = new List<Move>() { MoveFactory.Aromatherapy, },
			[32] = new List<Move>() { MoveFactory.EnergyBall, },
			[36] = new List<Move>() { MoveFactory.Charm, },
			[44] = new List<Move>() { MoveFactory.NaturePower, },
			[52] = new List<Move>() { MoveFactory.DoubleEdge, },
			[60] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}
