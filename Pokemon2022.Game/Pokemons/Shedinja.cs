using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shedinja : Pokemon
	{
		public override string Name => "Shedinja";
		public override int Generation => 3;
		public override string PokedexEntry => "A peculiar Pokémon that floats in air even though its wings remain completely still. The inside of its body is hollow and utterly dark.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WonderGuard, };
		public override Stats BaseStats => new Stats() {
			HP = 1,
			Attack = 90,
			Defense = 45,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ShadowClaw, MoveFactory.Grudge, MoveFactory.MudSlap, MoveFactory.MetalClaw, MoveFactory.Dig, MoveFactory.Scratch, MoveFactory.SandAttack, MoveFactory.Harden, MoveFactory.FalseSwipe, },
			[15] = new List<Move>() { MoveFactory.ConfuseRay, },
			[23] = new List<Move>() { MoveFactory.Absorb, },
			[29] = new List<Move>() { MoveFactory.ShadowSneak, },
			[36] = new List<Move>() { MoveFactory.FurySwipes, },
			[43] = new List<Move>() { MoveFactory.MindReader, },
			[50] = new List<Move>() { MoveFactory.ShadowBall, },
			[57] = new List<Move>() { MoveFactory.Spite, },
			[64] = new List<Move>() { MoveFactory.PhantomForce, },
		};
	}
}
