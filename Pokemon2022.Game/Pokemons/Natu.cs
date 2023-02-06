using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Natu : Pokemon
	{
		public override string Name => "Natu";
		public override int Generation => 2;
		public override string PokedexEntry => "It runs up short trees that grow on the savanna to peck at new shoots. A Natu's eyes look as if they are always observing something.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicBounce;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 50,
			Defense = 45,
			SpecialAttack = 70,
			SpecialDefense = 45,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.StoredPower, },
			[10] = new List<Move>() { MoveFactory.Teleport, },
			[15] = new List<Move>() { MoveFactory.ConfuseRay, },
			[20] = new List<Move>() { MoveFactory.NightShade, },
			[26] = new List<Move>() { MoveFactory.PsychoShift, },
			[30] = new List<Move>() { MoveFactory.PowerSwap, },
			[35] = new List<Move>() { MoveFactory.GuardSwap, MoveFactory.Psychic, },
			[40] = new List<Move>() { MoveFactory.Wish, },
			[45] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
