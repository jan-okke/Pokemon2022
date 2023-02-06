using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spiritomb : Pokemon
	{
		public override string Name => "Spiritomb";
		public override int Generation => 4;
		public override string PokedexEntry => "A Pokémon that was formed by 108 spirits. It is bound to a fissure in an odd keystone.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 92,
			Defense = 108,
			SpecialAttack = 92,
			SpecialDefense = 108,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.NightShade, MoveFactory.ConfuseRay, },
			[5] = new List<Move>() { MoveFactory.ShadowSneak, },
			[10] = new List<Move>() { MoveFactory.Spite, },
			[15] = new List<Move>() { MoveFactory.Payback, },
			[20] = new List<Move>() { MoveFactory.NastyPlot, },
			[25] = new List<Move>() { MoveFactory.Hex, },
			[30] = new List<Move>() { MoveFactory.Memento, },
			[35] = new List<Move>() { MoveFactory.SuckerPunch, },
			[40] = new List<Move>() { MoveFactory.Curse, },
			[45] = new List<Move>() { MoveFactory.ShadowBall, },
			[50] = new List<Move>() { MoveFactory.DarkPulse, },
			[55] = new List<Move>() { MoveFactory.Hypnosis, },
			[60] = new List<Move>() { MoveFactory.DreamEater, },
		};
	}
}
