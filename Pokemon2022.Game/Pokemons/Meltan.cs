using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Meltan : Pokemon
	{
		public override string Name => "Meltan";
		public override int Generation => 7;
		public override string PokedexEntry => "It melts particles of iron and other metals found in the subsoil, so it can absorb them into its body of molten steel.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MagnetPull, };
		public override Stats BaseStats => new Stats() {
			HP = 46,
			Attack = 65,
			Defense = 65,
			SpecialAttack = 55,
			SpecialDefense = 35,
			Speed = 34
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderShock, MoveFactory.Harden, },
			[8] = new List<Move>() { MoveFactory.TailWhip, },
			[16] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.ThunderWave, },
			[32] = new List<Move>() { MoveFactory.AcidArmor, },
			[40] = new List<Move>() { MoveFactory.FlashCannon, },
		};
	}
}
