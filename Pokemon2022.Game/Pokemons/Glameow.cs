using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Glameow : Pokemon
	{
		public override string Name => "Glameow";
		public override int Generation => 4;
		public override string PokedexEntry => "It claws if displeased and purrs when affectionate. Its fickleness is very popular among some.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.KeenEye;
		public override Stats BaseStats => new Stats() {
			HP = 49,
			Attack = 55,
			Defense = 42,
			SpecialAttack = 42,
			SpecialDefense = 37,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FakeOut, },
			[5] = new List<Move>() { MoveFactory.Scratch, },
			[8] = new List<Move>() { MoveFactory.Growl, },
			[13] = new List<Move>() { MoveFactory.Hypnosis, },
			[17] = new List<Move>() { MoveFactory.AerialAce, },
			[20] = new List<Move>() { MoveFactory.FurySwipes, },
			[25] = new List<Move>() { MoveFactory.Charm, },
			[29] = new List<Move>() { MoveFactory.Taunt, },
			[32] = new List<Move>() { MoveFactory.Retaliate, },
			[37] = new List<Move>() { MoveFactory.Slash, },
			[41] = new List<Move>() { MoveFactory.SuckerPunch, },
			[44] = new List<Move>() { MoveFactory.Attract, },
			[48] = new List<Move>() { MoveFactory.HoneClaws, },
			[50] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}
