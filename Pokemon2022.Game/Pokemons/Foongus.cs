using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Foongus : Pokemon
	{
		public override string Name => "Foongus";
		public override int Generation => 5;
		public override string PokedexEntry => "For some reason, this Pokémon resembles a Poké Ball. They release poison spores to repel those who try to catch them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EffectSpore, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 69,
			Attack = 55,
			Defense = 45,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.Growth, },
			[8] = new List<Move>() { MoveFactory.StunSpore, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.Synthesis, },
			[20] = new List<Move>() { MoveFactory.ClearSmog, },
			[24] = new List<Move>() { MoveFactory.SweetScent, },
			[28] = new List<Move>() { MoveFactory.GigaDrain, },
			[32] = new List<Move>() { MoveFactory.Ingrain, },
			[36] = new List<Move>() { MoveFactory.Toxic, },
			[40] = new List<Move>() { MoveFactory.RagePowder, },
			[44] = new List<Move>() { MoveFactory.SolarBeam, },
			[48] = new List<Move>() { MoveFactory.Spore, },
		};
	}
}
