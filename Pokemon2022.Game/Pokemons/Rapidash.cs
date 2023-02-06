using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rapidash : Pokemon
	{
		public override string Name => "Rapidash";
		public override int Generation => 1;
		public override string PokedexEntry => "It usually canters casually in the fields and plains. But once a Rapidash turns serious, its fiery manes flare and blaze as it gallops its way up to 150 mph.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlameBody;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 100,
			Defense = 70,
			SpecialAttack = 80,
			SpecialDefense = 80,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SmartStrike, },
			[1] = new List<Move>() { MoveFactory.SmartStrike, MoveFactory.Megahorn, MoveFactory.PoisonJab, MoveFactory.Tackle, MoveFactory.QuickAttack, MoveFactory.Growl, MoveFactory.TailWhip, MoveFactory.Ember, },
			[15] = new List<Move>() { MoveFactory.FlameCharge, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.FlameWheel, },
			[30] = new List<Move>() { MoveFactory.Stomp, },
			[35] = new List<Move>() { MoveFactory.FireSpin, },
			[43] = new List<Move>() { MoveFactory.TakeDown, },
			[49] = new List<Move>() { MoveFactory.Inferno, },
			[56] = new List<Move>() { MoveFactory.FireBlast, },
			[63] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
