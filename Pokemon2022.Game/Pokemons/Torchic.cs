using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Torchic : Pokemon
	{
		public override string Name => "Torchic";
		public override int Generation => 3;
		public override string PokedexEntry => "If attacked, it strikes back by spitting balls of fire it forms in its stomach. A Torchic dislikes darkness because it can't see its surroundings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SpeedBoost;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 60,
			Defense = 40,
			SpecialAttack = 70,
			SpecialDefense = 50,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.Ember, },
			[6] = new List<Move>() { MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.FlameCharge, },
			[12] = new List<Move>() { MoveFactory.Detect, },
			[15] = new List<Move>() { MoveFactory.SandAttack, },
			[18] = new List<Move>() { MoveFactory.AerialAce, },
			[21] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.Bounce, },
			[27] = new List<Move>() { MoveFactory.FocusEnergy, },
			[30] = new List<Move>() { MoveFactory.Flamethrower, },
			[33] = new List<Move>() { MoveFactory.FeatherDance, },
			[36] = new List<Move>() { MoveFactory.Reversal, },
			[39] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
