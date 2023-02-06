using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Growlithe : Pokemon
	{
		public override string Name => "Growlithe";
		public override int Generation => 1;
		public override string PokedexEntry => "Its superb sense of smell ensures that this Pokémon won't forget any scent, no matter what. It uses its sense of smell to detect the emotions of others.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Justified;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 70,
			Defense = 45,
			SpecialAttack = 70,
			SpecialDefense = 50,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Ember, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Howl, },
			[8] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.FlameWheel, },
			[16] = new List<Move>() { MoveFactory.HelpingHand, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[24] = new List<Move>() { MoveFactory.FireFang, },
			[28] = new List<Move>() { MoveFactory.Retaliate, },
			[32] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.TakeDown, },
			[40] = new List<Move>() { MoveFactory.Flamethrower, },
			[44] = new List<Move>() { MoveFactory.Roar, },
			[48] = new List<Move>() { MoveFactory.PlayRough, },
			[52] = new List<Move>() { MoveFactory.Reversal, },
			[56] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}
