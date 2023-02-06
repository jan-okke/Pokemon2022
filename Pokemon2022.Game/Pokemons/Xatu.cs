using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Xatu : Pokemon
	{
		public override string Name => "Xatu";
		public override int Generation => 2;
		public override string PokedexEntry => "It has the enigmatic power of foreseeing the future. Some people in different lands have long believed that Xatu are emissaries from another world.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicBounce;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 75,
			Defense = 70,
			SpecialAttack = 95,
			SpecialDefense = 70,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AirSlash, },
			[1] = new List<Move>() { MoveFactory.AirSlash, MoveFactory.Tailwind, MoveFactory.Peck, MoveFactory.Leer, MoveFactory.StoredPower, MoveFactory.Teleport, },
			[15] = new List<Move>() { MoveFactory.ConfuseRay, },
			[20] = new List<Move>() { MoveFactory.NightShade, },
			[28] = new List<Move>() { MoveFactory.PsychoShift, },
			[34] = new List<Move>() { MoveFactory.PowerSwap, MoveFactory.GuardSwap, },
			[41] = new List<Move>() { MoveFactory.Psychic, },
			[48] = new List<Move>() { MoveFactory.Wish, },
			[55] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
