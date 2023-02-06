using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Jynx : Pokemon
	{
		public override string Name => "Jynx";
		public override int Generation => 1;
		public override string PokedexEntry => "A Jynx sashays rhythmically as if it were dancing. Its motions are so bouncingly alluring, people seeing it are compelled to shake their hips without noticing.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.Forewarn, };
		public override Ability AvailableHiddenAbility => AbilityFactory.DrySkin;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 50,
			Defense = 35,
			SpecialAttack = 115,
			SpecialDefense = 95,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SweetKiss, MoveFactory.Lick, MoveFactory.Pound, MoveFactory.PowderSnow, MoveFactory.Copycat, },
			[12] = new List<Move>() { MoveFactory.Confusion, },
			[16] = new List<Move>() { MoveFactory.Covet, },
			[20] = new List<Move>() { MoveFactory.Sing, },
			[24] = new List<Move>() { MoveFactory.FakeTears, },
			[28] = new List<Move>() { MoveFactory.IcePunch, },
			[34] = new List<Move>() { MoveFactory.Psychic, },
			[40] = new List<Move>() { MoveFactory.LovelyKiss, },
			[46] = new List<Move>() { MoveFactory.MeanLook, },
			[52] = new List<Move>() { MoveFactory.PerishSong, },
			[58] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}
