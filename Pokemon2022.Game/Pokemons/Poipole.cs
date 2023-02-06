using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Poipole : Pokemon
	{
		public override string Name => "Poipole";
		public override int Generation => 7;
		public override string PokedexEntry => "An Ultra Beast that lives in a different world, it cackles wildly as it sprays its opponents with poison from the needles on its head.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 67,
			Attack = 73,
			Defense = 67,
			SpecialAttack = 73,
			SpecialDefense = 67,
			Speed = 73
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DragonPulse, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.HelpingHand, MoveFactory.Acid, },
			[7] = new List<Move>() { MoveFactory.FuryAttack, },
			[14] = new List<Move>() { MoveFactory.FellStinger, },
			[21] = new List<Move>() { MoveFactory.Charm, },
			[28] = new List<Move>() { MoveFactory.Venoshock, },
			[35] = new List<Move>() { MoveFactory.VenomDrench, },
			[42] = new List<Move>() { MoveFactory.NastyPlot, },
			[49] = new List<Move>() { MoveFactory.PoisonJab, },
			[56] = new List<Move>() { MoveFactory.GastroAcid, },
			[63] = new List<Move>() { MoveFactory.Toxic, },
		};
	}
}
