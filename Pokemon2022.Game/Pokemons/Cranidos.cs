using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cranidos : Pokemon
	{
		public override string Name => "Cranidos";
		public override int Generation => 4;
		public override string PokedexEntry => "It lived in jungles around 100 million years ago. Its skull is as hard as iron.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MoldBreaker, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 67,
			Attack = 125,
			Defense = 40,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 58
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Headbutt, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.FocusEnergy, },
			[10] = new List<Move>() { MoveFactory.RockPolish, },
			[15] = new List<Move>() { MoveFactory.TakeDown, },
			[19] = new List<Move>() { MoveFactory.ScaryFace, },
			[24] = new List<Move>() { MoveFactory.Assurance, },
			[28] = new List<Move>() { MoveFactory.SwordsDance, },
			[33] = new List<Move>() { MoveFactory.AncientPower, },
			[37] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[42] = new List<Move>() { MoveFactory.Screech, },
			[46] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}
