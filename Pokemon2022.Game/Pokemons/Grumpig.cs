using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Grumpig : Pokemon
	{
		public override string Name => "Grumpig";
		public override int Generation => 3;
		public override string PokedexEntry => "It stores power in the black pearls on its forehead. When it uses psychic power, it performs an odd dance step. Its style of dancing became hugely popular overseas.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 45,
			Defense = 65,
			SpecialAttack = 90,
			SpecialDefense = 110,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.TeeterDance, },
			[1] = new List<Move>() { MoveFactory.TeeterDance, MoveFactory.Belch, MoveFactory.Splash, },
			[7] = new List<Move>() { MoveFactory.Confusion, },
			[10] = new List<Move>() { MoveFactory.Growl, },
			[14] = new List<Move>() { MoveFactory.Psybeam, },
			[15] = new List<Move>() { MoveFactory.PsychUp, },
			[18] = new List<Move>() { MoveFactory.ConfuseRay, },
			[21] = new List<Move>() { MoveFactory.MagicCoat, },
			[26] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[29] = new List<Move>() { MoveFactory.PowerGem, },
			[35] = new List<Move>() { MoveFactory.Rest, MoveFactory.Snore, },
			[42] = new List<Move>() { MoveFactory.Psyshock, },
			[46] = new List<Move>() { MoveFactory.Payback, },
			[52] = new List<Move>() { MoveFactory.Psychic, },
			[60] = new List<Move>() { MoveFactory.Bounce, },
		};
	}
}
