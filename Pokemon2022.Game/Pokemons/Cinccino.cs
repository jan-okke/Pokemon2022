using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cinccino : Pokemon
	{
		public override string Name => "Cinccino";
		public override int Generation => 5;
		public override string PokedexEntry => "Their white fur feels amazing to touch. Their fur repels dust and prevents static electricity from building up.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.Technician, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SkillLink;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 95,
			Defense = 60,
			SpecialAttack = 65,
			SpecialDefense = 60,
			Speed = 115
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.BulletSeed, MoveFactory.RockBlast, MoveFactory.Sing, MoveFactory.Charm, MoveFactory.Swift, MoveFactory.Encore, MoveFactory.AfterYou, MoveFactory.TailSlap, MoveFactory.Tickle, MoveFactory.Slam, MoveFactory.HyperVoice, MoveFactory.LastResort, MoveFactory.Pound, MoveFactory.BabyDollEyes, MoveFactory.HelpingHand, MoveFactory.EchoedVoice, },
		};
	}
}
