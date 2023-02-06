using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Silicobra : Pokemon
	{
		public override string Name => "Silicobra";
		public override int Generation => 8;
		public override string PokedexEntry => "It spews sand from its nostrils. While the enemy is blinded, it burrows into the ground to hide.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandSpit, AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 52,
			Attack = 57,
			Defense = 75,
			SpecialAttack = 35,
			SpecialDefense = 50,
			Speed = 46
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.SandAttack, },
			[5] = new List<Move>() { MoveFactory.Minimize, },
			[10] = new List<Move>() { MoveFactory.BrutalSwing, },
			[15] = new List<Move>() { MoveFactory.Bulldoze, },
			[20] = new List<Move>() { MoveFactory.Headbutt, },
			[25] = new List<Move>() { MoveFactory.Glare, },
			[30] = new List<Move>() { MoveFactory.Dig, },
			[35] = new List<Move>() { MoveFactory.Sandstorm, },
			[40] = new List<Move>() { MoveFactory.Slam, },
			[45] = new List<Move>() { MoveFactory.Coil, },
			[50] = new List<Move>() { MoveFactory.SandTomb, },
		};
	}
}
