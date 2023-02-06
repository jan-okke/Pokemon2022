using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Misdreavus : Pokemon
	{
		public override string Name => "Misdreavus";
		public override int Generation => 2;
		public override string PokedexEntry => "A Misdreavus frightens people with a creepy, sobbing cry. It apparently uses its red spheres to absorb the fear of foes as its nutrition.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 60,
			SpecialAttack = 85,
			SpecialDefense = 85,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.Confusion, },
			[5] = new List<Move>() { MoveFactory.Spite, },
			[10] = new List<Move>() { MoveFactory.Astonish, },
			[14] = new List<Move>() { MoveFactory.ConfuseRay, },
			[19] = new List<Move>() { MoveFactory.MeanLook, },
			[23] = new List<Move>() { MoveFactory.Hex, },
			[28] = new List<Move>() { MoveFactory.Psybeam, },
			[32] = new List<Move>() { MoveFactory.PainSplit, },
			[37] = new List<Move>() { MoveFactory.Payback, },
			[41] = new List<Move>() { MoveFactory.ShadowBall, },
			[46] = new List<Move>() { MoveFactory.PerishSong, },
			[50] = new List<Move>() { MoveFactory.Grudge, },
			[55] = new List<Move>() { MoveFactory.PowerGem, },
		};
	}
}
