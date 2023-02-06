using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gothorita : Pokemon
	{
		public override string Name => "Gothorita";
		public override int Generation => 5;
		public override string PokedexEntry => "Starlight is the source of their power. At night, they mark star positions by using psychic power to float stones.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Frisk, AbilityFactory.Competitive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShadowTag;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 45,
			Defense = 70,
			SpecialAttack = 75,
			SpecialDefense = 85,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Confusion, MoveFactory.PlayNice, MoveFactory.Tickle, },
			[12] = new List<Move>() { MoveFactory.Psybeam, },
			[16] = new List<Move>() { MoveFactory.Charm, },
			[20] = new List<Move>() { MoveFactory.Psyshock, },
			[24] = new List<Move>() { MoveFactory.Hypnosis, },
			[28] = new List<Move>() { MoveFactory.FakeTears, },
			[35] = new List<Move>() { MoveFactory.PsychUp, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[46] = new List<Move>() { MoveFactory.Flatter, },
			[52] = new List<Move>() { MoveFactory.FutureSight, },
			[58] = new List<Move>() { MoveFactory.MagicRoom, },
		};
	}
}
