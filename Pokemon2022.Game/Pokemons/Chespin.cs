using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chespin : Pokemon
	{
		public override string Name => "Chespin";
		public override int Generation => 6;
		public override string PokedexEntry => "The quills on its head are usually soft. When it flexes them, the points become so hard and sharp that they can pierce rock.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Bulletproof;
		public override Stats BaseStats => new Stats() {
			HP = 56,
			Attack = 61,
			Defense = 65,
			SpecialAttack = 48,
			SpecialDefense = 45,
			Speed = 38
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.VineWhip, },
			[5] = new List<Move>() { MoveFactory.VineWhip, },
			[8] = new List<Move>() { MoveFactory.Rollout, },
			[11] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.LeechSeed, },
			[18] = new List<Move>() { MoveFactory.PinMissile, },
			[27] = new List<Move>() { MoveFactory.TakeDown, },
			[32] = new List<Move>() { MoveFactory.SeedBomb, },
			[35] = new List<Move>() { MoveFactory.MudShot, },
			[39] = new List<Move>() { MoveFactory.BulkUp, },
			[42] = new List<Move>() { MoveFactory.BodySlam, },
			[45] = new List<Move>() { MoveFactory.PainSplit, },
			[48] = new List<Move>() { MoveFactory.WoodHammer, },
		};
	}
}
