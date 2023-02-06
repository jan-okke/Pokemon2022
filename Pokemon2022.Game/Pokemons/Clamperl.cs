using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Clamperl : Pokemon
	{
		public override string Name => "Clamperl";
		public override int Generation => 3;
		public override string PokedexEntry => "A Clamperl slams its shell closed on prey to prevent escape. The pearl it creates upon evolution is said to be infused with a mysterious energy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 64,
			Defense = 85,
			SpecialAttack = 74,
			SpecialDefense = 55,
			Speed = 32
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Whirlpool, MoveFactory.IronDefense, },
			[50] = new List<Move>() { MoveFactory.ShellSmash, },
		};
	}
}
