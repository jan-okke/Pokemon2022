using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Farfetchd : Pokemon
	{
		public override string Name => "Farfetch'd";
		public override int Generation => 1;
		public override string PokedexEntry => "It is always seen with a stick from a plant. Apparently, there are good sticks and bad sticks. This Pokémon occasionally fights with others over choice sticks.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 52,
			Attack = 90,
			Defense = 55,
			SpecialAttack = 58,
			SpecialDefense = 62,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.SandAttack, },
			[5] = new List<Move>() { MoveFactory.Leer, },
			[10] = new List<Move>() { MoveFactory.FuryCutter, },
			[15] = new List<Move>() { MoveFactory.Cut, },
			[20] = new List<Move>() { MoveFactory.AerialAce, },
			[25] = new List<Move>() { MoveFactory.AirCutter, },
			[30] = new List<Move>() { MoveFactory.KnockOff, },
			[35] = new List<Move>() { MoveFactory.FalseSwipe, },
			[40] = new List<Move>() { MoveFactory.Slash, },
			[45] = new List<Move>() { MoveFactory.SwordsDance, },
			[50] = new List<Move>() { MoveFactory.AirSlash, },
			[55] = new List<Move>() { MoveFactory.LeafBlade, },
			[60] = new List<Move>() { MoveFactory.Agility, },
			[65] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}
