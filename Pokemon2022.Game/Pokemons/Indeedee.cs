using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Indeedee : Pokemon
	{
		public override string Name => "Indeedee";
		public override int Generation => 8;
		public override string PokedexEntry => "It uses the horns on its head to sense the emotions of others. Males will act as valets for those they serve, looking after their every need.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, AbilityFactory.Synchronize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PsychicSurge;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 65,
			Defense = 55,
			SpecialAttack = 105,
			SpecialDefense = 95,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.StoredPower, MoveFactory.PlayNice, },
			[5] = new List<Move>() { MoveFactory.Encore, },
			[10] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[15] = new List<Move>() { MoveFactory.Psybeam, },
			[20] = new List<Move>() { MoveFactory.HelpingHand, },
			[25] = new List<Move>() { MoveFactory.AfterYou, },
			[30] = new List<Move>() { MoveFactory.Aromatherapy, },
			[35] = new List<Move>() { MoveFactory.Psychic, },
			[40] = new List<Move>() { MoveFactory.CalmMind, },
			[45] = new List<Move>() { MoveFactory.PowerSplit, },
			[50] = new List<Move>() { MoveFactory.PsychicTerrain, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}
