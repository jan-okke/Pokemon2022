using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pancham : Pokemon
	{
		public override string Name => "Pancham";
		public override int Generation => 6;
		public override string PokedexEntry => "It does its best to be taken seriously by its enemies, but its glare is not sufficiently intimidating. Chewing on a leaf is its trademark.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IronFist, AbilityFactory.MoldBreaker, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 67,
			Attack = 82,
			Defense = 62,
			SpecialAttack = 46,
			SpecialDefense = 48,
			Speed = 43
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.ArmThrust, },
			[8] = new List<Move>() { MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.CircleThrow, },
			[16] = new List<Move>() { MoveFactory.LowSweep, },
			[20] = new List<Move>() { MoveFactory.WorkUp, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[28] = new List<Move>() { MoveFactory.VitalThrow, },
			[33] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.BodySlam, },
			[40] = new List<Move>() { MoveFactory.PartingShot, },
			[44] = new List<Move>() { MoveFactory.Entrainment, },
		};
	}
}
