using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Totodile : Pokemon
	{
		public override string Name => "Totodile";
		public override int Generation => 2;
		public override string PokedexEntry => "Despite its small body, Totodile's jaws are very powerful. While it may think it is just playfully nipping, its bite has enough strength to cause serious injury.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 65,
			Defense = 64,
			SpecialAttack = 44,
			SpecialDefense = 48,
			Speed = 43
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[8] = new List<Move>() { MoveFactory.MudSlap, },
			[13] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.ScaryFace, },
			[20] = new List<Move>() { MoveFactory.IceFang, },
			[22] = new List<Move>() { MoveFactory.Flail, },
			[27] = new List<Move>() { MoveFactory.Crunch, },
			[29] = new List<Move>() { MoveFactory.LowKick, },
			[34] = new List<Move>() { MoveFactory.Slash, },
			[36] = new List<Move>() { MoveFactory.Screech, },
			[41] = new List<Move>() { MoveFactory.Thrash, },
			[43] = new List<Move>() { MoveFactory.AquaTail, },
			[48] = new List<Move>() { MoveFactory.Superpower, },
			[50] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
