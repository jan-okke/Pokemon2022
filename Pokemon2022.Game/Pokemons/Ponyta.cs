using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ponyta : Pokemon
	{
		public override string Name => "Ponyta";
		public override int Generation => 1;
		public override string PokedexEntry => "A Ponyta is very weak at birth. It can barely stand up. Its legs become stronger as it stumbles and falls while trying to keep up with its parent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlameBody;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 85,
			Defense = 55,
			SpecialAttack = 65,
			SpecialDefense = 65,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.TailWhip, },
			[10] = new List<Move>() { MoveFactory.Ember, },
			[15] = new List<Move>() { MoveFactory.FlameCharge, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.FlameWheel, },
			[30] = new List<Move>() { MoveFactory.Stomp, },
			[35] = new List<Move>() { MoveFactory.FireSpin, },
			[41] = new List<Move>() { MoveFactory.TakeDown, },
			[45] = new List<Move>() { MoveFactory.Inferno, },
			[50] = new List<Move>() { MoveFactory.FireBlast, },
			[55] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
