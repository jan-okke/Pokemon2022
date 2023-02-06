using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dewpider : Pokemon
	{
		public override string Name => "Dewpider";
		public override int Generation => 7;
		public override string PokedexEntry => "When two Dewpider meet, they display their water bubbles to each other. Then the one with the smaller bubble gets out of the other's way.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterBubble, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 38,
			Attack = 40,
			Defense = 52,
			SpecialAttack = 40,
			SpecialDefense = 72,
			Speed = 27
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Infestation, },
			[4] = new List<Move>() { MoveFactory.BugBite, },
			[8] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.BubbleBeam, },
			[16] = new List<Move>() { MoveFactory.AquaRing, },
			[20] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.Crunch, },
			[28] = new List<Move>() { MoveFactory.Soak, },
			[32] = new List<Move>() { MoveFactory.Entrainment, },
			[36] = new List<Move>() { MoveFactory.Lunge, },
			[40] = new List<Move>() { MoveFactory.Liquidation, },
			[44] = new List<Move>() { MoveFactory.LeechLife, },
			[48] = new List<Move>() { MoveFactory.MirrorCoat, },
		};
	}
}
