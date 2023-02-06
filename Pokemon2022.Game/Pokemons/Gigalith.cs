using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gigalith : Pokemon
	{
		public override string Name => "Gigalith";
		public override int Generation => 5;
		public override string PokedexEntry => "The solar energy absorbed by its body's orange crystals is magnified internally and fired from its mouth.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.SandStream, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 135,
			Defense = 130,
			SpecialAttack = 60,
			SpecialDefense = 80,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowerGem, MoveFactory.SandAttack, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.StealthRock, },
			[12] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.SmackDown, },
			[20] = new List<Move>() { MoveFactory.IronDefense, },
			[24] = new List<Move>() { MoveFactory.Headbutt, },
			[30] = new List<Move>() { MoveFactory.RockSlide, },
			[36] = new List<Move>() { MoveFactory.RockBlast, },
			[42] = new List<Move>() { MoveFactory.Sandstorm, },
			[48] = new List<Move>() { MoveFactory.StoneEdge, },
			[54] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
