using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Charizard : Pokemon
	{
		public override string Name => "Charizard";
		public override int Generation => 1;
		public override string PokedexEntry => "A Charizard flies about in search of strong opponents. It breathes intense flames that can melt any material. However, it will never torch a weaker foe.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SolarPower;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 84,
			Defense = 78,
			SpecialAttack = 109,
			SpecialDefense = 85,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AirSlash, },
			[1] = new List<Move>() { MoveFactory.AirSlash, MoveFactory.DragonClaw, MoveFactory.HeatWave, MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.Ember, MoveFactory.Smokescreen, },
			[12] = new List<Move>() { MoveFactory.DragonBreath, },
			[19] = new List<Move>() { MoveFactory.FireFang, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.Flamethrower, },
			[39] = new List<Move>() { MoveFactory.ScaryFace, },
			[46] = new List<Move>() { MoveFactory.FireSpin, },
			[54] = new List<Move>() { MoveFactory.Inferno, },
			[62] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
