using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Metang : Pokemon
	{
		public override string Name => "Metang";
		public override int Generation => 3;
		public override string PokedexEntry => "The claws tipping its arms pack the destructive power to tear through thick iron sheets as if they were silk. It flies at over 60 miles per hour.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightMetal;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 75,
			Defense = 100,
			SpecialAttack = 55,
			SpecialDefense = 80,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Confusion, MoveFactory.MetalClaw, },
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.MetalClaw, MoveFactory.BulletPunch, MoveFactory.Tackle, },
			[6] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[12] = new List<Move>() { MoveFactory.MagnetRise, },
			[18] = new List<Move>() { MoveFactory.FlashCannon, },
			[26] = new List<Move>() { MoveFactory.TakeDown, },
			[34] = new List<Move>() { MoveFactory.Psychic, },
			[42] = new List<Move>() { MoveFactory.ScaryFace, },
			[50] = new List<Move>() { MoveFactory.MeteorMash, },
			[58] = new List<Move>() { MoveFactory.IronDefense, },
			[66] = new List<Move>() { MoveFactory.Agility, },
			[74] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
