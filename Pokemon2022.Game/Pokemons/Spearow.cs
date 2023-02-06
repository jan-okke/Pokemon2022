using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spearow : Pokemon
	{
		public override string Name => "Spearow";
		public override int Generation => 1;
		public override string PokedexEntry => "Its loud cry can be heard over half a mile away. If its high, keening cry is heard echoing all around, it is a sign that they are warning each other of danger.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sniper;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 60,
			Defense = 30,
			SpecialAttack = 31,
			SpecialDefense = 31,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.Leer, },
			[8] = new List<Move>() { MoveFactory.Assurance, },
			[11] = new List<Move>() { MoveFactory.FuryAttack, },
			[15] = new List<Move>() { MoveFactory.AerialAce, },
			[18] = new List<Move>() { MoveFactory.WingAttack, },
			[22] = new List<Move>() { MoveFactory.TakeDown, },
			[25] = new List<Move>() { MoveFactory.Agility, },
			[29] = new List<Move>() { MoveFactory.FocusEnergy, },
			[32] = new List<Move>() { MoveFactory.Roost, },
			[36] = new List<Move>() { MoveFactory.DrillPeck, },
		};
	}
}
