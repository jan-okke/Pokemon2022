using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Musharna : Pokemon
	{
		public override string Name => "Musharna";
		public override int Generation => 5;
		public override string PokedexEntry => "With the mist from its forehead, it can create shapes of things from dreams it has eaten.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Forewarn, AbilityFactory.Synchronize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 116,
			Attack = 55,
			Defense = 85,
			SpecialAttack = 107,
			SpecialDefense = 95,
			Speed = 29
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PsychicTerrain, MoveFactory.Imprison, MoveFactory.Moonlight, MoveFactory.MagicCoat, MoveFactory.ZenHeadbutt, MoveFactory.CalmMind, MoveFactory.Yawn, MoveFactory.Psychic, MoveFactory.Moonblast, MoveFactory.DreamEater, MoveFactory.FutureSight, MoveFactory.WonderRoom, MoveFactory.StoredPower, MoveFactory.DefenseCurl, MoveFactory.Hypnosis, MoveFactory.Psybeam, },
		};
	}
}
