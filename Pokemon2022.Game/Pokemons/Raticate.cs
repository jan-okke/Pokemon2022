using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Raticate : Pokemon
	{
		public override string Name => "Raticate";
		public override int Generation => 1;
		public override string PokedexEntry => "A Raticate's sturdy fangs grow steadily. To keep them ground down, it gnaws on rocks and logs. It may even chew on the walls of houses.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 81,
			Defense = 60,
			SpecialAttack = 50,
			SpecialDefense = 70,
			Speed = 97
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ScaryFace, },
			[1] = new List<Move>() { MoveFactory.ScaryFace, MoveFactory.SwordsDance, MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.QuickAttack, MoveFactory.FocusEnergy, },
			[4] = new List<Move>() { MoveFactory.QuickAttack, },
			[7] = new List<Move>() { MoveFactory.FocusEnergy, },
			[10] = new List<Move>() { MoveFactory.Bite, },
			[13] = new List<Move>() { MoveFactory.LaserFocus, },
			[16] = new List<Move>() { MoveFactory.TakeDown, },
			[19] = new List<Move>() { MoveFactory.Assurance, },
			[24] = new List<Move>() { MoveFactory.Crunch, },
			[29] = new List<Move>() { MoveFactory.SuckerPunch, },
			[34] = new List<Move>() { MoveFactory.SuperFang, },
			[39] = new List<Move>() { MoveFactory.DoubleEdge, },
			[44] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}
