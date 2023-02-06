using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Fennekin : Pokemon
	{
		public override string Name => "Fennekin";
		public override int Generation => 6;
		public override string PokedexEntry => "As it walks, it munches on a twig in place of a snack. It intimidates opponents by puffing hot air out of its ears.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Magician;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 40,
			SpecialAttack = 62,
			SpecialDefense = 60,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.Ember, },
			[11] = new List<Move>() { MoveFactory.Howl, },
			[14] = new List<Move>() { MoveFactory.FlameCharge, },
			[17] = new List<Move>() { MoveFactory.Psybeam, },
			[20] = new List<Move>() { MoveFactory.FireSpin, },
			[25] = new List<Move>() { MoveFactory.LuckyChant, },
			[27] = new List<Move>() { MoveFactory.LightScreen, },
			[31] = new List<Move>() { MoveFactory.Psyshock, },
			[35] = new List<Move>() { MoveFactory.Flamethrower, },
			[38] = new List<Move>() { MoveFactory.WillOWisp, },
			[41] = new List<Move>() { MoveFactory.Psychic, },
			[43] = new List<Move>() { MoveFactory.SunnyDay, },
			[46] = new List<Move>() { MoveFactory.MagicRoom, },
			[48] = new List<Move>() { MoveFactory.FireBlast, },
		};
	}
}
