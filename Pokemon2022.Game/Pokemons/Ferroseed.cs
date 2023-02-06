using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ferroseed : Pokemon
	{
		public override string Name => "Ferroseed";
		public override int Generation => 5;
		public override string PokedexEntry => "They stick their spikes into cave walls and absorb the minerals they find in the rock.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IronBarbs, };
		public override Stats BaseStats => new Stats() {
			HP = 44,
			Attack = 50,
			Defense = 91,
			SpecialAttack = 24,
			SpecialDefense = 86,
			Speed = 10
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.MetalClaw, },
			[10] = new List<Move>() { MoveFactory.PinMissile, },
			[15] = new List<Move>() { MoveFactory.Ingrain, },
			[20] = new List<Move>() { MoveFactory.FlashCannon, },
			[25] = new List<Move>() { MoveFactory.IronHead, },
			[30] = new List<Move>() { MoveFactory.SelfDestruct, },
			[35] = new List<Move>() { MoveFactory.IronDefense, },
			[41] = new List<Move>() { MoveFactory.Curse, },
			[45] = new List<Move>() { MoveFactory.GyroBall, },
			[50] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
