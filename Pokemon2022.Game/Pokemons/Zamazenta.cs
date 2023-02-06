using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zamazenta : Pokemon
	{
		public override string Name => "Zamazenta";
		public override int Generation => 8;
		public override string PokedexEntry => "This Pokémon slept for aeons while in the form of a statue. It was asleep for so long, people forgot that it ever existed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.DauntlessShield, };
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
			[1] = new List<Move>() { MoveFactory.MetalBurst, MoveFactory.WideGuard, MoveFactory.MetalClaw, MoveFactory.Howl, MoveFactory.QuickAttack, MoveFactory.Bite, },
			[11] = new List<Move>() { MoveFactory.Slash, },
			[22] = new List<Move>() { MoveFactory.IronDefense, },
			[33] = new List<Move>() { MoveFactory.IronHead, },
			[44] = new List<Move>() { MoveFactory.LaserFocus, },
			[55] = new List<Move>() { MoveFactory.Crunch, },
			[66] = new List<Move>() { MoveFactory.Moonblast, },
			[77] = new List<Move>() { MoveFactory.CloseCombat, },
			[88] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
