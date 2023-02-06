using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Starmie : Pokemon
	{
		public override string Name => "Starmie";
		public override int Generation => 1;
		public override string PokedexEntry => "People in ancient times imagined that Starmie were transformed from the reflections of stars that twinkled on gentle waves at night.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Illuminate, AbilityFactory.NaturalCure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 75,
			Defense = 85,
			SpecialAttack = 100,
			SpecialDefense = 85,
			Speed = 115
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.RapidSpin, MoveFactory.Minimize, MoveFactory.Swift, MoveFactory.Psybeam, MoveFactory.Brine, MoveFactory.LightScreen, MoveFactory.PowerGem, MoveFactory.Psychic, MoveFactory.Surf, MoveFactory.Recover, MoveFactory.CosmicPower, MoveFactory.HydroPump, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.WaterGun, MoveFactory.ConfuseRay, },
		};
	}
}
