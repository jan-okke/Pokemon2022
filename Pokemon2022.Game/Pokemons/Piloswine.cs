using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Piloswine : Pokemon
	{
		public override string Name => "Piloswine";
		public override int Generation => 2;
		public override string PokedexEntry => "A Piloswine is covered by a thick coat of long hair for enduring freezing cold. It uses its tusks to dig up food that has been buried under ice.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.SnowCloak, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ThickFat;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 100,
			Defense = 80,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IceFang, },
			[1] = new List<Move>() { MoveFactory.IceFang, MoveFactory.AncientPower, MoveFactory.Tackle, MoveFactory.MudSlap, MoveFactory.PowderSnow, MoveFactory.Flail, },
			[15] = new List<Move>() { MoveFactory.IceShard, },
			[20] = new List<Move>() { MoveFactory.Mist, },
			[25] = new List<Move>() { MoveFactory.Endure, },
			[30] = new List<Move>() { MoveFactory.IcyWind, },
			[37] = new List<Move>() { MoveFactory.Amnesia, },
			[44] = new List<Move>() { MoveFactory.TakeDown, },
			[51] = new List<Move>() { MoveFactory.Earthquake, },
			[58] = new List<Move>() { MoveFactory.Blizzard, },
			[65] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}
