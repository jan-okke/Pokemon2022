using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Metagross : Pokemon
	{
		public override string Name => "Metagross";
		public override int Generation => 3;
		public override string PokedexEntry => "Metagross has four brains that are joined by a complex neural network. As a result of integration, this Pokémon is smarter than a supercomputer.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightMetal;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 135,
			Defense = 130,
			SpecialAttack = 95,
			SpecialDefense = 90,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.HammerArm, },
			[1] = new List<Move>() { MoveFactory.HammerArm, MoveFactory.Confusion, MoveFactory.MetalClaw, MoveFactory.BulletPunch, MoveFactory.Tackle, },
			[6] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[12] = new List<Move>() { MoveFactory.MagnetRise, },
			[16] = new List<Move>() { MoveFactory.FlashCannon, },
			[26] = new List<Move>() { MoveFactory.TakeDown, },
			[34] = new List<Move>() { MoveFactory.Psychic, },
			[42] = new List<Move>() { MoveFactory.ScaryFace, },
			[52] = new List<Move>() { MoveFactory.MeteorMash, },
			[62] = new List<Move>() { MoveFactory.IronDefense, },
			[72] = new List<Move>() { MoveFactory.Agility, },
			[82] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}
