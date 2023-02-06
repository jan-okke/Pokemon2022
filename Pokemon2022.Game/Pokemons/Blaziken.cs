using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Blaziken : Pokemon
	{
		public override string Name => "Blaziken";
		public override int Generation => 3;
		public override string PokedexEntry => "It learns martial arts that use punches and kicks. Every several years, its old feathers burn off, and new, supple feathers grow back in their place.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SpeedBoost;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 120,
			Defense = 70,
			SpecialAttack = 110,
			SpecialDefense = 70,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.CloseCombat, MoveFactory.DoubleKick, MoveFactory.FirePunch, MoveFactory.BraveBird, MoveFactory.Flamethrower, MoveFactory.FeatherDance, MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.Ember, MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.FlameCharge, },
			[12] = new List<Move>() { MoveFactory.Detect, },
			[15] = new List<Move>() { MoveFactory.SandAttack, },
			[20] = new List<Move>() { MoveFactory.AerialAce, },
			[25] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.Bounce, },
			[35] = new List<Move>() { MoveFactory.FocusEnergy, },
			[42] = new List<Move>() { MoveFactory.BlazeKick, },
			[49] = new List<Move>() { MoveFactory.BulkUp, },
			[56] = new List<Move>() { MoveFactory.Reversal, },
			[63] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
