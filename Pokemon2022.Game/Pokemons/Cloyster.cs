using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cloyster : Pokemon
	{
		public override string Name => "Cloyster";
		public override int Generation => 1;
		public override string PokedexEntry => "It swims in the sea by swallowing water, then jetting it out toward the rear. The Cloyster shoots spikes from its shell using the same system.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShellArmor, AbilityFactory.SkillLink, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 95,
			Defense = 180,
			SpecialAttack = 85,
			SpecialDefense = 45,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IcicleSpear, },
			[1] = new List<Move>() { MoveFactory.IcicleSpear, MoveFactory.IcicleCrash, MoveFactory.ToxicSpikes, MoveFactory.Spikes, MoveFactory.Leer, MoveFactory.Whirlpool, MoveFactory.Supersonic, MoveFactory.AuroraBeam, MoveFactory.Protect, MoveFactory.RazorShell, MoveFactory.IronDefense, MoveFactory.IceBeam, MoveFactory.ShellSmash, MoveFactory.HydroPump, MoveFactory.Tackle, MoveFactory.WaterGun, MoveFactory.Withdraw, MoveFactory.IceShard, },
		};
	}
}
