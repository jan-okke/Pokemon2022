using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mightyena : Pokemon
	{
		public override string Name => "Mightyena";
		public override int Generation => 3;
		public override string PokedexEntry => "In the wild, Mightyena live in a pack. They never defy their leader's orders. They defeat foes with perfectly coordinated teamwork.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.QuickFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moxie;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 90,
			Defense = 70,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Snarl, },
			[1] = new List<Move>() { MoveFactory.Snarl, MoveFactory.FireFang, MoveFactory.ThunderFang, MoveFactory.IceFang, MoveFactory.Crunch, MoveFactory.Thief, MoveFactory.Tackle, MoveFactory.Howl, MoveFactory.SandAttack, MoveFactory.Bite, },
			[4] = new List<Move>() { MoveFactory.Howl, },
			[7] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.Bite, },
			[13] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.Roar, },
			[20] = new List<Move>() { MoveFactory.Swagger, },
			[24] = new List<Move>() { MoveFactory.Assurance, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[32] = new List<Move>() { MoveFactory.Headbutt, },
			[36] = new List<Move>() { MoveFactory.Taunt, },
			[40] = new List<Move>() { MoveFactory.Crunch, },
			[44] = new List<Move>() { MoveFactory.Yawn, },
			[48] = new List<Move>() { MoveFactory.TakeDown, },
			[52] = new List<Move>() { MoveFactory.SuckerPunch, },
			[56] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}
