using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pumpkaboo : Pokemon
	{
		public override string Name => "Pumpkaboo";
		public override int Generation => 6;
		public override string PokedexEntry => "When taking spirits to the afterlife, small Pumpkaboo prefer the spirits of children to those of adults.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.Frisk, };
		public override Stats BaseStats => new Stats() {
			HP = 44,
			Attack = 66,
			Defense = 70,
			SpecialAttack = 44,
			SpecialDefense = 55,
			Speed = 56
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.TrickorTreat, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.ShadowSneak, },
			[8] = new List<Move>() { MoveFactory.ConfuseRay, },
			[12] = new List<Move>() { MoveFactory.TrickorTreat, MoveFactory.RazorLeaf, },
			[16] = new List<Move>() { MoveFactory.LeechSeed, },
			[20] = new List<Move>() { MoveFactory.BulletSeed, },
			[24] = new List<Move>() { MoveFactory.TrickorTreat, MoveFactory.ScaryFace, },
			[28] = new List<Move>() { MoveFactory.WorrySeed, },
			[32] = new List<Move>() { MoveFactory.SeedBomb, },
			[36] = new List<Move>() { MoveFactory.TrickorTreat, MoveFactory.ShadowBall, },
			[40] = new List<Move>() { MoveFactory.Trick, },
			[44] = new List<Move>() { MoveFactory.PainSplit, },
		};
	}
}
