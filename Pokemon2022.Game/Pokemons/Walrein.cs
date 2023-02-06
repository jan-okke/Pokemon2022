using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Walrein : Pokemon
	{
		public override string Name => "Walrein";
		public override int Generation => 3;
		public override string PokedexEntry => "To protect its herd, the leader battles anything that invades its territory, even at the cost of its life. Its tusks may snap off in battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.IceBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Oblivious;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 80,
			Defense = 90,
			SpecialAttack = 95,
			SpecialDefense = 90,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Swagger, MoveFactory.Crunch, MoveFactory.IceFang, MoveFactory.Rollout, MoveFactory.DefenseCurl, MoveFactory.Growl, MoveFactory.WaterGun, },
			[12] = new List<Move>() { MoveFactory.PowderSnow, },
			[16] = new List<Move>() { MoveFactory.Rest, },
			[20] = new List<Move>() { MoveFactory.Snore, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.AuroraBeam, },
			[35] = new List<Move>() { MoveFactory.Encore, },
			[40] = new List<Move>() { MoveFactory.BodySlam, },
			[48] = new List<Move>() { MoveFactory.Surf, },
			[56] = new List<Move>() { MoveFactory.Blizzard, },
			[64] = new List<Move>() { MoveFactory.Hail, },
			[72] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}
