using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Phione : Pokemon
	{
		public override string Name => "Phione";
		public override int Generation => 4;
		public override string PokedexEntry => "A Pokémon that lives in warm seas. It inflates the flotation sac on its head to drift and search for food.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hydration, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 80,
			Defense = 80,
			SpecialAttack = 80,
			SpecialDefense = 80,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, },
			[9] = new List<Move>() { MoveFactory.Charm, },
			[16] = new List<Move>() { MoveFactory.Supersonic, },
			[24] = new List<Move>() { MoveFactory.BubbleBeam, },
			[31] = new List<Move>() { MoveFactory.AcidArmor, },
			[39] = new List<Move>() { MoveFactory.Whirlpool, },
			[46] = new List<Move>() { MoveFactory.WaterPulse, },
			[54] = new List<Move>() { MoveFactory.AquaRing, },
			[61] = new List<Move>() { MoveFactory.Dive, },
			[69] = new List<Move>() { MoveFactory.RainDance, },
		};
	}
}
