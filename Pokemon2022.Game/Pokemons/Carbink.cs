using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Carbink : Pokemon
	{
		public override string Name => "Carbink";
		public override int Generation => 6;
		public override string PokedexEntry => "Born from the high temperatures and pressures deep underground, it defends itself by firing beams from the jewel part of its body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sturdy;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 50,
			Defense = 150,
			SpecialAttack = 50,
			SpecialDefense = 150,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.GuardSplit, },
			[10] = new List<Move>() { MoveFactory.SmackDown, },
			[15] = new List<Move>() { MoveFactory.Flail, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[25] = new List<Move>() { MoveFactory.RockPolish, },
			[30] = new List<Move>() { MoveFactory.LightScreen, },
			[35] = new List<Move>() { MoveFactory.RockSlide, },
			[40] = new List<Move>() { MoveFactory.SkillSwap, },
			[45] = new List<Move>() { MoveFactory.PowerGem, },
			[50] = new List<Move>() { MoveFactory.StealthRock, },
			[55] = new List<Move>() { MoveFactory.Moonblast, },
			[60] = new List<Move>() { MoveFactory.StoneEdge, },
		};
	}
}
