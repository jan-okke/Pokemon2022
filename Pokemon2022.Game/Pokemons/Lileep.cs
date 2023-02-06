using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lileep : Pokemon
	{
		public override string Name => "Lileep";
		public override int Generation => 3;
		public override string PokedexEntry => "It disguises itself as seaweed by making its tentacles sway. Unsuspecting prey that come too close are swallowed whole. It became extinct 100 million years ago.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SuctionCups, };
		public override Ability AvailableHiddenAbility => AbilityFactory.StormDrain;
		public override Stats BaseStats => new Stats() {
			HP = 66,
			Attack = 41,
			Defense = 77,
			SpecialAttack = 61,
			SpecialDefense = 87,
			Speed = 23
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.Acid, },
			[8] = new List<Move>() { MoveFactory.ConfuseRay, },
			[12] = new List<Move>() { MoveFactory.Ingrain, },
			[16] = new List<Move>() { MoveFactory.AncientPower, },
			[20] = new List<Move>() { MoveFactory.MegaDrain, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.Amnesia, },
			[32] = new List<Move>() { MoveFactory.GastroAcid, },
			[36] = new List<Move>() { MoveFactory.GigaDrain, },
			[41] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.SpitUp, MoveFactory.Swallow, },
			[44] = new List<Move>() { MoveFactory.EnergyBall, },
		};
	}
}
