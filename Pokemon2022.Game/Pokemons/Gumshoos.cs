using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gumshoos : Pokemon
	{
		public override string Name => "Gumshoos";
		public override int Generation => 7;
		public override string PokedexEntry => "When it finds a trace of its prey, it patiently stakes out the location... but it's always snoozing by nightfall.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Stakeout, AbilityFactory.StrongJaw, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Adaptability;
		public override Stats BaseStats => new Stats() {
			HP = 88,
			Attack = 110,
			Defense = 60,
			SpecialAttack = 55,
			SpecialDefense = 60,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.Pursuit, MoveFactory.SandAttack, },
			[3] = new List<Move>() { MoveFactory.Leer, },
			[7] = new List<Move>() { MoveFactory.Pursuit, },
			[10] = new List<Move>() { MoveFactory.SandAttack, },
			[13] = new List<Move>() { MoveFactory.OdorSleuth, },
			[16] = new List<Move>() { MoveFactory.Bide, },
			[19] = new List<Move>() { MoveFactory.Bite, },
			[23] = new List<Move>() { MoveFactory.MudSlap, },
			[27] = new List<Move>() { MoveFactory.SuperFang, },
			[31] = new List<Move>() { MoveFactory.TakeDown, },
			[35] = new List<Move>() { MoveFactory.ScaryFace, },
			[39] = new List<Move>() { MoveFactory.Crunch, },
			[43] = new List<Move>() { MoveFactory.HyperFang, },
			[47] = new List<Move>() { MoveFactory.Yawn, },
			[51] = new List<Move>() { MoveFactory.Thrash, },
			[55] = new List<Move>() { MoveFactory.Rest, },
		};
	}
}
