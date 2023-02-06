using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Remoraid : Pokemon
	{
		public override string Name => "Remoraid";
		public override int Generation => 2;
		public override string PokedexEntry => "A Remoraid uses its abdominal muscles to forcefully expel swallowed water, then shoot down flying prey. When evolution approaches, it travels down rivers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hustle, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moody;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 65,
			Defense = 35,
			SpecialAttack = 65,
			SpecialDefense = 35,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.HelpingHand, },
			[4] = new List<Move>() { MoveFactory.WaterPulse, },
			[8] = new List<Move>() { MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.Psybeam, },
			[16] = new List<Move>() { MoveFactory.AuroraBeam, },
			[20] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.LockOn, },
			[28] = new List<Move>() { MoveFactory.BulletSeed, },
			[32] = new List<Move>() { MoveFactory.IceBeam, },
			[36] = new List<Move>() { MoveFactory.HydroPump, },
			[40] = new List<Move>() { MoveFactory.Soak, },
			[44] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
