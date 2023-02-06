using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bibarel : Pokemon
	{
		public override string Name => "Bibarel";
		public override int Generation => 4;
		public override string PokedexEntry => "It makes its nest by damming streams with bark and mud. It is known as an industrious worker.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Simple, AbilityFactory.Unaware, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moody;
		public override Stats BaseStats => new Stats() {
			HP = 79,
			Attack = 85,
			Defense = 60,
			SpecialAttack = 55,
			SpecialDefense = 60,
			Speed = 71
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.WaterGun, },
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.AquaJet, MoveFactory.Tackle, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.DefenseCurl, },
			[9] = new List<Move>() { MoveFactory.Rollout, },
			[13] = new List<Move>() { MoveFactory.Headbutt, },
			[18] = new List<Move>() { MoveFactory.Taunt, },
			[23] = new List<Move>() { MoveFactory.Yawn, },
			[28] = new List<Move>() { MoveFactory.Crunch, },
			[33] = new List<Move>() { MoveFactory.TakeDown, },
			[38] = new List<Move>() { MoveFactory.SuperFang, },
			[43] = new List<Move>() { MoveFactory.SwordsDance, },
			[48] = new List<Move>() { MoveFactory.Amnesia, },
			[53] = new List<Move>() { MoveFactory.Superpower, },
			[58] = new List<Move>() { MoveFactory.Curse, },
		};
	}
}
