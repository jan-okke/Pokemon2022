using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vulpix : Pokemon
	{
		public override string Name => "Vulpix";
		public override int Generation => 1;
		public override string PokedexEntry => "It can freely control fire, making fiery orbs fly like will-o'-the-wisps. Just before evolution, its six tails grow hot as if on fire.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Drought;
		public override Stats BaseStats => new Stats() {
			HP = 38,
			Attack = 41,
			Defense = 40,
			SpecialAttack = 50,
			SpecialDefense = 65,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Ember, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.Disable, },
			[8] = new List<Move>() { MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.Spite, },
			[16] = new List<Move>() { MoveFactory.Incinerate, },
			[20] = new List<Move>() { MoveFactory.ConfuseRay, },
			[24] = new List<Move>() { MoveFactory.WillOWisp, },
			[28] = new List<Move>() { MoveFactory.Extrasensory, },
			[32] = new List<Move>() { MoveFactory.Flamethrower, },
			[36] = new List<Move>() { MoveFactory.Imprison, },
			[40] = new List<Move>() { MoveFactory.FireSpin, },
			[44] = new List<Move>() { MoveFactory.Safeguard, },
			[48] = new List<Move>() { MoveFactory.Inferno, },
			[52] = new List<Move>() { MoveFactory.Grudge, },
			[56] = new List<Move>() { MoveFactory.FireBlast, },
		};
	}
}
