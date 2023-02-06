using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spoink : Pokemon
	{
		public override string Name => "Spoink";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that manipulates psychic power at will. It doesn't stop bouncing even when it is asleep. It loves eating mushrooms that grow underground.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 25,
			Defense = 35,
			SpecialAttack = 70,
			SpecialDefense = 80,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, },
			[7] = new List<Move>() { MoveFactory.Confusion, },
			[10] = new List<Move>() { MoveFactory.Growl, },
			[14] = new List<Move>() { MoveFactory.Psybeam, },
			[15] = new List<Move>() { MoveFactory.PsychUp, },
			[18] = new List<Move>() { MoveFactory.ConfuseRay, },
			[21] = new List<Move>() { MoveFactory.MagicCoat, },
			[26] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[29] = new List<Move>() { MoveFactory.PowerGem, MoveFactory.Rest, },
			[33] = new List<Move>() { MoveFactory.Snore, },
			[38] = new List<Move>() { MoveFactory.Psyshock, },
			[40] = new List<Move>() { MoveFactory.Payback, },
			[44] = new List<Move>() { MoveFactory.Psychic, },
			[50] = new List<Move>() { MoveFactory.Bounce, },
		};
	}
}
