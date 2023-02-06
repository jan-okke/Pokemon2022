using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sobble : Pokemon
	{
		public override string Name => "Sobble";
		public override int Generation => 8;
		public override string PokedexEntry => "When scared, this Pokémon cries. Its tears pack the chemical punch of 100 onions, and attackers won't be able to resist weeping.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sniper;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 40,
			Defense = 40,
			SpecialAttack = 70,
			SpecialDefense = 40,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[8] = new List<Move>() { MoveFactory.Bind, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[17] = new List<Move>() { MoveFactory.TearfulLook, },
			[20] = new List<Move>() { MoveFactory.SuckerPunch, },
			[24] = new List<Move>() { MoveFactory.Uturn, },
			[28] = new List<Move>() { MoveFactory.Liquidation, },
			[32] = new List<Move>() { MoveFactory.Soak, },
			[36] = new List<Move>() { MoveFactory.RainDance, },
		};
	}
}
