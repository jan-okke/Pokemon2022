using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pyukumuku : Pokemon
	{
		public override string Name => "Pyukumuku";
		public override int Generation => 7;
		public override string PokedexEntry => "It lives in shallow seas, such as areas near a beach. It can eject its internal organs, which it uses to engulf its prey or battle enemies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnardsOut, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unaware;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 60,
			Defense = 130,
			SpecialAttack = 30,
			SpecialDefense = 130,
			Speed = 5
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.BatonPass, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.HelpingHand, },
			[10] = new List<Move>() { MoveFactory.Taunt, },
			[15] = new List<Move>() { MoveFactory.Safeguard, },
			[20] = new List<Move>() { MoveFactory.Counter, },
			[25] = new List<Move>() { MoveFactory.Purify, },
			[30] = new List<Move>() { MoveFactory.Curse, },
			[35] = new List<Move>() { MoveFactory.GastroAcid, },
			[40] = new List<Move>() { MoveFactory.PainSplit, },
			[45] = new List<Move>() { MoveFactory.Recover, },
			[50] = new List<Move>() { MoveFactory.Soak, },
			[55] = new List<Move>() { MoveFactory.Toxic, },
			[60] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}
