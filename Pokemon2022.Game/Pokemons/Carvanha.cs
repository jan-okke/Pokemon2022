using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Carvanha : Pokemon
	{
		public override string Name => "Carvanha";
		public override int Generation => 3;
		public override string PokedexEntry => "Carvanha attack ships in swarms, making them sink. Although it is said to be a very vicious Pokémon, it timidly flees as soon as it finds itself alone.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RoughSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SpeedBoost;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 90,
			Defense = 20,
			SpecialAttack = 65,
			SpecialDefense = 20,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.AquaJet, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.PoisonFang, },
			[8] = new List<Move>() { MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.IceFang, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.Swagger, },
			[32] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.Agility, },
			[40] = new List<Move>() { MoveFactory.Liquidation, },
			[44] = new List<Move>() { MoveFactory.TakeDown, },
		};
	}
}
