using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Samurott : Pokemon
	{
		public override string Name => "Samurott";
		public override int Generation => 5;
		public override string PokedexEntry => "Part of the armor on its anterior legs becomes a giant sword. Its cry alone is enough to intimidate most enemies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShellArmor;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 100,
			Defense = 85,
			SpecialAttack = 108,
			SpecialDefense = 70,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Slash, },
			[1] = new List<Move>() { MoveFactory.Slash, MoveFactory.Megahorn, MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.WaterGun, MoveFactory.WaterSport, },
			[5] = new List<Move>() { MoveFactory.TailWhip, },
			[7] = new List<Move>() { MoveFactory.WaterGun, },
			[11] = new List<Move>() { MoveFactory.WaterSport, },
			[13] = new List<Move>() { MoveFactory.FocusEnergy, },
			[18] = new List<Move>() { MoveFactory.RazorShell, },
			[21] = new List<Move>() { MoveFactory.FuryCutter, },
			[25] = new List<Move>() { MoveFactory.WaterPulse, },
			[29] = new List<Move>() { MoveFactory.Revenge, },
			[34] = new List<Move>() { MoveFactory.AquaJet, },
			[39] = new List<Move>() { MoveFactory.Encore, },
			[46] = new List<Move>() { MoveFactory.AquaTail, },
			[51] = new List<Move>() { MoveFactory.Retaliate, },
			[58] = new List<Move>() { MoveFactory.SwordsDance, },
			[63] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
