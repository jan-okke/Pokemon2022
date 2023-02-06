using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drizzile : Pokemon
	{
		public override string Name => "Drizzile";
		public override int Generation => 8;
		public override string PokedexEntry => "A clever combatant, this Pokémon battles using water balloons created with moisture secreted from its palms.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sniper;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 60,
			Defense = 55,
			SpecialAttack = 95,
			SpecialDefense = 55,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Growl, MoveFactory.WaterGun, MoveFactory.Bind, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[19] = new List<Move>() { MoveFactory.TearfulLook, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[30] = new List<Move>() { MoveFactory.Uturn, },
			[36] = new List<Move>() { MoveFactory.Liquidation, },
			[42] = new List<Move>() { MoveFactory.Soak, },
			[48] = new List<Move>() { MoveFactory.RainDance, },
		};
	}
}
