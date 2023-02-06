using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Marshadow : Pokemon
	{
		public override string Name => "Marshadow";
		public override int Generation => 7;
		public override string PokedexEntry => "Able to conceal itself in shadows, it never appears before humans, so its very existence was the stuff of myth.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Technician, };
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 125,
			Defense = 80,
			SpecialAttack = 90,
			SpecialDefense = 90,
			Speed = 125
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderPunch, MoveFactory.FirePunch, MoveFactory.IcePunch, MoveFactory.Copycat, MoveFactory.ShadowSneak, MoveFactory.Feint, MoveFactory.Counter, },
			[9] = new List<Move>() { MoveFactory.RolePlay, },
			[18] = new List<Move>() { MoveFactory.ShadowPunch, },
			[27] = new List<Move>() { MoveFactory.ForcePalm, },
			[36] = new List<Move>() { MoveFactory.Assurance, },
			[45] = new List<Move>() { MoveFactory.SuckerPunch, },
			[54] = new List<Move>() { MoveFactory.DrainPunch, },
			[63] = new List<Move>() { MoveFactory.PsychUp, },
			[72] = new List<Move>() { MoveFactory.SpectralThief, },
			[81] = new List<Move>() { MoveFactory.LaserFocus, },
			[90] = new List<Move>() { MoveFactory.Endeavor, },
			[99] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}
