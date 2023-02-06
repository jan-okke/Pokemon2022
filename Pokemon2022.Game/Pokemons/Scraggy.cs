using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Scraggy : Pokemon
	{
		public override string Name => "Scraggy";
		public override int Generation => 5;
		public override string PokedexEntry => "It immediately headbutts anyone that makes eye contact with it. Its skull is massively thick.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, AbilityFactory.Moxie, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Intimidate;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 75,
			Defense = 70,
			SpecialAttack = 35,
			SpecialDefense = 70,
			Speed = 48
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.LowKick, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Payback, },
			[8] = new List<Move>() { MoveFactory.Headbutt, },
			[12] = new List<Move>() { MoveFactory.SandAttack, },
			[16] = new List<Move>() { MoveFactory.Facade, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[24] = new List<Move>() { MoveFactory.BeatUp, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[32] = new List<Move>() { MoveFactory.BrickBreak, },
			[36] = new List<Move>() { MoveFactory.Swagger, },
			[40] = new List<Move>() { MoveFactory.Crunch, },
			[44] = new List<Move>() { MoveFactory.HighJumpKick, },
			[48] = new List<Move>() { MoveFactory.FocusPunch, },
			[52] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
