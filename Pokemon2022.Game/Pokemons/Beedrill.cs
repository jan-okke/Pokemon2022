using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Beedrill : Pokemon
	{
		public override string Name => "Beedrill";
		public override int Generation => 1;
		public override string PokedexEntry => "A Beedrill is extremely territorial. For safety reasons, no one should ever approach its nest. If angered, they will attack in a swarm.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sniper;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 90,
			Defense = 40,
			SpecialAttack = 45,
			SpecialDefense = 80,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FuryAttack, },
			[1] = new List<Move>() { MoveFactory.BugBite, MoveFactory.FuryAttack, },
			[11] = new List<Move>() { MoveFactory.FuryCutter, },
			[14] = new List<Move>() { MoveFactory.LaserFocus, },
			[17] = new List<Move>() { MoveFactory.PoisonSting, },
			[20] = new List<Move>() { MoveFactory.FocusEnergy, },
			[23] = new List<Move>() { MoveFactory.Venoshock, },
			[26] = new List<Move>() { MoveFactory.Assurance, },
			[29] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[32] = new List<Move>() { MoveFactory.PinMissile, },
			[35] = new List<Move>() { MoveFactory.PoisonJab, },
			[38] = new List<Move>() { MoveFactory.Agility, },
			[41] = new List<Move>() { MoveFactory.Endeavor, },
			[44] = new List<Move>() { MoveFactory.FellStinger, },
		};
	}
}
