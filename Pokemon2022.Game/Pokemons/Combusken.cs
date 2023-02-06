using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Combusken : Pokemon
	{
		public override string Name => "Combusken";
		public override int Generation => 3;
		public override string PokedexEntry => "It lashes out with 10 kicks per second. Its strong fighting instinct compels it to keep up its offensive until the opponent gives up.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SpeedBoost;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 85,
			Defense = 60,
			SpecialAttack = 85,
			SpecialDefense = 60,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DoubleKick, },
			[1] = new List<Move>() { MoveFactory.DoubleKick, MoveFactory.Flamethrower, MoveFactory.FeatherDance, MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.Ember, MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.FlameCharge, },
			[12] = new List<Move>() { MoveFactory.Detect, },
			[15] = new List<Move>() { MoveFactory.SandAttack, },
			[20] = new List<Move>() { MoveFactory.AerialAce, },
			[25] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.Bounce, },
			[35] = new List<Move>() { MoveFactory.FocusEnergy, },
			[40] = new List<Move>() { MoveFactory.BlazeKick, },
			[45] = new List<Move>() { MoveFactory.BulkUp, },
			[50] = new List<Move>() { MoveFactory.Reversal, },
			[55] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
