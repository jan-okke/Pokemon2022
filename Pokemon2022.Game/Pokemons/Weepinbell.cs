using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Weepinbell : Pokemon
	{
		public override string Name => "Weepinbell";
		public override int Generation => 1;
		public override string PokedexEntry => "At night, a Weepinbell hangs on to a tree branch with its hooked rear and sleeps. If it moves around in its sleep, it may wake up to find itself on the ground.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 90,
			Defense = 50,
			SpecialAttack = 85,
			SpecialDefense = 45,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.VineWhip, MoveFactory.Growth, MoveFactory.Wrap, },
			[7] = new List<Move>() { MoveFactory.Growth, },
			[11] = new List<Move>() { MoveFactory.Wrap, },
			[13] = new List<Move>() { MoveFactory.SleepPowder, },
			[15] = new List<Move>() { MoveFactory.PoisonPowder, },
			[17] = new List<Move>() { MoveFactory.StunSpore, },
			[24] = new List<Move>() { MoveFactory.Acid, },
			[29] = new List<Move>() { MoveFactory.KnockOff, },
			[32] = new List<Move>() { MoveFactory.SweetScent, },
			[39] = new List<Move>() { MoveFactory.GastroAcid, },
			[44] = new List<Move>() { MoveFactory.RazorLeaf, },
			[47] = new List<Move>() { MoveFactory.PoisonJab, },
			[54] = new List<Move>() { MoveFactory.Slam, },
		};
	}
}
