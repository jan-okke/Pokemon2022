using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rampardos : Pokemon
	{
		public override string Name => "Rampardos";
		public override int Generation => 4;
		public override string PokedexEntry => "Its powerful head butt has enough power to shatter even the most durable things upon impact.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MoldBreaker, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 97,
			Attack = 165,
			Defense = 60,
			SpecialAttack = 65,
			SpecialDefense = 50,
			Speed = 58
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Endeavor, },
			[1] = new List<Move>() { MoveFactory.Endeavor, MoveFactory.Headbutt, MoveFactory.Leer, MoveFactory.FocusEnergy, },
			[6] = new List<Move>() { MoveFactory.FocusEnergy, },
			[10] = new List<Move>() { MoveFactory.RockPolish, },
			[15] = new List<Move>() { MoveFactory.TakeDown, },
			[19] = new List<Move>() { MoveFactory.ScaryFace, },
			[24] = new List<Move>() { MoveFactory.Assurance, },
			[28] = new List<Move>() { MoveFactory.SwordsDance, },
			[36] = new List<Move>() { MoveFactory.AncientPower, },
			[43] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[51] = new List<Move>() { MoveFactory.Screech, },
			[58] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
