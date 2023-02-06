using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nidorino : Pokemon
	{
		public override string Name => "Nidorino";
		public override int Generation => 1;
		public override string PokedexEntry => "Its horn is harder than a diamond. If it senses a hostile presence, all the barbs on its back bristle up at once, and it challenges the foe with all its might.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Rivalry, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 61,
			Attack = 72,
			Defense = 57,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leer, MoveFactory.PoisonSting, MoveFactory.Peck, MoveFactory.FocusEnergy, },
			[15] = new List<Move>() { MoveFactory.FuryAttack, },
			[22] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[29] = new List<Move>() { MoveFactory.DoubleKick, },
			[36] = new List<Move>() { MoveFactory.HornAttack, },
			[43] = new List<Move>() { MoveFactory.HelpingHand, },
			[50] = new List<Move>() { MoveFactory.Toxic, },
			[57] = new List<Move>() { MoveFactory.Flatter, },
			[64] = new List<Move>() { MoveFactory.PoisonJab, },
			[71] = new List<Move>() { MoveFactory.EarthPower, },
		};
	}
}
