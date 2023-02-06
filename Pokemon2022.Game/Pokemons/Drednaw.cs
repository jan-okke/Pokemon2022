using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drednaw : Pokemon
	{
		public override string Name => "Drednaw";
		public override int Generation => 8;
		public override string PokedexEntry => "With jaws that can shear through steel rods, this highly aggressive Pokémon chomps down on its unfortunate prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.StrongJaw, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 115,
			Defense = 90,
			SpecialAttack = 48,
			SpecialDefense = 68,
			Speed = 74
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.RockTomb, },
			[1] = new List<Move>() { MoveFactory.RockTomb, MoveFactory.RazorShell, MoveFactory.Crunch, MoveFactory.RockPolish, MoveFactory.Tackle, MoveFactory.WaterGun, MoveFactory.Bite, MoveFactory.Protect, },
			[21] = new List<Move>() { MoveFactory.Headbutt, },
			[30] = new List<Move>() { MoveFactory.Counter, },
			[39] = new List<Move>() { MoveFactory.JawLock, },
			[48] = new List<Move>() { MoveFactory.Liquidation, },
			[57] = new List<Move>() { MoveFactory.BodySlam, },
			[66] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
