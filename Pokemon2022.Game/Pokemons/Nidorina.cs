using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nidorina : Pokemon
	{
		public override string Name => "Nidorina";
		public override int Generation => 1;
		public override string PokedexEntry => "When it is with its friends or family, its barbs are tucked away to prevent injury. It appears to become nervous if separated from the others.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Rivalry, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 62,
			Defense = 67,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 56
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.PoisonSting, MoveFactory.Scratch, MoveFactory.TailWhip, },
			[15] = new List<Move>() { MoveFactory.FurySwipes, },
			[22] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[29] = new List<Move>() { MoveFactory.DoubleKick, },
			[36] = new List<Move>() { MoveFactory.Bite, },
			[43] = new List<Move>() { MoveFactory.HelpingHand, },
			[50] = new List<Move>() { MoveFactory.Toxic, },
			[57] = new List<Move>() { MoveFactory.Flatter, },
			[64] = new List<Move>() { MoveFactory.Crunch, },
			[71] = new List<Move>() { MoveFactory.EarthPower, },
		};
	}
}
