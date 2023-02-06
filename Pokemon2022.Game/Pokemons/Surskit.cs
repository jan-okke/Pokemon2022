using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Surskit : Pokemon
	{
		public override string Name => "Surskit";
		public override int Generation => 3;
		public override string PokedexEntry => "They gather on puddles after evening downpours, gliding across the surface of water as if sliding. It secretes honey with a sweet aroma from its head.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 30,
			Defense = 32,
			SpecialAttack = 50,
			SpecialDefense = 52,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, },
			[6] = new List<Move>() { MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.SweetScent, },
			[14] = new List<Move>() { MoveFactory.Soak, },
			[17] = new List<Move>() { MoveFactory.BubbleBeam, },
			[22] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.Mist, MoveFactory.Haze, },
			[30] = new List<Move>() { MoveFactory.AquaJet, },
			[35] = new List<Move>() { MoveFactory.BatonPass, },
			[38] = new List<Move>() { MoveFactory.StickyWeb, },
		};
	}
}
