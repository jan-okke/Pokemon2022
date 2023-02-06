using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Perrserker : Pokemon
	{
		public override string Name => "Perrserker";
		public override int Generation => 8;
		public override string PokedexEntry => "What appears to be an iron helmet is actually hardened hair. This Pokémon lives for the thrill of battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BattleArmor, AbilityFactory.ToughClaws, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SteelySpirit;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 110,
			Defense = 100,
			SpecialAttack = 50,
			SpecialDefense = 60,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IronHead, },
			[1] = new List<Move>() { MoveFactory.IronHead, MoveFactory.MetalBurst, MoveFactory.IronDefense, MoveFactory.FakeOut, MoveFactory.Growl, MoveFactory.HoneClaws, MoveFactory.Scratch, },
			[12] = new List<Move>() { MoveFactory.PayDay, },
			[16] = new List<Move>() { MoveFactory.MetalClaw, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[24] = new List<Move>() { MoveFactory.Swagger, },
			[31] = new List<Move>() { MoveFactory.FurySwipes, },
			[36] = new List<Move>() { MoveFactory.Screech, },
			[42] = new List<Move>() { MoveFactory.Slash, },
			[48] = new List<Move>() { MoveFactory.MetalSound, },
			[54] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}
