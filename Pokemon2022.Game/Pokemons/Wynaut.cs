using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wynaut : Pokemon
	{
		public override string Name => "Wynaut";
		public override int Generation => 3;
		public override string PokedexEntry => "A Wynaut loves to eat sweet fruits. It cleverly picks fruits using its earlike arms. They gather in fruit gardens, drawn by the fragrance.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShadowTag, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 23,
			Defense = 48,
			SpecialAttack = 23,
			SpecialDefense = 48,
			Speed = 23
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Counter, MoveFactory.MirrorCoat, MoveFactory.Safeguard, MoveFactory.DestinyBond, MoveFactory.Splash, MoveFactory.Charm, MoveFactory.Encore, MoveFactory.Amnesia, },
		};
	}
}
