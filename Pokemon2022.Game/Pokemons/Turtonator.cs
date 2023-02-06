using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Turtonator : Pokemon
	{
		public override string Name => "Turtonator";
		public override int Generation => 7;
		public override string PokedexEntry => "It lives in volcanoes and eats sulfur and other minerals. Materials from the food it eats form the basis of its explosive shell.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShellArmor, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 78,
			Defense = 135,
			SpecialAttack = 91,
			SpecialDefense = 85,
			Speed = 36
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Smog, MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.Protect, },
			[12] = new List<Move>() { MoveFactory.Endure, },
			[16] = new List<Move>() { MoveFactory.Flail, },
			[20] = new List<Move>() { MoveFactory.Incinerate, },
			[24] = new List<Move>() { MoveFactory.IronDefense, },
			[28] = new List<Move>() { MoveFactory.DragonPulse, },
			[32] = new List<Move>() { MoveFactory.BodySlam, },
			[36] = new List<Move>() { MoveFactory.Flamethrower, },
			[40] = new List<Move>() { MoveFactory.ShellTrap, },
			[44] = new List<Move>() { MoveFactory.ShellSmash, },
			[48] = new List<Move>() { MoveFactory.Overheat, },
			[52] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
