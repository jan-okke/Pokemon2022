using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Luvdisc : Pokemon
	{
		public override string Name => "Luvdisc";
		public override int Generation => 3;
		public override string PokedexEntry => "Luvdisc make the branches of Corsola their nests. There is a custom from long ago of giving a Luvdisc as a gift to express one's feelings of love.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 43,
			Attack = 30,
			Defense = 55,
			SpecialAttack = 40,
			SpecialDefense = 65,
			Speed = 97
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Charm, },
			[4] = new List<Move>() { MoveFactory.WaterGun, },
			[7] = new List<Move>() { MoveFactory.Agility, },
			[9] = new List<Move>() { MoveFactory.DrainingKiss, },
			[13] = new List<Move>() { MoveFactory.TearfulLook, },
			[17] = new List<Move>() { MoveFactory.WaterPulse, },
			[20] = new List<Move>() { MoveFactory.Attract, },
			[22] = new List<Move>() { MoveFactory.Brine, },
			[26] = new List<Move>() { MoveFactory.Flail, },
			[31] = new List<Move>() { MoveFactory.SweetKiss, },
			[34] = new List<Move>() { MoveFactory.TakeDown, },
			[37] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[40] = new List<Move>() { MoveFactory.AquaRing, },
			[42] = new List<Move>() { MoveFactory.Soak, },
			[46] = new List<Move>() { MoveFactory.HydroPump, },
			[49] = new List<Move>() { MoveFactory.Safeguard, },
		};
	}
}
