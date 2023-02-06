using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Delcatty : Pokemon
	{
		public override string Name => "Delcatty";
		public override int Generation => 3;
		public override string PokedexEntry => "Rather than keeping a permanent lair, it habitually seeks comfortable spots and sleeps there. It is nocturnal and becomes active at dusk.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.Normalize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WonderSkin;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 65,
			Defense = 65,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FakeOut, MoveFactory.Sing, MoveFactory.Attract, },
		};
	}
}
