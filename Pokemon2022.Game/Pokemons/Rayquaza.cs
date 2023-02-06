using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rayquaza : Pokemon
	{
		public override string Name => "Rayquaza";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that flies endlessly in the ozone layer. It is said it would descend to the ground if Kyogre and Groudon were to fight.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.AirLock, };
		public override Stats BaseStats => new Stats() {
			HP = 105,
			Attack = 150,
			Defense = 90,
			SpecialAttack = 150,
			SpecialDefense = 90,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DragonAscent, MoveFactory.Twister, MoveFactory.AncientPower, MoveFactory.AirSlash, MoveFactory.ScaryFace, },
			[9] = new List<Move>() { MoveFactory.Crunch, },
			[18] = new List<Move>() { MoveFactory.DragonDance, },
			[27] = new List<Move>() { MoveFactory.ExtremeSpeed, },
			[36] = new List<Move>() { MoveFactory.DragonPulse, },
			[45] = new List<Move>() { MoveFactory.HyperVoice, },
			[54] = new List<Move>() { MoveFactory.Rest, },
			[63] = new List<Move>() { MoveFactory.Fly, },
			[72] = new List<Move>() { MoveFactory.Hurricane, },
			[81] = new List<Move>() { MoveFactory.Outrage, },
			[90] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
