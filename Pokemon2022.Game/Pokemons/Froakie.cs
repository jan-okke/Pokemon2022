using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Froakie : Pokemon
	{
		public override string Name => "Froakie";
		public override int Generation => 6;
		public override string PokedexEntry => "It protects its skin by covering its body in delicate bubbles. Beneath its happy-go-lucky air, it keeps a watchful eye on its surroundings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Protean;
		public override Stats BaseStats => new Stats() {
			HP = 41,
			Attack = 56,
			Defense = 40,
			SpecialAttack = 62,
			SpecialDefense = 44,
			Speed = 71
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.Bubble, },
			[8] = new List<Move>() { MoveFactory.QuickAttack, },
			[10] = new List<Move>() { MoveFactory.Lick, },
			[14] = new List<Move>() { MoveFactory.WaterPulse, },
			[18] = new List<Move>() { MoveFactory.Smokescreen, },
			[21] = new List<Move>() { MoveFactory.Round, },
			[25] = new List<Move>() { MoveFactory.Fling, },
			[29] = new List<Move>() { MoveFactory.SmackDown, },
			[35] = new List<Move>() { MoveFactory.Substitute, },
			[39] = new List<Move>() { MoveFactory.Bounce, },
			[43] = new List<Move>() { MoveFactory.DoubleTeam, },
			[48] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
