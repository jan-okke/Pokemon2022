using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Aromatisse : Pokemon
	{
		public override string Name => "Aromatisse";
		public override int Generation => 6;
		public override string PokedexEntry => "It devises various scents, pleasant and unpleasant, and emits scents that its enemies dislike in order to gain an edge in battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Healer, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AromaVeil;
		public override Stats BaseStats => new Stats() {
			HP = 101,
			Attack = 72,
			Defense = 72,
			SpecialAttack = 99,
			SpecialDefense = 89,
			Speed = 29
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.AromaticMist, MoveFactory.HealPulse, MoveFactory.FairyWind, MoveFactory.SweetScent, MoveFactory.SweetKiss, MoveFactory.EchoedVoice, },
			[9] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[12] = new List<Move>() { MoveFactory.Aromatherapy, },
			[15] = new List<Move>() { MoveFactory.DrainingKiss, },
			[18] = new List<Move>() { MoveFactory.Attract, },
			[21] = new List<Move>() { MoveFactory.Flail, },
			[24] = new List<Move>() { MoveFactory.MistyTerrain, },
			[27] = new List<Move>() { MoveFactory.Psychic, },
			[30] = new List<Move>() { MoveFactory.Charm, },
			[33] = new List<Move>() { MoveFactory.CalmMind, },
			[36] = new List<Move>() { MoveFactory.Moonblast, },
			[39] = new List<Move>() { MoveFactory.SkillSwap, },
			[42] = new List<Move>() { MoveFactory.PsychUp, },
		};
	}
}
