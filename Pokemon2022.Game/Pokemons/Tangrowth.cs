using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tangrowth : Pokemon
	{
		public override string Name => "Tangrowth";
		public override int Generation => 4;
		public override string PokedexEntry => "It ensnares prey by extending arms made of vines. Losing arms to predators does not trouble it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.LeafGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 100,
			Defense = 125,
			SpecialAttack = 110,
			SpecialDefense = 50,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Block, MoveFactory.Absorb, MoveFactory.Bind, MoveFactory.StunSpore, MoveFactory.Growth, },
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
