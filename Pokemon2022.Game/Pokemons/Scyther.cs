using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Scyther : Pokemon
	{
		public override string Name => "Scyther";
		public override int Generation => 1;
		public override string PokedexEntry => "Its blindingly fast speed adds to the sharpness of its twin forearm scythes. The scythes can slice through thick logs in one wicked stroke.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Technician, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Steadfast;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 110,
			Defense = 80,
			SpecialAttack = 55,
			SpecialDefense = 80,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.FuryCutter, },
			[8] = new List<Move>() { MoveFactory.FalseSwipe, },
			[12] = new List<Move>() { MoveFactory.WingAttack, },
			[16] = new List<Move>() { MoveFactory.DoubleTeam, },
			[20] = new List<Move>() { MoveFactory.DoubleHit, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[28] = new List<Move>() { MoveFactory.FocusEnergy, },
			[32] = new List<Move>() { MoveFactory.Agility, },
			[36] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.XScissor, },
			[44] = new List<Move>() { MoveFactory.LaserFocus, },
			[48] = new List<Move>() { MoveFactory.SwordsDance, },
		};
	}
}
