using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gabite : Pokemon
	{
		public override string Name => "Gabite";
		public override int Generation => 4;
		public override string PokedexEntry => "There is a long-held belief that medicine made from its scales will heal even incurable illnesses.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RoughSkin;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 90,
			Defense = 65,
			SpecialAttack = 50,
			SpecialDefense = 55,
			Speed = 82
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DualChop, MoveFactory.SandTomb, MoveFactory.Tackle, MoveFactory.SandAttack, MoveFactory.DragonBreath, },
			[18] = new List<Move>() { MoveFactory.Bulldoze, },
			[27] = new List<Move>() { MoveFactory.Bite, },
			[34] = new List<Move>() { MoveFactory.Slash, },
			[42] = new List<Move>() { MoveFactory.DragonClaw, },
			[50] = new List<Move>() { MoveFactory.Dig, },
			[58] = new List<Move>() { MoveFactory.Sandstorm, },
			[66] = new List<Move>() { MoveFactory.TakeDown, },
			[74] = new List<Move>() { MoveFactory.DragonRush, },
		};
	}
}
