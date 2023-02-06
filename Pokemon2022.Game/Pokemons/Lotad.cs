using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lotad : Pokemon
	{
		public override string Name => "Lotad";
		public override int Generation => 3;
		public override string PokedexEntry => "This Pokémon lives in ponds with clean water. It is known to ferry small Pokémon across ponds by carrying them on the broad leaf on its head.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.RainDish, };
		public override Ability AvailableHiddenAbility => AbilityFactory.OwnTempo;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 30,
			Defense = 30,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.Absorb, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[9] = new List<Move>() { MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.Flail, },
			[20] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.NaturePower, },
			[28] = new List<Move>() { MoveFactory.GigaDrain, },
			[33] = new List<Move>() { MoveFactory.RainDance, },
			[38] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[43] = new List<Move>() { MoveFactory.EnergyBall, },
		};
	}
}
