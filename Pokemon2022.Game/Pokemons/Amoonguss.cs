using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Amoonguss : Pokemon
	{
		public override string Name => "Amoonguss";
		public override int Generation => 5;
		public override string PokedexEntry => "They show off their Poké Ball caps to lure prey, but very few Pokémon are fooled by this.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EffectSpore, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 114,
			Attack = 85,
			Defense = 70,
			SpecialAttack = 85,
			SpecialDefense = 80,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Astonish, MoveFactory.Growth, MoveFactory.StunSpore, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.Synthesis, },
			[20] = new List<Move>() { MoveFactory.ClearSmog, },
			[24] = new List<Move>() { MoveFactory.SweetScent, },
			[28] = new List<Move>() { MoveFactory.GigaDrain, },
			[32] = new List<Move>() { MoveFactory.Ingrain, },
			[36] = new List<Move>() { MoveFactory.Toxic, },
			[42] = new List<Move>() { MoveFactory.RagePowder, },
			[48] = new List<Move>() { MoveFactory.SolarBeam, },
			[54] = new List<Move>() { MoveFactory.Spore, },
		};
	}
}
