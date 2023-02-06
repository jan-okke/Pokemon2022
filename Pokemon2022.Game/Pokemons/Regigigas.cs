using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Regigigas : Pokemon
	{
		public override string Name => "Regigigas";
		public override int Generation => 4;
		public override string PokedexEntry => "There is an enduring legend that states this Pokémon towed continents with ropes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SlowStart, };
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 160,
			Defense = 110,
			SpecialAttack = 80,
			SpecialDefense = 110,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.ConfuseRay, },
			[6] = new List<Move>() { MoveFactory.Payback, },
			[12] = new List<Move>() { MoveFactory.Revenge, },
			[18] = new List<Move>() { MoveFactory.Stomp, },
			[24] = new List<Move>() { MoveFactory.Protect, },
			[30] = new List<Move>() { MoveFactory.KnockOff, },
			[36] = new List<Move>() { MoveFactory.MegaPunch, },
			[42] = new List<Move>() { MoveFactory.BodyPress, },
			[48] = new List<Move>() { MoveFactory.WideGuard, },
			[54] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[60] = new List<Move>() { MoveFactory.HeavySlam, },
			[66] = new List<Move>() { MoveFactory.HammerArm, },
			[72] = new List<Move>() { MoveFactory.GigaImpact, },
			[78] = new List<Move>() { MoveFactory.CrushGrip, },
		};
	}
}
