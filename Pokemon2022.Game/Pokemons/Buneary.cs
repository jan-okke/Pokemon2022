using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Buneary : Pokemon
	{
		public override string Name => "Buneary";
		public override int Generation => 4;
		public override string PokedexEntry => "It slams foes by sharply uncoiling its rolled ears. It stings enough to make a grown-up cry in pain.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.Klutz, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Limber;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 66,
			Defense = 44,
			SpecialAttack = 44,
			SpecialDefense = 56,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, MoveFactory.Pound, },
			[4] = new List<Move>() { MoveFactory.DefenseCurl, },
			[8] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[12] = new List<Move>() { MoveFactory.AfterYou, },
			[16] = new List<Move>() { MoveFactory.QuickAttack, },
			[20] = new List<Move>() { MoveFactory.DoubleKick, },
			[24] = new List<Move>() { MoveFactory.Charm, },
			[28] = new List<Move>() { MoveFactory.BatonPass, },
			[32] = new List<Move>() { MoveFactory.Headbutt, },
			[36] = new List<Move>() { MoveFactory.Agility, },
			[40] = new List<Move>() { MoveFactory.Entrainment, },
			[44] = new List<Move>() { MoveFactory.Flatter, },
			[48] = new List<Move>() { MoveFactory.Bounce, },
			[52] = new List<Move>() { MoveFactory.HealingWish, },
		};
	}
}
