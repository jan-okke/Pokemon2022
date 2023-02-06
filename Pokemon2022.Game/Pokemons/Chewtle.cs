using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chewtle : Pokemon
	{
		public override string Name => "Chewtle";
		public override int Generation => 8;
		public override string PokedexEntry => "It starts off battles by attacking with its rock-hard horn, but as soon as the opponent flinches, this Pokémon bites down and never lets go.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.StrongJaw, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 64,
			Defense = 50,
			SpecialAttack = 38,
			SpecialDefense = 38,
			Speed = 44
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.WaterGun, },
			[7] = new List<Move>() { MoveFactory.Bite, },
			[14] = new List<Move>() { MoveFactory.Protect, },
			[21] = new List<Move>() { MoveFactory.Headbutt, },
			[28] = new List<Move>() { MoveFactory.Counter, },
			[35] = new List<Move>() { MoveFactory.JawLock, },
			[42] = new List<Move>() { MoveFactory.Liquidation, },
			[49] = new List<Move>() { MoveFactory.BodySlam, },
		};
	}
}
