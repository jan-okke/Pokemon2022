using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Urshifu : Pokemon
	{
		public override string Name => "Urshifu";
		public override int Generation => 8;
		public override string PokedexEntry => "Inhabiting the mountains of a distant region, this Pokémon races across sheer cliffs, training its legs and refining its moves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.UnseenFist, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 130,
			Defense = 100,
			SpecialAttack = 63,
			SpecialDefense = 60,
			Speed = 97
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.WickedBlow, },
			[1] = new List<Move>() { MoveFactory.WickedBlow, MoveFactory.SuckerPunch, MoveFactory.RockSmash, MoveFactory.Leer, MoveFactory.Endure, MoveFactory.FocusEnergy, },
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
