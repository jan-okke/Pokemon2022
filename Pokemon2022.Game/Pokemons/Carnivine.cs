using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Carnivine : Pokemon
	{
		public override string Name => "Carnivine";
		public override int Generation => 4;
		public override string PokedexEntry => "It attracts prey with its sweet-smelling saliva, then chomps down. It takes a whole day to eat prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 74,
			Attack = 100,
			Defense = 72,
			SpecialAttack = 90,
			SpecialDefense = 72,
			Speed = 46
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Bind, MoveFactory.Growth, },
			[7] = new List<Move>() { MoveFactory.Bite, },
			[11] = new List<Move>() { MoveFactory.VineWhip, },
			[17] = new List<Move>() { MoveFactory.SweetScent, },
			[21] = new List<Move>() { MoveFactory.Ingrain, },
			[27] = new List<Move>() { MoveFactory.GrassKnot, },
			[31] = new List<Move>() { MoveFactory.LeafTornado, },
			[37] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.SpitUp, MoveFactory.Swallow, },
			[41] = new List<Move>() { MoveFactory.Crunch, },
			[47] = new List<Move>() { MoveFactory.SeedBomb, },
			[50] = new List<Move>() { MoveFactory.PowerWhip, },
		};
	}
}
