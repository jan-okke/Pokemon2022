using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Azurill : Pokemon
	{
		public override string Name => "Azurill";
		public override int Generation => 3;
		public override string PokedexEntry => "Its tail, which is packed with nutrition, is very bouncy like a rubber ball. On sunny days they gather at the edge of water and splash about for fun.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.HugePower, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SapSipper;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 20,
			Defense = 40,
			SpecialAttack = 20,
			SpecialDefense = 40,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, MoveFactory.WaterGun, MoveFactory.TailWhip, },
			[3] = new List<Move>() { MoveFactory.HelpingHand, },
			[6] = new List<Move>() { MoveFactory.BubbleBeam, },
			[9] = new List<Move>() { MoveFactory.Charm, },
			[12] = new List<Move>() { MoveFactory.Slam, },
			[15] = new List<Move>() { MoveFactory.Bounce, },
		};
	}
}
