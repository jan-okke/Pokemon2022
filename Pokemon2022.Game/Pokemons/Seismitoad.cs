using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Seismitoad : Pokemon
	{
		public override string Name => "Seismitoad";
		public override int Generation => 5;
		public override string PokedexEntry => "It increases the power of its punches by vibrating the bumps on its fists. It can turn a boulder to rubble with one punch.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.PoisonTouch, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 105,
			Attack = 95,
			Defense = 75,
			SpecialAttack = 85,
			SpecialDefense = 75,
			Speed = 74
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DrainPunch, },
			[1] = new List<Move>() { MoveFactory.DrainPunch, MoveFactory.GastroAcid, MoveFactory.EchoedVoice, MoveFactory.Growl, MoveFactory.Acid, MoveFactory.Supersonic, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[20] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[30] = new List<Move>() { MoveFactory.Uproar, },
			[39] = new List<Move>() { MoveFactory.AquaRing, },
			[46] = new List<Move>() { MoveFactory.HyperVoice, },
			[54] = new List<Move>() { MoveFactory.MuddyWater, },
			[62] = new List<Move>() { MoveFactory.RainDance, },
			[70] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
