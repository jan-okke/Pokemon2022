using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sneasel : Pokemon
	{
		public override string Name => "Sneasel";
		public override int Generation => 2;
		public override string PokedexEntry => "A Sneasel scales trees by punching its hooked claws into the bark. It seeks out unguarded nests and steals eggs for food while the parents are away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 95,
			Defense = 55,
			SpecialAttack = 35,
			SpecialDefense = 75,
			Speed = 115
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.QuickAttack, },
			[18] = new List<Move>() { MoveFactory.MetalClaw, },
			[24] = new List<Move>() { MoveFactory.IcyWind, },
			[30] = new List<Move>() { MoveFactory.FurySwipes, },
			[36] = new List<Move>() { MoveFactory.HoneClaws, },
			[42] = new List<Move>() { MoveFactory.BeatUp, },
			[48] = new List<Move>() { MoveFactory.Agility, },
			[54] = new List<Move>() { MoveFactory.Screech, },
			[60] = new List<Move>() { MoveFactory.Slash, },
		};
	}
}
