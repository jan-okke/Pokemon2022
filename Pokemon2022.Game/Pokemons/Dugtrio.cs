using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dugtrio : Pokemon
	{
		public override string Name => "Dugtrio";
		public override int Generation => 1;
		public override string PokedexEntry => "Because the triplets originally split from one body, they think exactly alike. They work cooperatively to burrow endlessly through the ground.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, AbilityFactory.ArenaTrap, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 100,
			Defense = 50,
			SpecialAttack = 50,
			SpecialDefense = 70,
			Speed = 120
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SandTomb, },
			[1] = new List<Move>() { MoveFactory.SandTomb, MoveFactory.NightSlash, MoveFactory.TriAttack, MoveFactory.SandAttack, MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.Astonish, },
			[12] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.Bulldoze, },
			[20] = new List<Move>() { MoveFactory.SuckerPunch, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.Sandstorm, },
			[36] = new List<Move>() { MoveFactory.Dig, },
			[42] = new List<Move>() { MoveFactory.EarthPower, },
			[48] = new List<Move>() { MoveFactory.Earthquake, },
			[54] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}
