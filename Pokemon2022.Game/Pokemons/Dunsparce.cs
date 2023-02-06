using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dunsparce : Pokemon
	{
		public override string Name => "Dunsparce";
		public override int Generation => 2;
		public override string PokedexEntry => "Its drill-tipped tail is used to burrow into the ground backwards. This Pokémon is known to make its nest in complex shapes deep under the ground.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SereneGrace, AbilityFactory.RunAway, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 70,
			Defense = 70,
			SpecialAttack = 65,
			SpecialDefense = 65,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Flail, MoveFactory.DefenseCurl, },
			[4] = new List<Move>() { MoveFactory.MudSlap, },
			[8] = new List<Move>() { MoveFactory.Rollout, },
			[12] = new List<Move>() { MoveFactory.Glare, },
			[16] = new List<Move>() { MoveFactory.Screech, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[24] = new List<Move>() { MoveFactory.DrillRun, },
			[28] = new List<Move>() { MoveFactory.Yawn, },
			[32] = new List<Move>() { MoveFactory.BodySlam, },
			[36] = new List<Move>() { MoveFactory.TakeDown, },
			[40] = new List<Move>() { MoveFactory.Roost, },
			[44] = new List<Move>() { MoveFactory.DragonRush, },
			[48] = new List<Move>() { MoveFactory.Coil, },
			[52] = new List<Move>() { MoveFactory.DoubleEdge, },
			[56] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}
