using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dragonair : Pokemon
	{
		public override string Name => "Dragonair";
		public override int Generation => 1;
		public override string PokedexEntry => "A Dragonair stores an enormous amount of energy inside its body. It is said to alter the weather around it by loosing energy from the crystals on its neck and tail.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MarvelScale;
		public override Stats BaseStats => new Stats() {
			HP = 61,
			Attack = 84,
			Defense = 65,
			SpecialAttack = 70,
			SpecialDefense = 70,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.Leer, MoveFactory.Twister, MoveFactory.ThunderWave, },
			[15] = new List<Move>() { MoveFactory.DragonTail, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.Slam, },
			[33] = new List<Move>() { MoveFactory.AquaTail, },
			[39] = new List<Move>() { MoveFactory.DragonRush, },
			[46] = new List<Move>() { MoveFactory.Safeguard, },
			[53] = new List<Move>() { MoveFactory.RainDance, },
			[60] = new List<Move>() { MoveFactory.DragonDance, },
			[67] = new List<Move>() { MoveFactory.Outrage, },
			[74] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
