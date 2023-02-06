using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pikipek : Pokemon
	{
		public override string Name => "Pikipek";
		public override int Generation => 7;
		public override string PokedexEntry => "It pecks at trees with its hard beak. You can get some idea of its mood or condition from the rhythm of its pecking.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.SkillLink, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickup;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 75,
			Defense = 30,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, },
			[3] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.EchoedVoice, },
			[9] = new List<Move>() { MoveFactory.RockSmash, },
			[13] = new List<Move>() { MoveFactory.Supersonic, },
			[15] = new List<Move>() { MoveFactory.Pluck, },
			[19] = new List<Move>() { MoveFactory.Roost, },
			[21] = new List<Move>() { MoveFactory.FuryAttack, },
			[25] = new List<Move>() { MoveFactory.Screech, },
			[27] = new List<Move>() { MoveFactory.DrillPeck, },
			[31] = new List<Move>() { MoveFactory.BulletSeed, },
			[33] = new List<Move>() { MoveFactory.FeatherDance, },
			[37] = new List<Move>() { MoveFactory.HyperVoice, },
		};
	}
}
