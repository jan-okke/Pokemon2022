using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class NidoranM : Pokemon
	{
		public override string Name => "Nidoran♂";
		public override int Generation => 1;
		public override string PokedexEntry => "The male Nidoran has developed muscles that freely move its ears in any direction. Even the slightest sound does not escape this Pokémon's notice.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Rivalry, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 46,
			Attack = 57,
			Defense = 40,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leer, MoveFactory.PoisonSting, },
			[5] = new List<Move>() { MoveFactory.Peck, },
			[10] = new List<Move>() { MoveFactory.FocusEnergy, },
			[15] = new List<Move>() { MoveFactory.FuryAttack, },
			[20] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[25] = new List<Move>() { MoveFactory.DoubleKick, },
			[30] = new List<Move>() { MoveFactory.HornAttack, },
			[35] = new List<Move>() { MoveFactory.HelpingHand, },
			[40] = new List<Move>() { MoveFactory.Toxic, },
			[45] = new List<Move>() { MoveFactory.Flatter, },
			[50] = new List<Move>() { MoveFactory.PoisonJab, },
			[55] = new List<Move>() { MoveFactory.EarthPower, },
		};
	}
}
