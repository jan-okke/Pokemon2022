using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mewtwo : Pokemon
	{
		public override string Name => "Mewtwo";
		public override int Generation => 1;
		public override string PokedexEntry => "A Pokémon that was created by genetic manipulation. However, even though the scientific power of humans made its body, they failed to give it a warm heart.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 106,
			Attack = 110,
			Defense = 90,
			SpecialAttack = 154,
			SpecialDefense = 90,
			Speed = 130
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.LifeDew, MoveFactory.LaserFocus, MoveFactory.Disable, MoveFactory.Confusion, MoveFactory.Swift, },
			[8] = new List<Move>() { MoveFactory.AncientPower, },
			[16] = new List<Move>() { MoveFactory.PsychoCut, },
			[24] = new List<Move>() { MoveFactory.Safeguard, },
			[32] = new List<Move>() { MoveFactory.Amnesia, },
			[40] = new List<Move>() { MoveFactory.AuraSphere, },
			[48] = new List<Move>() { MoveFactory.Psychic, },
			[56] = new List<Move>() { MoveFactory.PowerSwap, MoveFactory.GuardSwap, },
			[64] = new List<Move>() { MoveFactory.Mist, },
			[72] = new List<Move>() { MoveFactory.Psystrike, },
			[80] = new List<Move>() { MoveFactory.Recover, },
			[88] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
