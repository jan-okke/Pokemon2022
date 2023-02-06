using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shellder : Pokemon
	{
		public override string Name => "Shellder";
		public override int Generation => 1;
		public override string PokedexEntry => "At night, it burrows a hole in the seafloor with its broad tongue to make a place to sleep. While asleep, it closes its shell, but leaves its tongue hanging out.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShellArmor, AbilityFactory.SkillLink, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 65,
			Defense = 100,
			SpecialAttack = 45,
			SpecialDefense = 25,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.WaterGun, },
			[4] = new List<Move>() { MoveFactory.Withdraw, },
			[8] = new List<Move>() { MoveFactory.IceShard, },
			[12] = new List<Move>() { MoveFactory.Leer, },
			[16] = new List<Move>() { MoveFactory.Whirlpool, },
			[20] = new List<Move>() { MoveFactory.Supersonic, },
			[24] = new List<Move>() { MoveFactory.AuroraBeam, },
			[28] = new List<Move>() { MoveFactory.Protect, },
			[32] = new List<Move>() { MoveFactory.RazorShell, },
			[36] = new List<Move>() { MoveFactory.IronDefense, },
			[40] = new List<Move>() { MoveFactory.IceBeam, },
			[44] = new List<Move>() { MoveFactory.ShellSmash, },
			[48] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
