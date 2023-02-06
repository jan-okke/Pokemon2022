using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ralts : Pokemon
	{
		public override string Name => "Ralts";
		public override int Generation => 3;
		public override string PokedexEntry => "A Ralts has the power to sense the emotions of people and Pokémon with the horns on its head. It takes cover if it senses any hostility.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, AbilityFactory.Trace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 28,
			Attack = 25,
			Defense = 25,
			SpecialAttack = 45,
			SpecialDefense = 35,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.DisarmingVoice, },
			[3] = new List<Move>() { MoveFactory.DoubleTeam, },
			[6] = new List<Move>() { MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.Hypnosis, },
			[12] = new List<Move>() { MoveFactory.DrainingKiss, },
			[15] = new List<Move>() { MoveFactory.Teleport, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[21] = new List<Move>() { MoveFactory.LifeDew, },
			[24] = new List<Move>() { MoveFactory.Charm, },
			[27] = new List<Move>() { MoveFactory.CalmMind, },
			[30] = new List<Move>() { MoveFactory.Psychic, },
			[33] = new List<Move>() { MoveFactory.HealPulse, },
			[36] = new List<Move>() { MoveFactory.DreamEater, },
			[39] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
