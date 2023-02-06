using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lunala : Pokemon
	{
		public override string Name => "Lunala";
		public override int Generation => 7;
		public override string PokedexEntry => "Said to live in another world, this Pokémon devours light, drawing the moonless dark veil of night over the brightness of day.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShadowShield, };
		public override Stats BaseStats => new Stats() {
			HP = 137,
			Attack = 113,
			Defense = 89,
			SpecialAttack = 137,
			SpecialDefense = 107,
			Speed = 97
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.MoongeistBeam, },
			[1] = new List<Move>() { MoveFactory.MoongeistBeam, MoveFactory.CosmicPower, MoveFactory.Teleport, MoveFactory.Confusion, MoveFactory.Hypnosis, },
			[7] = new List<Move>() { MoveFactory.NightShade, },
			[14] = new List<Move>() { MoveFactory.ConfuseRay, },
			[21] = new List<Move>() { MoveFactory.AirSlash, },
			[28] = new List<Move>() { MoveFactory.ShadowBall, },
			[35] = new List<Move>() { MoveFactory.Moonlight, },
			[42] = new List<Move>() { MoveFactory.NightDaze, },
			[49] = new List<Move>() { MoveFactory.MagicCoat, },
			[56] = new List<Move>() { MoveFactory.Moonblast, },
			[63] = new List<Move>() { MoveFactory.PhantomForce, },
			[70] = new List<Move>() { MoveFactory.DreamEater, },
			[77] = new List<Move>() { MoveFactory.WideGuard, },
			[84] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
