using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tsareena : Pokemon
	{
		public override string Name => "Tsareena";
		public override int Generation => 7;
		public override string PokedexEntry => "A Pokémon with an aggressive personality and a mastery of kicking, it cackles every time it kicks an opponent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LeafGuard, AbilityFactory.QueenlyMajesty, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SweetVeil;
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 120,
			Defense = 98,
			SpecialAttack = 50,
			SpecialDefense = 98,
			Speed = 72
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.TropKick, },
			[1] = new List<Move>() { MoveFactory.TropKick, MoveFactory.PowerWhip, MoveFactory.Flail, MoveFactory.PlayNice, MoveFactory.Splash, MoveFactory.Swagger, MoveFactory.RapidSpin, MoveFactory.RazorLeaf, },
			[16] = new List<Move>() { MoveFactory.SweetScent, },
			[22] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[28] = new List<Move>() { MoveFactory.Stomp, },
			[34] = new List<Move>() { MoveFactory.TeeterDance, },
			[40] = new List<Move>() { MoveFactory.AromaticMist, },
			[46] = new List<Move>() { MoveFactory.Aromatherapy, },
			[52] = new List<Move>() { MoveFactory.LeafStorm, },
			[58] = new List<Move>() { MoveFactory.HighJumpKick, },
		};
	}
}
