using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Steenee : Pokemon
	{
		public override string Name => "Steenee";
		public override int Generation => 7;
		public override string PokedexEntry => "It's protected by its hard sepals, so it plays with bird Pokémon without worry. They peck it relentlessly, but it doesn't care.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LeafGuard, AbilityFactory.Oblivious, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SweetVeil;
		public override Stats BaseStats => new Stats() {
			HP = 52,
			Attack = 40,
			Defense = 48,
			SpecialAttack = 40,
			SpecialDefense = 48,
			Speed = 62
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Flail, MoveFactory.Splash, MoveFactory.PlayNice, MoveFactory.RapidSpin, MoveFactory.RazorLeaf, },
			[16] = new List<Move>() { MoveFactory.SweetScent, },
			[22] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[28] = new List<Move>() { MoveFactory.Stomp, },
			[34] = new List<Move>() { MoveFactory.TeeterDance, },
			[40] = new List<Move>() { MoveFactory.AromaticMist, },
			[46] = new List<Move>() { MoveFactory.Aromatherapy, },
			[52] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}
