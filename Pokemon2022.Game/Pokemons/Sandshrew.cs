using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sandshrew : Pokemon
	{
		public override string Name => "Sandshrew";
		public override int Generation => 1;
		public override string PokedexEntry => "When it curls up in a ball, it can make any attack bounce off harmlessly. Its hide has turned tough and solid as a result of living in the desert.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandRush;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 75,
			Defense = 85,
			SpecialAttack = 20,
			SpecialDefense = 30,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.DefenseCurl, },
			[3] = new List<Move>() { MoveFactory.PoisonSting, },
			[6] = new List<Move>() { MoveFactory.SandAttack, },
			[9] = new List<Move>() { MoveFactory.Rollout, },
			[12] = new List<Move>() { MoveFactory.FuryCutter, },
			[15] = new List<Move>() { MoveFactory.RapidSpin, },
			[18] = new List<Move>() { MoveFactory.Bulldoze, },
			[21] = new List<Move>() { MoveFactory.Swift, },
			[24] = new List<Move>() { MoveFactory.FurySwipes, },
			[27] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.Slash, },
			[33] = new List<Move>() { MoveFactory.Dig, },
			[36] = new List<Move>() { MoveFactory.GyroBall, },
			[39] = new List<Move>() { MoveFactory.SwordsDance, },
			[42] = new List<Move>() { MoveFactory.Sandstorm, },
			[45] = new List<Move>() { MoveFactory.Earthquake, },
		};
	}
}
