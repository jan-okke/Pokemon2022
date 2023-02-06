using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Paras : Pokemon
	{
		public override string Name => "Paras";
		public override int Generation => 1;
		public override string PokedexEntry => "A Paras has parasitic tochukaso mushrooms growing on its back. They grow by drawing nutrients from the host. They are valued as a medicine for long life.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EffectSpore, AbilityFactory.DrySkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 70,
			Defense = 55,
			SpecialAttack = 45,
			SpecialDefense = 55,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, },
			[6] = new List<Move>() { MoveFactory.StunSpore, MoveFactory.PoisonPowder, },
			[11] = new List<Move>() { MoveFactory.Absorb, },
			[17] = new List<Move>() { MoveFactory.FuryCutter, },
			[22] = new List<Move>() { MoveFactory.Spore, },
			[27] = new List<Move>() { MoveFactory.Slash, },
			[33] = new List<Move>() { MoveFactory.Growth, },
			[38] = new List<Move>() { MoveFactory.GigaDrain, },
			[43] = new List<Move>() { MoveFactory.Aromatherapy, },
			[49] = new List<Move>() { MoveFactory.RagePowder, },
			[54] = new List<Move>() { MoveFactory.XScissor, },
		};
	}
}
