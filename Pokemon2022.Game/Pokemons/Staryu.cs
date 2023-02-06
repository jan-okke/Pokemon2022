using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Staryu : Pokemon
	{
		public override string Name => "Staryu";
		public override int Generation => 1;
		public override string PokedexEntry => "It gathers with others in the night and makes its red core glow on and off with the twinkling stars. It can regenerate limbs if they are severed from its body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Illuminate, AbilityFactory.NaturalCure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 45,
			Defense = 55,
			SpecialAttack = 70,
			SpecialDefense = 55,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[4] = new List<Move>() { MoveFactory.WaterGun, },
			[8] = new List<Move>() { MoveFactory.ConfuseRay, },
			[12] = new List<Move>() { MoveFactory.RapidSpin, },
			[16] = new List<Move>() { MoveFactory.Minimize, },
			[20] = new List<Move>() { MoveFactory.Swift, },
			[24] = new List<Move>() { MoveFactory.Psybeam, },
			[28] = new List<Move>() { MoveFactory.Brine, },
			[32] = new List<Move>() { MoveFactory.LightScreen, },
			[36] = new List<Move>() { MoveFactory.PowerGem, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[44] = new List<Move>() { MoveFactory.Surf, },
			[48] = new List<Move>() { MoveFactory.Recover, },
			[52] = new List<Move>() { MoveFactory.CosmicPower, },
			[56] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
