using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Solosis : Pokemon
	{
		public override string Name => "Solosis";
		public override int Generation => 5;
		public override string PokedexEntry => "Because their bodies are enveloped in a special liquid, they can survive in any environment.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overcoat, AbilityFactory.MagicGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 30,
			Defense = 40,
			SpecialAttack = 105,
			SpecialDefense = 50,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Protect, MoveFactory.Confusion, },
			[4] = new List<Move>() { MoveFactory.Recover, },
			[8] = new List<Move>() { MoveFactory.Endeavor, },
			[12] = new List<Move>() { MoveFactory.Psybeam, },
			[16] = new List<Move>() { MoveFactory.Charm, },
			[20] = new List<Move>() { MoveFactory.Psyshock, },
			[24] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, },
			[28] = new List<Move>() { MoveFactory.AllySwitch, },
			[33] = new List<Move>() { MoveFactory.PainSplit, },
			[36] = new List<Move>() { MoveFactory.Psychic, },
			[40] = new List<Move>() { MoveFactory.SkillSwap, },
			[44] = new List<Move>() { MoveFactory.FutureSight, },
			[48] = new List<Move>() { MoveFactory.WonderRoom, },
		};
	}
}
