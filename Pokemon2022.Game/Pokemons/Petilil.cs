using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Petilil : Pokemon
	{
		public override string Name => "Petilil";
		public override int Generation => 5;
		public override string PokedexEntry => "Since they prefer moist, nutrient-rich soil, the areas where Petilil live are known to be good for growing plants.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LeafGuard;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 35,
			Defense = 50,
			SpecialAttack = 70,
			SpecialDefense = 50,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Growth, },
			[3] = new List<Move>() { MoveFactory.HelpingHand, },
			[6] = new List<Move>() { MoveFactory.StunSpore, },
			[9] = new List<Move>() { MoveFactory.MegaDrain, },
			[12] = new List<Move>() { MoveFactory.Aromatherapy, },
			[15] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[18] = new List<Move>() { MoveFactory.SleepPowder, },
			[21] = new List<Move>() { MoveFactory.GigaDrain, },
			[24] = new List<Move>() { MoveFactory.LeechSeed, },
			[27] = new List<Move>() { MoveFactory.AfterYou, },
			[30] = new List<Move>() { MoveFactory.EnergyBall, },
			[33] = new List<Move>() { MoveFactory.Synthesis, },
			[36] = new List<Move>() { MoveFactory.SunnyDay, },
			[39] = new List<Move>() { MoveFactory.Entrainment, },
			[42] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}
