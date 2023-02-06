using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Glaceon : Pokemon
	{
		public override string Name => "Glaceon";
		public override int Generation => 4;
		public override string PokedexEntry => "As a protective technique, it can completely freeze its fur to make its hairs stand like needles.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SnowCloak, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IceBody;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 60,
			Defense = 110,
			SpecialAttack = 130,
			SpecialDefense = 95,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IcyWind, },
			[1] = new List<Move>() { MoveFactory.IcyWind, MoveFactory.Covet, MoveFactory.Swift, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.TakeDown, MoveFactory.Charm, MoveFactory.DoubleEdge, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.IceShard, },
			[25] = new List<Move>() { MoveFactory.Bite, },
			[30] = new List<Move>() { MoveFactory.IceFang, },
			[35] = new List<Move>() { MoveFactory.Hail, },
			[40] = new List<Move>() { MoveFactory.FreezeDry, },
			[45] = new List<Move>() { MoveFactory.MirrorCoat, },
			[50] = new List<Move>() { MoveFactory.Blizzard, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}
