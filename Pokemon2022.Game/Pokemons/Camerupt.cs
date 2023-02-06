using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Camerupt : Pokemon
	{
		public override string Name => "Camerupt";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that lives in the crater of a volcano. Every 10 years, the volcanoes on its back erupt violently. Research is under way on the cause of eruption.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MagmaArmor, AbilityFactory.SolidRock, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AngerPoint;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 100,
			Defense = 70,
			SpecialAttack = 105,
			SpecialDefense = 75,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.RockSlide, },
			[1] = new List<Move>() { MoveFactory.RockSlide, MoveFactory.Fissure, MoveFactory.Eruption, MoveFactory.Growl, MoveFactory.Tackle, MoveFactory.Ember, MoveFactory.FocusEnergy, },
			[8] = new List<Move>() { MoveFactory.Ember, MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.Bulldoze, },
			[15] = new List<Move>() { MoveFactory.FlameWheel, },
			[19] = new List<Move>() { MoveFactory.Amnesia, },
			[22] = new List<Move>() { MoveFactory.LavaPlume, },
			[26] = new List<Move>() { MoveFactory.EarthPower, },
			[29] = new List<Move>() { MoveFactory.Curse, },
			[31] = new List<Move>() { MoveFactory.TakeDown, },
			[39] = new List<Move>() { MoveFactory.Yawn, },
			[46] = new List<Move>() { MoveFactory.Earthquake, },
			[52] = new List<Move>() { MoveFactory.Eruption, },
			[59] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}
