using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Yungoos : Pokemon
	{
		public override string Name => "Yungoos";
		public override int Generation => 7;
		public override string PokedexEntry => "Its stomach takes up most of its long torso. It's a big eater, so the amount Trainers have to spend on its food is no laughing matter.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Stakeout, AbilityFactory.StrongJaw, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Adaptability;
		public override Stats BaseStats => new Stats() {
			HP = 48,
			Attack = 70,
			Defense = 30,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[3] = new List<Move>() { MoveFactory.Leer, },
			[7] = new List<Move>() { MoveFactory.Pursuit, },
			[10] = new List<Move>() { MoveFactory.SandAttack, },
			[13] = new List<Move>() { MoveFactory.OdorSleuth, },
			[16] = new List<Move>() { MoveFactory.Bide, },
			[19] = new List<Move>() { MoveFactory.Bite, },
			[22] = new List<Move>() { MoveFactory.MudSlap, },
			[25] = new List<Move>() { MoveFactory.SuperFang, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[31] = new List<Move>() { MoveFactory.ScaryFace, },
			[34] = new List<Move>() { MoveFactory.Crunch, },
			[37] = new List<Move>() { MoveFactory.HyperFang, },
			[40] = new List<Move>() { MoveFactory.Yawn, },
			[43] = new List<Move>() { MoveFactory.Thrash, },
			[46] = new List<Move>() { MoveFactory.Rest, },
		};
	}
}
