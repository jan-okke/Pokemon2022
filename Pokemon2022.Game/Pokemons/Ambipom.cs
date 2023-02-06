using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ambipom : Pokemon
	{
		public override string Name => "Ambipom";
		public override int Generation => 4;
		public override string PokedexEntry => "To eat, it deftly shucks nuts with its two tails. It rarely uses its arms now.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Technician, AbilityFactory.Pickup, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SkillLink;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 100,
			Defense = 66,
			SpecialAttack = 60,
			SpecialDefense = 66,
			Speed = 115
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DualChop, MoveFactory.Scratch, MoveFactory.TailWhip, MoveFactory.SandAttack, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[8] = new List<Move>() { MoveFactory.Astonish, },
			[11] = new List<Move>() { MoveFactory.BatonPass, },
			[15] = new List<Move>() { MoveFactory.Tickle, },
			[18] = new List<Move>() { MoveFactory.FurySwipes, },
			[22] = new List<Move>() { MoveFactory.Swift, },
			[25] = new List<Move>() { MoveFactory.Screech, },
			[29] = new List<Move>() { MoveFactory.Agility, },
			[32] = new List<Move>() { MoveFactory.DoubleHit, },
			[36] = new List<Move>() { MoveFactory.Fling, },
			[39] = new List<Move>() { MoveFactory.NastyPlot, },
			[43] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}
