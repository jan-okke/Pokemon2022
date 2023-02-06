using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Absol : Pokemon
	{
		public override string Name => "Absol";
		public override int Generation => 3;
		public override string PokedexEntry => "It sharply senses even subtle changes in the sky and the land to predict natural disasters. It is a long-lived Pokémon that has a life-span of 100 years.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, AbilityFactory.SuperLuck, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Justified;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 130,
			Defense = 60,
			SpecialAttack = 75,
			SpecialDefense = 60,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.DoubleTeam, },
			[10] = new List<Move>() { MoveFactory.KnockOff, },
			[15] = new List<Move>() { MoveFactory.Detect, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[25] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.NightSlash, },
			[35] = new List<Move>() { MoveFactory.FocusEnergy, },
			[40] = new List<Move>() { MoveFactory.SuckerPunch, },
			[45] = new List<Move>() { MoveFactory.SwordsDance, },
			[50] = new List<Move>() { MoveFactory.FutureSight, },
			[55] = new List<Move>() { MoveFactory.PerishSong, },
		};
	}
}
