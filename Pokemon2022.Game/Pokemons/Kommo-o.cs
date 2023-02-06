using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kommoo : Pokemon
	{
		public override string Name => "Kommo-o";
		public override int Generation => 7;
		public override string PokedexEntry => "Its rigid scales function as offense and defense. In the past, its scales were processed and used to make weapons and other commodities.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Bulletproof, AbilityFactory.Soundproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 110,
			Defense = 125,
			SpecialAttack = 100,
			SpecialDefense = 105,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ClangingScales, },
			[1] = new List<Move>() { MoveFactory.ClangingScales, MoveFactory.BellyDrum, MoveFactory.Autotomize, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.Protect, MoveFactory.DragonTail, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[16] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.WorkUp, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.IronDefense, },
			[32] = new List<Move>() { MoveFactory.DragonClaw, },
			[38] = new List<Move>() { MoveFactory.NobleRoar, },
			[44] = new List<Move>() { MoveFactory.DragonDance, },
			[52] = new List<Move>() { MoveFactory.Outrage, },
			[60] = new List<Move>() { MoveFactory.CloseCombat, },
			[68] = new List<Move>() { MoveFactory.ClangorousSoul, },
			[76] = new List<Move>() { MoveFactory.Boomburst, },
		};
	}
}
