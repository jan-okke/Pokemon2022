using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Keldeo : Pokemon
	{
		public override string Name => "Keldeo";
		public override int Generation => 5;
		public override string PokedexEntry => "It crosses the world, running over the surfaces of oceans and rivers. It appears at scenic waterfronts.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Justified, };
		public override Stats BaseStats => new Stats() {
			HP = 91,
			Attack = 72,
			Defense = 90,
			SpecialAttack = 129,
			SpecialDefense = 90,
			Speed = 108
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SecretSword, MoveFactory.AquaJet, MoveFactory.Leer, MoveFactory.HelpingHand, MoveFactory.WorkUp, },
			[7] = new List<Move>() { MoveFactory.BubbleBeam, },
			[14] = new List<Move>() { MoveFactory.QuickGuard, },
			[21] = new List<Move>() { MoveFactory.DoubleKick, },
			[28] = new List<Move>() { MoveFactory.Retaliate, },
			[35] = new List<Move>() { MoveFactory.AquaTail, },
			[42] = new List<Move>() { MoveFactory.TakeDown, },
			[49] = new List<Move>() { MoveFactory.SacredSword, },
			[56] = new List<Move>() { MoveFactory.SwordsDance, },
			[63] = new List<Move>() { MoveFactory.HydroPump, },
			[70] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}
