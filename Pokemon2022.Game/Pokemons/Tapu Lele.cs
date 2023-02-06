using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class TapuLele : Pokemon
	{
		public override string Name => "Tapu Lele";
		public override int Generation => 7;
		public override string PokedexEntry => "As it flutters about, it scatters its strangely glowing scales. Touching them is said to restore good health on the spot.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PsychicSurge, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 85,
			Defense = 75,
			SpecialAttack = 130,
			SpecialDefense = 115,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Confusion, },
			[5] = new List<Move>() { MoveFactory.Withdraw, },
			[10] = new List<Move>() { MoveFactory.Aromatherapy, },
			[15] = new List<Move>() { MoveFactory.DrainingKiss, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.Flatter, },
			[30] = new List<Move>() { MoveFactory.AromaticMist, },
			[35] = new List<Move>() { MoveFactory.SweetScent, },
			[40] = new List<Move>() { MoveFactory.Extrasensory, },
			[45] = new List<Move>() { MoveFactory.Psyshock, },
			[50] = new List<Move>() { MoveFactory.MeanLook, },
			[55] = new List<Move>() { MoveFactory.NaturesMadness, },
			[60] = new List<Move>() { MoveFactory.Moonblast, },
			[65] = new List<Move>() { MoveFactory.Tickle, },
			[70] = new List<Move>() { MoveFactory.SkillSwap, },
			[75] = new List<Move>() { MoveFactory.PsychicTerrain, },
		};
	}
}
