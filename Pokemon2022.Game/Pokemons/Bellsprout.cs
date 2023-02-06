using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bellsprout : Pokemon
	{
		public override string Name => "Bellsprout";
		public override int Generation => 1;
		public override string PokedexEntry => "A Bellsprout's thin and flexible body lets it bend and sway to avoid any attack, however strong it may be. From its mouth, it leaks a fluid that melts even iron.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 75,
			Defense = 35,
			SpecialAttack = 70,
			SpecialDefense = 30,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.VineWhip, },
			[7] = new List<Move>() { MoveFactory.Growth, },
			[11] = new List<Move>() { MoveFactory.Wrap, },
			[13] = new List<Move>() { MoveFactory.SleepPowder, },
			[15] = new List<Move>() { MoveFactory.PoisonPowder, },
			[17] = new List<Move>() { MoveFactory.StunSpore, },
			[23] = new List<Move>() { MoveFactory.Acid, },
			[27] = new List<Move>() { MoveFactory.KnockOff, },
			[29] = new List<Move>() { MoveFactory.SweetScent, },
			[35] = new List<Move>() { MoveFactory.GastroAcid, },
			[39] = new List<Move>() { MoveFactory.RazorLeaf, },
			[41] = new List<Move>() { MoveFactory.PoisonJab, },
			[47] = new List<Move>() { MoveFactory.Slam, },
		};
	}
}
