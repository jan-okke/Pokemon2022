using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Charmeleon : Pokemon
	{
		public override string Name => "Charmeleon";
		public override int Generation => 1;
		public override string PokedexEntry => "Without pity, its sharp claws destroy foes. If it encounters a strong enemy, it becomes agitated, and the flame on its tail flares with a bluish white color.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SolarPower;
		public override Stats BaseStats => new Stats() {
			HP = 58,
			Attack = 64,
			Defense = 58,
			SpecialAttack = 80,
			SpecialDefense = 65,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.Ember, MoveFactory.Smokescreen, },
			[12] = new List<Move>() { MoveFactory.DragonBreath, },
			[19] = new List<Move>() { MoveFactory.FireFang, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.Flamethrower, },
			[37] = new List<Move>() { MoveFactory.ScaryFace, },
			[42] = new List<Move>() { MoveFactory.FireSpin, },
			[48] = new List<Move>() { MoveFactory.Inferno, },
			[54] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
