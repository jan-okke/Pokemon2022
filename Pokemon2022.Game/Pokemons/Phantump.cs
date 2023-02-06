using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Phantump : Pokemon
	{
		public override string Name => "Phantump";
		public override int Generation => 6;
		public override string PokedexEntry => "These Pokémon are stumps possessed by the spirits of children who died in the forest. Their cries sound like eerie screams.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Harvest;
		public override Stats BaseStats => new Stats() {
			HP = 43,
			Attack = 70,
			Defense = 48,
			SpecialAttack = 50,
			SpecialDefense = 60,
			Speed = 38
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.BranchPoke, },
			[8] = new List<Move>() { MoveFactory.LeechSeed, },
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
