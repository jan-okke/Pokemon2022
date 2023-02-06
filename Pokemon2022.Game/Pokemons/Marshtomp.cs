using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Marshtomp : Pokemon
	{
		public override string Name => "Marshtomp";
		public override int Generation => 3;
		public override string PokedexEntry => "Its toughened hind legs enable it to stand upright. Because it weakens if its skin dries out, it replenishes fluids by playing in mud.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 85,
			Defense = 70,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.MudShot, },
			[1] = new List<Move>() { MoveFactory.MudShot, MoveFactory.Earthquake, MoveFactory.Surf, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.WaterGun, MoveFactory.RockSmash, },
			[9] = new List<Move>() { MoveFactory.RockThrow, },
			[12] = new List<Move>() { MoveFactory.Protect, },
			[15] = new List<Move>() { MoveFactory.Supersonic, },
			[20] = new List<Move>() { MoveFactory.WaterPulse, },
			[25] = new List<Move>() { MoveFactory.RockSlide, },
			[30] = new List<Move>() { MoveFactory.TakeDown, },
			[35] = new List<Move>() { MoveFactory.Amnesia, },
			[40] = new List<Move>() { MoveFactory.MuddyWater, },
			[45] = new List<Move>() { MoveFactory.Screech, },
			[50] = new List<Move>() { MoveFactory.Endeavor, },
			[55] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
