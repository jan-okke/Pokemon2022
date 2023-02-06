using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bastiodon : Pokemon
	{
		public override string Name => "Bastiodon";
		public override int Generation => 4;
		public override string PokedexEntry => "Any frontal attack is repulsed. It is a docile Pokémon that feeds on grass and berries.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Soundproof;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 52,
			Defense = 168,
			SpecialAttack = 47,
			SpecialDefense = 138,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Block, },
			[1] = new List<Move>() { MoveFactory.Block, MoveFactory.Tackle, MoveFactory.Protect, MoveFactory.Taunt, MoveFactory.MetalSound, },
			[6] = new List<Move>() { MoveFactory.Taunt, },
			[10] = new List<Move>() { MoveFactory.MetalSound, },
			[15] = new List<Move>() { MoveFactory.TakeDown, },
			[19] = new List<Move>() { MoveFactory.IronDefense, },
			[24] = new List<Move>() { MoveFactory.Swagger, },
			[28] = new List<Move>() { MoveFactory.AncientPower, },
			[36] = new List<Move>() { MoveFactory.Endure, },
			[43] = new List<Move>() { MoveFactory.MetalBurst, },
			[51] = new List<Move>() { MoveFactory.IronHead, },
			[58] = new List<Move>() { MoveFactory.HeavySlam, },
		};
	}
}
