using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Scrafty : Pokemon
	{
		public override string Name => "Scrafty";
		public override int Generation => 5;
		public override string PokedexEntry => "It can smash concrete blocks with its kicking attacks. The one with the biggest crest is the group leader.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, AbilityFactory.Moxie, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Intimidate;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 90,
			Defense = 115,
			SpecialAttack = 45,
			SpecialDefense = 115,
			Speed = 58
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.LowKick, MoveFactory.Leer, MoveFactory.Payback, MoveFactory.Headbutt, },
			[12] = new List<Move>() { MoveFactory.SandAttack, },
			[16] = new List<Move>() { MoveFactory.Facade, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[24] = new List<Move>() { MoveFactory.BeatUp, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[32] = new List<Move>() { MoveFactory.BrickBreak, },
			[36] = new List<Move>() { MoveFactory.Swagger, },
			[42] = new List<Move>() { MoveFactory.Crunch, },
			[48] = new List<Move>() { MoveFactory.HighJumpKick, },
			[54] = new List<Move>() { MoveFactory.FocusPunch, },
			[60] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
