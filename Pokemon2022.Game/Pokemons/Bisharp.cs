using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bisharp : Pokemon
	{
		public override string Name => "Bisharp";
		public override int Generation => 5;
		public override string PokedexEntry => "Bisharp pursues prey in the company of a large group of Pawniard. Then Bisharp finishes off the prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Defiant, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pressure;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 125,
			Defense = 100,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MetalBurst, MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.FuryCutter, MoveFactory.MetalClaw, },
			[15] = new List<Move>() { MoveFactory.Torment, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.Assurance, },
			[30] = new List<Move>() { MoveFactory.MetalSound, },
			[35] = new List<Move>() { MoveFactory.Slash, },
			[40] = new List<Move>() { MoveFactory.NightSlash, },
			[45] = new List<Move>() { MoveFactory.IronDefense, },
			[50] = new List<Move>() { MoveFactory.LaserFocus, },
			[57] = new List<Move>() { MoveFactory.IronHead, },
			[64] = new List<Move>() { MoveFactory.SwordsDance, },
			[71] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}
