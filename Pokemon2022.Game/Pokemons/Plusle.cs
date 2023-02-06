using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Plusle : Pokemon
	{
		public override string Name => "Plusle";
		public override int Generation => 3;
		public override string PokedexEntry => "It has the trait of cheering on its fellow Pokémon. By shorting out the electricity it releases from its paws, it creates pom-poms for cheering.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Plus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightningRod;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 50,
			Defense = 40,
			SpecialAttack = 85,
			SpecialDefense = 75,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Nuzzle, MoveFactory.PlayNice, MoveFactory.Growl, MoveFactory.ThunderWave, MoveFactory.QuickAttack, },
			[4] = new List<Move>() { MoveFactory.HelpingHand, },
			[7] = new List<Move>() { MoveFactory.Spark, },
			[10] = new List<Move>() { MoveFactory.Encore, },
			[13] = new List<Move>() { MoveFactory.SkillSwap, },
			[16] = new List<Move>() { MoveFactory.Swift, },
			[19] = new List<Move>() { MoveFactory.ElectroBall, },
			[22] = new List<Move>() { MoveFactory.Copycat, },
			[25] = new List<Move>() { MoveFactory.Charm, },
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
