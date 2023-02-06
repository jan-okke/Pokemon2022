using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Inteleon : Pokemon
	{
		public override string Name => "Inteleon";
		public override int Generation => 8;
		public override string PokedexEntry => "It has many hidden capabilities, such as fingertips that can shoot water and a membrane on its back that it can use to glide through the air.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sniper;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 85,
			Defense = 65,
			SpecialAttack = 125,
			SpecialDefense = 65,
			Speed = 120
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SnipeShot, },
			[1] = new List<Move>() { MoveFactory.SnipeShot, MoveFactory.Acrobatics, MoveFactory.Pound, MoveFactory.Growl, MoveFactory.WaterGun, MoveFactory.Bind, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[19] = new List<Move>() { MoveFactory.TearfulLook, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[30] = new List<Move>() { MoveFactory.Uturn, },
			[38] = new List<Move>() { MoveFactory.Liquidation, },
			[46] = new List<Move>() { MoveFactory.Soak, },
			[54] = new List<Move>() { MoveFactory.RainDance, },
			[62] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
