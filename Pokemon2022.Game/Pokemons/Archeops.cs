using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Archeops : Pokemon
	{
		public override string Name => "Archeops";
		public override int Generation => 5;
		public override string PokedexEntry => "It runs better than it flies. It catches prey by running at speeds comparable to those of an automobile.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Defeatist, };
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 140,
			Defense = 65,
			SpecialAttack = 112,
			SpecialDefense = 65,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, MoveFactory.RockThrow, MoveFactory.WingAttack, },
			[9] = new List<Move>() { MoveFactory.DragonBreath, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[15] = new List<Move>() { MoveFactory.Pluck, },
			[18] = new List<Move>() { MoveFactory.QuickGuard, },
			[21] = new List<Move>() { MoveFactory.Uturn, },
			[24] = new List<Move>() { MoveFactory.RockSlide, },
			[27] = new List<Move>() { MoveFactory.ScaryFace, },
			[30] = new List<Move>() { MoveFactory.Crunch, },
			[33] = new List<Move>() { MoveFactory.Agility, },
			[36] = new List<Move>() { MoveFactory.Tailwind, },
			[41] = new List<Move>() { MoveFactory.DragonClaw, },
			[46] = new List<Move>() { MoveFactory.Thrash, },
			[51] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}
