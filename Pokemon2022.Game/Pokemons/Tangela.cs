using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tangela : Pokemon
	{
		public override string Name => "Tangela";
		public override int Generation => 1;
		public override string PokedexEntry => "Its vines snap off easily and painlessly if they are grabbed, allowing it to make a quick getaway. The lost vines are replaced by new growth the very next day.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.LeafGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 55,
			Defense = 115,
			SpecialAttack = 100,
			SpecialDefense = 40,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Bind, },
			[4] = new List<Move>() { MoveFactory.StunSpore, },
			[8] = new List<Move>() { MoveFactory.Growth, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.VineWhip, },
			[20] = new List<Move>() { MoveFactory.PoisonPowder, },
			[24] = new List<Move>() { MoveFactory.AncientPower, },
			[28] = new List<Move>() { MoveFactory.KnockOff, },
			[32] = new List<Move>() { MoveFactory.GigaDrain, },
			[36] = new List<Move>() { MoveFactory.SleepPowder, },
			[40] = new List<Move>() { MoveFactory.Slam, },
			[44] = new List<Move>() { MoveFactory.Tickle, },
			[48] = new List<Move>() { MoveFactory.PowerWhip, },
			[52] = new List<Move>() { MoveFactory.Ingrain, },
			[56] = new List<Move>() { MoveFactory.GrassyTerrain, },
		};
	}
}
