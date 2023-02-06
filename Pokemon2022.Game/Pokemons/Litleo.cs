using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Litleo : Pokemon
	{
		public override string Name => "Litleo";
		public override int Generation => 6;
		public override string PokedexEntry => "They set off on their own from their pride and live by themselves to become stronger. These hot-blooded Pokémon are quick to fight.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rivalry, AbilityFactory.Unnerve, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moxie;
		public override Stats BaseStats => new Stats() {
			HP = 62,
			Attack = 50,
			Defense = 58,
			SpecialAttack = 73,
			SpecialDefense = 54,
			Speed = 72
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.WorkUp, },
			[11] = new List<Move>() { MoveFactory.Headbutt, },
			[15] = new List<Move>() { MoveFactory.NobleRoar, },
			[20] = new List<Move>() { MoveFactory.TakeDown, },
			[23] = new List<Move>() { MoveFactory.FireFang, },
			[28] = new List<Move>() { MoveFactory.Endeavor, },
			[33] = new List<Move>() { MoveFactory.EchoedVoice, },
			[36] = new List<Move>() { MoveFactory.Flamethrower, },
			[39] = new List<Move>() { MoveFactory.Crunch, },
			[43] = new List<Move>() { MoveFactory.HyperVoice, },
			[46] = new List<Move>() { MoveFactory.Incinerate, },
			[50] = new List<Move>() { MoveFactory.Overheat, },
		};
	}
}
