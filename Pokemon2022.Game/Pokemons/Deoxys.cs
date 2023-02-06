using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Deoxys : Pokemon
	{
		public override string Name => "Deoxys";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that mutated from an extraterrestrial virus exposed to a laser beam. Its body is configured for superior agility and speed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 150,
			Defense = 50,
			SpecialAttack = 150,
			SpecialDefense = 50,
			Speed = 150
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leer, MoveFactory.Wrap, },
			[7] = new List<Move>() { MoveFactory.NightShade, },
			[13] = new List<Move>() { MoveFactory.Teleport, },
			[19] = new List<Move>() { MoveFactory.KnockOff, },
			[25] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[31] = new List<Move>() { MoveFactory.Psychic, },
			[37] = new List<Move>() { MoveFactory.Switcheroo, },
			[43] = new List<Move>() { MoveFactory.PsychoShift, },
			[49] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[55] = new List<Move>() { MoveFactory.CosmicPower, },
			[61] = new List<Move>() { MoveFactory.Recover, },
			[67] = new List<Move>() { MoveFactory.PsychoBoost, },
			[73] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
