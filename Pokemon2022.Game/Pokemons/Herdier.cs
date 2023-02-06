using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Herdier : Pokemon
	{
		public override string Name => "Herdier";
		public override int Generation => 5;
		public override string PokedexEntry => "It loyally follows its Trainer's orders. For ages, they have helped Trainers raise Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.SandRush, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 80,
			Defense = 65,
			SpecialAttack = 35,
			SpecialDefense = 65,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.WorkUp, MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.Retaliate, },
			[19] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[24] = new List<Move>() { MoveFactory.PlayRough, },
			[30] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.TakeDown, },
			[42] = new List<Move>() { MoveFactory.HelpingHand, },
			[48] = new List<Move>() { MoveFactory.Reversal, },
			[54] = new List<Move>() { MoveFactory.Roar, },
			[60] = new List<Move>() { MoveFactory.LastResort, },
			[66] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
