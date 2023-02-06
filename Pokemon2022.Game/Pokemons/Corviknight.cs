using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Corviknight : Pokemon
	{
		public override string Name => "Corviknight";
		public override int Generation => 8;
		public override string PokedexEntry => "This Pokémon reigns supreme in the skies. The black luster of its steel body could drive terror into the heart of any foe.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Flying, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, AbilityFactory.Unnerve, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MirrorArmor;
		public override Stats BaseStats => new Stats() {
			HP = 98,
			Attack = 87,
			Defense = 105,
			SpecialAttack = 53,
			SpecialDefense = 85,
			Speed = 67
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SteelWing, },
			[1] = new List<Move>() { MoveFactory.SteelWing, MoveFactory.IronDefense, MoveFactory.MetalSound, MoveFactory.Peck, MoveFactory.Leer, MoveFactory.PowerTrip, MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.FuryAttack, },
			[16] = new List<Move>() { MoveFactory.Pluck, },
			[22] = new List<Move>() { MoveFactory.Taunt, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[34] = new List<Move>() { MoveFactory.DrillPeck, },
			[42] = new List<Move>() { MoveFactory.Swagger, },
			[50] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}
