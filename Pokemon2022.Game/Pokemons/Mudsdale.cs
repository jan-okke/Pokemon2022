using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mudsdale : Pokemon
	{
		public override string Name => "Mudsdale";
		public override int Generation => 7;
		public override string PokedexEntry => "It remains calm and unmoving no matter the situation. It mixes dirt with the saliva in its mouth to make a special kind of mud.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.OwnTempo, AbilityFactory.Stamina, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 125,
			Defense = 100,
			SpecialAttack = 55,
			SpecialDefense = 85,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.RockSmash, MoveFactory.IronDefense, MoveFactory.DoubleKick, },
			[12] = new List<Move>() { MoveFactory.Bulldoze, },
			[16] = new List<Move>() { MoveFactory.Stomp, },
			[20] = new List<Move>() { MoveFactory.Strength, },
			[24] = new List<Move>() { MoveFactory.Counter, },
			[28] = new List<Move>() { MoveFactory.HighHorsepower, },
			[34] = new List<Move>() { MoveFactory.HeavySlam, },
			[40] = new List<Move>() { MoveFactory.Earthquake, },
			[46] = new List<Move>() { MoveFactory.MegaKick, },
			[52] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}
