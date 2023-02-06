using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Slakoth : Pokemon
	{
		public override string Name => "Slakoth";
		public override int Generation => 3;
		public override string PokedexEntry => "It sleeps virtually all day and night long. It doesn't change its nest its entire life, but it sometimes travels great distances by swimming in rivers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Truant, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 60,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Yawn, },
			[6] = new List<Move>() { MoveFactory.Encore, },
			[9] = new List<Move>() { MoveFactory.SlackOff, },
			[14] = new List<Move>() { MoveFactory.Rest, },
			[17] = new List<Move>() { MoveFactory.Amnesia, },
			[22] = new List<Move>() { MoveFactory.Covet, },
			[25] = new List<Move>() { MoveFactory.Headbutt, },
			[30] = new List<Move>() { MoveFactory.Counter, },
			[33] = new List<Move>() { MoveFactory.Flail, },
			[38] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}
