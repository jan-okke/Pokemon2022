using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Barbaracle : Pokemon
	{
		public override string Name => "Barbaracle";
		public override int Generation => 6;
		public override string PokedexEntry => "Barbaracle's legs and hands have minds of their own, and they will move independently. But they usually follow the head's orders.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ToughClaws, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 105,
			Defense = 115,
			SpecialAttack = 54,
			SpecialDefense = 86,
			Speed = 68
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SkullBash, MoveFactory.Scratch, MoveFactory.MudSlap, MoveFactory.Withdraw, MoveFactory.WaterGun, },
			[12] = new List<Move>() { MoveFactory.FuryCutter, },
			[16] = new List<Move>() { MoveFactory.FurySwipes, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[24] = new List<Move>() { MoveFactory.RockPolish, },
			[28] = new List<Move>() { MoveFactory.Slash, },
			[32] = new List<Move>() { MoveFactory.HoneClaws, },
			[36] = new List<Move>() { MoveFactory.RazorShell, },
			[42] = new List<Move>() { MoveFactory.ShellSmash, },
			[48] = new List<Move>() { MoveFactory.CrossChop, },
			[54] = new List<Move>() { MoveFactory.StoneEdge, },
		};
	}
}
