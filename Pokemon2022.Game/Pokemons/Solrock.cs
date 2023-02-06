using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Solrock : Pokemon
	{
		public override string Name => "Solrock";
		public override int Generation => 3;
		public override string PokedexEntry => "Solar energy is the source of this Pokémon's power. On sunny days, groups of Solrock line up facing the sun and absorb its light.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 95,
			Defense = 85,
			SpecialAttack = 55,
			SpecialDefense = 65,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FlareBlitz, MoveFactory.MorningSun, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.Confusion, MoveFactory.RockThrow, },
			[5] = new List<Move>() { MoveFactory.Hypnosis, },
			[10] = new List<Move>() { MoveFactory.RockPolish, },
			[15] = new List<Move>() { MoveFactory.RockSlide, },
			[20] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[25] = new List<Move>() { MoveFactory.CosmicPower, },
			[30] = new List<Move>() { MoveFactory.Psychic, },
			[35] = new List<Move>() { MoveFactory.StoneEdge, },
			[40] = new List<Move>() { MoveFactory.SolarBeam, },
			[45] = new List<Move>() { MoveFactory.WonderRoom, },
			[50] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
