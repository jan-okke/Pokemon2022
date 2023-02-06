using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Axew : Pokemon
	{
		public override string Name => "Axew";
		public override int Generation => 5;
		public override string PokedexEntry => "They mark their territory by leaving gashes in trees with their tusks. If a tusk breaks, a new one grows in quickly.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rivalry, AbilityFactory.MoldBreaker, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 46,
			Attack = 87,
			Defense = 60,
			SpecialAttack = 30,
			SpecialDefense = 40,
			Speed = 57
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[3] = new List<Move>() { MoveFactory.Bite, },
			[6] = new List<Move>() { MoveFactory.FalseSwipe, },
			[9] = new List<Move>() { MoveFactory.Assurance, },
			[12] = new List<Move>() { MoveFactory.Taunt, },
			[15] = new List<Move>() { MoveFactory.Slash, },
			[18] = new List<Move>() { MoveFactory.DragonClaw, },
			[21] = new List<Move>() { MoveFactory.ScaryFace, },
			[24] = new List<Move>() { MoveFactory.Crunch, },
			[27] = new List<Move>() { MoveFactory.DragonDance, },
			[30] = new List<Move>() { MoveFactory.DualChop, },
			[33] = new List<Move>() { MoveFactory.LaserFocus, },
			[36] = new List<Move>() { MoveFactory.DragonPulse, },
			[39] = new List<Move>() { MoveFactory.SwordsDance, },
			[42] = new List<Move>() { MoveFactory.Outrage, },
			[45] = new List<Move>() { MoveFactory.Guillotine, },
			[48] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
