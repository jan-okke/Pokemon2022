using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Naganadel : Pokemon
	{
		public override string Name => "Naganadel";
		public override int Generation => 7;
		public override string PokedexEntry => "One kind of Ultra Beast, it fires a glowing, venomous liquid from its needles. This liquid is also immensely adhesive.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 73,
			Attack = 73,
			Defense = 73,
			SpecialAttack = 127,
			SpecialDefense = 73,
			Speed = 121
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AirCutter, },
			[1] = new List<Move>() { MoveFactory.AirCutter, MoveFactory.AirSlash, MoveFactory.DragonPulse, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.HelpingHand, MoveFactory.Acid, },
			[7] = new List<Move>() { MoveFactory.FuryAttack, },
			[14] = new List<Move>() { MoveFactory.FellStinger, },
			[21] = new List<Move>() { MoveFactory.Charm, },
			[28] = new List<Move>() { MoveFactory.Venoshock, },
			[35] = new List<Move>() { MoveFactory.VenomDrench, },
			[42] = new List<Move>() { MoveFactory.NastyPlot, },
			[49] = new List<Move>() { MoveFactory.PoisonJab, },
			[56] = new List<Move>() { MoveFactory.GastroAcid, },
			[63] = new List<Move>() { MoveFactory.Toxic, },
			[70] = new List<Move>() { MoveFactory.DragonRush, },
		};
	}
}
