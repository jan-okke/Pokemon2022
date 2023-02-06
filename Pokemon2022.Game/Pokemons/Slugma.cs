using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Slugma : Pokemon
	{
		public override string Name => "Slugma";
		public override int Generation => 2;
		public override string PokedexEntry => "It is a species of Pokémon that lives in volcanic areas. If its body cools, its skin hardens and immobilizes it. To avoid that, it sleeps near magma.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MagmaArmor, AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 40,
			Defense = 40,
			SpecialAttack = 70,
			SpecialDefense = 40,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Yawn, MoveFactory.Smog, },
			[6] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.RockThrow, },
			[13] = new List<Move>() { MoveFactory.Harden, },
			[15] = new List<Move>() { MoveFactory.Incinerate, },
			[20] = new List<Move>() { MoveFactory.ClearSmog, },
			[22] = new List<Move>() { MoveFactory.AncientPower, },
			[29] = new List<Move>() { MoveFactory.RockSlide, },
			[34] = new List<Move>() { MoveFactory.LavaPlume, },
			[36] = new List<Move>() { MoveFactory.Amnesia, },
			[41] = new List<Move>() { MoveFactory.BodySlam, },
			[43] = new List<Move>() { MoveFactory.Recover, },
			[48] = new List<Move>() { MoveFactory.Flamethrower, },
			[50] = new List<Move>() { MoveFactory.EarthPower, },
		};
	}
}
