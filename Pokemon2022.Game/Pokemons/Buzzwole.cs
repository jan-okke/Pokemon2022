using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Buzzwole : Pokemon
	{
		public override string Name => "Buzzwole";
		public override int Generation => 7;
		public override string PokedexEntry => "This Ultra Beast appeared from another world. It shows off its body, but whether that display is a boast or a threat remains unclear.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 107,
			Attack = 139,
			Defense = 139,
			SpecialAttack = 53,
			SpecialDefense = 53,
			Speed = 79
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowerUpPunch, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.Taunt, },
			[10] = new List<Move>() { MoveFactory.FellStinger, },
			[15] = new List<Move>() { MoveFactory.VitalThrow, },
			[20] = new List<Move>() { MoveFactory.BulkUp, },
			[25] = new List<Move>() { MoveFactory.Endure, },
			[30] = new List<Move>() { MoveFactory.Reversal, },
			[35] = new List<Move>() { MoveFactory.MegaPunch, },
			[40] = new List<Move>() { MoveFactory.Lunge, },
			[45] = new List<Move>() { MoveFactory.FocusEnergy, },
			[50] = new List<Move>() { MoveFactory.DynamicPunch, },
			[55] = new List<Move>() { MoveFactory.Counter, },
			[60] = new List<Move>() { MoveFactory.HammerArm, },
			[65] = new List<Move>() { MoveFactory.Superpower, },
			[70] = new List<Move>() { MoveFactory.FocusPunch, },
		};
	}
}
