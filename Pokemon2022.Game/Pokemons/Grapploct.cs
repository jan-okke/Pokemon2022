using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Grapploct : Pokemon
	{
		public override string Name => "Grapploct";
		public override int Generation => 8;
		public override string PokedexEntry => "A body made up of nothing but muscle makes the grappling moves this Pokémon performs with its tentacles tremendously powerful.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Technician;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 118,
			Defense = 90,
			SpecialAttack = 70,
			SpecialDefense = 80,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Octolock, },
			[1] = new List<Move>() { MoveFactory.Octolock, MoveFactory.Octazooka, MoveFactory.RockSmash, MoveFactory.Leer, MoveFactory.Feint, MoveFactory.Bind, },
			[15] = new List<Move>() { MoveFactory.Detect, },
			[20] = new List<Move>() { MoveFactory.BrickBreak, },
			[25] = new List<Move>() { MoveFactory.BulkUp, },
			[30] = new List<Move>() { MoveFactory.Submission, },
			[35] = new List<Move>() { MoveFactory.Taunt, },
			[40] = new List<Move>() { MoveFactory.Reversal, },
			[45] = new List<Move>() { MoveFactory.Superpower, },
			[50] = new List<Move>() { MoveFactory.TopsyTurvy, },
		};
	}
}
