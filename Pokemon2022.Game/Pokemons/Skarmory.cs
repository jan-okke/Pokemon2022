using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Skarmory : Pokemon
	{
		public override string Name => "Skarmory";
		public override int Generation => 2;
		public override string PokedexEntry => "A Pokémon that has a body and wings of steel. People in the past used feathers fallen from Skarmory to make swords and knives.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 80,
			Defense = 140,
			SpecialAttack = 40,
			SpecialDefense = 70,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[8] = new List<Move>() { MoveFactory.FuryAttack, },
			[12] = new List<Move>() { MoveFactory.MetalClaw, },
			[16] = new List<Move>() { MoveFactory.Agility, },
			[20] = new List<Move>() { MoveFactory.WingAttack, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[28] = new List<Move>() { MoveFactory.SteelWing, },
			[32] = new List<Move>() { MoveFactory.Autotomize, },
			[36] = new List<Move>() { MoveFactory.DrillPeck, },
			[40] = new List<Move>() { MoveFactory.MetalSound, },
			[44] = new List<Move>() { MoveFactory.Spikes, },
			[48] = new List<Move>() { MoveFactory.IronDefense, },
			[52] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}
