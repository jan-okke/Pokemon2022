using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spheal : Pokemon
	{
		public override string Name => "Spheal";
		public override int Generation => 3;
		public override string PokedexEntry => "It is completely covered with plushy fur. As a result, it never feels the cold even when it is rolling about on ice floes or diving in the sea.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.IceBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Oblivious;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 40,
			Defense = 50,
			SpecialAttack = 55,
			SpecialDefense = 50,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Rollout, MoveFactory.DefenseCurl, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[8] = new List<Move>() { MoveFactory.WaterGun, },
			[12] = new List<Move>() { MoveFactory.PowderSnow, },
			[16] = new List<Move>() { MoveFactory.Rest, },
			[20] = new List<Move>() { MoveFactory.Snore, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.AuroraBeam, },
			[33] = new List<Move>() { MoveFactory.Encore, },
			[36] = new List<Move>() { MoveFactory.BodySlam, },
			[40] = new List<Move>() { MoveFactory.Surf, },
			[44] = new List<Move>() { MoveFactory.Blizzard, },
			[48] = new List<Move>() { MoveFactory.Hail, },
			[52] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}
