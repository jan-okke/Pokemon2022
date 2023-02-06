using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pidgeot : Pokemon
	{
		public override string Name => "Pidgeot";
		public override int Generation => 1;
		public override string PokedexEntry => "Pidgeot has gorgeous, glossy feathers. Many trainers are so captivated by the beautiful feathers on its head that they choose Pidgeot as their Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.TangledFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.BigPecks;
		public override Stats BaseStats => new Stats() {
			HP = 83,
			Attack = 80,
			Defense = 75,
			SpecialAttack = 70,
			SpecialDefense = 70,
			Speed = 101
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Hurricane, MoveFactory.Tackle, MoveFactory.SandAttack, MoveFactory.Gust, MoveFactory.QuickAttack, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[9] = new List<Move>() { MoveFactory.Gust, },
			[13] = new List<Move>() { MoveFactory.QuickAttack, },
			[17] = new List<Move>() { MoveFactory.Whirlwind, },
			[22] = new List<Move>() { MoveFactory.Twister, },
			[27] = new List<Move>() { MoveFactory.FeatherDance, },
			[32] = new List<Move>() { MoveFactory.Agility, },
			[38] = new List<Move>() { MoveFactory.WingAttack, },
			[44] = new List<Move>() { MoveFactory.Roost, },
			[50] = new List<Move>() { MoveFactory.Tailwind, },
			[56] = new List<Move>() { MoveFactory.AerialAce, },
			[62] = new List<Move>() { MoveFactory.AirSlash, },
			[68] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}
