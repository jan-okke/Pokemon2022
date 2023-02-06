using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Latios : Pokemon
	{
		public override string Name => "Latios";
		public override int Generation => 3;
		public override string PokedexEntry => "Even in hiding, it can detect the locations of others and sense their emotions since it has telepathy. Its intelligence allows it to understand human languages.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 90,
			Defense = 80,
			SpecialAttack = 130,
			SpecialDefense = 110,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.StoredPower, MoveFactory.DragonDance, },
			[5] = new List<Move>() { MoveFactory.HelpingHand, },
			[10] = new List<Move>() { MoveFactory.Recover, },
			[15] = new List<Move>() { MoveFactory.Confusion, },
			[20] = new List<Move>() { MoveFactory.Tailwind, },
			[25] = new List<Move>() { MoveFactory.DragonBreath, },
			[30] = new List<Move>() { MoveFactory.AllySwitch, },
			[35] = new List<Move>() { MoveFactory.LusterPurge, },
			[40] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[45] = new List<Move>() { MoveFactory.DragonPulse, },
			[50] = new List<Move>() { MoveFactory.HealPulse, },
			[55] = new List<Move>() { MoveFactory.SimpleBeam, },
			[60] = new List<Move>() { MoveFactory.Psychic, },
			[65] = new List<Move>() { MoveFactory.PowerSplit, },
			[70] = new List<Move>() { MoveFactory.Memento, },
			[75] = new List<Move>() { MoveFactory.PsychoShift, },
		};
	}
}
