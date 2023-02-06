using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Monferno : Pokemon
	{
		public override string Name => "Monferno";
		public override int Generation => 4;
		public override string PokedexEntry => "To intimidate attackers, it stretches the fire on its tail to make itself appear bigger.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IronFist;
		public override Stats BaseStats => new Stats() {
			HP = 64,
			Attack = 78,
			Defense = 52,
			SpecialAttack = 78,
			SpecialDefense = 52,
			Speed = 81
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.MachPunch, },
			[1] = new List<Move>() { MoveFactory.MachPunch, MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.Ember, },
			[7] = new List<Move>() { MoveFactory.Ember, },
			[9] = new List<Move>() { MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.PowerUpPunch, },
			[16] = new List<Move>() { MoveFactory.FurySwipes, },
			[19] = new List<Move>() { MoveFactory.FlameWheel, },
			[26] = new List<Move>() { MoveFactory.Feint, },
			[29] = new List<Move>() { MoveFactory.Torment, },
			[36] = new List<Move>() { MoveFactory.CloseCombat, },
			[39] = new List<Move>() { MoveFactory.FireSpin, },
			[46] = new List<Move>() { MoveFactory.Acrobatics, },
			[49] = new List<Move>() { MoveFactory.SlackOff, },
			[56] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
