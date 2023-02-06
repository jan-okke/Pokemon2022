using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Corphish : Pokemon
	{
		public override string Name => "Corphish";
		public override int Generation => 3;
		public override string PokedexEntry => "Once it grips prey with its large pincers, it will never let go, no matter what. It is a hardy Pokémon that can thrive in any environment.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Adaptability;
		public override Stats BaseStats => new Stats() {
			HP = 43,
			Attack = 80,
			Defense = 65,
			SpecialAttack = 50,
			SpecialDefense = 35,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Harden, },
			[4] = new List<Move>() { MoveFactory.Leer, },
			[8] = new List<Move>() { MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.BubbleBeam, },
			[16] = new List<Move>() { MoveFactory.KnockOff, },
			[20] = new List<Move>() { MoveFactory.DoubleHit, },
			[24] = new List<Move>() { MoveFactory.Protect, },
			[28] = new List<Move>() { MoveFactory.NightSlash, },
			[32] = new List<Move>() { MoveFactory.RazorShell, },
			[36] = new List<Move>() { MoveFactory.SwordsDance, },
			[40] = new List<Move>() { MoveFactory.Crunch, },
			[44] = new List<Move>() { MoveFactory.Crabhammer, },
			[48] = new List<Move>() { MoveFactory.Endeavor, },
			[52] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}
