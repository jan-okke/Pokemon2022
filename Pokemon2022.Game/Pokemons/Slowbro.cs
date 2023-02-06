using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Slowbro : Pokemon
	{
		public override string Name => "Slowbro";
		public override int Generation => 1;
		public override string PokedexEntry => "Its tail has a Shellder firmly attached with a bite. As a result, the tail can't be used for fishing anymore. This forces it to reluctantly swim and catch prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 75,
			Defense = 110,
			SpecialAttack = 100,
			SpecialDefense = 80,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Withdraw, MoveFactory.Tackle, MoveFactory.Curse, MoveFactory.Growl, MoveFactory.WaterGun, },
			[9] = new List<Move>() { MoveFactory.Yawn, },
			[12] = new List<Move>() { MoveFactory.Confusion, },
			[15] = new List<Move>() { MoveFactory.Disable, },
			[18] = new List<Move>() { MoveFactory.WaterPulse, },
			[21] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[27] = new List<Move>() { MoveFactory.Amnesia, },
			[30] = new List<Move>() { MoveFactory.Surf, },
			[33] = new List<Move>() { MoveFactory.SlackOff, },
			[36] = new List<Move>() { MoveFactory.Psychic, },
			[41] = new List<Move>() { MoveFactory.PsychUp, },
			[46] = new List<Move>() { MoveFactory.RainDance, },
			[51] = new List<Move>() { MoveFactory.HealPulse, },
		};
	}
}
