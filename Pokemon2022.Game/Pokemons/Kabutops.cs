using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kabutops : Pokemon
	{
		public override string Name => "Kabutops";
		public override int Generation => 1;
		public override string PokedexEntry => "Kabutops once swam underwater to hunt for prey. It was apparently evolving from being a water dweller to living on land as evident from changes in its gills and legs.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.BattleArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 115,
			Defense = 105,
			SpecialAttack = 65,
			SpecialDefense = 70,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Slash, },
			[1] = new List<Move>() { MoveFactory.Slash, MoveFactory.NightSlash, MoveFactory.Feint, MoveFactory.Absorb, MoveFactory.Harden, MoveFactory.Scratch, MoveFactory.SandAttack, },
			[15] = new List<Move>() { MoveFactory.AquaJet, },
			[20] = new List<Move>() { MoveFactory.Leer, },
			[25] = new List<Move>() { MoveFactory.MudShot, },
			[30] = new List<Move>() { MoveFactory.AncientPower, },
			[35] = new List<Move>() { MoveFactory.Brine, },
			[43] = new List<Move>() { MoveFactory.Protect, },
			[49] = new List<Move>() { MoveFactory.LeechLife, },
			[56] = new List<Move>() { MoveFactory.Liquidation, },
			[63] = new List<Move>() { MoveFactory.MetalSound, },
			[70] = new List<Move>() { MoveFactory.StoneEdge, },
		};
	}
}
