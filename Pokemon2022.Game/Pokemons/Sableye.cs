using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sableye : Pokemon
	{
		public override string Name => "Sableye";
		public override int Generation => 3;
		public override string PokedexEntry => "It digs branching holes in caves using its sharp claws in search of food--raw gems. A Sableye lurks in darkness and is seen only rarely.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.Stall, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Prankster;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 75,
			Defense = 75,
			SpecialAttack = 65,
			SpecialDefense = 65,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leer, MoveFactory.Scratch, },
			[3] = new List<Move>() { MoveFactory.Astonish, },
			[6] = new List<Move>() { MoveFactory.ConfuseRay, },
			[9] = new List<Move>() { MoveFactory.ShadowSneak, },
			[12] = new List<Move>() { MoveFactory.FakeOut, },
			[15] = new List<Move>() { MoveFactory.Disable, },
			[18] = new List<Move>() { MoveFactory.Detect, },
			[21] = new List<Move>() { MoveFactory.NightShade, },
			[24] = new List<Move>() { MoveFactory.FurySwipes, },
			[27] = new List<Move>() { MoveFactory.KnockOff, },
			[30] = new List<Move>() { MoveFactory.Quash, },
			[33] = new List<Move>() { MoveFactory.ShadowClaw, },
			[36] = new List<Move>() { MoveFactory.MeanLook, },
			[39] = new List<Move>() { MoveFactory.PowerGem, },
			[42] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[45] = new List<Move>() { MoveFactory.ShadowBall, },
			[48] = new List<Move>() { MoveFactory.FoulPlay, },
		};
	}
}
