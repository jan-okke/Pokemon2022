using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Orbeetle : Pokemon
	{
		public override string Name => "Orbeetle";
		public override int Generation => 8;
		public override string PokedexEntry => "It's famous for its high level of intelligence, and the large size of its brain is proof that it also possesses immense psychic power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 45,
			Defense = 110,
			SpecialAttack = 80,
			SpecialDefense = 120,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Reflect, MoveFactory.LightScreen, MoveFactory.Confusion, MoveFactory.StruggleBug, },
			[4] = new List<Move>() { MoveFactory.ConfuseRay, },
			[8] = new List<Move>() { MoveFactory.MagicCoat, },
			[12] = new List<Move>() { MoveFactory.Agility, },
			[16] = new List<Move>() { MoveFactory.Psybeam, },
			[20] = new List<Move>() { MoveFactory.Hypnosis, },
			[24] = new List<Move>() { MoveFactory.AllySwitch, },
			[28] = new List<Move>() { MoveFactory.BugBuzz, },
			[32] = new List<Move>() { MoveFactory.MirrorCoat, },
			[36] = new List<Move>() { MoveFactory.Psychic, },
			[40] = new List<Move>() { MoveFactory.AfterYou, },
			[44] = new List<Move>() { MoveFactory.CalmMind, },
			[48] = new List<Move>() { MoveFactory.PsychicTerrain, },
		};
	}
}
