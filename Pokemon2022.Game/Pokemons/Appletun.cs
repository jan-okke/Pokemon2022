using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Appletun : Pokemon
	{
		public override string Name => "Appletun";
		public override int Generation => 8;
		public override string PokedexEntry => "Its body is covered in sweet nectar, and the skin on its back is especially yummy. Children used to have it as a snack.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Ripen, AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ThickFat;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 85,
			Defense = 80,
			SpecialAttack = 100,
			SpecialDefense = 80,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Headbutt, },
			[1] = new List<Move>() { MoveFactory.Headbutt, MoveFactory.Recycle, MoveFactory.Withdraw, MoveFactory.Astonish, MoveFactory.Growth, MoveFactory.SweetScent, },
			[4] = new List<Move>() { MoveFactory.Curse, },
			[8] = new List<Move>() { MoveFactory.Stomp, },
			[12] = new List<Move>() { MoveFactory.LeechSeed, },
			[16] = new List<Move>() { MoveFactory.Protect, },
			[20] = new List<Move>() { MoveFactory.BulletSeed, },
			[24] = new List<Move>() { MoveFactory.Recover, },
			[28] = new List<Move>() { MoveFactory.AppleAcid, },
			[32] = new List<Move>() { MoveFactory.BodySlam, },
			[36] = new List<Move>() { MoveFactory.IronDefense, },
			[40] = new List<Move>() { MoveFactory.DragonPulse, },
			[44] = new List<Move>() { MoveFactory.EnergyBall, },
		};
	}
}
