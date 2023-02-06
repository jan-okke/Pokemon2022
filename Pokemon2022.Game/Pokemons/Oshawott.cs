using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Oshawott : Pokemon
	{
		public override string Name => "Oshawott";
		public override int Generation => 5;
		public override string PokedexEntry => "The scalchop on its stomach is made from the same elements as claws. It detaches the scalchop for use as a blade.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShellArmor;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 55,
			Defense = 45,
			SpecialAttack = 63,
			SpecialDefense = 45,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.TailWhip, },
			[7] = new List<Move>() { MoveFactory.WaterGun, },
			[11] = new List<Move>() { MoveFactory.WaterSport, },
			[13] = new List<Move>() { MoveFactory.FocusEnergy, },
			[17] = new List<Move>() { MoveFactory.RazorShell, },
			[19] = new List<Move>() { MoveFactory.FuryCutter, },
			[23] = new List<Move>() { MoveFactory.WaterPulse, },
			[25] = new List<Move>() { MoveFactory.Revenge, },
			[29] = new List<Move>() { MoveFactory.AquaJet, },
			[31] = new List<Move>() { MoveFactory.Encore, },
			[35] = new List<Move>() { MoveFactory.AquaTail, },
			[37] = new List<Move>() { MoveFactory.Retaliate, },
			[41] = new List<Move>() { MoveFactory.SwordsDance, },
			[43] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
