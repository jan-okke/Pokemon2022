using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Qwilfish : Pokemon
	{
		public override string Name => "Qwilfish";
		public override int Generation => 2;
		public override string PokedexEntry => "A Qwilfish uses the pressure of water it swallows to shoot toxic quills all at once from all over its body. It finds swimming to be somewhat challenging.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Intimidate;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 95,
			Defense = 85,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Harden, },
			[8] = new List<Move>() { MoveFactory.WaterGun, },
			[12] = new List<Move>() { MoveFactory.FellStinger, },
			[16] = new List<Move>() { MoveFactory.Minimize, },
			[20] = new List<Move>() { MoveFactory.Spikes, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.Revenge, },
			[32] = new List<Move>() { MoveFactory.PinMissile, },
			[36] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[40] = new List<Move>() { MoveFactory.PoisonJab, },
			[44] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.SpitUp, },
			[48] = new List<Move>() { MoveFactory.TakeDown, },
			[52] = new List<Move>() { MoveFactory.Toxic, },
			[56] = new List<Move>() { MoveFactory.AquaTail, },
			[60] = new List<Move>() { MoveFactory.Acupressure, },
			[66] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}
