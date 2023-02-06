using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dragonite : Pokemon
	{
		public override string Name => "Dragonite";
		public override int Generation => 1;
		public override string PokedexEntry => "It can circle the globe in just 16 hours. It is a kindhearted Pokémon that leads lost and foundering ships in a storm to the safety of land.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Multiscale;
		public override Stats BaseStats => new Stats() {
			HP = 91,
			Attack = 134,
			Defense = 95,
			SpecialAttack = 100,
			SpecialDefense = 100,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Hurricane, },
			[1] = new List<Move>() { MoveFactory.Hurricane, MoveFactory.WingAttack, MoveFactory.Roost, MoveFactory.ExtremeSpeed, MoveFactory.FirePunch, MoveFactory.ThunderPunch, MoveFactory.Wrap, MoveFactory.Leer, MoveFactory.Twister, MoveFactory.ThunderWave, },
			[15] = new List<Move>() { MoveFactory.DragonTail, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.Slam, },
			[33] = new List<Move>() { MoveFactory.AquaTail, },
			[39] = new List<Move>() { MoveFactory.DragonRush, },
			[41] = new List<Move>() { MoveFactory.Outrage, },
			[46] = new List<Move>() { MoveFactory.Safeguard, },
			[53] = new List<Move>() { MoveFactory.RainDance, },
			[62] = new List<Move>() { MoveFactory.DragonDance, },
			[80] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
