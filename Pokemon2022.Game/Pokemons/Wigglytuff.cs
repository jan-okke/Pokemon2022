using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wigglytuff : Pokemon
	{
		public override string Name => "Wigglytuff";
		public override int Generation => 1;
		public override string PokedexEntry => "Its fur is the ultimate in luxuriousness. Sleeping alongside a Wigglytuff is simply divine. Its body expands seemingly without end when it inhales.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.Competitive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Frisk;
		public override Stats BaseStats => new Stats() {
			HP = 140,
			Attack = 70,
			Defense = 45,
			SpecialAttack = 85,
			SpecialDefense = 50,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SweetKiss, MoveFactory.DisarmingVoice, MoveFactory.Disable, MoveFactory.Charm, MoveFactory.EchoedVoice, MoveFactory.Covet, MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, MoveFactory.Round, MoveFactory.Rest, MoveFactory.BodySlam, MoveFactory.Mimic, MoveFactory.GyroBall, MoveFactory.PlayRough, MoveFactory.HyperVoice, MoveFactory.DoubleEdge, MoveFactory.Sing, MoveFactory.Pound, MoveFactory.Copycat, MoveFactory.DefenseCurl, },
		};
	}
}
