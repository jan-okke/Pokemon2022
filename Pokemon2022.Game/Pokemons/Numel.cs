using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Numel : Pokemon
	{
		public override string Name => "Numel";
		public override int Generation => 3;
		public override string PokedexEntry => "A Numel stores boiling magma in the hump on its back. It is a hardy Pokémon that can transport a 220-pound load. It has served humans at work since long ago.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.Simple, };
		public override Ability AvailableHiddenAbility => AbilityFactory.OwnTempo;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 40,
			SpecialAttack = 65,
			SpecialDefense = 45,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.Bulldoze, },
			[15] = new List<Move>() { MoveFactory.FlameWheel, },
			[19] = new List<Move>() { MoveFactory.Amnesia, },
			[22] = new List<Move>() { MoveFactory.LavaPlume, },
			[26] = new List<Move>() { MoveFactory.EarthPower, },
			[29] = new List<Move>() { MoveFactory.Curse, },
			[31] = new List<Move>() { MoveFactory.TakeDown, },
			[36] = new List<Move>() { MoveFactory.Yawn, },
			[40] = new List<Move>() { MoveFactory.Earthquake, },
			[43] = new List<Move>() { MoveFactory.Flamethrower, },
			[47] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
