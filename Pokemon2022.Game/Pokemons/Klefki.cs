using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Klefki : Pokemon
	{
		public override string Name => "Klefki";
		public override int Generation => 6;
		public override string PokedexEntry => "It never lets go of a key that it likes, so people give it the keys to vaults and safes as a way to prevent crime.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Prankster, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Magician;
		public override Stats BaseStats => new Stats() {
			HP = 57,
			Attack = 80,
			Defense = 91,
			SpecialAttack = 80,
			SpecialDefense = 87,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FairyLock, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.Tackle, },
			[8] = new List<Move>() { MoveFactory.FairyWind, },
			[12] = new List<Move>() { MoveFactory.Torment, },
			[16] = new List<Move>() { MoveFactory.CraftyShield, },
			[20] = new List<Move>() { MoveFactory.MetalSound, },
			[24] = new List<Move>() { MoveFactory.DrainingKiss, },
			[28] = new List<Move>() { MoveFactory.Recycle, },
			[32] = new List<Move>() { MoveFactory.Imprison, },
			[36] = new List<Move>() { MoveFactory.FlashCannon, },
			[40] = new List<Move>() { MoveFactory.PlayRough, },
			[44] = new List<Move>() { MoveFactory.MagicRoom, },
			[48] = new List<Move>() { MoveFactory.FoulPlay, },
			[52] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}
