using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Octillery : Pokemon
	{
		public override string Name => "Octillery";
		public override int Generation => 2;
		public override string PokedexEntry => "It ensnares its foe with its suction- cupped tentacles before delivering the finishing blow. If the foe turns out to be too strong, it spews ink to escape.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SuctionCups, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moody;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 105,
			Defense = 75,
			SpecialAttack = 105,
			SpecialDefense = 75,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Octazooka, },
			[1] = new List<Move>() { MoveFactory.Octazooka, MoveFactory.GunkShot, MoveFactory.RockBlast, MoveFactory.HelpingHand, MoveFactory.WaterGun, MoveFactory.Wrap, MoveFactory.WaterPulse, MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.Psybeam, },
			[16] = new List<Move>() { MoveFactory.AuroraBeam, },
			[20] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.LockOn, },
			[30] = new List<Move>() { MoveFactory.BulletSeed, },
			[36] = new List<Move>() { MoveFactory.IceBeam, },
			[42] = new List<Move>() { MoveFactory.HydroPump, },
			[48] = new List<Move>() { MoveFactory.Soak, },
			[54] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
