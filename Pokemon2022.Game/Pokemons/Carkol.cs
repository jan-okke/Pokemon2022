using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Carkol : Pokemon
	{
		public override string Name => "Carkol";
		public override int Generation => 8;
		public override string PokedexEntry => "By rapidly rolling its legs, it can travel at over 18 mph. The temperature of the flames it breathes exceeds 1,000 degrees Celsius.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SteamEngine, AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlashFire;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 60,
			Defense = 90,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FlameCharge, },
			[1] = new List<Move>() { MoveFactory.FlameCharge, MoveFactory.Tackle, MoveFactory.Smokescreen, MoveFactory.RapidSpin, MoveFactory.SmackDown, },
			[15] = new List<Move>() { MoveFactory.RockPolish, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[27] = new List<Move>() { MoveFactory.Incinerate, },
			[35] = new List<Move>() { MoveFactory.StealthRock, },
			[41] = new List<Move>() { MoveFactory.HeatCrash, },
			[48] = new List<Move>() { MoveFactory.RockBlast, },
			[55] = new List<Move>() { MoveFactory.BurnUp, },
		};
	}
}
