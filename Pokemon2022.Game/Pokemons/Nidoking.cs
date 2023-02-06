using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nidoking : Pokemon
	{
		public override string Name => "Nidoking";
		public override int Generation => 1;
		public override string PokedexEntry => "A Nidoking's thick tail packs enormously destructive power capable of toppling a metal transmission tower. Once it goes on a rampage, there is no stopping it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Rivalry, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 81,
			Attack = 102,
			Defense = 77,
			SpecialAttack = 85,
			SpecialDefense = 75,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Megahorn, },
			[1] = new List<Move>() { MoveFactory.SludgeWave, MoveFactory.Megahorn, MoveFactory.FuryAttack, MoveFactory.ToxicSpikes, MoveFactory.DoubleKick, MoveFactory.HornAttack, MoveFactory.HelpingHand, MoveFactory.Toxic, MoveFactory.Flatter, MoveFactory.PoisonJab, MoveFactory.EarthPower, MoveFactory.Leer, MoveFactory.PoisonSting, MoveFactory.Peck, MoveFactory.FocusEnergy, },
		};
	}
}
