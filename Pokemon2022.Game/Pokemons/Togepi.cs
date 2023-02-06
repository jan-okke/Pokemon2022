using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Togepi : Pokemon
	{
		public override string Name => "Togepi";
		public override int Generation => 2;
		public override string PokedexEntry => "As its energy, it uses the feelings of compassion and pleasure exuded by people and Pokémon. It stores up happy feelings in its shell, then shares them out.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hustle, AbilityFactory.SereneGrace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SuperLuck;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 20,
			Defense = 65,
			SpecialAttack = 40,
			SpecialDefense = 65,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.Pound, },
			[4] = new List<Move>() { MoveFactory.SweetKiss, },
			[8] = new List<Move>() { MoveFactory.LifeDew, },
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
