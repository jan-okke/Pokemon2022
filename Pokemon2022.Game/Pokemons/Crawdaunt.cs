using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Crawdaunt : Pokemon
	{
		public override string Name => "Crawdaunt";
		public override int Generation => 3;
		public override string PokedexEntry => "A brutish Pokémon that loves to battle. A veteran Crawdaunt that has prevailed in hundreds of battles has giant pincers marked with countless scars.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Adaptability;
		public override Stats BaseStats => new Stats() {
			HP = 63,
			Attack = 120,
			Defense = 85,
			SpecialAttack = 90,
			SpecialDefense = 55,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Swift, },
			[1] = new List<Move>() { MoveFactory.Swift, MoveFactory.WaterGun, MoveFactory.Harden, MoveFactory.Leer, MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.BubbleBeam, },
			[16] = new List<Move>() { MoveFactory.KnockOff, },
			[20] = new List<Move>() { MoveFactory.DoubleHit, },
			[24] = new List<Move>() { MoveFactory.Protect, },
			[28] = new List<Move>() { MoveFactory.NightSlash, },
			[34] = new List<Move>() { MoveFactory.RazorShell, },
			[40] = new List<Move>() { MoveFactory.SwordsDance, },
			[46] = new List<Move>() { MoveFactory.Crunch, },
			[52] = new List<Move>() { MoveFactory.Crabhammer, },
			[58] = new List<Move>() { MoveFactory.Endeavor, },
			[64] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}
