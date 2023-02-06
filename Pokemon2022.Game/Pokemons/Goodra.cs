using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Goodra : Pokemon
	{
		public override string Name => "Goodra";
		public override int Generation => 6;
		public override string PokedexEntry => "It gets picked on because it's meek. But then, whoever teased it gets to feel the full force of its horns and a good swatting from its thick tail.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SapSipper, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gooey;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 100,
			Defense = 70,
			SpecialAttack = 110,
			SpecialDefense = 150,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AquaTail, },
			[1] = new List<Move>() { MoveFactory.AquaTail, MoveFactory.AcidSpray, MoveFactory.PoisonTail, MoveFactory.TearfulLook, MoveFactory.Feint, MoveFactory.Absorb, MoveFactory.Tackle, MoveFactory.WaterGun, MoveFactory.DragonBreath, },
			[15] = new List<Move>() { MoveFactory.Protect, },
			[20] = new List<Move>() { MoveFactory.Flail, },
			[25] = new List<Move>() { MoveFactory.WaterPulse, },
			[30] = new List<Move>() { MoveFactory.RainDance, },
			[35] = new List<Move>() { MoveFactory.DragonPulse, },
			[43] = new List<Move>() { MoveFactory.Curse, },
			[49] = new List<Move>() { MoveFactory.BodySlam, },
			[58] = new List<Move>() { MoveFactory.MuddyWater, },
			[67] = new List<Move>() { MoveFactory.PowerWhip, },
		};
	}
}
