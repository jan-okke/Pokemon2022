using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Greedent : Pokemon
	{
		public override string Name => "Greedent";
		public override int Generation => 8;
		public override string PokedexEntry => "It stashes berries in its tail - so many berries that they fall out constantly. But this Pokémon is a bit slow-witted, so it doesn't notice the loss.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CheekPouch, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 120,
			Attack = 95,
			Defense = 95,
			SpecialAttack = 55,
			SpecialDefense = 75,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Covet, },
			[1] = new List<Move>() { MoveFactory.Covet, MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.Bite, MoveFactory.StuffCheeks, },
			[15] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[20] = new List<Move>() { MoveFactory.BodySlam, },
			[27] = new List<Move>() { MoveFactory.Rest, },
			[34] = new List<Move>() { MoveFactory.Counter, },
			[41] = new List<Move>() { MoveFactory.BulletSeed, },
			[48] = new List<Move>() { MoveFactory.SuperFang, },
			[55] = new List<Move>() { MoveFactory.Belch, },
		};
	}
}
