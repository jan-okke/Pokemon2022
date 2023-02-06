using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Braixen : Pokemon
	{
		public override string Name => "Braixen";
		public override int Generation => 6;
		public override string PokedexEntry => "When the twig is plucked from its tail, friction sets the twig alight. The flame is used to send signals to its allies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Magician;
		public override Stats BaseStats => new Stats() {
			HP = 59,
			Attack = 59,
			Defense = 58,
			SpecialAttack = 90,
			SpecialDefense = 70,
			Speed = 73
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.TailWhip, MoveFactory.Ember, },
			[5] = new List<Move>() { MoveFactory.Ember, },
			[11] = new List<Move>() { MoveFactory.Howl, },
			[14] = new List<Move>() { MoveFactory.FlameCharge, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[22] = new List<Move>() { MoveFactory.FireSpin, },
			[28] = new List<Move>() { MoveFactory.LuckyChant, },
			[31] = new List<Move>() { MoveFactory.LightScreen, },
			[36] = new List<Move>() { MoveFactory.Psyshock, },
			[41] = new List<Move>() { MoveFactory.Flamethrower, },
			[45] = new List<Move>() { MoveFactory.WillOWisp, },
			[49] = new List<Move>() { MoveFactory.Psychic, },
			[52] = new List<Move>() { MoveFactory.SunnyDay, },
			[56] = new List<Move>() { MoveFactory.MagicRoom, },
			[59] = new List<Move>() { MoveFactory.FireBlast, },
		};
	}
}
