using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Falinks : Pokemon
	{
		public override string Name => "Falinks";
		public override int Generation => 8;
		public override string PokedexEntry => "The six of them work together as one Pokémon. Teamwork is also their battle strategy, and they constantly change their formation as they fight.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BattleArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 100,
			Defense = 100,
			SpecialAttack = 70,
			SpecialDefense = 60,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Protect, },
			[5] = new List<Move>() { MoveFactory.RockSmash, },
			[10] = new List<Move>() { MoveFactory.FocusEnergy, },
			[15] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.BulkUp, },
			[25] = new List<Move>() { MoveFactory.Endure, },
			[30] = new List<Move>() { MoveFactory.Reversal, },
			[35] = new List<Move>() { MoveFactory.FirstImpression, },
			[40] = new List<Move>() { MoveFactory.NoRetreat, },
			[45] = new List<Move>() { MoveFactory.IronDefense, },
			[50] = new List<Move>() { MoveFactory.CloseCombat, },
			[55] = new List<Move>() { MoveFactory.Megahorn, },
			[60] = new List<Move>() { MoveFactory.Counter, },
		};
	}
}
