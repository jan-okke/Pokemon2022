using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gulpin : Pokemon
	{
		public override string Name => "Gulpin";
		public override int Generation => 3;
		public override string PokedexEntry => "This Pokémon's stomach fluid can even digest scrap iron. In one gulp, it can swallow something that is as large as itself.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LiquidOoze, AbilityFactory.StickyHold, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 43,
			Defense = 53,
			SpecialAttack = 43,
			SpecialDefense = 53,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, },
			[5] = new List<Move>() { MoveFactory.Yawn, },
			[8] = new List<Move>() { MoveFactory.PoisonGas, },
			[10] = new List<Move>() { MoveFactory.Sludge, },
			[12] = new List<Move>() { MoveFactory.Amnesia, },
			[17] = new List<Move>() { MoveFactory.AcidSpray, },
			[20] = new List<Move>() { MoveFactory.Encore, },
			[25] = new List<Move>() { MoveFactory.Toxic, },
			[28] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.SpitUp, MoveFactory.Swallow, },
			[33] = new List<Move>() { MoveFactory.SludgeBomb, },
			[36] = new List<Move>() { MoveFactory.GastroAcid, },
			[41] = new List<Move>() { MoveFactory.Belch, },
			[44] = new List<Move>() { MoveFactory.PainSplit, },
			[49] = new List<Move>() { MoveFactory.GunkShot, },
		};
	}
}
