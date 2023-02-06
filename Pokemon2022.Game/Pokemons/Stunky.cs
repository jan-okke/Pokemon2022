using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Stunky : Pokemon
	{
		public override string Name => "Stunky";
		public override int Generation => 4;
		public override string PokedexEntry => "It protects itself by spraying a noxious fluid from its rear. The stench lingers for 24 hours.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Stench, AbilityFactory.Aftermath, };
		public override Ability AvailableHiddenAbility => AbilityFactory.KeenEye;
		public override Stats BaseStats => new Stats() {
			HP = 63,
			Attack = 63,
			Defense = 47,
			SpecialAttack = 41,
			SpecialDefense = 41,
			Speed = 74
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonGas, MoveFactory.Scratch, },
			[3] = new List<Move>() { MoveFactory.Feint, },
			[6] = new List<Move>() { MoveFactory.Smokescreen, },
			[9] = new List<Move>() { MoveFactory.AcidSpray, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[15] = new List<Move>() { MoveFactory.FocusEnergy, },
			[18] = new List<Move>() { MoveFactory.Bite, },
			[21] = new List<Move>() { MoveFactory.Venoshock, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[27] = new List<Move>() { MoveFactory.Toxic, },
			[30] = new List<Move>() { MoveFactory.SuckerPunch, },
			[33] = new List<Move>() { MoveFactory.Memento, },
			[36] = new List<Move>() { MoveFactory.NightSlash, },
			[39] = new List<Move>() { MoveFactory.Belch, },
			[42] = new List<Move>() { MoveFactory.VenomDrench, },
			[45] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
