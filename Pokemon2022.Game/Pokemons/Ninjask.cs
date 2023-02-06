using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ninjask : Pokemon
	{
		public override string Name => "Ninjask";
		public override int Generation => 3;
		public override string PokedexEntry => "Because it darts about vigorously at high speed, it is very difficult to see. Hearing its distinctive cries for too long induces a headache.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SpeedBoost, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 61,
			Attack = 90,
			Defense = 45,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 160
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DoubleTeam, MoveFactory.Screech, MoveFactory.FuryCutter, },
			[1] = new List<Move>() { MoveFactory.DoubleTeam, MoveFactory.Screech, MoveFactory.FuryCutter, MoveFactory.BatonPass, MoveFactory.AerialAce, MoveFactory.MudSlap, MoveFactory.MetalClaw, MoveFactory.Dig, MoveFactory.SandAttack, MoveFactory.Scratch, MoveFactory.Harden, MoveFactory.FalseSwipe, },
			[15] = new List<Move>() { MoveFactory.Agility, },
			[23] = new List<Move>() { MoveFactory.Absorb, },
			[29] = new List<Move>() { MoveFactory.BugBite, },
			[36] = new List<Move>() { MoveFactory.FurySwipes, },
			[43] = new List<Move>() { MoveFactory.MindReader, },
			[50] = new List<Move>() { MoveFactory.Slash, },
			[57] = new List<Move>() { MoveFactory.SwordsDance, },
			[64] = new List<Move>() { MoveFactory.XScissor, },
		};
	}
}
