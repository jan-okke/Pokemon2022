using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wartortle : Pokemon
	{
		public override string Name => "Wartortle";
		public override int Generation => 1;
		public override string PokedexEntry => "Its large tail is covered with rich, thick fur that deepens in color with age. The scratches on its shell are evidence of this Pokémon's toughness in battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 59,
			Attack = 63,
			Defense = 80,
			SpecialAttack = 65,
			SpecialDefense = 80,
			Speed = 58
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.WaterGun, MoveFactory.Withdraw, },
			[9] = new List<Move>() { MoveFactory.RapidSpin, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.WaterPulse, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[25] = new List<Move>() { MoveFactory.RainDance, },
			[30] = new List<Move>() { MoveFactory.AquaTail, },
			[35] = new List<Move>() { MoveFactory.ShellSmash, },
			[40] = new List<Move>() { MoveFactory.IronDefense, },
			[45] = new List<Move>() { MoveFactory.HydroPump, },
			[50] = new List<Move>() { MoveFactory.SkullBash, },
		};
	}
}
