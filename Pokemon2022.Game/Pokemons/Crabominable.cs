using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Crabominable : Pokemon
	{
		public override string Name => "Crabominable";
		public override int Generation => 7;
		public override string PokedexEntry => "It aimed for the top but got lost and ended up on a snowy mountain. Being forced to endure the cold, this Pokémon evolved and grew fur.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.IronFist, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AngerPoint;
		public override Stats BaseStats => new Stats() {
			HP = 97,
			Attack = 132,
			Defense = 77,
			SpecialAttack = 62,
			SpecialDefense = 67,
			Speed = 43
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IcePunch, },
			[1] = new List<Move>() { MoveFactory.IcePunch, MoveFactory.Bubble, MoveFactory.RockSmash, MoveFactory.Leer, MoveFactory.Pursuit, },
			[5] = new List<Move>() { MoveFactory.RockSmash, },
			[9] = new List<Move>() { MoveFactory.Leer, },
			[13] = new List<Move>() { MoveFactory.Pursuit, },
			[17] = new List<Move>() { MoveFactory.BubbleBeam, },
			[22] = new List<Move>() { MoveFactory.PowerUpPunch, },
			[25] = new List<Move>() { MoveFactory.DizzyPunch, },
			[29] = new List<Move>() { MoveFactory.Avalanche, },
			[33] = new List<Move>() { MoveFactory.Reversal, },
			[37] = new List<Move>() { MoveFactory.IceHammer, },
			[42] = new List<Move>() { MoveFactory.IronDefense, },
			[45] = new List<Move>() { MoveFactory.DynamicPunch, },
			[49] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}
