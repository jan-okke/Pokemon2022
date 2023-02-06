using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Yamper : Pokemon
	{
		public override string Name => "Yamper";
		public override int Generation => 8;
		public override string PokedexEntry => "This gluttonous Pokémon only assists people with their work because it wants treats. As it runs, it crackles with electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BallFetch, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 59,
			Attack = 45,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 26
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.Nuzzle, },
			[10] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.Roar, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[26] = new List<Move>() { MoveFactory.Charm, },
			[30] = new List<Move>() { MoveFactory.Crunch, },
			[35] = new List<Move>() { MoveFactory.Charge, },
			[40] = new List<Move>() { MoveFactory.WildCharge, },
			[45] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}
