using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Silvally : Pokemon
	{
		public override string Name => "Silvally";
		public override int Generation => 7;
		public override string PokedexEntry => "Its trust in its partner is what awakens it. This Pokémon is capable of changing its type, a flexibility that is well displayed in battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RKSSystem, };
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 95,
			Defense = 95,
			SpecialAttack = 95,
			SpecialDefense = 95,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.MultiAttack, },
			[1] = new List<Move>() { MoveFactory.MultiAttack, MoveFactory.Explosion, MoveFactory.ThunderFang, MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.PoisonFang, MoveFactory.Imprison, MoveFactory.IronHead, MoveFactory.Tackle, MoveFactory.Bite, MoveFactory.AerialAce, MoveFactory.ScaryFace, },
			[15] = new List<Move>() { MoveFactory.DoubleHit, },
			[20] = new List<Move>() { MoveFactory.MetalSound, },
			[25] = new List<Move>() { MoveFactory.CrushClaw, },
			[30] = new List<Move>() { MoveFactory.AirSlash, },
			[35] = new List<Move>() { MoveFactory.TriAttack, },
			[40] = new List<Move>() { MoveFactory.XScissor, },
			[45] = new List<Move>() { MoveFactory.Crunch, },
			[50] = new List<Move>() { MoveFactory.TakeDown, },
			[55] = new List<Move>() { MoveFactory.DoubleEdge, },
			[60] = new List<Move>() { MoveFactory.PartingShot, },
		};
	}
}
