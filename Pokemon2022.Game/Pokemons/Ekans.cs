using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ekans : Pokemon
	{
		public override string Name => "Ekans";
		public override int Generation => 1;
		public override string PokedexEntry => "An Ekans curls itself up in a spiral while it rests. This position allows it to quickly respond to an enemy from any direction with a threat from its upraised head.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 60,
			Defense = 44,
			SpecialAttack = 40,
			SpecialDefense = 54,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.PoisonSting, },
			[9] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.Glare, },
			[17] = new List<Move>() { MoveFactory.Screech, },
			[20] = new List<Move>() { MoveFactory.Acid, },
			[25] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[28] = new List<Move>() { MoveFactory.AcidSpray, },
			[33] = new List<Move>() { MoveFactory.SludgeBomb, },
			[36] = new List<Move>() { MoveFactory.GastroAcid, },
			[38] = new List<Move>() { MoveFactory.Belch, },
			[41] = new List<Move>() { MoveFactory.Haze, },
			[44] = new List<Move>() { MoveFactory.Coil, },
			[49] = new List<Move>() { MoveFactory.GunkShot, },
		};
	}
}
