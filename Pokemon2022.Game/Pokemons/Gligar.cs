using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gligar : Pokemon
	{
		public override string Name => "Gligar";
		public override int Generation => 2;
		public override string PokedexEntry => "It glides without making a single sound. It grasps the face of its foe using its hind and large front claws, then stabs with its poison barb.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Immunity;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 75,
			Defense = 105,
			SpecialAttack = 35,
			SpecialDefense = 65,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[7] = new List<Move>() { MoveFactory.Harden, },
			[10] = new List<Move>() { MoveFactory.KnockOff, },
			[13] = new List<Move>() { MoveFactory.QuickAttack, },
			[16] = new List<Move>() { MoveFactory.FuryCutter, },
			[19] = new List<Move>() { MoveFactory.MudSlap, },
			[22] = new List<Move>() { MoveFactory.Acrobatics, },
			[27] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.Uturn, },
			[35] = new List<Move>() { MoveFactory.Screech, },
			[40] = new List<Move>() { MoveFactory.XScissor, },
			[45] = new List<Move>() { MoveFactory.Earthquake, },
			[50] = new List<Move>() { MoveFactory.SwordsDance, },
			[55] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}
