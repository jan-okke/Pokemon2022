using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swinub : Pokemon
	{
		public override string Name => "Swinub";
		public override int Generation => 2;
		public override string PokedexEntry => "It roots for food by rubbing its snout against the ground. Its favorite food is a mushroom that grows under dried grass. It occasionally roots out hot springs.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.SnowCloak, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ThickFat;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 50,
			Defense = 40,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.MudSlap, },
			[5] = new List<Move>() { MoveFactory.PowderSnow, },
			[10] = new List<Move>() { MoveFactory.Flail, },
			[15] = new List<Move>() { MoveFactory.IceShard, },
			[20] = new List<Move>() { MoveFactory.Mist, },
			[25] = new List<Move>() { MoveFactory.Endure, },
			[30] = new List<Move>() { MoveFactory.IcyWind, },
			[35] = new List<Move>() { MoveFactory.Amnesia, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[45] = new List<Move>() { MoveFactory.Earthquake, },
			[50] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}
