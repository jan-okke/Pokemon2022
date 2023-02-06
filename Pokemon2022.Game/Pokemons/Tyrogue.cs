using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tyrogue : Pokemon
	{
		public override string Name => "Tyrogue";
		public override int Generation => 2;
		public override string PokedexEntry => "Tyrogue become stressed out if they do not get to train every day. When raising this Pokémon, the trainer must establish a regular training schedule.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.Steadfast, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VitalSpirit;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 35,
			Defense = 35,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.HelpingHand, MoveFactory.FakeOut, MoveFactory.FocusEnergy, },
		};
	}
}
