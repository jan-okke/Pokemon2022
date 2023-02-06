using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Miltank : Pokemon
	{
		public override string Name => "Miltank";
		public override int Generation => 2;
		public override string PokedexEntry => "It gives over five gallons of milk daily. Its sweet milk is enjoyed by children and adults alike. People who can't drink milk turn it into yogurt and eat it instead.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.Scrappy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SapSipper;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 80,
			Defense = 105,
			SpecialAttack = 40,
			SpecialDefense = 70,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.Rollout, },
			[10] = new List<Move>() { MoveFactory.DefenseCurl, },
			[15] = new List<Move>() { MoveFactory.Stomp, },
			[20] = new List<Move>() { MoveFactory.HealBell, },
			[25] = new List<Move>() { MoveFactory.Headbutt, },
			[30] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[35] = new List<Move>() { MoveFactory.MilkDrink, },
			[40] = new List<Move>() { MoveFactory.BodySlam, },
			[45] = new List<Move>() { MoveFactory.PlayRough, },
			[50] = new List<Move>() { MoveFactory.Charm, },
			[55] = new List<Move>() { MoveFactory.HighHorsepower, },
		};
	}
}
