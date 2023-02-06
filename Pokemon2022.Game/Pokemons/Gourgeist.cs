using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gourgeist : Pokemon
	{
		public override string Name => "Gourgeist";
		public override int Generation => 6;
		public override string PokedexEntry => "Small Gourgeist pretend to be children to fool adults. Anyone who falls for the act gets carried away to the hereafter.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.Frisk, };
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 85,
			Defense = 122,
			SpecialAttack = 58,
			SpecialDefense = 75,
			Speed = 99
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Explosion, MoveFactory.Moonblast, MoveFactory.TrickorTreat, MoveFactory.Astonish, MoveFactory.ShadowSneak, MoveFactory.ConfuseRay, },
			[12] = new List<Move>() { MoveFactory.TrickorTreat, MoveFactory.RazorLeaf, },
			[16] = new List<Move>() { MoveFactory.LeechSeed, },
			[20] = new List<Move>() { MoveFactory.BulletSeed, },
			[24] = new List<Move>() { MoveFactory.TrickorTreat, MoveFactory.ScaryFace, },
			[28] = new List<Move>() { MoveFactory.WorrySeed, },
			[32] = new List<Move>() { MoveFactory.SeedBomb, },
			[36] = new List<Move>() { MoveFactory.TrickorTreat, MoveFactory.ShadowBall, },
			[40] = new List<Move>() { MoveFactory.Trick, },
			[44] = new List<Move>() { MoveFactory.PainSplit, },
			[48] = new List<Move>() { MoveFactory.PhantomForce, },
		};
	}
}
