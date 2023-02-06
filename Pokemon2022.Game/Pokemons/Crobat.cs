using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Crobat : Pokemon
	{
		public override string Name => "Crobat";
		public override int Generation => 2;
		public override string PokedexEntry => "Over the course of evolution, its hind legs turned into wings. By alternately resting its front and rear wings, it can fly all day without having to stop.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 90,
			Defense = 80,
			SpecialAttack = 70,
			SpecialDefense = 80,
			Speed = 130
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.CrossPoison, },
			[1] = new List<Move>() { MoveFactory.CrossPoison, MoveFactory.Tailwind, MoveFactory.Toxic, MoveFactory.Screech, MoveFactory.Absorb, MoveFactory.Supersonic, MoveFactory.Astonish, MoveFactory.MeanLook, },
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
