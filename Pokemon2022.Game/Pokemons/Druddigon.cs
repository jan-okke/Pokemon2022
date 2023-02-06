using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Druddigon : Pokemon
	{
		public override string Name => "Druddigon";
		public override int Generation => 5;
		public override string PokedexEntry => "It races through narrow caves, using its sharp claws to catch prey. Then skin on its face is harder than a rock.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RoughSkin, AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MoldBreaker;
		public override Stats BaseStats => new Stats() {
			HP = 77,
			Attack = 120,
			Defense = 90,
			SpecialAttack = 60,
			SpecialDefense = 90,
			Speed = 48
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.Bite, },
			[10] = new List<Move>() { MoveFactory.DragonTail, },
			[15] = new List<Move>() { MoveFactory.MetalClaw, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.DragonClaw, },
			[35] = new List<Move>() { MoveFactory.HoneClaws, },
			[40] = new List<Move>() { MoveFactory.Crunch, },
			[45] = new List<Move>() { MoveFactory.IronHead, },
			[50] = new List<Move>() { MoveFactory.Outrage, },
			[55] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}
