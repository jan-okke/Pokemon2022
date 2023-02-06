using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swalot : Pokemon
	{
		public override string Name => "Swalot";
		public override int Generation => 3;
		public override string PokedexEntry => "Its powerful stomach acid is capable of digesting almost anything. The one thing in the whole world a Swalot can't digest is its own stomach.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LiquidOoze, AbilityFactory.StickyHold, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 73,
			Defense = 83,
			SpecialAttack = 73,
			SpecialDefense = 83,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.BodySlam, },
			[1] = new List<Move>() { MoveFactory.BodySlam, MoveFactory.VenomDrench, MoveFactory.GunkShot, MoveFactory.Pound, MoveFactory.Yawn, MoveFactory.PoisonGas, MoveFactory.Sludge, },
			[5] = new List<Move>() { MoveFactory.Yawn, },
			[8] = new List<Move>() { MoveFactory.PoisonGas, },
			[10] = new List<Move>() { MoveFactory.Sludge, },
			[12] = new List<Move>() { MoveFactory.Amnesia, },
			[17] = new List<Move>() { MoveFactory.AcidSpray, },
			[20] = new List<Move>() { MoveFactory.Encore, },
			[25] = new List<Move>() { MoveFactory.Toxic, },
			[30] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.SpitUp, MoveFactory.Swallow, },
			[37] = new List<Move>() { MoveFactory.SludgeBomb, },
			[42] = new List<Move>() { MoveFactory.GastroAcid, },
			[49] = new List<Move>() { MoveFactory.Belch, },
			[54] = new List<Move>() { MoveFactory.PainSplit, },
			[61] = new List<Move>() { MoveFactory.GunkShot, },
		};
	}
}
