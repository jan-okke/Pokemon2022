using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lopunny : Pokemon
	{
		public override string Name => "Lopunny";
		public override int Generation => 4;
		public override string PokedexEntry => "An extremely cautious Pokémon. It cloaks its body with its fluffy ear fur when it senses danger.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.Klutz, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Limber;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 76,
			Defense = 84,
			SpecialAttack = 54,
			SpecialDefense = 96,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MirrorCoat, MoveFactory.MagicCoat, MoveFactory.Splash, MoveFactory.Pound, MoveFactory.DefenseCurl, MoveFactory.BabyDollEyes, },
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
			[56] = new List<Move>() { MoveFactory.HighJumpKick, },
		};
	}
}
