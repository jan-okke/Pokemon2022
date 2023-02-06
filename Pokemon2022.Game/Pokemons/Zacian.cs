using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zacian : Pokemon
	{
		public override string Name => "Zacian";
		public override int Generation => 8;
		public override string PokedexEntry => "Known as a legendary hero, this Pokémon absorbs metal particles, transforming them into a weapon it uses to battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IntrepidSword, };
		public override Stats BaseStats => new Stats() {
			HP = 92,
			Attack = 130,
			Defense = 115,
			SpecialAttack = 80,
			SpecialDefense = 115,
			Speed = 138
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SacredSword, MoveFactory.QuickGuard, MoveFactory.MetalClaw, MoveFactory.Howl, MoveFactory.QuickAttack, MoveFactory.Bite, },
			[11] = new List<Move>() { MoveFactory.Slash, },
			[22] = new List<Move>() { MoveFactory.SwordsDance, },
			[33] = new List<Move>() { MoveFactory.IronHead, },
			[44] = new List<Move>() { MoveFactory.LaserFocus, },
			[55] = new List<Move>() { MoveFactory.Crunch, },
			[66] = new List<Move>() { MoveFactory.Moonblast, },
			[77] = new List<Move>() { MoveFactory.CloseCombat, },
			[88] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
