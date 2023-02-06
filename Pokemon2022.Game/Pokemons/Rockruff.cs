using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rockruff : Pokemon
	{
		public override string Name => "Rockruff";
		public override int Generation => 7;
		public override string PokedexEntry => "This Pokémon has lived with people since times long ago. It can sense when its Trainer is in the dumps and will stick close by its Trainer's side.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.VitalSpirit, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Steadfast;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 65,
			Defense = 40,
			SpecialAttack = 30,
			SpecialDefense = 40,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[8] = new List<Move>() { MoveFactory.DoubleTeam, },
			[12] = new List<Move>() { MoveFactory.RockThrow, },
			[16] = new List<Move>() { MoveFactory.Howl, },
			[20] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.RockTomb, },
			[28] = new List<Move>() { MoveFactory.Roar, },
			[32] = new List<Move>() { MoveFactory.RockSlide, },
			[36] = new List<Move>() { MoveFactory.Crunch, },
			[40] = new List<Move>() { MoveFactory.ScaryFace, },
			[44] = new List<Move>() { MoveFactory.StealthRock, },
			[48] = new List<Move>() { MoveFactory.StoneEdge, },
		};
	}
}
