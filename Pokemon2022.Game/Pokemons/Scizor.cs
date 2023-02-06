using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Scizor : Pokemon
	{
		public override string Name => "Scizor";
		public override int Generation => 2;
		public override string PokedexEntry => "A Scizor has a body with the hardness of steel. It is not easily fazed by ordinary sorts of attacks. It flaps its wings to regulate its body temperature.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Technician, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightMetal;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 130,
			Defense = 100,
			SpecialAttack = 55,
			SpecialDefense = 80,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.BulletPunch, },
			[1] = new List<Move>() { MoveFactory.BulletPunch, MoveFactory.WingAttack, MoveFactory.Agility, MoveFactory.AirSlash, MoveFactory.QuickAttack, MoveFactory.Leer, MoveFactory.FuryCutter, MoveFactory.FalseSwipe, },
			[12] = new List<Move>() { MoveFactory.MetalClaw, },
			[16] = new List<Move>() { MoveFactory.DoubleTeam, },
			[20] = new List<Move>() { MoveFactory.DoubleHit, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[28] = new List<Move>() { MoveFactory.FocusEnergy, },
			[32] = new List<Move>() { MoveFactory.IronDefense, },
			[36] = new List<Move>() { MoveFactory.IronHead, },
			[40] = new List<Move>() { MoveFactory.XScissor, },
			[44] = new List<Move>() { MoveFactory.LaserFocus, },
			[48] = new List<Move>() { MoveFactory.SwordsDance, },
		};
	}
}
