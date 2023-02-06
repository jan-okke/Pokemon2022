using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nihilego : Pokemon
	{
		public override string Name => "Nihilego";
		public override int Generation => 7;
		public override string PokedexEntry => "One of several mysterious Ultra Beasts. People on the street report observing those infested by it suddenly becoming violent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 109,
			Attack = 53,
			Defense = 47,
			SpecialAttack = 127,
			SpecialDefense = 131,
			Speed = 103
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.Pound, },
			[5] = new List<Move>() { MoveFactory.Acid, },
			[10] = new List<Move>() { MoveFactory.Tickle, },
			[15] = new List<Move>() { MoveFactory.AcidSpray, },
			[20] = new List<Move>() { MoveFactory.ClearSmog, },
			[25] = new List<Move>() { MoveFactory.PowerSplit, MoveFactory.GuardSplit, },
			[30] = new List<Move>() { MoveFactory.Venoshock, },
			[35] = new List<Move>() { MoveFactory.Headbutt, },
			[40] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[45] = new List<Move>() { MoveFactory.VenomDrench, },
			[50] = new List<Move>() { MoveFactory.PowerGem, },
			[55] = new List<Move>() { MoveFactory.StealthRock, },
			[60] = new List<Move>() { MoveFactory.MirrorCoat, },
			[65] = new List<Move>() { MoveFactory.WonderRoom, },
			[70] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
