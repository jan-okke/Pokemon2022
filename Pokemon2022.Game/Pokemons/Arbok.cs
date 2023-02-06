using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Arbok : Pokemon
	{
		public override string Name => "Arbok";
		public override int Generation => 1;
		public override string PokedexEntry => "This Pokémon has a terrifically strong constricting power. It can even flatten steel oil drums. Once it wraps its body around its foe, escaping is impossible.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 95,
			Defense = 69,
			SpecialAttack = 65,
			SpecialDefense = 79,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Crunch, },
			[1] = new List<Move>() { MoveFactory.Crunch, MoveFactory.IceFang, MoveFactory.ThunderFang, MoveFactory.FireFang, MoveFactory.Wrap, MoveFactory.Leer, MoveFactory.PoisonSting, MoveFactory.Bite, },
			[4] = new List<Move>() { MoveFactory.PoisonSting, },
			[9] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.Glare, },
			[17] = new List<Move>() { MoveFactory.Screech, },
			[20] = new List<Move>() { MoveFactory.Acid, },
			[27] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[32] = new List<Move>() { MoveFactory.AcidSpray, },
			[39] = new List<Move>() { MoveFactory.SludgeBomb, },
			[44] = new List<Move>() { MoveFactory.GastroAcid, },
			[48] = new List<Move>() { MoveFactory.Belch, },
			[51] = new List<Move>() { MoveFactory.Haze, },
			[56] = new List<Move>() { MoveFactory.Coil, },
			[63] = new List<Move>() { MoveFactory.GunkShot, },
		};
	}
}
