using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Psyduck : Pokemon
	{
		public override string Name => "Psyduck";
		public override int Generation => 1;
		public override string PokedexEntry => "When its headache intensifies, it starts using strange powers. However, it has no recollection of its powers, so it always looks befuddled and bewildered.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Damp, AbilityFactory.CloudNine, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 52,
			Defense = 48,
			SpecialAttack = 65,
			SpecialDefense = 50,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.TailWhip, },
			[3] = new List<Move>() { MoveFactory.WaterGun, },
			[6] = new List<Move>() { MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.FurySwipes, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[15] = new List<Move>() { MoveFactory.Disable, },
			[18] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[21] = new List<Move>() { MoveFactory.Screech, },
			[24] = new List<Move>() { MoveFactory.AquaTail, },
			[27] = new List<Move>() { MoveFactory.Soak, },
			[30] = new List<Move>() { MoveFactory.PsychUp, },
			[34] = new List<Move>() { MoveFactory.Amnesia, },
			[36] = new List<Move>() { MoveFactory.HydroPump, },
			[39] = new List<Move>() { MoveFactory.WonderRoom, },
		};
	}
}
