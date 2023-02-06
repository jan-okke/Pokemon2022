using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Fletchinder : Pokemon
	{
		public override string Name => "Fletchinder";
		public override int Generation => 6;
		public override string PokedexEntry => "From its beak, it expels embers that set the tall grass on fire. Then it pounces on the bewildered prey that pop out of the grass.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.GaleWings;
		public override Stats BaseStats => new Stats() {
			HP = 62,
			Attack = 73,
			Defense = 55,
			SpecialAttack = 56,
			SpecialDefense = 52,
			Speed = 84
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FlameCharge, },
			[1] = new List<Move>() { MoveFactory.FlameCharge, MoveFactory.Feint, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.QuickAttack, MoveFactory.Ember, },
			[15] = new List<Move>() { MoveFactory.Flail, },
			[22] = new List<Move>() { MoveFactory.Acrobatics, },
			[29] = new List<Move>() { MoveFactory.Agility, },
			[36] = new List<Move>() { MoveFactory.AerialAce, },
			[43] = new List<Move>() { MoveFactory.Tailwind, },
			[50] = new List<Move>() { MoveFactory.SteelWing, },
			[57] = new List<Move>() { MoveFactory.Roost, },
			[64] = new List<Move>() { MoveFactory.Fly, },
		};
	}
}
