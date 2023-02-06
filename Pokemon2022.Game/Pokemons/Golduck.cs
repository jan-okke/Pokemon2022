using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Golduck : Pokemon
	{
		public override string Name => "Golduck";
		public override int Generation => 1;
		public override string PokedexEntry => "A Golduck is an adept swimmer. It sometimes joins competitive swimmers in training. It uses psychic powers when its forehead shimmers with light.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Damp, AbilityFactory.CloudNine, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 82,
			Defense = 78,
			SpecialAttack = 95,
			SpecialDefense = 80,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.AquaJet, MoveFactory.Scratch, MoveFactory.TailWhip, MoveFactory.WaterGun, MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.FurySwipes, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[15] = new List<Move>() { MoveFactory.Disable, },
			[18] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[21] = new List<Move>() { MoveFactory.Screech, },
			[24] = new List<Move>() { MoveFactory.AquaTail, },
			[27] = new List<Move>() { MoveFactory.Soak, },
			[30] = new List<Move>() { MoveFactory.PsychUp, },
			[36] = new List<Move>() { MoveFactory.Amnesia, },
			[40] = new List<Move>() { MoveFactory.HydroPump, },
			[45] = new List<Move>() { MoveFactory.WonderRoom, },
		};
	}
}
