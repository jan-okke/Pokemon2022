using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nuzleaf : Pokemon
	{
		public override string Name => "Nuzleaf";
		public override int Generation => 3;
		public override string PokedexEntry => "A forest-dwelling Pokémon that is skilled at climbing trees. Its long and pointed nose is its weak point. It loses power if the nose is gripped.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 70,
			Defense = 40,
			SpecialAttack = 60,
			SpecialDefense = 40,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.RazorLeaf, },
			[1] = new List<Move>() { MoveFactory.RazorLeaf, MoveFactory.AirCutter, MoveFactory.Torment, MoveFactory.FakeOut, MoveFactory.Swagger, MoveFactory.Synthesis, MoveFactory.Explosion, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.Absorb, MoveFactory.Astonish, },
			[9] = new List<Move>() { MoveFactory.Growth, },
			[12] = new List<Move>() { MoveFactory.Rollout, },
			[18] = new List<Move>() { MoveFactory.MegaDrain, },
			[24] = new List<Move>() { MoveFactory.Payback, },
			[30] = new List<Move>() { MoveFactory.NaturePower, },
			[36] = new List<Move>() { MoveFactory.SunnyDay, },
			[43] = new List<Move>() { MoveFactory.Extrasensory, },
			[50] = new List<Move>() { MoveFactory.SuckerPunch, },
			[57] = new List<Move>() { MoveFactory.LeafBlade, },
		};
	}
}
