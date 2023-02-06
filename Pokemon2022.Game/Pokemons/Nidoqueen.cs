using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nidoqueen : Pokemon
	{
		public override string Name => "Nidoqueen";
		public override int Generation => 1;
		public override string PokedexEntry => "It is adept at sending foes flying with harsh tackles using its tough, scaly body. This Pokémon is at its strongest when it is defending its young.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Rivalry, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 92,
			Defense = 87,
			SpecialAttack = 75,
			SpecialDefense = 85,
			Speed = 76
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Superpower, },
			[1] = new List<Move>() { MoveFactory.SludgeWave, MoveFactory.Superpower, MoveFactory.FurySwipes, MoveFactory.ToxicSpikes, MoveFactory.DoubleKick, MoveFactory.Bite, MoveFactory.HelpingHand, MoveFactory.Toxic, MoveFactory.Flatter, MoveFactory.Crunch, MoveFactory.EarthPower, MoveFactory.Growl, MoveFactory.PoisonSting, MoveFactory.Scratch, MoveFactory.TailWhip, },
		};
	}
}
