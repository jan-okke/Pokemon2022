using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Venonat : Pokemon
	{
		public override string Name => "Venonat";
		public override int Generation => 1;
		public override string PokedexEntry => "Its coat of thin, stiff hair that covers its entire body is said to have evolved for protection. Its large eyes never fail to spot even miniscule prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CompoundEyes, AbilityFactory.TintedLens, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RunAway;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 55,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 55,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Disable, MoveFactory.StruggleBug, },
			[5] = new List<Move>() { MoveFactory.Supersonic, },
			[11] = new List<Move>() { MoveFactory.Confusion, },
			[13] = new List<Move>() { MoveFactory.PoisonPowder, },
			[17] = new List<Move>() { MoveFactory.Psybeam, },
			[23] = new List<Move>() { MoveFactory.StunSpore, },
			[25] = new List<Move>() { MoveFactory.MegaDrain, },
			[29] = new List<Move>() { MoveFactory.SleepPowder, },
			[35] = new List<Move>() { MoveFactory.LeechLife, },
			[37] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[41] = new List<Move>() { MoveFactory.PoisonFang, },
			[47] = new List<Move>() { MoveFactory.Psychic, },
		};
	}
}
