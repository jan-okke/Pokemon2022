using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Krabby : Pokemon
	{
		public override string Name => "Krabby";
		public override int Generation => 1;
		public override string PokedexEntry => "Krabby live in holes dug into beaches. On sandy shores with little in the way of food, they can be seen squabbling with each other over territory.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 105,
			Defense = 90,
			SpecialAttack = 25,
			SpecialDefense = 25,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Harden, },
			[8] = new List<Move>() { MoveFactory.MetalClaw, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[16] = new List<Move>() { MoveFactory.Protect, },
			[20] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.Stomp, },
			[29] = new List<Move>() { MoveFactory.Flail, },
			[32] = new List<Move>() { MoveFactory.RazorShell, },
			[36] = new List<Move>() { MoveFactory.Slam, },
			[40] = new List<Move>() { MoveFactory.SwordsDance, },
			[44] = new List<Move>() { MoveFactory.Crabhammer, },
			[48] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}
