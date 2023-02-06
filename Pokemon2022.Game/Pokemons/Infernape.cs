using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Infernape : Pokemon
	{
		public override string Name => "Infernape";
		public override int Generation => 4;
		public override string PokedexEntry => "It uses a special kind of martial arts involving all its limbs. Its fire never goes out.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IronFist;
		public override Stats BaseStats => new Stats() {
			HP = 76,
			Attack = 104,
			Defense = 71,
			SpecialAttack = 104,
			SpecialDefense = 71,
			Speed = 108
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.CloseCombat, },
			[1] = new List<Move>() { MoveFactory.CloseCombat, MoveFactory.MachPunch, MoveFactory.FlareBlitz, MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.Ember, MoveFactory.Taunt, },
			[7] = new List<Move>() { MoveFactory.Ember, },
			[9] = new List<Move>() { MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.PowerUpPunch, },
			[16] = new List<Move>() { MoveFactory.FurySwipes, },
			[19] = new List<Move>() { MoveFactory.FlameWheel, },
			[26] = new List<Move>() { MoveFactory.Feint, },
			[29] = new List<Move>() { MoveFactory.Uturn, },
			[42] = new List<Move>() { MoveFactory.FireSpin, },
			[52] = new List<Move>() { MoveFactory.Acrobatics, },
			[58] = new List<Move>() { MoveFactory.CalmMind, },
			[68] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
