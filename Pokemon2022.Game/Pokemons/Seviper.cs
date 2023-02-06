using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Seviper : Pokemon
	{
		public override string Name => "Seviper";
		public override int Generation => 3;
		public override string PokedexEntry => "Seviper and Zangoose are eternal rivals. It counters a Zangoose's dazzling agility with its swordlike tail, which also oozes a horrible poison.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 73,
			Attack = 100,
			Defense = 60,
			SpecialAttack = 100,
			SpecialDefense = 60,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.Swagger, },
			[4] = new List<Move>() { MoveFactory.Bite, },
			[6] = new List<Move>() { MoveFactory.Lick, },
			[9] = new List<Move>() { MoveFactory.PoisonTail, },
			[11] = new List<Move>() { MoveFactory.Feint, },
			[14] = new List<Move>() { MoveFactory.Screech, },
			[16] = new List<Move>() { MoveFactory.Venoshock, },
			[19] = new List<Move>() { MoveFactory.Glare, },
			[21] = new List<Move>() { MoveFactory.PoisonFang, },
			[24] = new List<Move>() { MoveFactory.VenomDrench, },
			[26] = new List<Move>() { MoveFactory.NightSlash, },
			[29] = new List<Move>() { MoveFactory.GastroAcid, },
			[31] = new List<Move>() { MoveFactory.PoisonJab, },
			[34] = new List<Move>() { MoveFactory.Haze, },
			[36] = new List<Move>() { MoveFactory.SwordsDance, },
			[39] = new List<Move>() { MoveFactory.Crunch, },
			[41] = new List<Move>() { MoveFactory.Belch, },
			[44] = new List<Move>() { MoveFactory.Coil, },
			[46] = new List<Move>() { MoveFactory.SludgeBomb, },
		};
	}
}
