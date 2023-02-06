using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Croconaw : Pokemon
	{
		public override string Name => "Croconaw";
		public override int Generation => 2;
		public override string PokedexEntry => "Once its jaws clamp down on its foe, it will absolutely not let go. Because the tips of its fangs are forked back like fishhooks, they become irremovably embedded.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 80,
			Defense = 80,
			SpecialAttack = 59,
			SpecialDefense = 63,
			Speed = 58
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.WaterGun, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[8] = new List<Move>() { MoveFactory.MudSlap, },
			[13] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.ScaryFace, },
			[21] = new List<Move>() { MoveFactory.IceFang, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[30] = new List<Move>() { MoveFactory.Crunch, },
			[33] = new List<Move>() { MoveFactory.LowKick, },
			[39] = new List<Move>() { MoveFactory.Slash, },
			[42] = new List<Move>() { MoveFactory.Screech, },
			[48] = new List<Move>() { MoveFactory.Thrash, },
			[51] = new List<Move>() { MoveFactory.AquaTail, },
			[57] = new List<Move>() { MoveFactory.Superpower, },
			[60] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
