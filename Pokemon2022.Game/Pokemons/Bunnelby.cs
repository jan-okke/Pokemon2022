using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bunnelby : Pokemon
	{
		public override string Name => "Bunnelby";
		public override int Generation => 6;
		public override string PokedexEntry => "It has ears like shovels. Digging holes strengthens its ears so much that they can sever thick roots effortlessly.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.CheekPouch, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HugePower;
		public override Stats BaseStats => new Stats() {
			HP = 38,
			Attack = 36,
			Defense = 38,
			SpecialAttack = 32,
			SpecialDefense = 36,
			Speed = 57
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.Leer, },
			[3] = new List<Move>() { MoveFactory.Tackle, },
			[6] = new List<Move>() { MoveFactory.LaserFocus, },
			[9] = new List<Move>() { MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[15] = new List<Move>() { MoveFactory.Flail, },
			[18] = new List<Move>() { MoveFactory.DoubleKick, },
			[21] = new List<Move>() { MoveFactory.Bulldoze, },
			[24] = new List<Move>() { MoveFactory.Dig, },
			[27] = new List<Move>() { MoveFactory.Bounce, },
			[30] = new List<Move>() { MoveFactory.TakeDown, },
			[33] = new List<Move>() { MoveFactory.SwordsDance, },
			[36] = new List<Move>() { MoveFactory.Earthquake, },
			[39] = new List<Move>() { MoveFactory.SuperFang, },
		};
	}
}
