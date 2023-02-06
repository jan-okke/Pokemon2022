using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kecleon : Pokemon
	{
		public override string Name => "Kecleon";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that has the ability to alter its body colors to match its surroundings. A Kecleon reverts to its original colors if it is startled.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ColorChange, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Protean;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 90,
			Defense = 70,
			SpecialAttack = 60,
			SpecialDefense = 120,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Thief, MoveFactory.TailWhip, MoveFactory.Astonish, MoveFactory.Lick, MoveFactory.Scratch, },
			[4] = new List<Move>() { MoveFactory.Bind, },
			[7] = new List<Move>() { MoveFactory.ShadowSneak, },
			[10] = new List<Move>() { MoveFactory.Feint, },
			[13] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.Disable, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[21] = new List<Move>() { MoveFactory.AncientPower, },
			[25] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.Detect, },
			[33] = new List<Move>() { MoveFactory.ShadowClaw, },
			[38] = new List<Move>() { MoveFactory.Screech, },
			[42] = new List<Move>() { MoveFactory.Substitute, },
			[46] = new List<Move>() { MoveFactory.SuckerPunch, },
			[50] = new List<Move>() { MoveFactory.FoulPlay, },
		};
	}
}
