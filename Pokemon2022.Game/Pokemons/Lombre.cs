using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lombre : Pokemon
	{
		public override string Name => "Lombre";
		public override int Generation => 3;
		public override string PokedexEntry => "In the evening, it takes great delight in popping out of rivers and startling people. It feeds on aquatic moss that grows on rocks in the riverbed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.RainDish, };
		public override Ability AvailableHiddenAbility => AbilityFactory.OwnTempo;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 50,
			Defense = 50,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.TeeterDance, MoveFactory.FakeOut, MoveFactory.KnockOff, MoveFactory.Flail, MoveFactory.Astonish, MoveFactory.Growl, MoveFactory.Absorb, MoveFactory.WaterGun, },
			[9] = new List<Move>() { MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[18] = new List<Move>() { MoveFactory.FurySwipes, },
			[24] = new List<Move>() { MoveFactory.BubbleBeam, },
			[30] = new List<Move>() { MoveFactory.NaturePower, },
			[36] = new List<Move>() { MoveFactory.GigaDrain, },
			[43] = new List<Move>() { MoveFactory.RainDance, },
			[50] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[57] = new List<Move>() { MoveFactory.EnergyBall, },
			[64] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
