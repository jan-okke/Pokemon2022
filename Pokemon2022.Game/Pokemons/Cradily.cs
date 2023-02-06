using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cradily : Pokemon
	{
		public override string Name => "Cradily";
		public override int Generation => 3;
		public override string PokedexEntry => "It drags its heavy body along the seafloor. It makes its nest in the shallows of warm seas. Cradily can be seen on beaches when the tide goes out.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SuctionCups, };
		public override Ability AvailableHiddenAbility => AbilityFactory.StormDrain;
		public override Stats BaseStats => new Stats() {
			HP = 86,
			Attack = 81,
			Defense = 97,
			SpecialAttack = 81,
			SpecialDefense = 107,
			Speed = 43
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.LeechSeed, MoveFactory.Wrap, MoveFactory.Astonish, MoveFactory.Acid, MoveFactory.ConfuseRay, },
			[12] = new List<Move>() { MoveFactory.Ingrain, },
			[16] = new List<Move>() { MoveFactory.AncientPower, },
			[20] = new List<Move>() { MoveFactory.MegaDrain, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.Amnesia, },
			[32] = new List<Move>() { MoveFactory.GastroAcid, },
			[36] = new List<Move>() { MoveFactory.GigaDrain, },
			[43] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.SpitUp, MoveFactory.Swallow, },
			[48] = new List<Move>() { MoveFactory.EnergyBall, },
		};
	}
}
