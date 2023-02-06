using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drampa : Pokemon
	{
		public override string Name => "Drampa";
		public override int Generation => 7;
		public override string PokedexEntry => "This Pokémon is friendly to people and loves children most of all. It comes from deep in the mountains to play with children it likes in town.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Berserk, AbilityFactory.SapSipper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CloudNine;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 60,
			Defense = 85,
			SpecialAttack = 135,
			SpecialDefense = 91,
			Speed = 36
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PlayNice, MoveFactory.EchoedVoice, },
			[5] = new List<Move>() { MoveFactory.Twister, },
			[10] = new List<Move>() { MoveFactory.Protect, },
			[15] = new List<Move>() { MoveFactory.Glare, },
			[20] = new List<Move>() { MoveFactory.Safeguard, },
			[25] = new List<Move>() { MoveFactory.DragonBreath, },
			[30] = new List<Move>() { MoveFactory.Extrasensory, },
			[35] = new List<Move>() { MoveFactory.DragonPulse, },
			[40] = new List<Move>() { MoveFactory.LightScreen, },
			[45] = new List<Move>() { MoveFactory.Fly, },
			[50] = new List<Move>() { MoveFactory.HyperVoice, },
			[55] = new List<Move>() { MoveFactory.Outrage, },
		};
	}
}
