using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Diglett : Pokemon
	{
		public override string Name => "Diglett";
		public override int Generation => 1;
		public override string PokedexEntry => "Diglett are raised in most farms. The reason is simple--wherever they burrow, the soil is left perfectly tilled for growing delicious crops.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, AbilityFactory.ArenaTrap, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 10,
			Attack = 55,
			Defense = 25,
			SpecialAttack = 35,
			SpecialDefense = 45,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SandAttack, MoveFactory.Scratch, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[8] = new List<Move>() { MoveFactory.Astonish, },
			[12] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.Bulldoze, },
			[20] = new List<Move>() { MoveFactory.SuckerPunch, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[28] = new List<Move>() { MoveFactory.Sandstorm, },
			[32] = new List<Move>() { MoveFactory.Dig, },
			[36] = new List<Move>() { MoveFactory.EarthPower, },
			[40] = new List<Move>() { MoveFactory.Earthquake, },
			[44] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}
