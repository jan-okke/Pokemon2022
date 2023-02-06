using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Duosion : Pokemon
	{
		public override string Name => "Duosion";
		public override int Generation => 5;
		public override string PokedexEntry => "When their brains, now divided in two, are thinking the same thoughts, these Pokémon exhibit their maximum power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overcoat, AbilityFactory.MagicGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 40,
			Defense = 50,
			SpecialAttack = 125,
			SpecialDefense = 60,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Protect, MoveFactory.Confusion, MoveFactory.Recover, MoveFactory.Endeavor, },
			[12] = new List<Move>() { MoveFactory.Psybeam, },
			[16] = new List<Move>() { MoveFactory.Charm, },
			[20] = new List<Move>() { MoveFactory.Psyshock, },
			[24] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, },
			[28] = new List<Move>() { MoveFactory.AllySwitch, },
			[35] = new List<Move>() { MoveFactory.PainSplit, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[46] = new List<Move>() { MoveFactory.SkillSwap, },
			[52] = new List<Move>() { MoveFactory.FutureSight, },
			[58] = new List<Move>() { MoveFactory.WonderRoom, },
		};
	}
}
