using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Croagunk : Pokemon
	{
		public override string Name => "Croagunk";
		public override int Generation => 4;
		public override string PokedexEntry => "Its cheeks hold poison sacs. It tries to catch foes off guard to jab them with toxic fingers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Anticipation, AbilityFactory.DrySkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PoisonTouch;
		public override Stats BaseStats => new Stats() {
			HP = 48,
			Attack = 61,
			Defense = 40,
			SpecialAttack = 61,
			SpecialDefense = 40,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.MudSlap, },
			[4] = new List<Move>() { MoveFactory.Astonish, },
			[8] = new List<Move>() { MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.Flatter, },
			[16] = new List<Move>() { MoveFactory.Revenge, },
			[20] = new List<Move>() { MoveFactory.Venoshock, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.Swagger, },
			[32] = new List<Move>() { MoveFactory.PoisonJab, },
			[36] = new List<Move>() { MoveFactory.Toxic, },
			[40] = new List<Move>() { MoveFactory.NastyPlot, },
			[44] = new List<Move>() { MoveFactory.SludgeBomb, },
			[48] = new List<Move>() { MoveFactory.Belch, },
		};
	}
}
