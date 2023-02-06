using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Genesect : Pokemon
	{
		public override string Name => "Genesect";
		public override int Generation => 5;
		public override string PokedexEntry => "This ancient bug Pokémon was altered by Team Plasma. They upgraded the cannon on its back.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Download, };
		public override Stats BaseStats => new Stats() {
			HP = 71,
			Attack = 120,
			Defense = 95,
			SpecialAttack = 120,
			SpecialDefense = 95,
			Speed = 99
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.QuickAttack, },
			[7] = new List<Move>() { MoveFactory.Screech, },
			[14] = new List<Move>() { MoveFactory.MetalClaw, },
			[21] = new List<Move>() { MoveFactory.FellStinger, },
			[28] = new List<Move>() { MoveFactory.FlameCharge, },
			[35] = new List<Move>() { MoveFactory.MetalSound, },
			[42] = new List<Move>() { MoveFactory.XScissor, },
			[49] = new List<Move>() { MoveFactory.MagnetRise, },
			[56] = new List<Move>() { MoveFactory.BugBuzz, },
			[63] = new List<Move>() { MoveFactory.SimpleBeam, },
			[70] = new List<Move>() { MoveFactory.ZapCannon, },
			[77] = new List<Move>() { MoveFactory.LockOn, },
			[84] = new List<Move>() { MoveFactory.TechnoBlast, },
			[91] = new List<Move>() { MoveFactory.SelfDestruct, },
		};
	}
}
