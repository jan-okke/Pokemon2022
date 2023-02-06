using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drowzee : Pokemon
	{
		public override string Name => "Drowzee";
		public override int Generation => 1;
		public override string PokedexEntry => "If your nose becomes itchy while you are sleeping, it's a sure sign that a Drowzee is standing above your pillow and trying to eat your dream through your nostrils.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Insomnia, AbilityFactory.Forewarn, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 48,
			Defense = 45,
			SpecialAttack = 43,
			SpecialDefense = 90,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Hypnosis, },
			[5] = new List<Move>() { MoveFactory.Disable, },
			[9] = new List<Move>() { MoveFactory.Confusion, },
			[13] = new List<Move>() { MoveFactory.Headbutt, },
			[17] = new List<Move>() { MoveFactory.PoisonGas, },
			[21] = new List<Move>() { MoveFactory.Hypnosis, },
			[25] = new List<Move>() { MoveFactory.Psybeam, },
			[29] = new List<Move>() { MoveFactory.MindReader, },
			[33] = new List<Move>() { MoveFactory.PsychUp, },
			[37] = new List<Move>() { MoveFactory.Hypnosis, },
			[41] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[45] = new List<Move>() { MoveFactory.Swagger, },
			[49] = new List<Move>() { MoveFactory.Psychic, },
			[53] = new List<Move>() { MoveFactory.NastyPlot, },
			[57] = new List<Move>() { MoveFactory.Psyshock, },
			[61] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}
