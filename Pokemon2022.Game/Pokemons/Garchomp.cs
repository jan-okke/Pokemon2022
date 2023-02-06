using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Garchomp : Pokemon
	{
		public override string Name => "Garchomp";
		public override int Generation => 4;
		public override string PokedexEntry => "When it folds up its body and extends its wings, it looks like a jet plane. It flies at sonic speed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RoughSkin;
		public override Stats BaseStats => new Stats() {
			HP = 108,
			Attack = 130,
			Defense = 95,
			SpecialAttack = 80,
			SpecialDefense = 85,
			Speed = 102
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Crunch, },
			[1] = new List<Move>() { MoveFactory.Crunch, MoveFactory.DualChop, MoveFactory.SandTomb, MoveFactory.Tackle, MoveFactory.SandAttack, MoveFactory.DragonBreath, },
			[18] = new List<Move>() { MoveFactory.Bulldoze, },
			[27] = new List<Move>() { MoveFactory.Bite, },
			[34] = new List<Move>() { MoveFactory.Slash, },
			[42] = new List<Move>() { MoveFactory.DragonClaw, },
			[52] = new List<Move>() { MoveFactory.Dig, },
			[62] = new List<Move>() { MoveFactory.Sandstorm, },
			[72] = new List<Move>() { MoveFactory.TakeDown, },
			[82] = new List<Move>() { MoveFactory.DragonRush, },
		};
	}
}
