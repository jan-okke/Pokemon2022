using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Duskull : Pokemon
	{
		public override string Name => "Duskull";
		public override int Generation => 3;
		public override string PokedexEntry => "A glare from its single scarlet eye makes even burly grown-ups freeze in utter fear. It is a nocturnal Pokémon that roams about under the cloak of darkness.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Frisk;
		public override Stats BaseStats => new Stats() {
			HP = 20,
			Attack = 40,
			Defense = 90,
			SpecialAttack = 30,
			SpecialDefense = 90,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Disable, },
			[8] = new List<Move>() { MoveFactory.ShadowSneak, },
			[12] = new List<Move>() { MoveFactory.ConfuseRay, },
			[16] = new List<Move>() { MoveFactory.NightShade, },
			[20] = new List<Move>() { MoveFactory.Payback, },
			[24] = new List<Move>() { MoveFactory.WillOWisp, },
			[28] = new List<Move>() { MoveFactory.MeanLook, },
			[32] = new List<Move>() { MoveFactory.Hex, },
			[36] = new List<Move>() { MoveFactory.Curse, },
			[40] = new List<Move>() { MoveFactory.ShadowBall, },
			[44] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
