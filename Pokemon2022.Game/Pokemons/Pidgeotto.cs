using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pidgeotto : Pokemon
	{
		public override string Name => "Pidgeotto";
		public override int Generation => 1;
		public override string PokedexEntry => "This Pokémon flies around, patrolling its large territory. If its living space is violated, it shows no mercy in thoroughly punishing the foe with its sharp claws.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.TangledFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.BigPecks;
		public override Stats BaseStats => new Stats() {
			HP = 63,
			Attack = 60,
			Defense = 55,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 71
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.SandAttack, MoveFactory.Gust, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[9] = new List<Move>() { MoveFactory.Gust, },
			[13] = new List<Move>() { MoveFactory.QuickAttack, },
			[17] = new List<Move>() { MoveFactory.Whirlwind, },
			[22] = new List<Move>() { MoveFactory.Twister, },
			[27] = new List<Move>() { MoveFactory.FeatherDance, },
			[32] = new List<Move>() { MoveFactory.Agility, },
			[37] = new List<Move>() { MoveFactory.WingAttack, },
			[42] = new List<Move>() { MoveFactory.Roost, },
			[47] = new List<Move>() { MoveFactory.Tailwind, },
			[52] = new List<Move>() { MoveFactory.AerialAce, },
			[57] = new List<Move>() { MoveFactory.AirSlash, },
			[62] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}
