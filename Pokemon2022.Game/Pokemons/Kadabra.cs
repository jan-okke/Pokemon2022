using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kadabra : Pokemon
	{
		public override string Name => "Kadabra";
		public override int Generation => 1;
		public override string PokedexEntry => "It is rumored that a boy with psychic abilities suddenly transformed into Kadabra while he was assisting research into extrasensory powers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicGuard;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 35,
			Defense = 30,
			SpecialAttack = 120,
			SpecialDefense = 70,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Confusion, },
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
