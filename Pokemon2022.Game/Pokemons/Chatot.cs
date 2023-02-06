using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chatot : Pokemon
	{
		public override string Name => "Chatot";
		public override int Generation => 4;
		public override string PokedexEntry => "It can learn and speak human words. If they gather, they all learn the same saying.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.TangledFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.BigPecks;
		public override Stats BaseStats => new Stats() {
			HP = 76,
			Attack = 65,
			Defense = 45,
			SpecialAttack = 92,
			SpecialDefense = 42,
			Speed = 91
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.HyperVoice, MoveFactory.Chatter, MoveFactory.Confide, MoveFactory.Taunt, },
			[5] = new List<Move>() { MoveFactory.Peck, },
			[9] = new List<Move>() { MoveFactory.Growl, },
			[13] = new List<Move>() { MoveFactory.Sing, },
			[17] = new List<Move>() { MoveFactory.FuryAttack, },
			[21] = new List<Move>() { MoveFactory.Chatter, },
			[25] = new List<Move>() { MoveFactory.Taunt, },
			[29] = new List<Move>() { MoveFactory.Round, },
			[33] = new List<Move>() { MoveFactory.Mimic, },
			[37] = new List<Move>() { MoveFactory.EchoedVoice, },
			[41] = new List<Move>() { MoveFactory.Roost, },
			[45] = new List<Move>() { MoveFactory.Uproar, },
			[49] = new List<Move>() { MoveFactory.PartingShot, },
			[50] = new List<Move>() { MoveFactory.FeatherDance, },
			[57] = new List<Move>() { MoveFactory.HyperVoice, },
		};
	}
}
