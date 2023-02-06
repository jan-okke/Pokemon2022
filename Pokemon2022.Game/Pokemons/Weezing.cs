using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Weezing : Pokemon
	{
		public override string Name => "Weezing";
		public override int Generation => 1;
		public override string PokedexEntry => "By diluting its toxic gases with a special process, the highest grade of perfume can be made. To Weezing, gases emanating from garbage are the ultimate feast.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, AbilityFactory.NeutralizingGas, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Stench;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 90,
			Defense = 120,
			SpecialAttack = 85,
			SpecialDefense = 70,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DoubleHit, },
			[1] = new List<Move>() { MoveFactory.DoubleHit, MoveFactory.HeatWave, MoveFactory.PoisonGas, MoveFactory.Tackle, MoveFactory.Smog, MoveFactory.Smokescreen, },
			[12] = new List<Move>() { MoveFactory.ClearSmog, },
			[16] = new List<Move>() { MoveFactory.Assurance, },
			[20] = new List<Move>() { MoveFactory.Sludge, },
			[24] = new List<Move>() { MoveFactory.Haze, },
			[28] = new List<Move>() { MoveFactory.SelfDestruct, },
			[32] = new List<Move>() { MoveFactory.SludgeBomb, },
			[38] = new List<Move>() { MoveFactory.Toxic, },
			[44] = new List<Move>() { MoveFactory.Belch, },
			[50] = new List<Move>() { MoveFactory.Explosion, },
			[56] = new List<Move>() { MoveFactory.Memento, },
			[62] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}
