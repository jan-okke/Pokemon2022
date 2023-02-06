using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Fearow : Pokemon
	{
		public override string Name => "Fearow";
		public override int Generation => 1;
		public override string PokedexEntry => "Its long neck and elongated beak are ideal for catching prey in soil or water. It deftly moves this extended and skinny beak to pluck prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sniper;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 90,
			Defense = 65,
			SpecialAttack = 61,
			SpecialDefense = 61,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DrillRun, MoveFactory.Pluck, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Leer, },
			[8] = new List<Move>() { MoveFactory.Assurance, },
			[11] = new List<Move>() { MoveFactory.FuryAttack, },
			[15] = new List<Move>() { MoveFactory.AerialAce, },
			[18] = new List<Move>() { MoveFactory.WingAttack, },
			[23] = new List<Move>() { MoveFactory.TakeDown, },
			[27] = new List<Move>() { MoveFactory.Agility, },
			[32] = new List<Move>() { MoveFactory.FocusEnergy, },
			[36] = new List<Move>() { MoveFactory.Roost, },
			[41] = new List<Move>() { MoveFactory.DrillPeck, },
			[45] = new List<Move>() { MoveFactory.DrillRun, },
		};
	}
}
