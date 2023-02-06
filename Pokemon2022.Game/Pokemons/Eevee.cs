using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Eevee : Pokemon
	{
		public override string Name => "Eevee";
		public override int Generation => 1;
		public override string PokedexEntry => "An Eevee has an unstable genetic makeup that suddenly mutates due to its environment. Radiation from various stones causes this Pokémon to evolve.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.Adaptability, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Anticipation;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 55,
			Defense = 50,
			SpecialAttack = 45,
			SpecialDefense = 65,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Covet, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.Swift, },
			[25] = new List<Move>() { MoveFactory.Bite, },
			[30] = new List<Move>() { MoveFactory.Copycat, },
			[35] = new List<Move>() { MoveFactory.BatonPass, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[45] = new List<Move>() { MoveFactory.Charm, },
			[50] = new List<Move>() { MoveFactory.DoubleEdge, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}
