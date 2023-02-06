using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Reuniclus : Pokemon
	{
		public override string Name => "Reuniclus";
		public override int Generation => 5;
		public override string PokedexEntry => "These remarkably intelligent Pokémon fight by controlling arms that can grip with rock-crushing power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overcoat, AbilityFactory.MagicGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 65,
			Defense = 75,
			SpecialAttack = 125,
			SpecialDefense = 85,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.HammerArm, },
			[1] = new List<Move>() { MoveFactory.HammerArm, MoveFactory.Protect, MoveFactory.Confusion, MoveFactory.Recover, MoveFactory.Endeavor, },
			[12] = new List<Move>() { MoveFactory.Psybeam, },
			[16] = new List<Move>() { MoveFactory.Charm, },
			[20] = new List<Move>() { MoveFactory.Psyshock, },
			[24] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, },
			[28] = new List<Move>() { MoveFactory.AllySwitch, },
			[35] = new List<Move>() { MoveFactory.PainSplit, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[48] = new List<Move>() { MoveFactory.SkillSwap, },
			[56] = new List<Move>() { MoveFactory.FutureSight, },
			[64] = new List<Move>() { MoveFactory.WonderRoom, },
		};
	}
}
