using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Flareon : Pokemon
	{
		public override string Name => "Flareon";
		public override int Generation => 1;
		public override string PokedexEntry => "Flareon's fluffy fur releases heat into the air so that its body does not get excessively hot. Its body temperature can rise to a maximum of 1,650 degrees F.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Guts;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 130,
			Defense = 60,
			SpecialAttack = 95,
			SpecialDefense = 110,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Ember, },
			[1] = new List<Move>() { MoveFactory.Ember, MoveFactory.Covet, MoveFactory.Swift, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.TakeDown, MoveFactory.Charm, MoveFactory.DoubleEdge, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.Smog, },
			[25] = new List<Move>() { MoveFactory.Bite, },
			[30] = new List<Move>() { MoveFactory.FireFang, },
			[35] = new List<Move>() { MoveFactory.FireSpin, },
			[40] = new List<Move>() { MoveFactory.LavaPlume, },
			[45] = new List<Move>() { MoveFactory.ScaryFace, },
			[50] = new List<Move>() { MoveFactory.FlareBlitz, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}
