using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Darumaka : Pokemon
	{
		public override string Name => "Darumaka";
		public override int Generation => 5;
		public override string PokedexEntry => "Darumaka's droppings are hot, so people used to put them in their clothes to keep themselves warm.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hustle, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 90,
			Defense = 45,
			SpecialAttack = 15,
			SpecialDefense = 45,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Ember, MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Taunt, },
			[8] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.Incinerate, },
			[16] = new List<Move>() { MoveFactory.WorkUp, },
			[20] = new List<Move>() { MoveFactory.FireFang, },
			[24] = new List<Move>() { MoveFactory.Headbutt, },
			[28] = new List<Move>() { MoveFactory.FirePunch, },
			[32] = new List<Move>() { MoveFactory.Uproar, },
			[36] = new List<Move>() { MoveFactory.BellyDrum, },
			[40] = new List<Move>() { MoveFactory.FlareBlitz, },
			[44] = new List<Move>() { MoveFactory.Thrash, },
			[48] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}
