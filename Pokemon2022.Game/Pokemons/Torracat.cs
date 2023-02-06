using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Torracat : Pokemon
	{
		public override string Name => "Torracat";
		public override int Generation => 7;
		public override string PokedexEntry => "It can act spoiled if it grows close to its Trainer. A powerful Pokémon, its sharp claws can leave its Trainer's whole body covered in scratches.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Intimidate;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 85,
			Defense = 50,
			SpecialAttack = 80,
			SpecialDefense = 50,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.Ember, MoveFactory.Lick, },
			[9] = new List<Move>() { MoveFactory.Roar, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.DoubleKick, },
			[25] = new List<Move>() { MoveFactory.FireFang, },
			[30] = new List<Move>() { MoveFactory.ScaryFace, },
			[35] = new List<Move>() { MoveFactory.Swagger, },
			[40] = new List<Move>() { MoveFactory.Flamethrower, },
			[45] = new List<Move>() { MoveFactory.Thrash, },
			[50] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
