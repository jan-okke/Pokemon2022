using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kingler : Pokemon
	{
		public override string Name => "Kingler";
		public override int Generation => 1;
		public override string PokedexEntry => "It waves its huge, oversized claw in the air to communicate with others. But since the claw is so heavy, this Pokémon quickly tires.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 130,
			Defense = 115,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WideGuard, MoveFactory.HammerArm, MoveFactory.WaterGun, MoveFactory.Leer, MoveFactory.Harden, MoveFactory.MetalClaw, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[16] = new List<Move>() { MoveFactory.Protect, },
			[20] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.Stomp, },
			[31] = new List<Move>() { MoveFactory.Flail, },
			[36] = new List<Move>() { MoveFactory.RazorShell, },
			[42] = new List<Move>() { MoveFactory.Slam, },
			[48] = new List<Move>() { MoveFactory.SwordsDance, },
			[54] = new List<Move>() { MoveFactory.Crabhammer, },
			[60] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}
