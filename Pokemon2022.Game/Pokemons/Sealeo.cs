using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sealeo : Pokemon
	{
		public override string Name => "Sealeo";
		public override int Generation => 3;
		public override string PokedexEntry => "Sealeo live in herds on ice floes. Using its powerful flippers, it shatters ice. It dives into the sea to hunt prey five times a day.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.IceBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Oblivious;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 60,
			Defense = 70,
			SpecialAttack = 75,
			SpecialDefense = 70,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Swagger, },
			[1] = new List<Move>() { MoveFactory.Swagger, MoveFactory.Rollout, MoveFactory.DefenseCurl, MoveFactory.Growl, MoveFactory.WaterGun, },
			[12] = new List<Move>() { MoveFactory.PowderSnow, },
			[16] = new List<Move>() { MoveFactory.Rest, },
			[20] = new List<Move>() { MoveFactory.Snore, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.AuroraBeam, },
			[35] = new List<Move>() { MoveFactory.Encore, },
			[40] = new List<Move>() { MoveFactory.BodySlam, },
			[46] = new List<Move>() { MoveFactory.Surf, },
			[52] = new List<Move>() { MoveFactory.Blizzard, },
			[58] = new List<Move>() { MoveFactory.Hail, },
			[64] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}
