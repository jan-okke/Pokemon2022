using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Parasect : Pokemon
	{
		public override string Name => "Parasect";
		public override int Generation => 1;
		public override string PokedexEntry => "Parasect are known to infest the roots of large trees en masse and drain nutrients. When an infested tree dies, they move onto another tree all at once.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EffectSpore, AbilityFactory.DrySkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 95,
			Defense = 80,
			SpecialAttack = 60,
			SpecialDefense = 80,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.CrossPoison, MoveFactory.Scratch, MoveFactory.StunSpore, MoveFactory.PoisonPowder, MoveFactory.Absorb, },
			[6] = new List<Move>() { MoveFactory.StunSpore, MoveFactory.PoisonPowder, },
			[11] = new List<Move>() { MoveFactory.Absorb, },
			[17] = new List<Move>() { MoveFactory.FuryCutter, },
			[22] = new List<Move>() { MoveFactory.Spore, },
			[29] = new List<Move>() { MoveFactory.Slash, },
			[37] = new List<Move>() { MoveFactory.Growth, },
			[44] = new List<Move>() { MoveFactory.GigaDrain, },
			[51] = new List<Move>() { MoveFactory.Aromatherapy, },
			[59] = new List<Move>() { MoveFactory.RagePowder, },
			[66] = new List<Move>() { MoveFactory.XScissor, },
		};
	}
}
