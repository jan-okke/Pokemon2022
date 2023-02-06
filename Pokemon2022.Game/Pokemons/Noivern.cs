using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Noivern : Pokemon
	{
		public override string Name => "Noivern";
		public override int Generation => 6;
		public override string PokedexEntry => "They fly around on moonless nights and attack careless prey. Nothing can beat them in a battle in the dark.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Flying, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Frisk, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 70,
			Defense = 80,
			SpecialAttack = 97,
			SpecialDefense = 80,
			Speed = 123
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DragonPulse, },
			[1] = new List<Move>() { MoveFactory.DragonPulse, MoveFactory.Moonlight, MoveFactory.Absorb, MoveFactory.Tackle, MoveFactory.Gust, MoveFactory.Supersonic, },
			[12] = new List<Move>() { MoveFactory.DoubleTeam, },
			[16] = new List<Move>() { MoveFactory.WingAttack, },
			[20] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.AirCutter, },
			[28] = new List<Move>() { MoveFactory.Whirlwind, },
			[32] = new List<Move>() { MoveFactory.SuperFang, },
			[36] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.Screech, },
			[44] = new List<Move>() { MoveFactory.Roost, },
			[51] = new List<Move>() { MoveFactory.Tailwind, },
			[56] = new List<Move>() { MoveFactory.Hurricane, },
			[62] = new List<Move>() { MoveFactory.Boomburst, },
		};
	}
}
