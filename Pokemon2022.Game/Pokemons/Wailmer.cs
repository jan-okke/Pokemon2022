using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wailmer : Pokemon
	{
		public override string Name => "Wailmer";
		public override int Generation => 3;
		public override string PokedexEntry => "While this Pokémon usually lives in the sea, it can survive on land, although not too long. It loses vitality if its body becomes dried out.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterVeil, AbilityFactory.Oblivious, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pressure;
		public override Stats BaseStats => new Stats() {
			HP = 130,
			Attack = 70,
			Defense = 35,
			SpecialAttack = 70,
			SpecialDefense = 35,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, },
			[3] = new List<Move>() { MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.Astonish, },
			[12] = new List<Move>() { MoveFactory.WaterGun, },
			[15] = new List<Move>() { MoveFactory.Mist, },
			[18] = new List<Move>() { MoveFactory.WaterPulse, },
			[21] = new List<Move>() { MoveFactory.HeavySlam, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[27] = new List<Move>() { MoveFactory.Whirlpool, },
			[30] = new List<Move>() { MoveFactory.Dive, },
			[33] = new List<Move>() { MoveFactory.Bounce, },
			[36] = new List<Move>() { MoveFactory.BodySlam, },
			[39] = new List<Move>() { MoveFactory.Rest, },
			[42] = new List<Move>() { MoveFactory.Amnesia, },
			[45] = new List<Move>() { MoveFactory.HydroPump, },
			[48] = new List<Move>() { MoveFactory.WaterSpout, },
		};
	}
}
