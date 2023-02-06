using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Feraligatr : Pokemon
	{
		public override string Name => "Feraligatr";
		public override int Generation => 2;
		public override string PokedexEntry => "It opens its huge mouth to intimidate enemies. In battle, it runs using its thick and powerful hind legs to charge the foe with incredible speed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 105,
			Defense = 100,
			SpecialAttack = 79,
			SpecialDefense = 83,
			Speed = 78
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Agility, MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.WaterGun, MoveFactory.MudSlap, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[8] = new List<Move>() { MoveFactory.MudSlap, },
			[13] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.ScaryFace, },
			[21] = new List<Move>() { MoveFactory.IceFang, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[32] = new List<Move>() { MoveFactory.Crunch, },
			[37] = new List<Move>() { MoveFactory.LowKick, },
			[45] = new List<Move>() { MoveFactory.Slash, },
			[50] = new List<Move>() { MoveFactory.Screech, },
			[58] = new List<Move>() { MoveFactory.Thrash, },
			[63] = new List<Move>() { MoveFactory.AquaTail, },
			[71] = new List<Move>() { MoveFactory.Superpower, },
			[76] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
