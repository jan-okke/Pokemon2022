using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Snubbull : Pokemon
	{
		public override string Name => "Snubbull";
		public override int Generation => 2;
		public override string PokedexEntry => "By baring its fangs and making a scary face, it sends smaller Pokémon scurrying in terror. The Snubbull does seem a little sad at making its foes flee.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.RunAway, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 80,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.ThunderFang, MoveFactory.Tackle, MoveFactory.ScaryFace, MoveFactory.TailWhip, MoveFactory.Charm, },
			[7] = new List<Move>() { MoveFactory.Bite, },
			[13] = new List<Move>() { MoveFactory.Lick, },
			[19] = new List<Move>() { MoveFactory.Headbutt, },
			[25] = new List<Move>() { MoveFactory.Roar, },
			[31] = new List<Move>() { MoveFactory.Taunt, },
			[37] = new List<Move>() { MoveFactory.PlayRough, },
			[43] = new List<Move>() { MoveFactory.Payback, },
			[49] = new List<Move>() { MoveFactory.Crunch, },
		};
	}
}
