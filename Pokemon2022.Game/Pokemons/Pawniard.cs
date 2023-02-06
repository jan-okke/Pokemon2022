using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pawniard : Pokemon
	{
		public override string Name => "Pawniard";
		public override int Generation => 5;
		public override string PokedexEntry => "They fight at Bisharp's command. They cling to their prey and inflict damage by sinking their blades into it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Defiant, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pressure;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 85,
			Defense = 70,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.FuryCutter, },
			[10] = new List<Move>() { MoveFactory.MetalClaw, },
			[15] = new List<Move>() { MoveFactory.Torment, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.Assurance, },
			[30] = new List<Move>() { MoveFactory.MetalSound, },
			[35] = new List<Move>() { MoveFactory.Slash, },
			[40] = new List<Move>() { MoveFactory.NightSlash, },
			[45] = new List<Move>() { MoveFactory.IronDefense, },
			[50] = new List<Move>() { MoveFactory.LaserFocus, },
			[55] = new List<Move>() { MoveFactory.IronHead, },
			[60] = new List<Move>() { MoveFactory.SwordsDance, },
			[65] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}
