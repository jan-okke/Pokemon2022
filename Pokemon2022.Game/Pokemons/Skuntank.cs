using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Skuntank : Pokemon
	{
		public override string Name => "Skuntank";
		public override int Generation => 4;
		public override string PokedexEntry => "It sprays a vile-smelling fluid from the tip of its tail to attack. Its range is over 160 feet.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Stench, AbilityFactory.Aftermath, };
		public override Ability AvailableHiddenAbility => AbilityFactory.KeenEye;
		public override Stats BaseStats => new Stats() {
			HP = 103,
			Attack = 93,
			Defense = 67,
			SpecialAttack = 71,
			SpecialDefense = 61,
			Speed = 84
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Flamethrower, },
			[1] = new List<Move>() { MoveFactory.Flamethrower, MoveFactory.PoisonGas, MoveFactory.Scratch, MoveFactory.Feint, MoveFactory.Smokescreen, },
			[9] = new List<Move>() { MoveFactory.AcidSpray, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[15] = new List<Move>() { MoveFactory.FocusEnergy, },
			[18] = new List<Move>() { MoveFactory.Bite, },
			[21] = new List<Move>() { MoveFactory.Venoshock, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[27] = new List<Move>() { MoveFactory.Toxic, },
			[30] = new List<Move>() { MoveFactory.SuckerPunch, },
			[33] = new List<Move>() { MoveFactory.Memento, },
			[38] = new List<Move>() { MoveFactory.NightSlash, },
			[43] = new List<Move>() { MoveFactory.Belch, },
			[48] = new List<Move>() { MoveFactory.VenomDrench, },
			[53] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
