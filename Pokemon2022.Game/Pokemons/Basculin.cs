using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Basculin : Pokemon
	{
		public override string Name => "Basculin";
		public override int Generation => 5;
		public override string PokedexEntry => "Savage, violent Pokémon, red and blue Basculin are always fighting each other over territory.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Reckless, AbilityFactory.Adaptability, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MoldBreaker;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 92,
			Defense = 65,
			SpecialAttack = 80,
			SpecialDefense = 55,
			Speed = 98
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.Tackle, },
			[8] = new List<Move>() { MoveFactory.Flail, },
			[12] = new List<Move>() { MoveFactory.AquaJet, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[24] = new List<Move>() { MoveFactory.Headbutt, },
			[28] = new List<Move>() { MoveFactory.Soak, },
			[32] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.TakeDown, },
			[40] = new List<Move>() { MoveFactory.FinalGambit, },
			[44] = new List<Move>() { MoveFactory.AquaTail, },
			[48] = new List<Move>() { MoveFactory.Thrash, },
			[52] = new List<Move>() { MoveFactory.DoubleEdge, },
			[56] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
