using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Onix : Pokemon
	{
		public override string Name => "Onix";
		public override int Generation => 1;
		public override string PokedexEntry => "There is a magnet in its brain that prevents an Onix from losing direction while tunneling. As it grows older, its body becomes steadily rounder and smoother.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 45,
			Defense = 160,
			SpecialAttack = 30,
			SpecialDefense = 45,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.Bind, MoveFactory.RockThrow, },
			[4] = new List<Move>() { MoveFactory.SmackDown, },
			[8] = new List<Move>() { MoveFactory.RockPolish, },
			[12] = new List<Move>() { MoveFactory.DragonBreath, },
			[16] = new List<Move>() { MoveFactory.Curse, },
			[20] = new List<Move>() { MoveFactory.RockSlide, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.SandTomb, },
			[32] = new List<Move>() { MoveFactory.StealthRock, },
			[36] = new List<Move>() { MoveFactory.Slam, },
			[40] = new List<Move>() { MoveFactory.Sandstorm, },
			[44] = new List<Move>() { MoveFactory.Dig, },
			[48] = new List<Move>() { MoveFactory.IronTail, },
			[52] = new List<Move>() { MoveFactory.StoneEdge, },
			[56] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
