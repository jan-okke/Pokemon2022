using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chikorita : Pokemon
	{
		public override string Name => "Chikorita";
		public override int Generation => 2;
		public override string PokedexEntry => "It waves its leaf around to keep foes at bay. However, a sweet fragrance also wafts from the leaf, creating a friendly atmosphere that becalms the battlers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LeafGuard;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 49,
			Defense = 65,
			SpecialAttack = 49,
			SpecialDefense = 65,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.RazorLeaf, },
			[9] = new List<Move>() { MoveFactory.PoisonPowder, },
			[12] = new List<Move>() { MoveFactory.Synthesis, },
			[17] = new List<Move>() { MoveFactory.Reflect, },
			[20] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[23] = new List<Move>() { MoveFactory.NaturePower, },
			[28] = new List<Move>() { MoveFactory.SweetScent, },
			[31] = new List<Move>() { MoveFactory.LightScreen, },
			[34] = new List<Move>() { MoveFactory.BodySlam, },
			[39] = new List<Move>() { MoveFactory.Safeguard, },
			[42] = new List<Move>() { MoveFactory.Aromatherapy, },
			[45] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}
