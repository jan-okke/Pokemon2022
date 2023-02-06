using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Oranguru : Pokemon
	{
		public override string Name => "Oranguru";
		public override int Generation => 7;
		public override string PokedexEntry => "It normally spends its time meditating in the treetops. It throws Poké Balls and gives other Pokémon orders as it pleases.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, AbilityFactory.Telepathy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Symbiosis;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 60,
			Defense = 80,
			SpecialAttack = 90,
			SpecialDefense = 110,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.Taunt, },
			[5] = new List<Move>() { MoveFactory.AfterYou, },
			[10] = new List<Move>() { MoveFactory.CalmMind, },
			[15] = new List<Move>() { MoveFactory.StoredPower, },
			[20] = new List<Move>() { MoveFactory.PsychUp, },
			[25] = new List<Move>() { MoveFactory.Quash, },
			[30] = new List<Move>() { MoveFactory.NastyPlot, },
			[35] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[40] = new List<Move>() { MoveFactory.TrickRoom, },
			[45] = new List<Move>() { MoveFactory.Psychic, },
			[50] = new List<Move>() { MoveFactory.Instruct, },
			[55] = new List<Move>() { MoveFactory.FoulPlay, },
			[60] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
