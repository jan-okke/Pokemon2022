using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drapion : Pokemon
	{
		public override string Name => "Drapion";
		public override int Generation => 4;
		public override string PokedexEntry => "It has the power in its clawed arms to make scrap of a car. The tips of its claws release poison.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BattleArmor, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.KeenEye;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 90,
			Defense = 110,
			SpecialAttack = 60,
			SpecialDefense = 75,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderFang, MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.PoisonSting, MoveFactory.Leer, MoveFactory.HoneClaws, MoveFactory.FellStinger, },
			[9] = new List<Move>() { MoveFactory.PoisonFang, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[18] = new List<Move>() { MoveFactory.BugBite, },
			[21] = new List<Move>() { MoveFactory.Venoshock, },
			[24] = new List<Move>() { MoveFactory.KnockOff, },
			[27] = new List<Move>() { MoveFactory.ScaryFace, },
			[30] = new List<Move>() { MoveFactory.PinMissile, },
			[33] = new List<Move>() { MoveFactory.Toxic, },
			[36] = new List<Move>() { MoveFactory.NightSlash, },
			[39] = new List<Move>() { MoveFactory.CrossPoison, },
			[44] = new List<Move>() { MoveFactory.XScissor, },
			[49] = new List<Move>() { MoveFactory.Acupressure, },
			[54] = new List<Move>() { MoveFactory.Crunch, },
		};
	}
}
