using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Golbat : Pokemon
	{
		public override string Name => "Golbat";
		public override int Generation => 1;
		public override string PokedexEntry => "Its fangs easily puncture even thick animal hide. It loves to feast on the blood of people and Pokémon. It flits about in darkness and strikes from behind.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 80,
			Defense = 70,
			SpecialAttack = 65,
			SpecialDefense = 75,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Screech, MoveFactory.Absorb, MoveFactory.Supersonic, MoveFactory.Astonish, MoveFactory.MeanLook, },
			[15] = new List<Move>() { MoveFactory.PoisonFang, },
			[20] = new List<Move>() { MoveFactory.QuickGuard, },
			[27] = new List<Move>() { MoveFactory.AirCutter, },
			[34] = new List<Move>() { MoveFactory.Bite, },
			[41] = new List<Move>() { MoveFactory.Haze, },
			[48] = new List<Move>() { MoveFactory.Venoshock, },
			[55] = new List<Move>() { MoveFactory.ConfuseRay, },
			[62] = new List<Move>() { MoveFactory.AirSlash, },
			[69] = new List<Move>() { MoveFactory.LeechLife, },
		};
	}
}
