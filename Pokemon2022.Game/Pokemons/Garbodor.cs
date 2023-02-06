using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Garbodor : Pokemon
	{
		public override string Name => "Garbodor";
		public override int Generation => 5;
		public override string PokedexEntry => "They absorb garbage and make it part of their bodies. They shoot a poisonous liquid from their right-hand fingertips.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Stench, AbilityFactory.WeakArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Aftermath;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 95,
			Defense = 82,
			SpecialAttack = 60,
			SpecialDefense = 82,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.TakeDown, MoveFactory.MetalClaw, MoveFactory.PoisonGas, MoveFactory.Recycle, MoveFactory.AcidSpray, },
			[9] = new List<Move>() { MoveFactory.Amnesia, },
			[12] = new List<Move>() { MoveFactory.ClearSmog, },
			[15] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[18] = new List<Move>() { MoveFactory.Sludge, },
			[21] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, },
			[24] = new List<Move>() { MoveFactory.BodySlam, },
			[27] = new List<Move>() { MoveFactory.SludgeBomb, },
			[30] = new List<Move>() { MoveFactory.Toxic, },
			[33] = new List<Move>() { MoveFactory.Belch, },
			[39] = new List<Move>() { MoveFactory.PainSplit, },
			[43] = new List<Move>() { MoveFactory.GunkShot, },
			[48] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
