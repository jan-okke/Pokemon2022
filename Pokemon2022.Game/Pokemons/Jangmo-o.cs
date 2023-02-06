using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Jangmoo : Pokemon
	{
		public override string Name => "Jangmo-o";
		public override int Generation => 7;
		public override string PokedexEntry => "It expresses its feelings by smacking its scales. Metallic sounds echo through the tall mountains where Jangmo-o lives.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Bulletproof, AbilityFactory.Soundproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 55,
			Defense = 65,
			SpecialAttack = 45,
			SpecialDefense = 45,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Protect, },
			[8] = new List<Move>() { MoveFactory.DragonTail, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[16] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.WorkUp, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.IronDefense, },
			[32] = new List<Move>() { MoveFactory.DragonClaw, },
			[36] = new List<Move>() { MoveFactory.NobleRoar, },
			[40] = new List<Move>() { MoveFactory.DragonDance, },
			[44] = new List<Move>() { MoveFactory.Outrage, },
		};
	}
}
