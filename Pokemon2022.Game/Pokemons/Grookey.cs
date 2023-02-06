using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Grookey : Pokemon
	{
		public override string Name => "Grookey";
		public override int Generation => 8;
		public override string PokedexEntry => "When it uses its special stick to strike up a beat, the sound waves produced carry revitalizing energy to the plants and flowers in the area.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.GrassySurge;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 65,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.BranchPoke, },
			[8] = new List<Move>() { MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[17] = new List<Move>() { MoveFactory.Screech, },
			[20] = new List<Move>() { MoveFactory.KnockOff, },
			[24] = new List<Move>() { MoveFactory.Slam, },
			[28] = new List<Move>() { MoveFactory.Uproar, },
			[32] = new List<Move>() { MoveFactory.WoodHammer, },
			[36] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}
