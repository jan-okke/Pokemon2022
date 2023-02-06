using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kubfu : Pokemon
	{
		public override string Name => "Kubfu";
		public override int Generation => 8;
		public override string PokedexEntry => "Kubfu trains hard to perfect its moves. The moves it masters will determine which form it takes when it evolves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 90,
			Defense = 60,
			SpecialAttack = 53,
			SpecialDefense = 50,
			Speed = 72
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.RockSmash, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Endure, },
			[8] = new List<Move>() { MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.AerialAce, },
			[16] = new List<Move>() { MoveFactory.ScaryFace, },
			[20] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.BrickBreak, },
			[28] = new List<Move>() { MoveFactory.Detect, },
			[32] = new List<Move>() { MoveFactory.BulkUp, },
			[36] = new List<Move>() { MoveFactory.IronHead, },
			[40] = new List<Move>() { MoveFactory.DynamicPunch, },
			[44] = new List<Move>() { MoveFactory.Counter, },
			[48] = new List<Move>() { MoveFactory.CloseCombat, },
			[52] = new List<Move>() { MoveFactory.FocusPunch, },
		};
	}
}
