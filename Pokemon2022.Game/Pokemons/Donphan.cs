using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Donphan : Pokemon
	{
		public override string Name => "Donphan";
		public override int Generation => 2;
		public override string PokedexEntry => "A Donphan is so strong it can easily haul a dump truck. Its hide has toughened to a rock-hard state. An ordinary sort of attack won't even leave a scratch.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 120,
			Defense = 120,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FuryAttack, },
			[1] = new List<Move>() { MoveFactory.FuryAttack, MoveFactory.FireFang, MoveFactory.ThunderFang, MoveFactory.HornAttack, MoveFactory.Bulldoze, MoveFactory.Growl, MoveFactory.DefenseCurl, },
			[6] = new List<Move>() { MoveFactory.RapidSpin, },
			[10] = new List<Move>() { MoveFactory.Rollout, },
			[15] = new List<Move>() { MoveFactory.Assurance, },
			[19] = new List<Move>() { MoveFactory.KnockOff, },
			[24] = new List<Move>() { MoveFactory.Slam, },
			[30] = new List<Move>() { MoveFactory.RockTomb, },
			[37] = new List<Move>() { MoveFactory.ScaryFace, },
			[43] = new List<Move>() { MoveFactory.Earthquake, },
			[50] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
