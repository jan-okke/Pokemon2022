using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gyarados : Pokemon
	{
		public override string Name => "Gyarados";
		public override int Generation => 1;
		public override string PokedexEntry => "It is an extremely vicious and violent Pokémon. When humans begin to fight, it will appear and burn everything to the ground with intensely hot flames.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moxie;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 125,
			Defense = 79,
			SpecialAttack = 60,
			SpecialDefense = 100,
			Speed = 81
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Bite, },
			[1] = new List<Move>() { MoveFactory.Bite, MoveFactory.Flail, MoveFactory.Splash, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.Twister, },
			[4] = new List<Move>() { MoveFactory.Whirlpool, },
			[8] = new List<Move>() { MoveFactory.IceFang, },
			[12] = new List<Move>() { MoveFactory.Brine, },
			[16] = new List<Move>() { MoveFactory.ScaryFace, },
			[21] = new List<Move>() { MoveFactory.Waterfall, },
			[24] = new List<Move>() { MoveFactory.Crunch, },
			[28] = new List<Move>() { MoveFactory.RainDance, },
			[32] = new List<Move>() { MoveFactory.AquaTail, },
			[36] = new List<Move>() { MoveFactory.DragonDance, },
			[40] = new List<Move>() { MoveFactory.HydroPump, },
			[44] = new List<Move>() { MoveFactory.Hurricane, },
			[48] = new List<Move>() { MoveFactory.Thrash, },
			[52] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
