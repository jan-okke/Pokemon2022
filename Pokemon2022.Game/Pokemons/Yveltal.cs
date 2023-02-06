using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Yveltal : Pokemon
	{
		public override string Name => "Yveltal";
		public override int Generation => 6;
		public override string PokedexEntry => "When its life comes to an end, it absorbs the life energy of every living thing and turns into a cocoon once more.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.DarkAura, };
		public override Stats BaseStats => new Stats() {
			HP = 126,
			Attack = 131,
			Defense = 95,
			SpecialAttack = 131,
			SpecialDefense = 98,
			Speed = 99
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.DoubleTeam, },
			[5] = new List<Move>() { MoveFactory.Taunt, },
			[10] = new List<Move>() { MoveFactory.Snarl, },
			[15] = new List<Move>() { MoveFactory.Disable, },
			[20] = new List<Move>() { MoveFactory.SuckerPunch, },
			[25] = new List<Move>() { MoveFactory.Tailwind, },
			[30] = new List<Move>() { MoveFactory.Roost, },
			[35] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.DarkPulse, },
			[45] = new List<Move>() { MoveFactory.Psychic, },
			[50] = new List<Move>() { MoveFactory.OblivionWing, },
			[55] = new List<Move>() { MoveFactory.PhantomForce, },
			[60] = new List<Move>() { MoveFactory.FoulPlay, },
			[65] = new List<Move>() { MoveFactory.DragonRush, },
			[70] = new List<Move>() { MoveFactory.Hurricane, },
			[75] = new List<Move>() { MoveFactory.FocusBlast, },
			[80] = new List<Move>() { MoveFactory.SkyAttack, },
			[85] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
