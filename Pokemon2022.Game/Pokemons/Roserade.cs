using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Roserade : Pokemon
	{
		public override string Name => "Roserade";
		public override int Generation => 4;
		public override string PokedexEntry => "It attracts prey with a sweet aroma, then downs it with thorny whips hidden in its arms.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, AbilityFactory.PoisonPoint, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Technician;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 70,
			Defense = 65,
			SpecialAttack = 125,
			SpecialDefense = 105,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.GrassyTerrain, MoveFactory.PoisonSting, MoveFactory.VenomDrench, MoveFactory.MegaDrain, MoveFactory.LeechSeed, MoveFactory.MagicalLeaf, MoveFactory.ToxicSpikes, MoveFactory.SweetScent, MoveFactory.GigaDrain, MoveFactory.Synthesis, MoveFactory.Toxic, MoveFactory.PetalBlizzard, MoveFactory.Aromatherapy, MoveFactory.Ingrain, MoveFactory.PetalDance, MoveFactory.Absorb, MoveFactory.Growth, MoveFactory.StunSpore, MoveFactory.WorrySeed, },
		};
	}
}
