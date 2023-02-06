using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Aerodactyl : Pokemon
	{
		public override string Name => "Aerodactyl";
		public override int Generation => 1;
		public override string PokedexEntry => "Aerodactyl is a Pokémon from the age of dinosaurs. It was regenerated from DNA extracted from amber. It is imagined to have been the king of the skies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 105,
			Defense = 65,
			SpecialAttack = 60,
			SpecialDefense = 75,
			Speed = 130
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Bite, MoveFactory.AncientPower, },
			[5] = new List<Move>() { MoveFactory.Supersonic, },
			[10] = new List<Move>() { MoveFactory.WingAttack, },
			[15] = new List<Move>() { MoveFactory.ScaryFace, },
			[20] = new List<Move>() { MoveFactory.RockSlide, },
			[25] = new List<Move>() { MoveFactory.Roar, },
			[30] = new List<Move>() { MoveFactory.Crunch, },
			[35] = new List<Move>() { MoveFactory.IronHead, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[45] = new List<Move>() { MoveFactory.StoneEdge, },
			[50] = new List<Move>() { MoveFactory.Agility, },
			[55] = new List<Move>() { MoveFactory.HyperBeam, },
			[60] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
