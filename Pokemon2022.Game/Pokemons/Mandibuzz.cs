using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mandibuzz : Pokemon
	{
		public override string Name => "Mandibuzz";
		public override int Generation => 5;
		public override string PokedexEntry => "Watching from the sky, they swoop to strike weakened Pokémon on the ground. They decorate themselves with bones.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BigPecks, AbilityFactory.Overcoat, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 65,
			Defense = 105,
			SpecialAttack = 55,
			SpecialDefense = 95,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.BoneRush, },
			[1] = new List<Move>() { MoveFactory.BoneRush, MoveFactory.SkyAttack, MoveFactory.Toxic, MoveFactory.Gust, MoveFactory.Leer, MoveFactory.Flatter, MoveFactory.Pluck, },
			[18] = new List<Move>() { MoveFactory.Tailwind, },
			[24] = new List<Move>() { MoveFactory.KnockOff, },
			[30] = new List<Move>() { MoveFactory.IronDefense, },
			[36] = new List<Move>() { MoveFactory.Whirlwind, },
			[42] = new List<Move>() { MoveFactory.AirSlash, },
			[48] = new List<Move>() { MoveFactory.DarkPulse, },
			[57] = new List<Move>() { MoveFactory.NastyPlot, },
			[64] = new List<Move>() { MoveFactory.Defog, },
			[72] = new List<Move>() { MoveFactory.Attract, },
			[80] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}
