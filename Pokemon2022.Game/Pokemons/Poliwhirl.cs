using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Poliwhirl : Pokemon
	{
		public override string Name => "Poliwhirl";
		public override int Generation => 1;
		public override string PokedexEntry => "Its body surface is always wet and slick with an oily fluid. Because of this greasy covering, it can easily slip and slide out of the clutches of any enemy in battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.Damp, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 65,
			Defense = 65,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Hypnosis, MoveFactory.Pound, MoveFactory.MudShot, },
			[18] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.RainDance, },
			[32] = new List<Move>() { MoveFactory.BodySlam, },
			[40] = new List<Move>() { MoveFactory.EarthPower, },
			[48] = new List<Move>() { MoveFactory.HydroPump, },
			[56] = new List<Move>() { MoveFactory.BellyDrum, },
			[66] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
