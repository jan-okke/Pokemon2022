using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lapras : Pokemon
	{
		public override string Name => "Lapras";
		public override int Generation => 1;
		public override string PokedexEntry => "People have driven Lapras almost to the point of extinction. In the evenings, it is said to sing plaintively as it seeks what few others of its kind still remain.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 130,
			Attack = 85,
			Defense = 80,
			SpecialAttack = 85,
			SpecialDefense = 95,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.WaterGun, },
			[5] = new List<Move>() { MoveFactory.Sing, },
			[10] = new List<Move>() { MoveFactory.Mist, },
			[15] = new List<Move>() { MoveFactory.LifeDew, },
			[20] = new List<Move>() { MoveFactory.IceShard, },
			[25] = new List<Move>() { MoveFactory.ConfuseRay, },
			[30] = new List<Move>() { MoveFactory.WaterPulse, },
			[35] = new List<Move>() { MoveFactory.Brine, },
			[40] = new List<Move>() { MoveFactory.BodySlam, },
			[45] = new List<Move>() { MoveFactory.IceBeam, },
			[50] = new List<Move>() { MoveFactory.RainDance, },
			[55] = new List<Move>() { MoveFactory.HydroPump, },
			[60] = new List<Move>() { MoveFactory.PerishSong, },
			[65] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}
