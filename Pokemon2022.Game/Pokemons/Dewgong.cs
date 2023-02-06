using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dewgong : Pokemon
	{
		public override string Name => "Dewgong";
		public override int Generation => 1;
		public override string PokedexEntry => "It loves to snooze on bitterly cold ice. The sight of this Pokémon sleeping on a glacier was mistakenly thought to be a mermaid by a mariner long ago.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IceBody;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 70,
			Defense = 80,
			SpecialAttack = 70,
			SpecialDefense = 95,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SheerCold, },
			[1] = new List<Move>() { MoveFactory.SheerCold, MoveFactory.Headbutt, MoveFactory.Growl, MoveFactory.BubbleBeam, MoveFactory.IcyWind, },
			[3] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.BubbleBeam, },
			[11] = new List<Move>() { MoveFactory.IcyWind, },
			[13] = new List<Move>() { MoveFactory.Encore, },
			[17] = new List<Move>() { MoveFactory.IceShard, },
			[21] = new List<Move>() { MoveFactory.Rest, },
			[23] = new List<Move>() { MoveFactory.AquaRing, },
			[27] = new List<Move>() { MoveFactory.AuroraBeam, },
			[31] = new List<Move>() { MoveFactory.AquaJet, },
			[33] = new List<Move>() { MoveFactory.Brine, },
			[39] = new List<Move>() { MoveFactory.TakeDown, },
			[45] = new List<Move>() { MoveFactory.Dive, },
			[49] = new List<Move>() { MoveFactory.AquaTail, },
			[55] = new List<Move>() { MoveFactory.IceBeam, },
			[61] = new List<Move>() { MoveFactory.Safeguard, },
			[65] = new List<Move>() { MoveFactory.Hail, },
		};
	}
}
