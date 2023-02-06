using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zarude : Pokemon
	{
		public override string Name => "Zarude";
		public override int Generation => 8;
		public override string PokedexEntry => "Once the vines on Zarude's body tear off, they become nutrients in the soil. This helps the plants of the forest grow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LeafGuard, };
		public override Stats BaseStats => new Stats() {
			HP = 105,
			Attack = 120,
			Defense = 105,
			SpecialAttack = 70,
			SpecialDefense = 95,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Bind, MoveFactory.Scratch, },
			[6] = new List<Move>() { MoveFactory.Leer, },
			[12] = new List<Move>() { MoveFactory.VineWhip, },
			[18] = new List<Move>() { MoveFactory.Growth, },
			[24] = new List<Move>() { MoveFactory.FurySwipes, },
			[30] = new List<Move>() { MoveFactory.ScaryFace, },
			[36] = new List<Move>() { MoveFactory.GrassKnot, },
			[42] = new List<Move>() { MoveFactory.Bite, },
			[48] = new List<Move>() { MoveFactory.Uturn, },
			[54] = new List<Move>() { MoveFactory.Swagger, },
			[60] = new List<Move>() { MoveFactory.EnergyBall, },
			[66] = new List<Move>() { MoveFactory.Synthesis, },
			[72] = new List<Move>() { MoveFactory.HammerArm, },
			[78] = new List<Move>() { MoveFactory.Thrash, },
			[84] = new List<Move>() { MoveFactory.PowerWhip, },
			[90] = new List<Move>() { MoveFactory.JungleHealing, },
		};
	}
}
