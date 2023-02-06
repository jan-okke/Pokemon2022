using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dewott : Pokemon
	{
		public override string Name => "Dewott";
		public override int Generation => 5;
		public override string PokedexEntry => "Scalchop techniques differ from one Dewott to another. It never neglects maintaining its scalchops.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShellArmor;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 75,
			Defense = 60,
			SpecialAttack = 83,
			SpecialDefense = 60,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.WaterGun, MoveFactory.WaterSport, },
			[5] = new List<Move>() { MoveFactory.TailWhip, },
			[7] = new List<Move>() { MoveFactory.WaterGun, },
			[11] = new List<Move>() { MoveFactory.WaterSport, },
			[13] = new List<Move>() { MoveFactory.FocusEnergy, },
			[18] = new List<Move>() { MoveFactory.RazorShell, },
			[21] = new List<Move>() { MoveFactory.FuryCutter, },
			[26] = new List<Move>() { MoveFactory.WaterPulse, },
			[29] = new List<Move>() { MoveFactory.Revenge, },
			[34] = new List<Move>() { MoveFactory.AquaJet, },
			[37] = new List<Move>() { MoveFactory.Encore, },
			[42] = new List<Move>() { MoveFactory.AquaTail, },
			[45] = new List<Move>() { MoveFactory.Retaliate, },
			[50] = new List<Move>() { MoveFactory.SwordsDance, },
			[53] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
