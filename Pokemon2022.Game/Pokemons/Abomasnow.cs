using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Abomasnow : Pokemon
	{
		public override string Name => "Abomasnow";
		public override int Generation => 4;
		public override string PokedexEntry => "It whips up blizzards in mountains that are always buried in snow. It is the abominable snowman.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SnowWarning, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Soundproof;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 92,
			Defense = 75,
			SpecialAttack = 92,
			SpecialDefense = 85,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IcePunch, },
			[1] = new List<Move>() { MoveFactory.IcePunch, MoveFactory.AuroraVeil, MoveFactory.PowderSnow, MoveFactory.Leer, MoveFactory.Leafage, MoveFactory.Mist, },
			[15] = new List<Move>() { MoveFactory.IceShard, },
			[20] = new List<Move>() { MoveFactory.RazorLeaf, },
			[25] = new List<Move>() { MoveFactory.IcyWind, },
			[30] = new List<Move>() { MoveFactory.Swagger, },
			[35] = new List<Move>() { MoveFactory.Ingrain, },
			[43] = new List<Move>() { MoveFactory.WoodHammer, },
			[49] = new List<Move>() { MoveFactory.Blizzard, },
			[56] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}
