using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Barboach : Pokemon
	{
		public override string Name => "Barboach";
		public override int Generation => 3;
		public override string PokedexEntry => "Its body is covered with a slimy film. The film acts as a barrier to prevent germs in muddy water from entering the Barboach's body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.Anticipation, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 48,
			Defense = 43,
			SpecialAttack = 46,
			SpecialDefense = 41,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.WaterGun, },
			[6] = new List<Move>() { MoveFactory.Rest, MoveFactory.Snore, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[18] = new List<Move>() { MoveFactory.Amnesia, },
			[24] = new List<Move>() { MoveFactory.AquaTail, },
			[31] = new List<Move>() { MoveFactory.MuddyWater, },
			[36] = new List<Move>() { MoveFactory.Earthquake, },
			[42] = new List<Move>() { MoveFactory.FutureSight, },
			[48] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}
