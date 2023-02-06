using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sandslash : Pokemon
	{
		public override string Name => "Sandslash";
		public override int Generation => 1;
		public override string PokedexEntry => "It curls up in a ball to protect itself from enemy attacks. It also curls up to prevent heatstroke during the daytime when temperatures rise sharply.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandRush;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 100,
			Defense = 110,
			SpecialAttack = 45,
			SpecialDefense = 55,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.CrushClaw, MoveFactory.Scratch, MoveFactory.DefenseCurl, MoveFactory.PoisonSting, MoveFactory.SandAttack, },
			[9] = new List<Move>() { MoveFactory.Rollout, },
			[12] = new List<Move>() { MoveFactory.FuryCutter, },
			[15] = new List<Move>() { MoveFactory.RapidSpin, },
			[18] = new List<Move>() { MoveFactory.Bulldoze, },
			[21] = new List<Move>() { MoveFactory.Swift, },
			[26] = new List<Move>() { MoveFactory.FurySwipes, },
			[31] = new List<Move>() { MoveFactory.SandTomb, },
			[36] = new List<Move>() { MoveFactory.Slash, },
			[41] = new List<Move>() { MoveFactory.Dig, },
			[46] = new List<Move>() { MoveFactory.GyroBall, },
			[51] = new List<Move>() { MoveFactory.SwordsDance, },
			[56] = new List<Move>() { MoveFactory.Sandstorm, },
			[61] = new List<Move>() { MoveFactory.Earthquake, },
		};
	}
}
