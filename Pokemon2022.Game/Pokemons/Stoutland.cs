using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Stoutland : Pokemon
	{
		public override string Name => "Stoutland";
		public override int Generation => 5;
		public override string PokedexEntry => "This extremely wise Pokémon excels at rescuing people stranded at sea or in the mountains.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.SandRush, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 110,
			Defense = 90,
			SpecialAttack = 45,
			SpecialDefense = 90,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.ThunderFang, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.WorkUp, MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.Retaliate, },
			[19] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[24] = new List<Move>() { MoveFactory.PlayRough, },
			[30] = new List<Move>() { MoveFactory.Crunch, },
			[38] = new List<Move>() { MoveFactory.TakeDown, },
			[46] = new List<Move>() { MoveFactory.HelpingHand, },
			[54] = new List<Move>() { MoveFactory.Reversal, },
			[62] = new List<Move>() { MoveFactory.Roar, },
			[70] = new List<Move>() { MoveFactory.LastResort, },
			[78] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}
