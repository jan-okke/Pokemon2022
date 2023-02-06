using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kirlia : Pokemon
	{
		public override string Name => "Kirlia";
		public override int Generation => 3;
		public override string PokedexEntry => "A Kirlia has the psychic power to create a rip in the dimensions and see into the future. It is said to dance with pleasure on sunny mornings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, AbilityFactory.Trace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 38,
			Attack = 35,
			Defense = 35,
			SpecialAttack = 65,
			SpecialDefense = 55,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.DisarmingVoice, MoveFactory.DoubleTeam, MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.Hypnosis, },
			[12] = new List<Move>() { MoveFactory.DrainingKiss, },
			[15] = new List<Move>() { MoveFactory.Teleport, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[23] = new List<Move>() { MoveFactory.LifeDew, },
			[28] = new List<Move>() { MoveFactory.Charm, },
			[33] = new List<Move>() { MoveFactory.CalmMind, },
			[38] = new List<Move>() { MoveFactory.Psychic, },
			[43] = new List<Move>() { MoveFactory.HealPulse, },
			[48] = new List<Move>() { MoveFactory.DreamEater, },
			[53] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
