using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Braviary : Pokemon
	{
		public override string Name => "Braviary";
		public override int Generation => 5;
		public override string PokedexEntry => "The more scars they have, the more respect these brave soldiers of the sky get from their peers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 123,
			Defense = 75,
			SpecialAttack = 57,
			SpecialDefense = 75,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Superpower, },
			[1] = new List<Move>() { MoveFactory.Superpower, MoveFactory.SkyAttack, MoveFactory.Peck, MoveFactory.Leer, MoveFactory.HoneClaws, MoveFactory.WingAttack, },
			[18] = new List<Move>() { MoveFactory.Tailwind, },
			[24] = new List<Move>() { MoveFactory.ScaryFace, },
			[30] = new List<Move>() { MoveFactory.AerialAce, },
			[36] = new List<Move>() { MoveFactory.Slash, },
			[42] = new List<Move>() { MoveFactory.Whirlwind, },
			[48] = new List<Move>() { MoveFactory.CrushClaw, },
			[57] = new List<Move>() { MoveFactory.AirSlash, },
			[64] = new List<Move>() { MoveFactory.Defog, },
			[72] = new List<Move>() { MoveFactory.Thrash, },
			[80] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}
