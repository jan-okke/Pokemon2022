using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spinarak : Pokemon
	{
		public override string Name => "Spinarak";
		public override int Generation => 2;
		public override string PokedexEntry => "The web it spins can be considered its second nervous system. It is said that a Spinarak determines its prey by the tiny vibrations it feels through the web.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Insomnia, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sniper;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 60,
			Defense = 40,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.StringShot, },
			[5] = new List<Move>() { MoveFactory.Absorb, },
			[8] = new List<Move>() { MoveFactory.Infestation, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[15] = new List<Move>() { MoveFactory.NightShade, },
			[19] = new List<Move>() { MoveFactory.ShadowSneak, },
			[22] = new List<Move>() { MoveFactory.FurySwipes, },
			[26] = new List<Move>() { MoveFactory.SuckerPunch, },
			[29] = new List<Move>() { MoveFactory.LeechLife, },
			[33] = new List<Move>() { MoveFactory.Agility, },
			[36] = new List<Move>() { MoveFactory.PinMissile, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[43] = new List<Move>() { MoveFactory.PoisonJab, },
			[47] = new List<Move>() { MoveFactory.CrossPoison, },
			[50] = new List<Move>() { MoveFactory.StickyWeb, },
			[54] = new List<Move>() { MoveFactory.ToxicThread, },
		};
	}
}
