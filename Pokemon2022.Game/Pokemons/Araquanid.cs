using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Araquanid : Pokemon
	{
		public override string Name => "Araquanid";
		public override int Generation => 7;
		public override string PokedexEntry => "It delivers headbutts with the water bubble on its head. Small Pokémon get sucked into the bubble, where they drown.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterBubble, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 70,
			Defense = 92,
			SpecialAttack = 50,
			SpecialDefense = 132,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WideGuard, MoveFactory.WaterGun, MoveFactory.Infestation, MoveFactory.BugBite, MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.BubbleBeam, },
			[16] = new List<Move>() { MoveFactory.AquaRing, },
			[20] = new List<Move>() { MoveFactory.Headbutt, },
			[26] = new List<Move>() { MoveFactory.Crunch, },
			[32] = new List<Move>() { MoveFactory.Soak, },
			[38] = new List<Move>() { MoveFactory.Entrainment, },
			[44] = new List<Move>() { MoveFactory.Lunge, },
			[50] = new List<Move>() { MoveFactory.Liquidation, },
			[56] = new List<Move>() { MoveFactory.LeechLife, },
			[62] = new List<Move>() { MoveFactory.MirrorCoat, },
		};
	}
}
