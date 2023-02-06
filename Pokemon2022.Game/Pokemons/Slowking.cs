using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Slowking : Pokemon
	{
		public override string Name => "Slowking";
		public override int Generation => 2;
		public override string PokedexEntry => "It undertakes research every day to solve the mysteries of the world. However, it apparently forgets everything if the Shellder on its head comes off.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 75,
			Defense = 80,
			SpecialAttack = 100,
			SpecialDefense = 110,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowerGem, MoveFactory.NastyPlot, MoveFactory.Swagger, MoveFactory.Tackle, MoveFactory.Curse, MoveFactory.Growl, MoveFactory.WaterGun, },
			[9] = new List<Move>() { MoveFactory.Yawn, },
			[12] = new List<Move>() { MoveFactory.Confusion, },
			[15] = new List<Move>() { MoveFactory.Disable, },
			[18] = new List<Move>() { MoveFactory.WaterPulse, },
			[21] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[27] = new List<Move>() { MoveFactory.Amnesia, },
			[30] = new List<Move>() { MoveFactory.Surf, },
			[33] = new List<Move>() { MoveFactory.SlackOff, },
			[36] = new List<Move>() { MoveFactory.Psychic, },
			[39] = new List<Move>() { MoveFactory.PsychUp, },
			[42] = new List<Move>() { MoveFactory.RainDance, },
			[45] = new List<Move>() { MoveFactory.HealPulse, },
		};
	}
}
