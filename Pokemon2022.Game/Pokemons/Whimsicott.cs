using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Whimsicott : Pokemon
	{
		public override string Name => "Whimsicott";
		public override int Generation => 5;
		public override string PokedexEntry => "Riding whirlwinds, they appear. These Pokémon sneak through gaps into houses and cause all sorts of mischief.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Prankster, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Chlorophyll;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 67,
			Defense = 85,
			SpecialAttack = 77,
			SpecialDefense = 75,
			Speed = 116
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Tailwind, MoveFactory.Moonblast, MoveFactory.Memento, MoveFactory.Hurricane, MoveFactory.MegaDrain, MoveFactory.RazorLeaf, MoveFactory.Growth, MoveFactory.PoisonPowder, MoveFactory.GigaDrain, MoveFactory.Charm, MoveFactory.LeechSeed, MoveFactory.CottonSpore, MoveFactory.EnergyBall, MoveFactory.SunnyDay, MoveFactory.Endeavor, MoveFactory.CottonGuard, MoveFactory.SolarBeam, MoveFactory.Absorb, MoveFactory.HelpingHand, MoveFactory.FairyWind, MoveFactory.StunSpore, },
		};
	}
}
