using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Necrozma : Pokemon
	{
		public override string Name => "Necrozma";
		public override int Generation => 7;
		public override string PokedexEntry => "Light is apparently the source of its energy. It has an extraordinarily vicious disposition and is constantly firing off laser beams.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PrismArmor, };
		public override Stats BaseStats => new Stats() {
			HP = 97,
			Attack = 107,
			Defense = 101,
			SpecialAttack = 127,
			SpecialDefense = 89,
			Speed = 79
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Moonlight, MoveFactory.MorningSun, MoveFactory.ChargeBeam, MoveFactory.Gravity, MoveFactory.MetalClaw, MoveFactory.Confusion, },
			[8] = new List<Move>() { MoveFactory.StealthRock, },
			[16] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.NightSlash, },
			[32] = new List<Move>() { MoveFactory.PsychoCut, },
			[40] = new List<Move>() { MoveFactory.StoredPower, },
			[48] = new List<Move>() { MoveFactory.RockBlast, },
			[56] = new List<Move>() { MoveFactory.IronDefense, },
			[64] = new List<Move>() { MoveFactory.PowerGem, },
			[72] = new List<Move>() { MoveFactory.PhotonGeyser, },
			[80] = new List<Move>() { MoveFactory.Autotomize, },
			[88] = new List<Move>() { MoveFactory.PrismaticLaser, },
		};
	}
}
