using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Trumbeak : Pokemon
	{
		public override string Name => "Trumbeak";
		public override int Generation => 7;
		public override string PokedexEntry => "It eats berries and stores their seeds in its beak. When it encounters enemies or prey, it fires off all the seeds in a burst.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.SkillLink, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickup;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 85,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.RockBlast, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.EchoedVoice, MoveFactory.RockSmash, },
			[3] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.EchoedVoice, },
			[9] = new List<Move>() { MoveFactory.RockSmash, },
			[13] = new List<Move>() { MoveFactory.Supersonic, },
			[16] = new List<Move>() { MoveFactory.Pluck, },
			[21] = new List<Move>() { MoveFactory.Roost, },
			[24] = new List<Move>() { MoveFactory.FuryAttack, },
			[29] = new List<Move>() { MoveFactory.Screech, },
			[32] = new List<Move>() { MoveFactory.DrillPeck, },
			[37] = new List<Move>() { MoveFactory.BulletSeed, },
			[40] = new List<Move>() { MoveFactory.FeatherDance, },
			[45] = new List<Move>() { MoveFactory.HyperVoice, },
		};
	}
}
