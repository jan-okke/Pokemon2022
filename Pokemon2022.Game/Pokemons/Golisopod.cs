using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Golisopod : Pokemon
	{
		public override string Name => "Golisopod";
		public override int Generation => 7;
		public override string PokedexEntry => "It battles skillfully with its six arms, but spends most of its time peacefully meditating in caves deep beneath the sea.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EmergencyExit, };
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 125,
			Defense = 140,
			SpecialAttack = 60,
			SpecialDefense = 90,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FirstImpression, },
			[1] = new List<Move>() { MoveFactory.FirstImpression, MoveFactory.StruggleBug, MoveFactory.SandAttack, MoveFactory.DefenseCurl, MoveFactory.Spite, },
			[4] = new List<Move>() { MoveFactory.RockSmash, },
			[8] = new List<Move>() { MoveFactory.FuryCutter, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[16] = new List<Move>() { MoveFactory.BugBite, },
			[20] = new List<Move>() { MoveFactory.IronDefense, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.Slash, },
			[32] = new List<Move>() { MoveFactory.RazorShell, },
			[36] = new List<Move>() { MoveFactory.PinMissile, },
			[40] = new List<Move>() { MoveFactory.SwordsDance, },
			[44] = new List<Move>() { MoveFactory.Liquidation, },
		};
	}
}
