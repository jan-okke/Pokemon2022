using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Florges : Pokemon
	{
		public override string Name => "Florges";
		public override int Generation => 6;
		public override string PokedexEntry => "It claims exquisite flower gardens as its territory, and it obtains power from basking in the energy emitted by flowering plants.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlowerVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Symbiosis;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 65,
			Defense = 68,
			SpecialAttack = 112,
			SpecialDefense = 154,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DisarmingVoice, MoveFactory.LuckyChant, MoveFactory.Wish, MoveFactory.MagicalLeaf, MoveFactory.FlowerShield, MoveFactory.GrassKnot, MoveFactory.GrassyTerrain, MoveFactory.PetalBlizzard, MoveFactory.MistyTerrain, MoveFactory.Moonblast, MoveFactory.PetalDance, MoveFactory.Aromatherapy, },
		};
	}
}
