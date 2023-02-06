using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Furfrou : Pokemon
	{
		public override string Name => "Furfrou";
		public override int Generation => 6;
		public override string PokedexEntry => "Trimming its fluffy fur not only makes it more elegant but also increases the swiftness of its movements.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FurCoat, };
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 80,
			Defense = 60,
			SpecialAttack = 65,
			SpecialDefense = 90,
			Speed = 102
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[9] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[12] = new List<Move>() { MoveFactory.Headbutt, },
			[15] = new List<Move>() { MoveFactory.TailWhip, },
			[22] = new List<Move>() { MoveFactory.Bite, },
			[27] = new List<Move>() { MoveFactory.OdorSleuth, },
			[33] = new List<Move>() { MoveFactory.Retaliate, },
			[35] = new List<Move>() { MoveFactory.TakeDown, },
			[38] = new List<Move>() { MoveFactory.Charm, },
			[42] = new List<Move>() { MoveFactory.SuckerPunch, },
			[48] = new List<Move>() { MoveFactory.CottonGuard, },
		};
	}
}
