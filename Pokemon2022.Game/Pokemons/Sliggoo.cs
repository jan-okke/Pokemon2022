using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sliggoo : Pokemon
	{
		public override string Name => "Sliggoo";
		public override int Generation => 6;
		public override string PokedexEntry => "This Pokémon's mucous can dissolve anything. Toothless, it sprays mucous on its prey. Once they're nicely dissolved, it slurps them up.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SapSipper, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gooey;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 75,
			Defense = 53,
			SpecialAttack = 83,
			SpecialDefense = 113,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AcidSpray, },
			[1] = new List<Move>() { MoveFactory.AcidSpray, MoveFactory.Absorb, MoveFactory.Tackle, MoveFactory.WaterGun, MoveFactory.DragonBreath, },
			[15] = new List<Move>() { MoveFactory.Protect, },
			[20] = new List<Move>() { MoveFactory.Flail, },
			[25] = new List<Move>() { MoveFactory.WaterPulse, },
			[30] = new List<Move>() { MoveFactory.RainDance, },
			[35] = new List<Move>() { MoveFactory.DragonPulse, },
			[43] = new List<Move>() { MoveFactory.Curse, },
			[49] = new List<Move>() { MoveFactory.BodySlam, },
			[56] = new List<Move>() { MoveFactory.MuddyWater, },
		};
	}
}
