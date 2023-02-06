using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Trevenant : Pokemon
	{
		public override string Name => "Trevenant";
		public override int Generation => 6;
		public override string PokedexEntry => "Through its roots, it exerts control over other trees. A deadly curse falls upon anyone cutting down trees in forests where Trevenant dwell.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Harvest;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 110,
			Defense = 76,
			SpecialAttack = 65,
			SpecialDefense = 82,
			Speed = 56
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ShadowClaw, },
			[1] = new List<Move>() { MoveFactory.ShadowClaw, MoveFactory.Astonish, MoveFactory.Tackle, MoveFactory.BranchPoke, MoveFactory.LeechSeed, },
			[12] = new List<Move>() { MoveFactory.ConfuseRay, },
			[16] = new List<Move>() { MoveFactory.WillOWisp, },
			[20] = new List<Move>() { MoveFactory.Hex, },
			[24] = new List<Move>() { MoveFactory.Growth, },
			[28] = new List<Move>() { MoveFactory.HornLeech, },
			[32] = new List<Move>() { MoveFactory.Curse, },
			[36] = new List<Move>() { MoveFactory.PhantomForce, },
			[40] = new List<Move>() { MoveFactory.Ingrain, },
			[44] = new List<Move>() { MoveFactory.WoodHammer, },
			[48] = new List<Move>() { MoveFactory.DestinyBond, },
			[52] = new List<Move>() { MoveFactory.ForestsCurse, },
		};
	}
}
