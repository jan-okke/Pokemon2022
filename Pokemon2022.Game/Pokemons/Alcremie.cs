using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Alcremie : Pokemon
	{
		public override string Name => "Alcremie";
		public override int Generation => 8;
		public override string PokedexEntry => "When Alcremie is content, the cream it secretes from its hands becomes sweeter and richer.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SweetVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AromaVeil;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 60,
			Defense = 75,
			SpecialAttack = 110,
			SpecialDefense = 121,
			Speed = 64
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Decorate, },
			[1] = new List<Move>() { MoveFactory.Decorate, MoveFactory.Tackle, MoveFactory.AromaticMist, MoveFactory.SweetKiss, MoveFactory.SweetScent, },
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
