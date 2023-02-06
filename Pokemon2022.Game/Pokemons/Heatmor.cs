using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Heatmor : Pokemon
	{
		public override string Name => "Heatmor";
		public override int Generation => 5;
		public override string PokedexEntry => "Using their very hot, flame-covered tongues, they burn through Durant's steel bodies and consume their insides.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Gluttony, AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WhiteSmoke;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 97,
			Defense = 66,
			SpecialAttack = 105,
			SpecialDefense = 66,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Lick, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.FurySwipes, },
			[10] = new List<Move>() { MoveFactory.Incinerate, },
			[15] = new List<Move>() { MoveFactory.BugBite, },
			[20] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[25] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.Bind, },
			[35] = new List<Move>() { MoveFactory.FireLash, },
			[40] = new List<Move>() { MoveFactory.HoneClaws, },
			[45] = new List<Move>() { MoveFactory.Amnesia, },
			[50] = new List<Move>() { MoveFactory.FireSpin, },
			[55] = new List<Move>() { MoveFactory.Inferno, },
			[60] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
