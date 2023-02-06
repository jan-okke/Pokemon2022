using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Minun : Pokemon
	{
		public override string Name => "Minun";
		public override int Generation => 3;
		public override string PokedexEntry => "At a meeting of Pokémon academics, it was announced that simultaneous exposure to electricity from a Plusle and Minun will promote circulation and boost vitality.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Minus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VoltAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 40,
			Defense = 50,
			SpecialAttack = 75,
			SpecialDefense = 85,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Nuzzle, MoveFactory.PlayNice, MoveFactory.Growl, MoveFactory.ThunderWave, MoveFactory.QuickAttack, },
			[4] = new List<Move>() { MoveFactory.HelpingHand, },
			[7] = new List<Move>() { MoveFactory.Spark, },
			[10] = new List<Move>() { MoveFactory.Encore, },
			[13] = new List<Move>() { MoveFactory.Switcheroo, },
			[16] = new List<Move>() { MoveFactory.Swift, },
			[19] = new List<Move>() { MoveFactory.ElectroBall, },
			[22] = new List<Move>() { MoveFactory.Copycat, },
			[25] = new List<Move>() { MoveFactory.FakeTears, },
			[28] = new List<Move>() { MoveFactory.Charge, },
			[31] = new List<Move>() { MoveFactory.Discharge, },
			[34] = new List<Move>() { MoveFactory.BatonPass, },
			[37] = new List<Move>() { MoveFactory.Agility, },
			[40] = new List<Move>() { MoveFactory.LastResort, },
			[43] = new List<Move>() { MoveFactory.Thunder, },
			[46] = new List<Move>() { MoveFactory.NastyPlot, },
			[49] = new List<Move>() { MoveFactory.Entrainment, },
		};
	}
}
