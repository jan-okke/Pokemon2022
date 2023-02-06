using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Latias : Pokemon
	{
		public override string Name => "Latias";
		public override int Generation => 3;
		public override string PokedexEntry => "They make a small herd of only several members. They rarely make contact with people or other Pokémon. They disappear if they sense enemies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 80,
			Defense = 90,
			SpecialAttack = 110,
			SpecialDefense = 130,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.StoredPower, MoveFactory.Charm, },
			[5] = new List<Move>() { MoveFactory.HelpingHand, },
			[10] = new List<Move>() { MoveFactory.Recover, },
			[15] = new List<Move>() { MoveFactory.Confusion, },
			[20] = new List<Move>() { MoveFactory.Tailwind, },
			[25] = new List<Move>() { MoveFactory.DragonBreath, },
			[30] = new List<Move>() { MoveFactory.Wish, },
			[35] = new List<Move>() { MoveFactory.MistBall, },
			[40] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[45] = new List<Move>() { MoveFactory.DragonPulse, },
			[50] = new List<Move>() { MoveFactory.HealPulse, },
			[55] = new List<Move>() { MoveFactory.ReflectType, },
			[60] = new List<Move>() { MoveFactory.Psychic, },
			[65] = new List<Move>() { MoveFactory.GuardSplit, },
			[70] = new List<Move>() { MoveFactory.HealingWish, },
			[75] = new List<Move>() { MoveFactory.PsychoShift, },
		};
	}
}
