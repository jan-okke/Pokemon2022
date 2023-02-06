using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lunatone : Pokemon
	{
		public override string Name => "Lunatone";
		public override int Generation => 3;
		public override string PokedexEntry => "It becomes very active on the night of a full moon. This Pokémon was first discovered 40 years ago at the site of a meteor strike.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 55,
			Defense = 65,
			SpecialAttack = 95,
			SpecialDefense = 85,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Moonblast, MoveFactory.Moonlight, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.Confusion, MoveFactory.RockThrow, },
			[5] = new List<Move>() { MoveFactory.Hypnosis, },
			[10] = new List<Move>() { MoveFactory.RockPolish, },
			[15] = new List<Move>() { MoveFactory.RockSlide, },
			[20] = new List<Move>() { MoveFactory.Psyshock, },
			[25] = new List<Move>() { MoveFactory.CosmicPower, },
			[30] = new List<Move>() { MoveFactory.Psychic, },
			[35] = new List<Move>() { MoveFactory.StoneEdge, },
			[40] = new List<Move>() { MoveFactory.FutureSight, },
			[45] = new List<Move>() { MoveFactory.MagicRoom, },
			[50] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}
