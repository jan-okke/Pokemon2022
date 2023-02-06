using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Clauncher : Pokemon
	{
		public override string Name => "Clauncher";
		public override int Generation => 6;
		public override string PokedexEntry => "Through controlled expulsions of internal gas, it can expel water like a pistol shot. At close distances, it can shatter rock.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MegaLauncher, };
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 53,
			Defense = 62,
			SpecialAttack = 58,
			SpecialDefense = 63,
			Speed = 44
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, MoveFactory.WaterGun, },
			[5] = new List<Move>() { MoveFactory.ViseGrip, },
			[10] = new List<Move>() { MoveFactory.Flail, },
			[15] = new List<Move>() { MoveFactory.AquaJet, },
			[20] = new List<Move>() { MoveFactory.SmackDown, },
			[25] = new List<Move>() { MoveFactory.HoneClaws, },
			[30] = new List<Move>() { MoveFactory.WaterPulse, },
			[35] = new List<Move>() { MoveFactory.SwordsDance, },
			[40] = new List<Move>() { MoveFactory.AuraSphere, },
			[45] = new List<Move>() { MoveFactory.Bounce, },
			[50] = new List<Move>() { MoveFactory.MuddyWater, },
			[55] = new List<Move>() { MoveFactory.Crabhammer, },
		};
	}
}
