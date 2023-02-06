using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Trubbish : Pokemon
	{
		public override string Name => "Trubbish";
		public override int Generation => 5;
		public override string PokedexEntry => "The combination of garbage bags and industrial waste caused the chemical reaction that crated this Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Stench, AbilityFactory.StickyHold, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Aftermath;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 50,
			Defense = 62,
			SpecialAttack = 40,
			SpecialDefense = 62,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.PoisonGas, },
			[3] = new List<Move>() { MoveFactory.Recycle, },
			[6] = new List<Move>() { MoveFactory.AcidSpray, },
			[9] = new List<Move>() { MoveFactory.Amnesia, },
			[12] = new List<Move>() { MoveFactory.ClearSmog, },
			[15] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[18] = new List<Move>() { MoveFactory.Sludge, },
			[21] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, },
			[24] = new List<Move>() { MoveFactory.TakeDown, },
			[27] = new List<Move>() { MoveFactory.SludgeBomb, },
			[30] = new List<Move>() { MoveFactory.Toxic, },
			[33] = new List<Move>() { MoveFactory.Belch, },
			[37] = new List<Move>() { MoveFactory.PainSplit, },
			[39] = new List<Move>() { MoveFactory.GunkShot, },
			[42] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
