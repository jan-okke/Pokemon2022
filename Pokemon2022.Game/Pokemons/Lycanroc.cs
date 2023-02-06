using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lycanroc : Pokemon
	{
		public override string Name => "Lycanroc";
		public override int Generation => 7;
		public override string PokedexEntry => "Its quick movements confuse its enemies. Well equipped with claws and fangs, it also uses the sharp rocks in its mane as weapons.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.SandRush, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Steadfast;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 115,
			Defense = 65,
			SpecialAttack = 55,
			SpecialDefense = 65,
			Speed = 112
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SuckerPunch, },
			[1] = new List<Move>() { MoveFactory.SuckerPunch, MoveFactory.Accelerock, MoveFactory.QuickGuard, MoveFactory.QuickAttack, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.SandAttack, MoveFactory.DoubleTeam, },
			[12] = new List<Move>() { MoveFactory.RockThrow, },
			[16] = new List<Move>() { MoveFactory.Howl, },
			[20] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.RockTomb, },
			[30] = new List<Move>() { MoveFactory.Roar, },
			[36] = new List<Move>() { MoveFactory.RockSlide, },
			[42] = new List<Move>() { MoveFactory.Crunch, },
			[48] = new List<Move>() { MoveFactory.ScaryFace, },
			[54] = new List<Move>() { MoveFactory.StealthRock, },
			[60] = new List<Move>() { MoveFactory.StoneEdge, },
		};
	}
}
