using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Prinplup : Pokemon
	{
		public override string Name => "Prinplup";
		public override int Generation => 4;
		public override string PokedexEntry => "It lives alone, away from others. Apparently, every one of them believes it is the most important.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 64,
			Attack = 66,
			Defense = 68,
			SpecialAttack = 81,
			SpecialDefense = 76,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.MetalClaw, },
			[1] = new List<Move>() { MoveFactory.MetalClaw, MoveFactory.Tackle, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[8] = new List<Move>() { MoveFactory.WaterGun, },
			[11] = new List<Move>() { MoveFactory.Charm, },
			[15] = new List<Move>() { MoveFactory.Peck, },
			[19] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.Swagger, },
			[28] = new List<Move>() { MoveFactory.FuryAttack, },
			[33] = new List<Move>() { MoveFactory.Brine, },
			[37] = new List<Move>() { MoveFactory.Whirlpool, },
			[42] = new List<Move>() { MoveFactory.Mist, },
			[46] = new List<Move>() { MoveFactory.DrillPeck, },
			[50] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
