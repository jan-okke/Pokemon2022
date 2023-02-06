using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Milcery : Pokemon
	{
		public override string Name => "Milcery";
		public override int Generation => 8;
		public override string PokedexEntry => "This Pokémon was born from sweet-smelling particles in the air. Its body is made of cream.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SweetVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AromaVeil;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 40,
			Defense = 40,
			SpecialAttack = 50,
			SpecialDefense = 61,
			Speed = 34
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.AromaticMist, },
			[5] = new List<Move>() { MoveFactory.SweetKiss, },
			[10] = new List<Move>() { MoveFactory.SweetScent, },
			[15] = new List<Move>() { MoveFactory.DrainingKiss, },
			[20] = new List<Move>() { MoveFactory.Aromatherapy, },
			[25] = new List<Move>() { MoveFactory.Attract, },
			[30] = new List<Move>() { MoveFactory.AcidArmor, },
			[35] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[40] = new List<Move>() { MoveFactory.Recover, },
			[45] = new List<Move>() { MoveFactory.MistyTerrain, },
			[50] = new List<Move>() { MoveFactory.Entrainment, },
		};
	}
}
