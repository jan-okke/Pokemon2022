using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Magearna : Pokemon
	{
		public override string Name => "Magearna";
		public override int Generation => 7;
		public override string PokedexEntry => "This artificial Pokémon, constructed more than 500 years ago, can understand human speech but cannot itself speak.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SoulHeart, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 95,
			Defense = 115,
			SpecialAttack = 130,
			SpecialDefense = 115,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.GyroBall, MoveFactory.HelpingHand, },
			[6] = new List<Move>() { MoveFactory.DefenseCurl, },
			[12] = new List<Move>() { MoveFactory.Rollout, },
			[18] = new List<Move>() { MoveFactory.IronDefense, },
			[24] = new List<Move>() { MoveFactory.GearUp, },
			[30] = new List<Move>() { MoveFactory.Psybeam, },
			[36] = new List<Move>() { MoveFactory.AuroraBeam, },
			[42] = new List<Move>() { MoveFactory.MindReader, },
			[48] = new List<Move>() { MoveFactory.ShiftGear, },
			[54] = new List<Move>() { MoveFactory.CraftyShield, },
			[60] = new List<Move>() { MoveFactory.IronHead, },
			[66] = new List<Move>() { MoveFactory.AuraSphere, },
			[72] = new List<Move>() { MoveFactory.FlashCannon, },
			[78] = new List<Move>() { MoveFactory.PainSplit, },
			[84] = new List<Move>() { MoveFactory.ZapCannon, },
			[90] = new List<Move>() { MoveFactory.FleurCannon, },
		};
	}
}
