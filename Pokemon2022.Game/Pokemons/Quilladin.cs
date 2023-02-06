using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Quilladin : Pokemon
	{
		public override string Name => "Quilladin";
		public override int Generation => 6;
		public override string PokedexEntry => "They strengthen their lower bodies by running into one another. They are very kind and won't start fights.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Bulletproof;
		public override Stats BaseStats => new Stats() {
			HP = 61,
			Attack = 78,
			Defense = 95,
			SpecialAttack = 56,
			SpecialDefense = 58,
			Speed = 57
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.NeedleArm, },
			[1] = new List<Move>() { MoveFactory.NeedleArm, MoveFactory.Growl, MoveFactory.VineWhip, },
			[5] = new List<Move>() { MoveFactory.VineWhip, },
			[8] = new List<Move>() { MoveFactory.Rollout, },
			[11] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.LeechSeed, },
			[19] = new List<Move>() { MoveFactory.PinMissile, },
			[29] = new List<Move>() { MoveFactory.TakeDown, },
			[35] = new List<Move>() { MoveFactory.SeedBomb, },
			[39] = new List<Move>() { MoveFactory.MudShot, },
			[44] = new List<Move>() { MoveFactory.BulkUp, },
			[48] = new List<Move>() { MoveFactory.BodySlam, },
			[52] = new List<Move>() { MoveFactory.PainSplit, },
			[56] = new List<Move>() { MoveFactory.WoodHammer, },
		};
	}
}
