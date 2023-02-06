using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bayleef : Pokemon
	{
		public override string Name => "Bayleef";
		public override int Generation => 2;
		public override string PokedexEntry => "A Bayleef's neck is ringed by curled-up leaves. Inside each leaf is a small tree shoot. The fragrance of this shoot makes people peppy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LeafGuard;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 62,
			Defense = 80,
			SpecialAttack = 63,
			SpecialDefense = 80,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.RazorLeaf, MoveFactory.PoisonPowder, },
			[6] = new List<Move>() { MoveFactory.RazorLeaf, },
			[9] = new List<Move>() { MoveFactory.PoisonPowder, },
			[12] = new List<Move>() { MoveFactory.Synthesis, },
			[18] = new List<Move>() { MoveFactory.Reflect, },
			[22] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[26] = new List<Move>() { MoveFactory.NaturePower, },
			[32] = new List<Move>() { MoveFactory.SweetScent, },
			[36] = new List<Move>() { MoveFactory.LightScreen, },
			[40] = new List<Move>() { MoveFactory.BodySlam, },
			[46] = new List<Move>() { MoveFactory.Safeguard, },
			[50] = new List<Move>() { MoveFactory.Aromatherapy, },
			[54] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}
