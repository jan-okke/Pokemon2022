using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mantyke : Pokemon
	{
		public override string Name => "Mantyke";
		public override int Generation => 4;
		public override string PokedexEntry => "A friendly Pokémon that captures the subtle flows of seawater using its two antennae.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.WaterAbsorb, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterVeil;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 20,
			Defense = 50,
			SpecialAttack = 60,
			SpecialDefense = 120,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.WaterGun, },
			[4] = new List<Move>() { MoveFactory.Supersonic, },
			[8] = new List<Move>() { MoveFactory.WingAttack, },
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
