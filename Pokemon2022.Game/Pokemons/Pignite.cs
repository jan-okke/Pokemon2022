using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pignite : Pokemon
	{
		public override string Name => "Pignite";
		public override int Generation => 5;
		public override string PokedexEntry => "Whatever it eats becomes fuel for the flame in its stomach. When it is angered, the intensity of the flame increases.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ThickFat;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 93,
			Defense = 55,
			SpecialAttack = 70,
			SpecialDefense = 55,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ArmThrust, },
			[1] = new List<Move>() { MoveFactory.ArmThrust, MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.Ember, MoveFactory.OdorSleuth, },
			[3] = new List<Move>() { MoveFactory.TailWhip, },
			[7] = new List<Move>() { MoveFactory.Ember, },
			[9] = new List<Move>() { MoveFactory.OdorSleuth, },
			[13] = new List<Move>() { MoveFactory.DefenseCurl, },
			[15] = new List<Move>() { MoveFactory.FlameCharge, },
			[20] = new List<Move>() { MoveFactory.Smog, },
			[23] = new List<Move>() { MoveFactory.Rollout, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[31] = new List<Move>() { MoveFactory.HeatCrash, },
			[36] = new List<Move>() { MoveFactory.Assurance, },
			[39] = new List<Move>() { MoveFactory.Flamethrower, },
			[44] = new List<Move>() { MoveFactory.HeadSmash, },
			[47] = new List<Move>() { MoveFactory.Roar, },
			[52] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
