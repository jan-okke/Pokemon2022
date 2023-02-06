using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tyrantrum : Pokemon
	{
		public override string Name => "Tyrantrum";
		public override int Generation => 6;
		public override string PokedexEntry => "Thanks to its gargantuan jaws, which could shred thick metal plates as if they were paper, it was invincible in the ancient world it once inhabited.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.StrongJaw, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RockHead;
		public override Stats BaseStats => new Stats() {
			HP = 82,
			Attack = 121,
			Defense = 119,
			SpecialAttack = 69,
			SpecialDefense = 59,
			Speed = 71
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.Roar, MoveFactory.AncientPower, },
			[12] = new List<Move>() { MoveFactory.Charm, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.DragonTail, },
			[24] = new List<Move>() { MoveFactory.Stomp, },
			[28] = new List<Move>() { MoveFactory.RockSlide, },
			[32] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.DragonClaw, },
			[42] = new List<Move>() { MoveFactory.Thrash, },
			[48] = new List<Move>() { MoveFactory.Earthquake, },
			[54] = new List<Move>() { MoveFactory.HornDrill, },
			[60] = new List<Move>() { MoveFactory.GigaImpact, },
			[66] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
