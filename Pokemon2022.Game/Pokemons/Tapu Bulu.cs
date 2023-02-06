using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class TapuBulu : Pokemon
	{
		public override string Name => "Tapu Bulu";
		public override int Generation => 7;
		public override string PokedexEntry => "It pulls large trees up by the roots and swings them around. It causes vegetation to grow, and then it absorbs energy from the growth.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.GrassySurge, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 130,
			Defense = 115,
			SpecialAttack = 85,
			SpecialDefense = 95,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leafage, MoveFactory.RockSmash, },
			[5] = new List<Move>() { MoveFactory.Withdraw, },
			[10] = new List<Move>() { MoveFactory.Disable, },
			[15] = new List<Move>() { MoveFactory.LeechSeed, },
			[20] = new List<Move>() { MoveFactory.MegaDrain, },
			[25] = new List<Move>() { MoveFactory.Whirlwind, },
			[30] = new List<Move>() { MoveFactory.HornAttack, },
			[35] = new List<Move>() { MoveFactory.ScaryFace, },
			[40] = new List<Move>() { MoveFactory.HornLeech, },
			[45] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[50] = new List<Move>() { MoveFactory.MeanLook, },
			[55] = new List<Move>() { MoveFactory.NaturesMadness, },
			[60] = new List<Move>() { MoveFactory.WoodHammer, },
			[65] = new List<Move>() { MoveFactory.Megahorn, },
			[70] = new List<Move>() { MoveFactory.SkullBash, },
			[75] = new List<Move>() { MoveFactory.GrassyTerrain, },
		};
	}
}
