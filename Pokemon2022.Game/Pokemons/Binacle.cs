using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Binacle : Pokemon
	{
		public override string Name => "Binacle";
		public override int Generation => 6;
		public override string PokedexEntry => "They stretch and then contract, yanking their rocks along with them in bold hops. They eat seaweed that washes up on the shoreline.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ToughClaws, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 42,
			Attack = 52,
			Defense = 67,
			SpecialAttack = 39,
			SpecialDefense = 56,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.MudSlap, },
			[4] = new List<Move>() { MoveFactory.Withdraw, },
			[8] = new List<Move>() { MoveFactory.WaterGun, },
			[12] = new List<Move>() { MoveFactory.FuryCutter, },
			[16] = new List<Move>() { MoveFactory.FurySwipes, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[24] = new List<Move>() { MoveFactory.RockPolish, },
			[28] = new List<Move>() { MoveFactory.Slash, },
			[32] = new List<Move>() { MoveFactory.HoneClaws, },
			[36] = new List<Move>() { MoveFactory.RazorShell, },
			[40] = new List<Move>() { MoveFactory.ShellSmash, },
			[44] = new List<Move>() { MoveFactory.CrossChop, },
		};
	}
}
