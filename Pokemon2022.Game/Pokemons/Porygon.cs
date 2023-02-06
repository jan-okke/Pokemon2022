using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Porygon : Pokemon
	{
		public override string Name => "Porygon";
		public override int Generation => 1;
		public override string PokedexEntry => "It is capable of reverting itself entirely back to program data in order to enter cyberspace. A Porygon is copy-protected so it cannot be duplicated.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Trace, AbilityFactory.Download, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 60,
			Defense = 70,
			SpecialAttack = 85,
			SpecialDefense = 75,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Conversion, },
			[5] = new List<Move>() { MoveFactory.Recycle, },
			[10] = new List<Move>() { MoveFactory.MagnetRise, },
			[15] = new List<Move>() { MoveFactory.ThunderShock, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.Conversion2, },
			[30] = new List<Move>() { MoveFactory.Agility, },
			[35] = new List<Move>() { MoveFactory.Recover, },
			[40] = new List<Move>() { MoveFactory.Discharge, },
			[45] = new List<Move>() { MoveFactory.TriAttack, },
			[50] = new List<Move>() { MoveFactory.MagicCoat, },
			[55] = new List<Move>() { MoveFactory.LockOn, },
			[60] = new List<Move>() { MoveFactory.ZapCannon, },
		};
	}
}
