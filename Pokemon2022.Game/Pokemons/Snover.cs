using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Snover : Pokemon
	{
		public override string Name => "Snover";
		public override int Generation => 4;
		public override string PokedexEntry => "It lives on snowy mountains. Having had little contact with humans, it is boldly inquisitive.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SnowWarning, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Soundproof;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 62,
			Defense = 50,
			SpecialAttack = 62,
			SpecialDefense = 60,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.Leafage, },
			[10] = new List<Move>() { MoveFactory.Mist, },
			[15] = new List<Move>() { MoveFactory.IceShard, },
			[20] = new List<Move>() { MoveFactory.RazorLeaf, },
			[25] = new List<Move>() { MoveFactory.IcyWind, },
			[30] = new List<Move>() { MoveFactory.Swagger, },
			[35] = new List<Move>() { MoveFactory.Ingrain, },
			[41] = new List<Move>() { MoveFactory.WoodHammer, },
			[45] = new List<Move>() { MoveFactory.Blizzard, },
			[50] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}
