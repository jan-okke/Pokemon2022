using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cubone : Pokemon
	{
		public override string Name => "Cubone";
		public override int Generation => 1;
		public override string PokedexEntry => "It pines for the mother it will never see again. Seeing a likeness of its mother in the full moon, it cries. The stains on the skull it wears are from its tears.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, AbilityFactory.LightningRod, };
		public override Ability AvailableHiddenAbility => AbilityFactory.BattleArmor;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 50,
			Defense = 95,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.TailWhip, },
			[8] = new List<Move>() { MoveFactory.FalseSwipe, },
			[12] = new List<Move>() { MoveFactory.Headbutt, },
			[16] = new List<Move>() { MoveFactory.Retaliate, },
			[20] = new List<Move>() { MoveFactory.Fling, },
			[24] = new List<Move>() { MoveFactory.StompingTantrum, },
			[29] = new List<Move>() { MoveFactory.BoneRush, },
			[32] = new List<Move>() { MoveFactory.FocusEnergy, },
			[36] = new List<Move>() { MoveFactory.Endeavor, },
			[40] = new List<Move>() { MoveFactory.Bonemerang, },
			[44] = new List<Move>() { MoveFactory.Thrash, },
			[48] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
