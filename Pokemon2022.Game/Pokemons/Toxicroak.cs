using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Toxicroak : Pokemon
	{
		public override string Name => "Toxicroak";
		public override int Generation => 4;
		public override string PokedexEntry => "Its knuckle claws secrete a toxin so vile that even a scratch could prove fatal.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Anticipation, AbilityFactory.DrySkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PoisonTouch;
		public override Stats BaseStats => new Stats() {
			HP = 83,
			Attack = 106,
			Defense = 65,
			SpecialAttack = 86,
			SpecialDefense = 65,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.MudSlap, MoveFactory.Astonish, MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.Flatter, },
			[16] = new List<Move>() { MoveFactory.Revenge, },
			[20] = new List<Move>() { MoveFactory.Venoshock, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.Swagger, },
			[32] = new List<Move>() { MoveFactory.PoisonJab, },
			[36] = new List<Move>() { MoveFactory.Toxic, },
			[42] = new List<Move>() { MoveFactory.NastyPlot, },
			[48] = new List<Move>() { MoveFactory.SludgeBomb, },
			[54] = new List<Move>() { MoveFactory.Belch, },
		};
	}
}
