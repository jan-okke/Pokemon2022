using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Diancie : Pokemon
	{
		public override string Name => "Diancie";
		public override int Generation => 6;
		public override string PokedexEntry => "A sudden transformation of Carbink, its pink, glimmering body is said to be the loveliest sight in the whole world.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, };
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 100,
			Defense = 150,
			SpecialAttack = 100,
			SpecialDefense = 150,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[7] = new List<Move>() { MoveFactory.GuardSplit, },
			[14] = new List<Move>() { MoveFactory.SmackDown, },
			[21] = new List<Move>() { MoveFactory.Flail, },
			[28] = new List<Move>() { MoveFactory.AncientPower, },
			[35] = new List<Move>() { MoveFactory.RockPolish, },
			[42] = new List<Move>() { MoveFactory.LightScreen, },
			[49] = new List<Move>() { MoveFactory.RockSlide, },
			[56] = new List<Move>() { MoveFactory.SkillSwap, },
			[63] = new List<Move>() { MoveFactory.PowerGem, },
			[70] = new List<Move>() { MoveFactory.StealthRock, },
			[77] = new List<Move>() { MoveFactory.Moonblast, },
			[84] = new List<Move>() { MoveFactory.StoneEdge, },
			[91] = new List<Move>() { MoveFactory.DiamondStorm, },
		};
	}
}
