using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Stantler : Pokemon
	{
		public override string Name => "Stantler";
		public override int Generation => 2;
		public override string PokedexEntry => "Stantler's magnificent antlers were once traded at high prices as works of art. As a result, this Pokémon was hunted close to extinction.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SapSipper;
		public override Stats BaseStats => new Stats() {
			HP = 73,
			Attack = 95,
			Defense = 62,
			SpecialAttack = 85,
			SpecialDefense = 65,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[3] = new List<Move>() { MoveFactory.Leer, },
			[7] = new List<Move>() { MoveFactory.Astonish, },
			[10] = new List<Move>() { MoveFactory.Hypnosis, },
			[13] = new List<Move>() { MoveFactory.Stomp, },
			[16] = new List<Move>() { MoveFactory.SandAttack, },
			[21] = new List<Move>() { MoveFactory.TakeDown, },
			[23] = new List<Move>() { MoveFactory.ConfuseRay, },
			[27] = new List<Move>() { MoveFactory.CalmMind, },
			[33] = new List<Move>() { MoveFactory.RolePlay, },
			[38] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[43] = new List<Move>() { MoveFactory.Lunge, },
			[49] = new List<Move>() { MoveFactory.Imprison, },
			[50] = new List<Move>() { MoveFactory.Entrainment, },
			[55] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}
