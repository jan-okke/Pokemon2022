using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Giratina : Pokemon
	{
		public override string Name => "Giratina";
		public override int Generation => 4;
		public override string PokedexEntry => "A Pokémon that is said to live in a world on the reverse side of ours. It appears in an ancient cemetery.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 150,
			Attack = 100,
			Defense = 120,
			SpecialAttack = 100,
			SpecialDefense = 120,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ShadowSneak, MoveFactory.Defog, },
			[7] = new List<Move>() { MoveFactory.DragonBreath, },
			[14] = new List<Move>() { MoveFactory.AncientPower, },
			[21] = new List<Move>() { MoveFactory.Hex, },
			[28] = new List<Move>() { MoveFactory.Slash, },
			[35] = new List<Move>() { MoveFactory.ScaryFace, },
			[42] = new List<Move>() { MoveFactory.ShadowClaw, },
			[49] = new List<Move>() { MoveFactory.ShadowForce, },
			[56] = new List<Move>() { MoveFactory.PainSplit, },
			[63] = new List<Move>() { MoveFactory.AuraSphere, },
			[70] = new List<Move>() { MoveFactory.DragonClaw, },
			[77] = new List<Move>() { MoveFactory.EarthPower, },
			[84] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}
