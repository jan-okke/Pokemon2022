using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ludicolo : Pokemon
	{
		public override string Name => "Ludicolo";
		public override int Generation => 3;
		public override string PokedexEntry => "When it hears festive music, all the cells in its body become stimulated, and it begins moving in rhythm. It does not quail even when it faces a tough opponent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.RainDish, };
		public override Ability AvailableHiddenAbility => AbilityFactory.OwnTempo;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 70,
			Defense = 70,
			SpecialAttack = 90,
			SpecialDefense = 100,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.TeeterDance, MoveFactory.FakeOut, MoveFactory.KnockOff, MoveFactory.Flail, MoveFactory.Mist, MoveFactory.MegaDrain, MoveFactory.FurySwipes, MoveFactory.BubbleBeam, MoveFactory.NaturePower, MoveFactory.GigaDrain, MoveFactory.RainDance, MoveFactory.ZenHeadbutt, MoveFactory.EnergyBall, MoveFactory.HydroPump, MoveFactory.Astonish, MoveFactory.Growl, MoveFactory.Absorb, MoveFactory.WaterGun, },
		};
	}
}
