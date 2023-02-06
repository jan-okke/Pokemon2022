using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rufflet : Pokemon
	{
		public override string Name => "Rufflet";
		public override int Generation => 5;
		public override string PokedexEntry => "They will challenge anything, even strong opponents, without fear. Their frequent fights help them become stronger.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 83,
			Defense = 50,
			SpecialAttack = 37,
			SpecialDefense = 50,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.WingAttack, },
			[18] = new List<Move>() { MoveFactory.Tailwind, },
			[24] = new List<Move>() { MoveFactory.ScaryFace, },
			[30] = new List<Move>() { MoveFactory.AerialAce, },
			[36] = new List<Move>() { MoveFactory.Slash, },
			[42] = new List<Move>() { MoveFactory.Whirlwind, },
			[48] = new List<Move>() { MoveFactory.CrushClaw, },
			[55] = new List<Move>() { MoveFactory.AirSlash, },
			[60] = new List<Move>() { MoveFactory.Defog, },
			[66] = new List<Move>() { MoveFactory.Thrash, },
			[72] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}
