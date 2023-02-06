using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dracovish : Pokemon
	{
		public override string Name => "Dracovish";
		public override int Generation => 8;
		public override string PokedexEntry => "Powerful legs and jaws made it the apex predator of its time. Its own overhunting of its prey was what drove it to extinction.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.StrongJaw, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandRush;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 90,
			Defense = 100,
			SpecialAttack = 70,
			SpecialDefense = 80,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.WaterGun, },
			[7] = new List<Move>() { MoveFactory.Protect, },
			[14] = new List<Move>() { MoveFactory.BrutalSwing, },
			[21] = new List<Move>() { MoveFactory.AncientPower, },
			[28] = new List<Move>() { MoveFactory.Bite, },
			[35] = new List<Move>() { MoveFactory.DragonBreath, },
			[42] = new List<Move>() { MoveFactory.Stomp, },
			[49] = new List<Move>() { MoveFactory.SuperFang, },
			[56] = new List<Move>() { MoveFactory.Crunch, },
			[63] = new List<Move>() { MoveFactory.FishiousRend, },
			[70] = new List<Move>() { MoveFactory.DragonPulse, },
			[77] = new List<Move>() { MoveFactory.DragonRush, },
		};
	}
}
