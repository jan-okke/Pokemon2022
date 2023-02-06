using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Litten : Pokemon
	{
		public override string Name => "Litten";
		public override int Generation => 7;
		public override string PokedexEntry => "Its coat regrows twice a year. When the time comes, Litten sets its own body on fire and burns away the old fur.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Intimidate;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 65,
			Defense = 40,
			SpecialAttack = 60,
			SpecialDefense = 40,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.Ember, },
			[6] = new List<Move>() { MoveFactory.Lick, },
			[9] = new List<Move>() { MoveFactory.Roar, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.DoubleKick, },
			[21] = new List<Move>() { MoveFactory.FireFang, },
			[24] = new List<Move>() { MoveFactory.ScaryFace, },
			[27] = new List<Move>() { MoveFactory.Swagger, },
			[30] = new List<Move>() { MoveFactory.Flamethrower, },
			[33] = new List<Move>() { MoveFactory.Thrash, },
			[36] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
