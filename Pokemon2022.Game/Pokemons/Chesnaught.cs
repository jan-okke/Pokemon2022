using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chesnaught : Pokemon
	{
		public override string Name => "Chesnaught";
		public override int Generation => 6;
		public override string PokedexEntry => "Its Tackle is forceful enough to flip a 50-ton tank. It shields its allies from danger with its own body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Bulletproof;
		public override Stats BaseStats => new Stats() {
			HP = 88,
			Attack = 107,
			Defense = 122,
			SpecialAttack = 74,
			SpecialDefense = 75,
			Speed = 64
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SpikyShield, },
			[1] = new List<Move>() { MoveFactory.SpikyShield, MoveFactory.NeedleArm, MoveFactory.HammerArm, MoveFactory.Feint, MoveFactory.BellyDrum, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.VineWhip, MoveFactory.Rollout, },
			[5] = new List<Move>() { MoveFactory.VineWhip, },
			[8] = new List<Move>() { MoveFactory.Rollout, },
			[11] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.LeechSeed, },
			[19] = new List<Move>() { MoveFactory.PinMissile, },
			[29] = new List<Move>() { MoveFactory.TakeDown, },
			[35] = new List<Move>() { MoveFactory.SeedBomb, },
			[41] = new List<Move>() { MoveFactory.MudShot, },
			[48] = new List<Move>() { MoveFactory.BulkUp, },
			[54] = new List<Move>() { MoveFactory.BodySlam, },
			[60] = new List<Move>() { MoveFactory.PainSplit, },
			[66] = new List<Move>() { MoveFactory.WoodHammer, },
			[72] = new List<Move>() { MoveFactory.HammerArm, },
			[78] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
