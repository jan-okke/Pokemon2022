using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Furret : Pokemon
	{
		public override string Name => "Furret";
		public override int Generation => 2;
		public override string PokedexEntry => "A Furret has a very slim build. When under attack, it can squirm through narrow spaces and get away. In spite of its short limbs, it is very nimble and fleet.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Frisk;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 76,
			Defense = 64,
			SpecialAttack = 45,
			SpecialDefense = 55,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Agility, },
			[1] = new List<Move>() { MoveFactory.Agility, MoveFactory.Coil, MoveFactory.Scratch, MoveFactory.DefenseCurl, MoveFactory.QuickAttack, },
			[4] = new List<Move>() { MoveFactory.DefenseCurl, },
			[7] = new List<Move>() { MoveFactory.QuickAttack, },
			[13] = new List<Move>() { MoveFactory.FurySwipes, },
			[17] = new List<Move>() { MoveFactory.HelpingHand, },
			[21] = new List<Move>() { MoveFactory.FollowMe, },
			[28] = new List<Move>() { MoveFactory.Slam, },
			[32] = new List<Move>() { MoveFactory.Rest, },
			[36] = new List<Move>() { MoveFactory.SuckerPunch, },
			[42] = new List<Move>() { MoveFactory.Amnesia, },
			[46] = new List<Move>() { MoveFactory.BatonPass, },
			[50] = new List<Move>() { MoveFactory.Reversal, },
			[56] = new List<Move>() { MoveFactory.HyperVoice, },
		};
	}
}
