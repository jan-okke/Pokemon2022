using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Xerneas : Pokemon
	{
		public override string Name => "Xerneas";
		public override int Generation => 6;
		public override string PokedexEntry => "Legends say it can share eternal life. It slept for a thousand years in the form of a tree before its revival.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FairyAura, };
		public override Stats BaseStats => new Stats() {
			HP = 126,
			Attack = 131,
			Defense = 95,
			SpecialAttack = 131,
			SpecialDefense = 98,
			Speed = 99
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Gravity, },
			[5] = new List<Move>() { MoveFactory.LightScreen, },
			[10] = new List<Move>() { MoveFactory.AuroraBeam, },
			[15] = new List<Move>() { MoveFactory.NaturePower, },
			[20] = new List<Move>() { MoveFactory.NightSlash, },
			[25] = new List<Move>() { MoveFactory.Aromatherapy, },
			[30] = new List<Move>() { MoveFactory.PsychUp, },
			[35] = new List<Move>() { MoveFactory.HornLeech, },
			[40] = new List<Move>() { MoveFactory.MistyTerrain, },
			[45] = new List<Move>() { MoveFactory.Ingrain, },
			[50] = new List<Move>() { MoveFactory.TakeDown, },
			[55] = new List<Move>() { MoveFactory.Geomancy, },
			[60] = new List<Move>() { MoveFactory.Moonblast, },
			[65] = new List<Move>() { MoveFactory.HealPulse, },
			[70] = new List<Move>() { MoveFactory.Megahorn, },
			[75] = new List<Move>() { MoveFactory.CloseCombat, },
			[80] = new List<Move>() { MoveFactory.Outrage, },
			[85] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
