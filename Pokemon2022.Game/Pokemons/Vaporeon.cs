using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vaporeon : Pokemon
	{
		public override string Name => "Vaporeon";
		public override int Generation => 1;
		public override string PokedexEntry => "Vaporeon underwent a spontaneous mutation and grew fins and gills that allow them to live underwater. They have the ability to freely control water.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 130,
			Attack = 65,
			Defense = 60,
			SpecialAttack = 110,
			SpecialDefense = 95,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.WaterGun, },
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Covet, MoveFactory.Swift, MoveFactory.Bite, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.TakeDown, MoveFactory.Charm, MoveFactory.DoubleEdge, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.Haze, },
			[25] = new List<Move>() { MoveFactory.WaterPulse, },
			[30] = new List<Move>() { MoveFactory.AuroraBeam, },
			[35] = new List<Move>() { MoveFactory.AquaRing, },
			[40] = new List<Move>() { MoveFactory.MuddyWater, },
			[45] = new List<Move>() { MoveFactory.AcidArmor, },
			[50] = new List<Move>() { MoveFactory.HydroPump, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}
