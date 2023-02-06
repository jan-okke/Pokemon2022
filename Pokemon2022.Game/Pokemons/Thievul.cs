using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Thievul : Pokemon
	{
		public override string Name => "Thievul";
		public override int Generation => 8;
		public override string PokedexEntry => "It secretly marks potential targets with a scent. By following the scent, it stalks its targets and steals from them when they least expect it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.Unburden, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Stakeout;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 58,
			Defense = 58,
			SpecialAttack = 87,
			SpecialDefense = 92,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Thief, },
			[1] = new List<Move>() { MoveFactory.Thief, MoveFactory.QuickAttack, MoveFactory.TailWhip, MoveFactory.BeatUp, MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.Snarl, },
			[16] = new List<Move>() { MoveFactory.Assurance, },
			[22] = new List<Move>() { MoveFactory.NastyPlot, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[34] = new List<Move>() { MoveFactory.NightSlash, },
			[40] = new List<Move>() { MoveFactory.TailSlap, },
			[46] = new List<Move>() { MoveFactory.FoulPlay, },
			[52] = new List<Move>() { MoveFactory.PartingShot, },
		};
	}
}
