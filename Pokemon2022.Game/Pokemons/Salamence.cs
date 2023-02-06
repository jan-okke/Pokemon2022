using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Salamence : Pokemon
	{
		public override string Name => "Salamence";
		public override int Generation => 3;
		public override string PokedexEntry => "After many long years, its cellular structure underwent a sudden mutation to grow wings. When angered, it loses all thought and rampages out of control.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moxie;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 135,
			Defense = 80,
			SpecialAttack = 110,
			SpecialDefense = 80,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Fly, },
			[1] = new List<Move>() { MoveFactory.Fly, MoveFactory.Protect, MoveFactory.DragonTail, MoveFactory.Ember, MoveFactory.Leer, MoveFactory.Bite, MoveFactory.DragonBreath, },
			[15] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.Crunch, },
			[33] = new List<Move>() { MoveFactory.DragonClaw, },
			[39] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[46] = new List<Move>() { MoveFactory.FocusEnergy, },
			[55] = new List<Move>() { MoveFactory.Flamethrower, },
			[64] = new List<Move>() { MoveFactory.Outrage, },
			[73] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
