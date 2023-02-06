using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hippowdon : Pokemon
	{
		public override string Name => "Hippowdon";
		public override int Generation => 4;
		public override string PokedexEntry => "It blasts internally stored sand from ports on its body to create a towering twister for attack.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandStream, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 108,
			Attack = 112,
			Defense = 118,
			SpecialAttack = 68,
			SpecialDefense = 72,
			Speed = 47
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.ThunderFang, MoveFactory.Tackle, MoveFactory.SandAttack, MoveFactory.Bite, MoveFactory.Yawn, },
			[12] = new List<Move>() { MoveFactory.SandTomb, },
			[16] = new List<Move>() { MoveFactory.Dig, },
			[20] = new List<Move>() { MoveFactory.Crunch, },
			[24] = new List<Move>() { MoveFactory.Sandstorm, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[32] = new List<Move>() { MoveFactory.Roar, },
			[38] = new List<Move>() { MoveFactory.Rest, },
			[44] = new List<Move>() { MoveFactory.Earthquake, },
			[50] = new List<Move>() { MoveFactory.DoubleEdge, },
			[56] = new List<Move>() { MoveFactory.Fissure, },
			[62] = new List<Move>() { MoveFactory.SlackOff, },
		};
	}
}
