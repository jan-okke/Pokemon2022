using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Banette : Pokemon
	{
		public override string Name => "Banette";
		public override int Generation => 3;
		public override string PokedexEntry => "An abandoned plush doll became this Pokémon. They are said to live in garbage dumps and wander about in search of the children that threw them away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Insomnia, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CursedBody;
		public override Stats BaseStats => new Stats() {
			HP = 64,
			Attack = 115,
			Defense = 65,
			SpecialAttack = 83,
			SpecialDefense = 63,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PhantomForce, MoveFactory.KnockOff, MoveFactory.Screech, MoveFactory.NightShade, MoveFactory.Spite, },
			[4] = new List<Move>() { MoveFactory.Screech, },
			[7] = new List<Move>() { MoveFactory.NightShade, },
			[10] = new List<Move>() { MoveFactory.Spite, },
			[13] = new List<Move>() { MoveFactory.ShadowSneak, },
			[16] = new List<Move>() { MoveFactory.WillOWisp, },
			[19] = new List<Move>() { MoveFactory.PainSplit, },
			[22] = new List<Move>() { MoveFactory.Hex, },
			[26] = new List<Move>() { MoveFactory.Curse, },
			[30] = new List<Move>() { MoveFactory.ShadowBall, },
			[34] = new List<Move>() { MoveFactory.RolePlay, },
			[40] = new List<Move>() { MoveFactory.SuckerPunch, },
			[46] = new List<Move>() { MoveFactory.KnockOff, },
			[52] = new List<Move>() { MoveFactory.Grudge, },
			[58] = new List<Move>() { MoveFactory.Trick, },
			[64] = new List<Move>() { MoveFactory.PhantomForce, },
		};
	}
}
