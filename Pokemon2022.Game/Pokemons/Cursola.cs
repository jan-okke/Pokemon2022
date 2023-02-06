using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cursola : Pokemon
	{
		public override string Name => "Cursola";
		public override int Generation => 8;
		public override string PokedexEntry => "Its shell is overflowing with its heightened otherworldly energy. The ectoplasm serves as protection for this Pokémon's core spirit.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WeakArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PerishBody;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 95,
			Defense = 50,
			SpecialAttack = 145,
			SpecialDefense = 130,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PerishSong, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.Astonish, MoveFactory.Disable, },
			[15] = new List<Move>() { MoveFactory.Spite, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[25] = new List<Move>() { MoveFactory.Hex, },
			[30] = new List<Move>() { MoveFactory.Curse, },
			[35] = new List<Move>() { MoveFactory.StrengthSap, },
			[40] = new List<Move>() { MoveFactory.PowerGem, },
			[45] = new List<Move>() { MoveFactory.NightShade, },
			[50] = new List<Move>() { MoveFactory.Grudge, },
			[55] = new List<Move>() { MoveFactory.MirrorCoat, },
		};
	}
}
