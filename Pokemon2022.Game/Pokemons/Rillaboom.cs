using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rillaboom : Pokemon
	{
		public override string Name => "Rillaboom";
		public override int Generation => 8;
		public override string PokedexEntry => "By drumming, it taps into the power of its special tree stump. The roots of the stump follow its direction in battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.GrassySurge;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 125,
			Defense = 90,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DrumBeating, },
			[1] = new List<Move>() { MoveFactory.DrumBeating, MoveFactory.DoubleHit, MoveFactory.GrassyTerrain, MoveFactory.NobleRoar, MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.BranchPoke, MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[19] = new List<Move>() { MoveFactory.Screech, },
			[24] = new List<Move>() { MoveFactory.KnockOff, },
			[30] = new List<Move>() { MoveFactory.Slam, },
			[38] = new List<Move>() { MoveFactory.Uproar, },
			[46] = new List<Move>() { MoveFactory.WoodHammer, },
			[54] = new List<Move>() { MoveFactory.Endeavor, },
			[62] = new List<Move>() { MoveFactory.Boomburst, },
		};
	}
}
