using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Toxapex : Pokemon
	{
		public override string Name => "Toxapex";
		public override int Generation => 7;
		public override string PokedexEntry => "Those attacked by Toxapex's poison will suffer intense pain for three days and three nights. Post-recovery, there will be some aftereffects.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Merciless, AbilityFactory.Limber, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 63,
			Defense = 152,
			SpecialAttack = 53,
			SpecialDefense = 142,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.BanefulBunker, },
			[1] = new List<Move>() { MoveFactory.BanefulBunker, MoveFactory.PoisonSting, MoveFactory.Peck, MoveFactory.WideGuard, MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.Venoshock, },
			[20] = new List<Move>() { MoveFactory.Recover, },
			[25] = new List<Move>() { MoveFactory.PinMissile, },
			[30] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[35] = new List<Move>() { MoveFactory.Liquidation, },
			[42] = new List<Move>() { MoveFactory.VenomDrench, },
			[49] = new List<Move>() { MoveFactory.PoisonJab, },
			[56] = new List<Move>() { MoveFactory.Toxic, },
		};
	}
}
