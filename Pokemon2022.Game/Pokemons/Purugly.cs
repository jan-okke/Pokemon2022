using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Purugly : Pokemon
	{
		public override string Name => "Purugly";
		public override int Generation => 4;
		public override string PokedexEntry => "It is a brazen brute that barges its way into another Pokémon's nest and claims it as its own.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 71,
			Attack = 82,
			Defense = 64,
			SpecialAttack = 64,
			SpecialDefense = 59,
			Speed = 112
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Swagger, },
			[1] = new List<Move>() { MoveFactory.Swagger, MoveFactory.FakeOut, MoveFactory.Scratch, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.Scratch, },
			[8] = new List<Move>() { MoveFactory.Growl, },
			[13] = new List<Move>() { MoveFactory.Hypnosis, },
			[17] = new List<Move>() { MoveFactory.AerialAce, },
			[20] = new List<Move>() { MoveFactory.FurySwipes, },
			[25] = new List<Move>() { MoveFactory.Charm, },
			[29] = new List<Move>() { MoveFactory.Taunt, },
			[32] = new List<Move>() { MoveFactory.Retaliate, },
			[37] = new List<Move>() { MoveFactory.Slash, },
			[45] = new List<Move>() { MoveFactory.BodySlam, },
			[52] = new List<Move>() { MoveFactory.Attract, },
			[60] = new List<Move>() { MoveFactory.HoneClaws, },
		};
	}
}
