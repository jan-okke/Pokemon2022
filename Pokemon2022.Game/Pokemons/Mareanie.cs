using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mareanie : Pokemon
	{
		public override string Name => "Mareanie";
		public override int Generation => 7;
		public override string PokedexEntry => "It plunges the poison spike on its head into its prey. When the prey has weakened, Mareanie deals the finishing blow with its 10 tentacles.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Merciless, AbilityFactory.Limber, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 53,
			Defense = 62,
			SpecialAttack = 43,
			SpecialDefense = 52,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.Peck, },
			[5] = new List<Move>() { MoveFactory.WideGuard, },
			[10] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.Venoshock, },
			[20] = new List<Move>() { MoveFactory.Recover, },
			[25] = new List<Move>() { MoveFactory.PinMissile, },
			[30] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[35] = new List<Move>() { MoveFactory.Liquidation, },
			[40] = new List<Move>() { MoveFactory.VenomDrench, },
			[45] = new List<Move>() { MoveFactory.PoisonJab, },
			[50] = new List<Move>() { MoveFactory.Toxic, },
		};
	}
}
