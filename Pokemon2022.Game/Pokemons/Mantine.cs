using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mantine : Pokemon
	{
		public override string Name => "Mantine";
		public override int Generation => 2;
		public override string PokedexEntry => "On sunny days, schools of Mantine can be seen elegantly leaping over the waves. It is not bothered by the Remoraid that hitches rides.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.WaterAbsorb, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterVeil;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 40,
			Defense = 70,
			SpecialAttack = 80,
			SpecialDefense = 140,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Psybeam, MoveFactory.BulletSeed, MoveFactory.Roost, MoveFactory.Tackle, MoveFactory.WaterGun, MoveFactory.Supersonic, MoveFactory.WingAttack, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[16] = new List<Move>() { MoveFactory.WideGuard, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[24] = new List<Move>() { MoveFactory.BubbleBeam, },
			[28] = new List<Move>() { MoveFactory.Headbutt, },
			[32] = new List<Move>() { MoveFactory.AirSlash, },
			[36] = new List<Move>() { MoveFactory.AquaRing, },
			[40] = new List<Move>() { MoveFactory.Bounce, },
			[44] = new List<Move>() { MoveFactory.TakeDown, },
			[48] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
