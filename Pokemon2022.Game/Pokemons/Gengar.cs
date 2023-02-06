using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gengar : Pokemon
	{
		public override string Name => "Gengar";
		public override int Generation => 1;
		public override string PokedexEntry => "Deep in the night, your shadow cast by a streetlight may suddenly overtake you. It is actually a Gengar running past you, pretending to be your shadow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CursedBody, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 65,
			Defense = 60,
			SpecialAttack = 130,
			SpecialDefense = 75,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ShadowPunch, MoveFactory.PerishSong, MoveFactory.ReflectType, MoveFactory.Lick, MoveFactory.ConfuseRay, MoveFactory.Hypnosis, MoveFactory.MeanLook, },
			[12] = new List<Move>() { MoveFactory.Payback, },
			[16] = new List<Move>() { MoveFactory.Spite, },
			[20] = new List<Move>() { MoveFactory.Curse, },
			[24] = new List<Move>() { MoveFactory.Hex, },
			[30] = new List<Move>() { MoveFactory.NightShade, },
			[36] = new List<Move>() { MoveFactory.SuckerPunch, },
			[42] = new List<Move>() { MoveFactory.DarkPulse, },
			[48] = new List<Move>() { MoveFactory.ShadowBall, },
			[54] = new List<Move>() { MoveFactory.DestinyBond, },
			[60] = new List<Move>() { MoveFactory.DreamEater, },
		};
	}
}
