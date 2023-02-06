using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shieldon : Pokemon
	{
		public override string Name => "Shieldon";
		public override int Generation => 4;
		public override string PokedexEntry => "A Pokémon that lived in jungles around 100 million years ago. Its facial hide is extremely hard.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Soundproof;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 42,
			Defense = 118,
			SpecialAttack = 42,
			SpecialDefense = 88,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Protect, },
			[6] = new List<Move>() { MoveFactory.Taunt, },
			[10] = new List<Move>() { MoveFactory.MetalSound, },
			[15] = new List<Move>() { MoveFactory.TakeDown, },
			[19] = new List<Move>() { MoveFactory.IronDefense, },
			[24] = new List<Move>() { MoveFactory.Swagger, },
			[28] = new List<Move>() { MoveFactory.AncientPower, },
			[33] = new List<Move>() { MoveFactory.Endure, },
			[37] = new List<Move>() { MoveFactory.MetalBurst, },
			[42] = new List<Move>() { MoveFactory.IronHead, },
			[46] = new List<Move>() { MoveFactory.HeavySlam, },
		};
	}
}
