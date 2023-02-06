using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Guzzlord : Pokemon
	{
		public override string Name => "Guzzlord";
		public override int Generation => 7;
		public override string PokedexEntry => "A dangerous Ultra Beast, it appears to be eating constantly, but for some reason its droppings have never been found.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 223,
			Attack = 101,
			Defense = 53,
			SpecialAttack = 97,
			SpecialDefense = 53,
			Speed = 43
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Bite, MoveFactory.DragonTail, },
			[5] = new List<Move>() { MoveFactory.Swallow, MoveFactory.Stockpile, },
			[10] = new List<Move>() { MoveFactory.KnockOff, },
			[15] = new List<Move>() { MoveFactory.Stomp, },
			[20] = new List<Move>() { MoveFactory.StompingTantrum, },
			[25] = new List<Move>() { MoveFactory.WideGuard, },
			[30] = new List<Move>() { MoveFactory.Crunch, },
			[35] = new List<Move>() { MoveFactory.BodySlam, },
			[40] = new List<Move>() { MoveFactory.GastroAcid, },
			[45] = new List<Move>() { MoveFactory.HammerArm, },
			[50] = new List<Move>() { MoveFactory.HeavySlam, },
			[55] = new List<Move>() { MoveFactory.DragonRush, },
			[60] = new List<Move>() { MoveFactory.Belch, },
			[65] = new List<Move>() { MoveFactory.Thrash, },
			[70] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
