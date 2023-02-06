using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Morelull : Pokemon
	{
		public override string Name => "Morelull";
		public override int Generation => 7;
		public override string PokedexEntry => "It scatters its shining spores around itself. Even though they're dangerous, nighttime tours of forests where Morelull live are popular.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Illuminate, AbilityFactory.EffectSpore, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 35,
			Defense = 55,
			SpecialAttack = 65,
			SpecialDefense = 75,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.ConfuseRay, },
			[8] = new List<Move>() { MoveFactory.Ingrain, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.SleepPowder, },
			[20] = new List<Move>() { MoveFactory.Moonlight, },
			[25] = new List<Move>() { MoveFactory.StrengthSap, },
			[28] = new List<Move>() { MoveFactory.GigaDrain, },
			[32] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[36] = new List<Move>() { MoveFactory.Spore, },
			[40] = new List<Move>() { MoveFactory.Moonblast, },
			[44] = new List<Move>() { MoveFactory.DreamEater, },
		};
	}
}
