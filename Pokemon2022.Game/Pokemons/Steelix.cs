using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Steelix : Pokemon
	{
		public override string Name => "Steelix";
		public override int Generation => 2;
		public override string PokedexEntry => "Steelix live even further underground than Onix. This Pokémon is known to dig toward the earth's core, reaching a depth of over six-tenths of a mile underground.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 85,
			Defense = 200,
			SpecialAttack = 55,
			SpecialDefense = 65,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Crunch, MoveFactory.ThunderFang, MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.RockPolish, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.Bind, MoveFactory.RockThrow, },
			[4] = new List<Move>() { MoveFactory.SmackDown, },
			[8] = new List<Move>() { MoveFactory.Autotomize, },
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
			[60] = new List<Move>() { MoveFactory.MagnetRise, },
		};
	}
}
