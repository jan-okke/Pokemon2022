using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wobbuffet : Pokemon
	{
		public override string Name => "Wobbuffet";
		public override int Generation => 2;
		public override string PokedexEntry => "Usually docile, a Wobbuffet strikes back ferociously if its black tail is attacked. It makes its lair in caves where it waits for nightfall.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShadowTag, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 190,
			Attack = 33,
			Defense = 58,
			SpecialAttack = 33,
			SpecialDefense = 58,
			Speed = 33
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Counter, MoveFactory.MirrorCoat, MoveFactory.Safeguard, MoveFactory.DestinyBond, },
			[1] = new List<Move>() { MoveFactory.Splash, MoveFactory.Charm, MoveFactory.Encore, MoveFactory.Amnesia, MoveFactory.Counter, MoveFactory.MirrorCoat, MoveFactory.Safeguard, MoveFactory.DestinyBond, },
		};
	}
}
