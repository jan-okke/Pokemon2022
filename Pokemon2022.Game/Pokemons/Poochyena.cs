using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Poochyena : Pokemon
	{
		public override string Name => "Poochyena";
		public override int Generation => 3;
		public override string PokedexEntry => "It savagely threatens foes with bared fangs. It chases after fleeing targets tenaciously. It turns tail and runs, however, if the foe strikes back.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.QuickFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 55,
			Defense = 35,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Howl, },
			[7] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.Bite, },
			[13] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.Roar, },
			[19] = new List<Move>() { MoveFactory.Swagger, },
			[22] = new List<Move>() { MoveFactory.Assurance, },
			[25] = new List<Move>() { MoveFactory.ScaryFace, },
			[28] = new List<Move>() { MoveFactory.Headbutt, },
			[31] = new List<Move>() { MoveFactory.Taunt, },
			[34] = new List<Move>() { MoveFactory.Crunch, },
			[37] = new List<Move>() { MoveFactory.Yawn, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[43] = new List<Move>() { MoveFactory.SuckerPunch, },
			[46] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}
