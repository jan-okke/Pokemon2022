using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hakamoo : Pokemon
	{
		public override string Name => "Hakamo-o";
		public override int Generation => 7;
		public override string PokedexEntry => "It sheds and regrows its scales on a continuous basis. The scales become harder and sharper each time they're regrown.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Bulletproof, AbilityFactory.Soundproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 75,
			Defense = 90,
			SpecialAttack = 65,
			SpecialDefense = 70,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Autotomize, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.Protect, MoveFactory.DragonTail, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[16] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.WorkUp, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.IronDefense, },
			[32] = new List<Move>() { MoveFactory.DragonClaw, },
			[38] = new List<Move>() { MoveFactory.NobleRoar, },
			[44] = new List<Move>() { MoveFactory.DragonDance, },
			[50] = new List<Move>() { MoveFactory.Outrage, },
			[56] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}
