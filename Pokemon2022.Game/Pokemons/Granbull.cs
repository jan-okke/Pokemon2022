using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Granbull : Pokemon
	{
		public override string Name => "Granbull";
		public override int Generation => 2;
		public override string PokedexEntry => "It has a particularly well-developed lower jaw. The huge fangs are heavy, causing it to tilt its head. Unless it is startled, it will not try to bite.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.QuickFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 120,
			Defense = 75,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Outrage, MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.ThunderFang, MoveFactory.Tackle, MoveFactory.ScaryFace, MoveFactory.TailWhip, MoveFactory.Charm, },
			[7] = new List<Move>() { MoveFactory.Bite, },
			[13] = new List<Move>() { MoveFactory.Lick, },
			[19] = new List<Move>() { MoveFactory.Headbutt, },
			[27] = new List<Move>() { MoveFactory.Roar, },
			[35] = new List<Move>() { MoveFactory.Taunt, },
			[43] = new List<Move>() { MoveFactory.PlayRough, },
			[51] = new List<Move>() { MoveFactory.Payback, },
			[59] = new List<Move>() { MoveFactory.Crunch, },
			[67] = new List<Move>() { MoveFactory.Outrage, },
		};
	}
}
