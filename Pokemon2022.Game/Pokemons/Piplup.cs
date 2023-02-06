using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Piplup : Pokemon
	{
		public override string Name => "Piplup";
		public override int Generation => 4;
		public override string PokedexEntry => "Because it is very proud, it hates accepting food from people. Its thick down guards it from cold.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 53,
			Attack = 51,
			Defense = 53,
			SpecialAttack = 61,
			SpecialDefense = 56,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[11] = new List<Move>() { MoveFactory.Charm, },
			[15] = new List<Move>() { MoveFactory.Peck, },
			[18] = new List<Move>() { MoveFactory.BubbleBeam, },
			[22] = new List<Move>() { MoveFactory.Swagger, },
			[25] = new List<Move>() { MoveFactory.FuryAttack, },
			[29] = new List<Move>() { MoveFactory.Brine, },
			[32] = new List<Move>() { MoveFactory.Whirlpool, },
			[36] = new List<Move>() { MoveFactory.Mist, },
			[39] = new List<Move>() { MoveFactory.DrillPeck, },
			[43] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
