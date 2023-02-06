using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Skrelp : Pokemon
	{
		public override string Name => "Skrelp";
		public override int Generation => 6;
		public override string PokedexEntry => "Camouflaged as rotten kelp, they spray liquid poison on prey that approaches unawares and then finish it off.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.PoisonTouch, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Adaptability;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 60,
			Defense = 60,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Smokescreen, },
			[5] = new List<Move>() { MoveFactory.Acid, },
			[10] = new List<Move>() { MoveFactory.WaterGun, },
			[15] = new List<Move>() { MoveFactory.TailWhip, },
			[20] = new List<Move>() { MoveFactory.DoubleTeam, },
			[25] = new List<Move>() { MoveFactory.PoisonTail, },
			[30] = new List<Move>() { MoveFactory.WaterPulse, },
			[35] = new List<Move>() { MoveFactory.Toxic, },
			[40] = new List<Move>() { MoveFactory.DragonPulse, },
			[45] = new List<Move>() { MoveFactory.AquaTail, },
			[50] = new List<Move>() { MoveFactory.SludgeBomb, },
			[55] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
