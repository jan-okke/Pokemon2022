using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Empoleon : Pokemon
	{
		public override string Name => "Empoleon";
		public override int Generation => 4;
		public override string PokedexEntry => "The three horns that extend from its beak attest to its power. The leader has the biggest horns.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 84,
			Attack = 86,
			Defense = 88,
			SpecialAttack = 111,
			SpecialDefense = 101,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AquaJet, },
			[1] = new List<Move>() { MoveFactory.AquaJet, MoveFactory.MetalClaw, MoveFactory.Tackle, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[8] = new List<Move>() { MoveFactory.WaterGun, },
			[11] = new List<Move>() { MoveFactory.SwordsDance, },
			[15] = new List<Move>() { MoveFactory.Peck, },
			[19] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.Swagger, },
			[28] = new List<Move>() { MoveFactory.FuryAttack, },
			[33] = new List<Move>() { MoveFactory.Brine, },
			[39] = new List<Move>() { MoveFactory.Whirlpool, },
			[46] = new List<Move>() { MoveFactory.Mist, },
			[52] = new List<Move>() { MoveFactory.DrillPeck, },
			[59] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
