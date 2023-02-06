using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Relicanth : Pokemon
	{
		public override string Name => "Relicanth";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that was once believed to be extinct. The species has not changed its form for 100 million years. It walks on the seafloor using its pectoral fins.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sturdy;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 90,
			Defense = 130,
			SpecialAttack = 45,
			SpecialDefense = 65,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.WaterGun, },
			[10] = new List<Move>() { MoveFactory.AncientPower, },
			[15] = new List<Move>() { MoveFactory.Yawn, },
			[20] = new List<Move>() { MoveFactory.Dive, },
			[25] = new List<Move>() { MoveFactory.TakeDown, },
			[30] = new List<Move>() { MoveFactory.AquaTail, },
			[35] = new List<Move>() { MoveFactory.Rest, },
			[40] = new List<Move>() { MoveFactory.Flail, },
			[45] = new List<Move>() { MoveFactory.HydroPump, },
			[50] = new List<Move>() { MoveFactory.DoubleEdge, },
			[55] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
