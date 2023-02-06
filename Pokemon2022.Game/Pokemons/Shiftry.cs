using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shiftry : Pokemon
	{
		public override string Name => "Shiftry";
		public override int Generation => 3;
		public override string PokedexEntry => "It is said to arrive on chilly, wintry winds. Feared from long ago as the guardian of forests, this Pokémon lives in a deep forest where people do not venture.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 100,
			Defense = 60,
			SpecialAttack = 90,
			SpecialDefense = 60,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.LeafTornado, },
			[1] = new List<Move>() { MoveFactory.LeafTornado, MoveFactory.RazorLeaf, MoveFactory.AirCutter, MoveFactory.Torment, MoveFactory.FakeOut, MoveFactory.Swagger, MoveFactory.Whirlwind, MoveFactory.Hurricane, MoveFactory.Synthesis, MoveFactory.Explosion, MoveFactory.Growth, MoveFactory.Rollout, MoveFactory.MegaDrain, MoveFactory.Payback, MoveFactory.NaturePower, MoveFactory.SunnyDay, MoveFactory.Extrasensory, MoveFactory.SuckerPunch, MoveFactory.LeafBlade, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.Absorb, MoveFactory.Astonish, },
		};
	}
}
