using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gardevoir : Pokemon
	{
		public override string Name => "Gardevoir";
		public override int Generation => 3;
		public override string PokedexEntry => "It apparently does not feel the pull of gravity because it supports itself with psychic power. It will give its life to protect its trainer.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, AbilityFactory.Trace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 65,
			Defense = 65,
			SpecialAttack = 125,
			SpecialDefense = 115,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[1] = new List<Move>() { MoveFactory.DazzlingGleam, MoveFactory.Moonblast, MoveFactory.MistyTerrain, MoveFactory.HealingWish, MoveFactory.Charm, MoveFactory.Growl, MoveFactory.DisarmingVoice, MoveFactory.DoubleTeam, MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.Hypnosis, },
			[12] = new List<Move>() { MoveFactory.DrainingKiss, },
			[15] = new List<Move>() { MoveFactory.Teleport, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[23] = new List<Move>() { MoveFactory.LifeDew, },
			[28] = new List<Move>() { MoveFactory.Wish, },
			[35] = new List<Move>() { MoveFactory.CalmMind, },
			[42] = new List<Move>() { MoveFactory.Psychic, },
			[49] = new List<Move>() { MoveFactory.HealPulse, },
			[56] = new List<Move>() { MoveFactory.DreamEater, },
			[63] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
