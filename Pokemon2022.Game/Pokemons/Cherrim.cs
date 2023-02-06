using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cherrim : Pokemon
	{
		public override string Name => "Cherrim";
		public override int Generation => 4;
		public override string PokedexEntry => "Its folded petals are pretty tough. Bird Pokémon can peck at them all they want, and Cherrim won't be bothered at all.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlowerGift, };
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 60,
			Defense = 70,
			SpecialAttack = 87,
			SpecialDefense = 78,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SunnyDay, },
			[1] = new List<Move>() { MoveFactory.SunnyDay, MoveFactory.FlowerShield, MoveFactory.MorningSun, MoveFactory.Tackle, MoveFactory.Leafage, MoveFactory.Growth, },
			[15] = new List<Move>() { MoveFactory.HelpingHand, },
			[20] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[28] = new List<Move>() { MoveFactory.LeechSeed, },
			[34] = new List<Move>() { MoveFactory.TakeDown, },
			[41] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[48] = new List<Move>() { MoveFactory.WorrySeed, },
			[55] = new List<Move>() { MoveFactory.SolarBeam, },
			[62] = new List<Move>() { MoveFactory.PetalDance, },
		};
	}
}
