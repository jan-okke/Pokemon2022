using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dratini : Pokemon
	{
		public override string Name => "Dratini";
		public override int Generation => 1;
		public override string PokedexEntry => "A Dratini continually molts and sloughs off its old skin. It does so because the life energy within its body steadily builds to reach uncontrollable levels.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MarvelScale;
		public override Stats BaseStats => new Stats() {
			HP = 41,
			Attack = 64,
			Defense = 45,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.Twister, },
			[10] = new List<Move>() { MoveFactory.ThunderWave, },
			[15] = new List<Move>() { MoveFactory.DragonTail, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.Slam, },
			[31] = new List<Move>() { MoveFactory.AquaTail, },
			[35] = new List<Move>() { MoveFactory.DragonRush, },
			[40] = new List<Move>() { MoveFactory.Safeguard, },
			[45] = new List<Move>() { MoveFactory.RainDance, },
			[50] = new List<Move>() { MoveFactory.DragonDance, },
			[55] = new List<Move>() { MoveFactory.Outrage, },
			[60] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
