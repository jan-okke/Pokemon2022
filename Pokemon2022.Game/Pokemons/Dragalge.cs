using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dragalge : Pokemon
	{
		public override string Name => "Dragalge";
		public override int Generation => 6;
		public override string PokedexEntry => "Their poison is strong enough to eat through the hull of a tanker, and they spit it indiscriminately at anything that enters their territory.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.PoisonTouch, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Adaptability;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 75,
			Defense = 90,
			SpecialAttack = 97,
			SpecialDefense = 123,
			Speed = 44
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Smokescreen, MoveFactory.Acid, MoveFactory.WaterGun, },
			[15] = new List<Move>() { MoveFactory.TailWhip, },
			[20] = new List<Move>() { MoveFactory.DoubleTeam, },
			[25] = new List<Move>() { MoveFactory.PoisonTail, },
			[30] = new List<Move>() { MoveFactory.WaterPulse, },
			[35] = new List<Move>() { MoveFactory.Toxic, },
			[40] = new List<Move>() { MoveFactory.DragonPulse, },
			[45] = new List<Move>() { MoveFactory.AquaTail, },
			[52] = new List<Move>() { MoveFactory.SludgeBomb, },
			[59] = new List<Move>() { MoveFactory.HydroPump, },
			[66] = new List<Move>() { MoveFactory.Outrage, },
		};
	}
}
