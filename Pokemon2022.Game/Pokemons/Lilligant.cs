using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lilligant : Pokemon
	{
		public override string Name => "Lilligant";
		public override int Generation => 5;
		public override string PokedexEntry => "The fragrance of the garland on its head has a relaxing effect. It withers if a Trainer does not take good care of it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LeafGuard;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 60,
			Defense = 75,
			SpecialAttack = 110,
			SpecialDefense = 75,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PetalDance, },
			[1] = new List<Move>() { MoveFactory.PetalDance, MoveFactory.PetalBlizzard, MoveFactory.QuiverDance, MoveFactory.TeeterDance, MoveFactory.MegaDrain, MoveFactory.Aromatherapy, MoveFactory.MagicalLeaf, MoveFactory.SleepPowder, MoveFactory.GigaDrain, MoveFactory.LeechSeed, MoveFactory.AfterYou, MoveFactory.EnergyBall, MoveFactory.Synthesis, MoveFactory.SunnyDay, MoveFactory.Entrainment, MoveFactory.LeafStorm, MoveFactory.Absorb, MoveFactory.Growth, MoveFactory.HelpingHand, MoveFactory.StunSpore, },
		};
	}
}
