using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shroomish : Pokemon
	{
		public override string Name => "Shroomish";
		public override int Generation => 3;
		public override string PokedexEntry => "It loves to eat damp, composted soil in forests. If you enter a forest after a long rain, you can see many Shroomish feasting on composted soil.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EffectSpore, AbilityFactory.PoisonHeal, };
		public override Ability AvailableHiddenAbility => AbilityFactory.QuickFeet;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 40,
			Defense = 60,
			SpecialAttack = 40,
			SpecialDefense = 60,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.StunSpore, },
			[8] = new List<Move>() { MoveFactory.LeechSeed, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[15] = new List<Move>() { MoveFactory.Headbutt, },
			[19] = new List<Move>() { MoveFactory.PoisonPowder, },
			[22] = new List<Move>() { MoveFactory.WorrySeed, },
			[26] = new List<Move>() { MoveFactory.GigaDrain, },
			[29] = new List<Move>() { MoveFactory.Growth, },
			[33] = new List<Move>() { MoveFactory.Toxic, },
			[36] = new List<Move>() { MoveFactory.SeedBomb, },
			[40] = new List<Move>() { MoveFactory.Spore, },
		};
	}
}
