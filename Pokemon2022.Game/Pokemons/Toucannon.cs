using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Toucannon : Pokemon
	{
		public override string Name => "Toucannon";
		public override int Generation => 7;
		public override string PokedexEntry => "They smack beaks with others of their kind to communicate. The strength and number of hits tell each other how they feel.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.SkillLink, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 120,
			Defense = 75,
			SpecialAttack = 75,
			SpecialDefense = 75,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.BeakBlast, },
			[1] = new List<Move>() { MoveFactory.BeakBlast, MoveFactory.RockBlast, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.EchoedVoice, MoveFactory.RockSmash, },
			[3] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.EchoedVoice, },
			[9] = new List<Move>() { MoveFactory.RockSmash, },
			[13] = new List<Move>() { MoveFactory.Supersonic, },
			[16] = new List<Move>() { MoveFactory.Pluck, },
			[21] = new List<Move>() { MoveFactory.Roost, },
			[24] = new List<Move>() { MoveFactory.FuryAttack, },
			[28] = new List<Move>() { MoveFactory.BeakBlast, },
			[30] = new List<Move>() { MoveFactory.Screech, },
			[34] = new List<Move>() { MoveFactory.DrillPeck, },
			[40] = new List<Move>() { MoveFactory.BulletSeed, },
			[44] = new List<Move>() { MoveFactory.FeatherDance, },
			[50] = new List<Move>() { MoveFactory.HyperVoice, },
		};
	}
}
