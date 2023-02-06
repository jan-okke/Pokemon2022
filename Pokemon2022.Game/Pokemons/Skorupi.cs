using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Skorupi : Pokemon
	{
		public override string Name => "Skorupi";
		public override int Generation => 4;
		public override string PokedexEntry => "It grips prey with its tail claws and injects poison. It tenaciously hangs on until the poison takes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BattleArmor, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.KeenEye;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 50,
			Defense = 90,
			SpecialAttack = 30,
			SpecialDefense = 55,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.Leer, },
			[3] = new List<Move>() { MoveFactory.HoneClaws, },
			[6] = new List<Move>() { MoveFactory.FellStinger, },
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
			[42] = new List<Move>() { MoveFactory.XScissor, },
			[45] = new List<Move>() { MoveFactory.Acupressure, },
			[48] = new List<Move>() { MoveFactory.Crunch, },
		};
	}
}
