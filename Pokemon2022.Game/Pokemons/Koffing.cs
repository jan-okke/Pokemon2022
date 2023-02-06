using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Koffing : Pokemon
	{
		public override string Name => "Koffing";
		public override int Generation => 1;
		public override string PokedexEntry => "Getting up close to a Koffing will give you a chance to observe, through its thin skin, the toxic gases swirling inside. It blows up at the slightest stimulation.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, AbilityFactory.NeutralizingGas, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Stench;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 65,
			Defense = 95,
			SpecialAttack = 60,
			SpecialDefense = 45,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonGas, MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Smog, },
			[8] = new List<Move>() { MoveFactory.Smokescreen, },
			[12] = new List<Move>() { MoveFactory.ClearSmog, },
			[16] = new List<Move>() { MoveFactory.Assurance, },
			[20] = new List<Move>() { MoveFactory.Sludge, },
			[24] = new List<Move>() { MoveFactory.Haze, },
			[28] = new List<Move>() { MoveFactory.SelfDestruct, },
			[32] = new List<Move>() { MoveFactory.SludgeBomb, },
			[36] = new List<Move>() { MoveFactory.Toxic, },
			[40] = new List<Move>() { MoveFactory.Belch, },
			[44] = new List<Move>() { MoveFactory.Explosion, },
			[48] = new List<Move>() { MoveFactory.Memento, },
			[52] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}
