using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mimikyu : Pokemon
	{
		public override string Name => "Mimikyu";
		public override int Generation => 7;
		public override string PokedexEntry => "A lonely Pokémon, it conceals its terrifying appearance beneath an old rag so it can get closer to people and other Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Disguise, };
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 90,
			Defense = 80,
			SpecialAttack = 50,
			SpecialDefense = 105,
			Speed = 96
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WoodHammer, MoveFactory.Splash, MoveFactory.Astonish, MoveFactory.Scratch, MoveFactory.Copycat, },
			[6] = new List<Move>() { MoveFactory.ShadowSneak, },
			[12] = new List<Move>() { MoveFactory.DoubleTeam, },
			[18] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[24] = new List<Move>() { MoveFactory.Mimic, },
			[30] = new List<Move>() { MoveFactory.HoneClaws, },
			[36] = new List<Move>() { MoveFactory.Slash, },
			[42] = new List<Move>() { MoveFactory.ShadowClaw, },
			[48] = new List<Move>() { MoveFactory.Charm, },
			[54] = new List<Move>() { MoveFactory.PlayRough, },
			[60] = new List<Move>() { MoveFactory.PainSplit, },
		};
	}
}
