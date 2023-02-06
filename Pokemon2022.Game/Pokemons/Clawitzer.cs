using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Clawitzer : Pokemon
	{
		public override string Name => "Clawitzer";
		public override int Generation => 6;
		public override string PokedexEntry => "By expelling water from the nozzle in the back of its claw, it can move at a speed of 60 knots.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MegaLauncher, };
		public override Stats BaseStats => new Stats() {
			HP = 71,
			Attack = 73,
			Defense = 88,
			SpecialAttack = 120,
			SpecialDefense = 89,
			Speed = 59
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DarkPulse, MoveFactory.DragonPulse, MoveFactory.HealPulse, MoveFactory.Splash, MoveFactory.WaterGun, MoveFactory.ViseGrip, MoveFactory.Flail, },
			[15] = new List<Move>() { MoveFactory.AquaJet, },
			[20] = new List<Move>() { MoveFactory.SmackDown, },
			[25] = new List<Move>() { MoveFactory.HoneClaws, },
			[30] = new List<Move>() { MoveFactory.WaterPulse, },
			[35] = new List<Move>() { MoveFactory.SwordsDance, },
			[42] = new List<Move>() { MoveFactory.AuraSphere, },
			[49] = new List<Move>() { MoveFactory.Bounce, },
			[56] = new List<Move>() { MoveFactory.MuddyWater, },
			[63] = new List<Move>() { MoveFactory.Crabhammer, },
		};
	}
}
