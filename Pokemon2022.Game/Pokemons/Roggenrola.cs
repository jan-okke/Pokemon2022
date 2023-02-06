using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Roggenrola : Pokemon
	{
		public override string Name => "Roggenrola";
		public override int Generation => 5;
		public override string PokedexEntry => "They were discovered a hundred years ago in an earthquake fissure. Inside each one is an energy core.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.WeakArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 75,
			Defense = 85,
			SpecialAttack = 25,
			SpecialDefense = 25,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SandAttack, MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Harden, },
			[8] = new List<Move>() { MoveFactory.StealthRock, },
			[12] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.SmackDown, },
			[20] = new List<Move>() { MoveFactory.IronDefense, },
			[24] = new List<Move>() { MoveFactory.Headbutt, },
			[28] = new List<Move>() { MoveFactory.RockSlide, },
			[32] = new List<Move>() { MoveFactory.RockBlast, },
			[36] = new List<Move>() { MoveFactory.Sandstorm, },
			[40] = new List<Move>() { MoveFactory.StoneEdge, },
			[44] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
