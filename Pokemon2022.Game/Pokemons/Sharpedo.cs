using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sharpedo : Pokemon
	{
		public override string Name => "Sharpedo";
		public override int Generation => 3;
		public override string PokedexEntry => "The vicious and sly gangster of the sea. Its skin is specially textured to minimize drag in water. Its speed tops out at over 75 miles per hour.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RoughSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SpeedBoost;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 120,
			Defense = 40,
			SpecialAttack = 95,
			SpecialDefense = 40,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Slash, },
			[1] = new List<Move>() { MoveFactory.Slash, MoveFactory.NightSlash, MoveFactory.AquaJet, MoveFactory.Leer, MoveFactory.PoisonFang, MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.IceFang, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.Swagger, },
			[34] = new List<Move>() { MoveFactory.Crunch, },
			[40] = new List<Move>() { MoveFactory.Agility, },
			[46] = new List<Move>() { MoveFactory.Liquidation, },
			[52] = new List<Move>() { MoveFactory.TakeDown, },
		};
	}
}
