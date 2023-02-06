using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Linoone : Pokemon
	{
		public override string Name => "Linoone";
		public override int Generation => 3;
		public override string PokedexEntry => "It is exceedingly fast if it only has to run in a straight line. When it spots pond- dwelling prey underwater, it quickly leaps in and catches it with its sharp claws.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.QuickFeet;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 70,
			Defense = 61,
			SpecialAttack = 50,
			SpecialDefense = 61,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Slash, },
			[1] = new List<Move>() { MoveFactory.Slash, MoveFactory.Switcheroo, MoveFactory.PinMissile, MoveFactory.BabyDollEyes, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.SandAttack, MoveFactory.TailWhip, },
			[9] = new List<Move>() { MoveFactory.Covet, },
			[12] = new List<Move>() { MoveFactory.Headbutt, },
			[15] = new List<Move>() { MoveFactory.HoneClaws, },
			[18] = new List<Move>() { MoveFactory.FurySwipes, },
			[23] = new List<Move>() { MoveFactory.Rest, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[33] = new List<Move>() { MoveFactory.Fling, },
			[38] = new List<Move>() { MoveFactory.Flail, },
			[43] = new List<Move>() { MoveFactory.BellyDrum, },
			[48] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
