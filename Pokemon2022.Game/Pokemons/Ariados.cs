using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ariados : Pokemon
	{
		public override string Name => "Ariados";
		public override int Generation => 2;
		public override string PokedexEntry => "Its feet are tipped with tiny hooked claws that enable it to scuttle on ceilings and vertical walls. It constricts its foe with thin and strong silk webbing.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Insomnia, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sniper;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 90,
			Defense = 70,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SwordsDance, },
			[1] = new List<Move>() { MoveFactory.SwordsDance, MoveFactory.FocusEnergy, MoveFactory.VenomDrench, MoveFactory.FellStinger, MoveFactory.BugBite, MoveFactory.PoisonSting, MoveFactory.StringShot, MoveFactory.Absorb, },
			[5] = new List<Move>() { MoveFactory.Absorb, },
			[8] = new List<Move>() { MoveFactory.Infestation, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[15] = new List<Move>() { MoveFactory.NightShade, },
			[19] = new List<Move>() { MoveFactory.ShadowSneak, },
			[23] = new List<Move>() { MoveFactory.FurySwipes, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[32] = new List<Move>() { MoveFactory.LeechLife, },
			[37] = new List<Move>() { MoveFactory.Agility, },
			[41] = new List<Move>() { MoveFactory.PinMissile, },
			[46] = new List<Move>() { MoveFactory.Psychic, },
			[50] = new List<Move>() { MoveFactory.PoisonJab, },
			[55] = new List<Move>() { MoveFactory.CrossPoison, },
			[58] = new List<Move>() { MoveFactory.StickyWeb, },
			[63] = new List<Move>() { MoveFactory.ToxicThread, },
		};
	}
}
