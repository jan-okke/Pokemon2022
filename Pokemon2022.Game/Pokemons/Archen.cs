using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Archen : Pokemon
	{
		public override string Name => "Archen";
		public override int Generation => 5;
		public override string PokedexEntry => "Revived from a fossil, this Pokémon is thought to be the ancestor of all bird Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Defeatist, };
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 112,
			Defense = 45,
			SpecialAttack = 74,
			SpecialDefense = 45,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, },
			[3] = new List<Move>() { MoveFactory.RockThrow, },
			[6] = new List<Move>() { MoveFactory.WingAttack, },
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
			[39] = new List<Move>() { MoveFactory.DragonClaw, },
			[42] = new List<Move>() { MoveFactory.Thrash, },
			[45] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}
