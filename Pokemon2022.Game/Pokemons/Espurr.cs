using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Espurr : Pokemon
	{
		public override string Name => "Espurr";
		public override int Generation => 6;
		public override string PokedexEntry => "The organ that emits its intense psychic power is sheltered by its ears to keep power from leaking out.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.OwnTempo;
		public override Stats BaseStats => new Stats() {
			HP = 62,
			Attack = 48,
			Defense = 54,
			SpecialAttack = 63,
			SpecialDefense = 60,
			Speed = 68
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[3] = new List<Move>() { MoveFactory.FakeOut, },
			[6] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[9] = new List<Move>() { MoveFactory.Confusion, },
			[18] = new List<Move>() { MoveFactory.Covet, },
			[21] = new List<Move>() { MoveFactory.Psybeam, },
			[30] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, },
			[33] = new List<Move>() { MoveFactory.Psyshock, },
		};
	}
}
