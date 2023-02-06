using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gliscor : Pokemon
	{
		public override string Name => "Gliscor";
		public override int Generation => 4;
		public override string PokedexEntry => "It observes prey while hanging inverted from branches. When the chance presents itself, it swoops!";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PoisonHeal;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 95,
			Defense = 125,
			SpecialAttack = 45,
			SpecialDefense = 75,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Guillotine, MoveFactory.ThunderFang, MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.PoisonJab, MoveFactory.SandAttack, MoveFactory.Harden, MoveFactory.KnockOff, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[7] = new List<Move>() { MoveFactory.Harden, },
			[10] = new List<Move>() { MoveFactory.KnockOff, },
			[13] = new List<Move>() { MoveFactory.QuickAttack, },
			[16] = new List<Move>() { MoveFactory.FuryCutter, },
			[19] = new List<Move>() { MoveFactory.MudSlap, },
			[22] = new List<Move>() { MoveFactory.Acrobatics, },
			[27] = new List<Move>() { MoveFactory.NightSlash, },
			[30] = new List<Move>() { MoveFactory.Uturn, },
			[35] = new List<Move>() { MoveFactory.Screech, },
			[40] = new List<Move>() { MoveFactory.XScissor, },
			[45] = new List<Move>() { MoveFactory.Earthquake, },
			[50] = new List<Move>() { MoveFactory.SwordsDance, },
			[55] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}
