using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sirfetchd : Pokemon
	{
		public override string Name => "Sirfetch'd";
		public override int Generation => 8;
		public override string PokedexEntry => "After deflecting attacks with its hard leaf shield, it strikes back with its sharp leek stalk. The leek stalk is both weapon and food.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Steadfast, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 62,
			Attack = 135,
			Defense = 95,
			SpecialAttack = 68,
			SpecialDefense = 82,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IronDefense, },
			[1] = new List<Move>() { MoveFactory.IronDefense, MoveFactory.FirstImpression, MoveFactory.Peck, MoveFactory.SandAttack, MoveFactory.Leer, MoveFactory.FuryCutter, },
			[15] = new List<Move>() { MoveFactory.RockSmash, },
			[20] = new List<Move>() { MoveFactory.BrutalSwing, },
			[25] = new List<Move>() { MoveFactory.Detect, },
			[30] = new List<Move>() { MoveFactory.KnockOff, },
			[35] = new List<Move>() { MoveFactory.Defog, },
			[40] = new List<Move>() { MoveFactory.BrickBreak, },
			[45] = new List<Move>() { MoveFactory.SwordsDance, },
			[50] = new List<Move>() { MoveFactory.Slam, },
			[55] = new List<Move>() { MoveFactory.LeafBlade, },
			[60] = new List<Move>() { MoveFactory.FinalGambit, },
			[65] = new List<Move>() { MoveFactory.BraveBird, },
			[70] = new List<Move>() { MoveFactory.MeteorAssault, },
		};
	}
}
