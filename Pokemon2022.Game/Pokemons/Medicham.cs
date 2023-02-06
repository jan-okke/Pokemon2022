using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Medicham : Pokemon
	{
		public override string Name => "Medicham";
		public override int Generation => 3;
		public override string PokedexEntry => "Through crushingly harsh yoga training, it gained the power to foretell its foe's actions. It battles with elegant, dance- like movement.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PurePower, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 75,
			SpecialAttack = 60,
			SpecialDefense = 75,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ZenHeadbutt, MoveFactory.FirePunch, MoveFactory.ThunderPunch, MoveFactory.IcePunch, MoveFactory.Pound, MoveFactory.Confusion, MoveFactory.Detect, },
			[4] = new List<Move>() { MoveFactory.LowKick, },
			[7] = new List<Move>() { MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.Detect, },
			[12] = new List<Move>() { MoveFactory.Endure, },
			[15] = new List<Move>() { MoveFactory.Feint, },
			[17] = new List<Move>() { MoveFactory.ForcePalm, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[23] = new List<Move>() { MoveFactory.CalmMind, },
			[25] = new List<Move>() { MoveFactory.MindReader, },
			[28] = new List<Move>() { MoveFactory.HighJumpKick, },
			[31] = new List<Move>() { MoveFactory.PsychUp, },
			[33] = new List<Move>() { MoveFactory.Acupressure, },
			[36] = new List<Move>() { MoveFactory.PowerTrick, },
			[42] = new List<Move>() { MoveFactory.Reversal, },
			[47] = new List<Move>() { MoveFactory.Recover, },
			[53] = new List<Move>() { MoveFactory.Counter, },
		};
	}
}
