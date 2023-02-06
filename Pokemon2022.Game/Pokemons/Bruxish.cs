using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bruxish : Pokemon
	{
		public override string Name => "Bruxish";
		public override int Generation => 7;
		public override string PokedexEntry => "When it unleashes its psychic power from the protuberance on its head, the grating sound of grinding teeth echoes through the area.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Dazzling, AbilityFactory.StrongJaw, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WonderSkin;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 105,
			Defense = 70,
			SpecialAttack = 70,
			SpecialDefense = 70,
			Speed = 92
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, },
			[4] = new List<Move>() { MoveFactory.Astonish, },
			[9] = new List<Move>() { MoveFactory.Confusion, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[17] = new List<Move>() { MoveFactory.AquaJet, },
			[20] = new List<Move>() { MoveFactory.Disable, },
			[25] = new List<Move>() { MoveFactory.Psywave, },
			[28] = new List<Move>() { MoveFactory.Crunch, },
			[33] = new List<Move>() { MoveFactory.AquaTail, },
			[36] = new List<Move>() { MoveFactory.Screech, },
			[41] = new List<Move>() { MoveFactory.PsychicFangs, },
			[44] = new List<Move>() { MoveFactory.Synchronoise, },
		};
	}
}
