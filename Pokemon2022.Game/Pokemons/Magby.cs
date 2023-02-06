using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Magby : Pokemon
	{
		public override string Name => "Magby";
		public override int Generation => 2;
		public override string PokedexEntry => "If a Magby is spouting yellow flames from its mouth, it is in good health. When it is fatigued, black smoke will be mixed in with the flames.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VitalSpirit;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 75,
			Defense = 37,
			SpecialAttack = 70,
			SpecialDefense = 55,
			Speed = 83
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Smog, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.Smokescreen, },
			[12] = new List<Move>() { MoveFactory.ClearSmog, },
			[16] = new List<Move>() { MoveFactory.FlameWheel, },
			[20] = new List<Move>() { MoveFactory.ConfuseRay, },
			[24] = new List<Move>() { MoveFactory.ScaryFace, },
			[28] = new List<Move>() { MoveFactory.FirePunch, },
			[32] = new List<Move>() { MoveFactory.LavaPlume, },
			[36] = new List<Move>() { MoveFactory.LowKick, },
			[40] = new List<Move>() { MoveFactory.Flamethrower, },
			[44] = new List<Move>() { MoveFactory.SunnyDay, },
			[48] = new List<Move>() { MoveFactory.FireBlast, },
		};
	}
}
