using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Alakazam : Pokemon
	{
		public override string Name => "Alakazam";
		public override int Generation => 1;
		public override string PokedexEntry => "While it has strong psychic abilities and high intelligence, an Alakazam's muscles are very weak. It uses psychic power to move its body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicGuard;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 50,
			Defense = 45,
			SpecialAttack = 135,
			SpecialDefense = 95,
			Speed = 120
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.Kinesis, MoveFactory.Disable, MoveFactory.Teleport, },
			[5] = new List<Move>() { MoveFactory.Psybeam, },
			[10] = new List<Move>() { MoveFactory.Reflect, },
			[15] = new List<Move>() { MoveFactory.AllySwitch, },
			[20] = new List<Move>() { MoveFactory.PsychoCut, },
			[25] = new List<Move>() { MoveFactory.Recover, },
			[30] = new List<Move>() { MoveFactory.Psyshock, },
			[35] = new List<Move>() { MoveFactory.Psychic, },
			[40] = new List<Move>() { MoveFactory.RolePlay, },
			[45] = new List<Move>() { MoveFactory.FutureSight, },
			[50] = new List<Move>() { MoveFactory.CalmMind, },
		};
	}
}
