using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bagon : Pokemon
	{
		public override string Name => "Bagon";
		public override int Generation => 3;
		public override string PokedexEntry => "Although it is small, this Pokémon is very powerful because its body is a bundle of muscles. It launches head-butts with its ironlike skull.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 75,
			Defense = 60,
			SpecialAttack = 40,
			SpecialDefense = 30,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Ember, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.Bite, },
			[10] = new List<Move>() { MoveFactory.DragonBreath, },
			[15] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.Crunch, },
			[31] = new List<Move>() { MoveFactory.DragonClaw, },
			[35] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[40] = new List<Move>() { MoveFactory.FocusEnergy, },
			[45] = new List<Move>() { MoveFactory.Flamethrower, },
			[50] = new List<Move>() { MoveFactory.Outrage, },
			[55] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
