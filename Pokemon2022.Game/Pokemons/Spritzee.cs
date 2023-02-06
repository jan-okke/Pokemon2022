using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spritzee : Pokemon
	{
		public override string Name => "Spritzee";
		public override int Generation => 6;
		public override string PokedexEntry => "It emits a scent that enraptures those who smell it. This fragrance changes depending on what it has eaten.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Healer, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AromaVeil;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 52,
			Defense = 60,
			SpecialAttack = 63,
			SpecialDefense = 65,
			Speed = 23
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FairyWind, MoveFactory.SweetScent, },
			[3] = new List<Move>() { MoveFactory.SweetKiss, },
			[6] = new List<Move>() { MoveFactory.EchoedVoice, },
			[9] = new List<Move>() { MoveFactory.DrainingKiss, },
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
		};
	}
}
