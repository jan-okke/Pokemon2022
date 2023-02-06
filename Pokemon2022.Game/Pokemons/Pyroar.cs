using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pyroar : Pokemon
	{
		public override string Name => "Pyroar";
		public override int Generation => 6;
		public override string PokedexEntry => "With fiery breath of more than 6,000 degrees Celsius, they viciously threaten any challenger. The females protect the pride's cubs.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rivalry, AbilityFactory.Unnerve, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moxie;
		public override Stats BaseStats => new Stats() {
			HP = 86,
			Attack = 68,
			Defense = 72,
			SpecialAttack = 109,
			SpecialDefense = 66,
			Speed = 106
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.HyperBeam, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.Ember, MoveFactory.WorkUp, },
			[5] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.WorkUp, },
			[11] = new List<Move>() { MoveFactory.Headbutt, },
			[15] = new List<Move>() { MoveFactory.NobleRoar, },
			[20] = new List<Move>() { MoveFactory.TakeDown, },
			[23] = new List<Move>() { MoveFactory.FireFang, },
			[28] = new List<Move>() { MoveFactory.Endeavor, },
			[33] = new List<Move>() { MoveFactory.EchoedVoice, },
			[38] = new List<Move>() { MoveFactory.Flamethrower, },
			[42] = new List<Move>() { MoveFactory.Crunch, },
			[48] = new List<Move>() { MoveFactory.HyperVoice, },
			[51] = new List<Move>() { MoveFactory.Incinerate, },
			[57] = new List<Move>() { MoveFactory.Overheat, },
		};
	}
}
