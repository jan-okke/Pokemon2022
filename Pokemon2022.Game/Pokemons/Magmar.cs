using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Magmar : Pokemon
	{
		public override string Name => "Magmar";
		public override int Generation => 1;
		public override string PokedexEntry => "In battle, it blows out intense flames from all over its body to intimidate its foe. These fiery bursts create heat waves that ignite grass and trees.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VitalSpirit;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 95,
			Defense = 57,
			SpecialAttack = 100,
			SpecialDefense = 85,
			Speed = 93
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Smog, MoveFactory.Leer, MoveFactory.Ember, MoveFactory.Smokescreen, },
			[12] = new List<Move>() { MoveFactory.ClearSmog, },
			[16] = new List<Move>() { MoveFactory.FlameWheel, },
			[20] = new List<Move>() { MoveFactory.ConfuseRay, },
			[24] = new List<Move>() { MoveFactory.ScaryFace, },
			[28] = new List<Move>() { MoveFactory.FirePunch, },
			[34] = new List<Move>() { MoveFactory.LavaPlume, },
			[40] = new List<Move>() { MoveFactory.LowKick, },
			[46] = new List<Move>() { MoveFactory.Flamethrower, },
			[52] = new List<Move>() { MoveFactory.SunnyDay, },
			[58] = new List<Move>() { MoveFactory.FireBlast, },
			[64] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
