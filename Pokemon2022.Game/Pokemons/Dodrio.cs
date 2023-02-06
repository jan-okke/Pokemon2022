using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dodrio : Pokemon
	{
		public override string Name => "Dodrio";
		public override int Generation => 1;
		public override string PokedexEntry => "A peculiar Pokémon species with three heads. It vigorously races across grassy plains even in arid seasons with little rainfall.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.TangledFeet;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 110,
			Defense = 70,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.TriAttack, },
			[1] = new List<Move>() { MoveFactory.TriAttack, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.QuickAttack, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[8] = new List<Move>() { MoveFactory.Leer, },
			[12] = new List<Move>() { MoveFactory.FuryAttack, },
			[15] = new List<Move>() { MoveFactory.WingAttack, },
			[19] = new List<Move>() { MoveFactory.Pluck, },
			[22] = new List<Move>() { MoveFactory.DoubleHit, },
			[26] = new List<Move>() { MoveFactory.Agility, },
			[29] = new List<Move>() { MoveFactory.Uproar, },
			[34] = new List<Move>() { MoveFactory.Acupressure, },
			[38] = new List<Move>() { MoveFactory.SwordsDance, },
			[43] = new List<Move>() { MoveFactory.Lunge, },
			[47] = new List<Move>() { MoveFactory.DrillPeck, },
			[52] = new List<Move>() { MoveFactory.Endeavor, },
			[56] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}
