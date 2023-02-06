using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Whiscash : Pokemon
	{
		public override string Name => "Whiscash";
		public override int Generation => 3;
		public override string PokedexEntry => "Mysteriously, it can foretell earthquakes. In the daytime, it sleeps in mud at the bottom of a pond. When it awakens, it continually feeds throughout the night.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.Anticipation, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 78,
			Defense = 73,
			SpecialAttack = 76,
			SpecialDefense = 71,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Thrash, },
			[1] = new List<Move>() { MoveFactory.Thrash, MoveFactory.Belch, MoveFactory.ZenHeadbutt, MoveFactory.Tickle, MoveFactory.MudSlap, MoveFactory.WaterGun, MoveFactory.Rest, MoveFactory.Snore, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[18] = new List<Move>() { MoveFactory.Amnesia, },
			[24] = new List<Move>() { MoveFactory.AquaTail, },
			[33] = new List<Move>() { MoveFactory.MuddyWater, },
			[40] = new List<Move>() { MoveFactory.Earthquake, },
			[48] = new List<Move>() { MoveFactory.FutureSight, },
			[56] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}
