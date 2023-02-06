using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cramorant : Pokemon
	{
		public override string Name => "Cramorant";
		public override int Generation => 8;
		public override string PokedexEntry => "It's so strong that it can knock out some opponents in a single hit, but it also may forget what it's battling midfight.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Flying, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.GulpMissile, };
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 85,
			Defense = 55,
			SpecialAttack = 85,
			SpecialDefense = 95,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Belch, MoveFactory.Peck, MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[7] = new List<Move>() { MoveFactory.WaterGun, },
			[14] = new List<Move>() { MoveFactory.FuryAttack, },
			[21] = new List<Move>() { MoveFactory.Pluck, },
			[28] = new List<Move>() { MoveFactory.Dive, },
			[35] = new List<Move>() { MoveFactory.DrillPeck, },
			[42] = new List<Move>() { MoveFactory.Amnesia, },
			[49] = new List<Move>() { MoveFactory.Thrash, },
			[56] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
