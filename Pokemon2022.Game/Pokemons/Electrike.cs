using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Electrike : Pokemon
	{
		public override string Name => "Electrike";
		public override int Generation => 3;
		public override string PokedexEntry => "It generates electricity using friction from the atmosphere. In seasons with especially arid air, its entire body blazes with violent showers of sparks.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, AbilityFactory.LightningRod, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Minus;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 40,
			SpecialAttack = 65,
			SpecialDefense = 40,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.ThunderWave, },
			[4] = new List<Move>() { MoveFactory.Leer, },
			[8] = new List<Move>() { MoveFactory.Howl, },
			[12] = new List<Move>() { MoveFactory.QuickAttack, },
			[16] = new List<Move>() { MoveFactory.ShockWave, },
			[20] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.ThunderFang, },
			[28] = new List<Move>() { MoveFactory.Roar, },
			[32] = new List<Move>() { MoveFactory.Discharge, },
			[36] = new List<Move>() { MoveFactory.Charge, },
			[40] = new List<Move>() { MoveFactory.WildCharge, },
			[44] = new List<Move>() { MoveFactory.Thunder, },
		};
	}
}
