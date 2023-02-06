using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shuppet : Pokemon
	{
		public override string Name => "Shuppet";
		public override int Generation => 3;
		public override string PokedexEntry => "This Pokémon roams about deep in the night seeking such negative emotions as grudges and envy. It retreats to its nest when the sun begins to rise.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Insomnia, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CursedBody;
		public override Stats BaseStats => new Stats() {
			HP = 44,
			Attack = 75,
			Defense = 35,
			SpecialAttack = 63,
			SpecialDefense = 33,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.KnockOff, },
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
			[38] = new List<Move>() { MoveFactory.SuckerPunch, },
			[42] = new List<Move>() { MoveFactory.KnockOff, },
			[46] = new List<Move>() { MoveFactory.Grudge, },
			[50] = new List<Move>() { MoveFactory.Trick, },
			[54] = new List<Move>() { MoveFactory.PhantomForce, },
		};
	}
}
