using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kricketot : Pokemon
	{
		public override string Name => "Kricketot";
		public override int Generation => 4;
		public override string PokedexEntry => "It shakes its head back to front, causing its antennae to hit each other and sound like a xylophone.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RunAway;
		public override Stats BaseStats => new Stats() {
			HP = 37,
			Attack = 25,
			Defense = 41,
			SpecialAttack = 25,
			SpecialDefense = 41,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.Pound, },
			[6] = new List<Move>() { MoveFactory.StruggleBug, },
			[16] = new List<Move>() { MoveFactory.BugBite, },
		};
	}
}
