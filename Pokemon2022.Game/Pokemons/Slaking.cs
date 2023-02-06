using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Slaking : Pokemon
	{
		public override string Name => "Slaking";
		public override int Generation => 3;
		public override string PokedexEntry => "Hordes of Slaking gather around trees when fruits come into season. They wait around patiently for ripened fruits to fall out of the trees.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Truant, };
		public override Stats BaseStats => new Stats() {
			HP = 150,
			Attack = 160,
			Defense = 100,
			SpecialAttack = 95,
			SpecialDefense = 65,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Swagger, },
			[1] = new List<Move>() { MoveFactory.Swagger, MoveFactory.HammerArm, MoveFactory.Fling, MoveFactory.Scratch, MoveFactory.Yawn, MoveFactory.Encore, MoveFactory.SlackOff, },
			[6] = new List<Move>() { MoveFactory.Encore, },
			[9] = new List<Move>() { MoveFactory.SlackOff, },
			[14] = new List<Move>() { MoveFactory.Rest, },
			[17] = new List<Move>() { MoveFactory.Amnesia, },
			[23] = new List<Move>() { MoveFactory.Covet, },
			[27] = new List<Move>() { MoveFactory.Headbutt, },
			[33] = new List<Move>() { MoveFactory.Counter, },
			[39] = new List<Move>() { MoveFactory.Flail, },
			[47] = new List<Move>() { MoveFactory.Fling, },
			[53] = new List<Move>() { MoveFactory.SuckerPunch, },
			[61] = new List<Move>() { MoveFactory.HammerArm, },
		};
	}
}
