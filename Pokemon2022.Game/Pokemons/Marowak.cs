using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Marowak : Pokemon
	{
		public override string Name => "Marowak";
		public override int Generation => 1;
		public override string PokedexEntry => "A Marowak is the evolved form of a Cubone that has grown tough by overcoming the grief of losing its mother. Its tempered and hardened spirit is not easily broken.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, AbilityFactory.LightningRod, };
		public override Ability AvailableHiddenAbility => AbilityFactory.BattleArmor;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 80,
			Defense = 110,
			SpecialAttack = 50,
			SpecialDefense = 80,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.Growl, MoveFactory.TailWhip, MoveFactory.FalseSwipe, },
			[12] = new List<Move>() { MoveFactory.Headbutt, },
			[16] = new List<Move>() { MoveFactory.Retaliate, },
			[20] = new List<Move>() { MoveFactory.Fling, },
			[24] = new List<Move>() { MoveFactory.StompingTantrum, },
			[31] = new List<Move>() { MoveFactory.BoneRush, },
			[36] = new List<Move>() { MoveFactory.FocusEnergy, },
			[42] = new List<Move>() { MoveFactory.Endeavor, },
			[48] = new List<Move>() { MoveFactory.Bonemerang, },
			[54] = new List<Move>() { MoveFactory.Thrash, },
			[60] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
