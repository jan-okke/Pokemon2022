using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Moltres : Pokemon
	{
		public override string Name => "Moltres";
		public override int Generation => 1;
		public override string PokedexEntry => "Moltres is a legendary bird Pokémon that can control fire. If injured, it is said to dip its body in the molten magma of a volcano to burn and heal itself.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlameBody;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 100,
			Defense = 90,
			SpecialAttack = 125,
			SpecialDefense = 85,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.Ember, },
			[10] = new List<Move>() { MoveFactory.Safeguard, },
			[15] = new List<Move>() { MoveFactory.WingAttack, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.AncientPower, },
			[30] = new List<Move>() { MoveFactory.Incinerate, },
			[35] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.Roost, },
			[45] = new List<Move>() { MoveFactory.HeatWave, },
			[50] = new List<Move>() { MoveFactory.SunnyDay, },
			[55] = new List<Move>() { MoveFactory.Hurricane, },
			[60] = new List<Move>() { MoveFactory.Endure, },
			[65] = new List<Move>() { MoveFactory.BurnUp, },
			[70] = new List<Move>() { MoveFactory.SkyAttack, },
		};
	}
}
