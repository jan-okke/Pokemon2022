using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Clobbopus : Pokemon
	{
		public override string Name => "Clobbopus";
		public override int Generation => 8;
		public override string PokedexEntry => "It's very curious, but its means of investigating things is to try to punch them with its tentacles. The search for food is what brings it onto land.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Technician;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 68,
			Defense = 60,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 32
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.RockSmash, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.Feint, },
			[10] = new List<Move>() { MoveFactory.Bind, },
			[15] = new List<Move>() { MoveFactory.Detect, },
			[20] = new List<Move>() { MoveFactory.BrickBreak, },
			[25] = new List<Move>() { MoveFactory.BulkUp, },
			[30] = new List<Move>() { MoveFactory.Submission, },
			[35] = new List<Move>() { MoveFactory.Taunt, },
			[40] = new List<Move>() { MoveFactory.Reversal, },
			[45] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}
