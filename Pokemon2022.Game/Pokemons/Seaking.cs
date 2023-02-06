using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Seaking : Pokemon
	{
		public override string Name => "Seaking";
		public override int Generation => 1;
		public override string PokedexEntry => "It punches holes in boulders on stream- beds. This is a clever innovation that prevents its eggs from being attacked or washed away by the current.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.WaterVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightningRod;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 92,
			Defense = 65,
			SpecialAttack = 65,
			SpecialDefense = 80,
			Speed = 68
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.TailWhip, MoveFactory.Supersonic, MoveFactory.WaterPulse, },
			[15] = new List<Move>() { MoveFactory.HornAttack, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.AquaRing, },
			[30] = new List<Move>() { MoveFactory.Flail, },
			[37] = new List<Move>() { MoveFactory.Waterfall, },
			[44] = new List<Move>() { MoveFactory.Soak, },
			[51] = new List<Move>() { MoveFactory.Megahorn, },
			[58] = new List<Move>() { MoveFactory.HornDrill, },
		};
	}
}
