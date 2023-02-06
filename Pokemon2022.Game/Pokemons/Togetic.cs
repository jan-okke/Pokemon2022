using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Togetic : Pokemon
	{
		public override string Name => "Togetic";
		public override int Generation => 2;
		public override string PokedexEntry => "It is said to be a Pokémon that brings good fortune. When it spots someone who is pure of heart, a Togetic appears and shares its happiness with that person.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hustle, AbilityFactory.SereneGrace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SuperLuck;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 40,
			Defense = 85,
			SpecialAttack = 80,
			SpecialDefense = 105,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FairyWind, },
			[1] = new List<Move>() { MoveFactory.FairyWind, MoveFactory.Growl, MoveFactory.Pound, MoveFactory.SweetKiss, MoveFactory.LifeDew, },
			[12] = new List<Move>() { MoveFactory.Charm, },
			[16] = new List<Move>() { MoveFactory.AncientPower, },
			[20] = new List<Move>() { MoveFactory.Yawn, },
			[24] = new List<Move>() { MoveFactory.Metronome, },
			[28] = new List<Move>() { MoveFactory.AfterYou, },
			[32] = new List<Move>() { MoveFactory.DoubleEdge, },
			[36] = new List<Move>() { MoveFactory.Safeguard, },
			[40] = new List<Move>() { MoveFactory.FollowMe, },
			[44] = new List<Move>() { MoveFactory.BatonPass, },
			[48] = new List<Move>() { MoveFactory.LastResort, },
			[52] = new List<Move>() { MoveFactory.Wish, },
		};
	}
}
