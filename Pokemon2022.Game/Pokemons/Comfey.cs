using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Comfey : Pokemon
	{
		public override string Name => "Comfey";
		public override int Generation => 7;
		public override string PokedexEntry => "Baths prepared with the flowers from its vine have a relaxing effect, so this Pokémon is a hit with many people.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlowerVeil, AbilityFactory.Triage, };
		public override Ability AvailableHiddenAbility => AbilityFactory.NaturalCure;
		public override Stats BaseStats => new Stats() {
			HP = 51,
			Attack = 52,
			Defense = 90,
			SpecialAttack = 82,
			SpecialDefense = 110,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.Growth, },
			[3] = new List<Move>() { MoveFactory.VineWhip, },
			[6] = new List<Move>() { MoveFactory.HelpingHand, },
			[9] = new List<Move>() { MoveFactory.DrainingKiss, },
			[12] = new List<Move>() { MoveFactory.FlowerShield, },
			[15] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[18] = new List<Move>() { MoveFactory.Synthesis, },
			[21] = new List<Move>() { MoveFactory.LeechSeed, },
			[24] = new List<Move>() { MoveFactory.GrassKnot, },
			[27] = new List<Move>() { MoveFactory.SweetKiss, },
			[30] = new List<Move>() { MoveFactory.FloralHealing, },
			[33] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[36] = new List<Move>() { MoveFactory.Aromatherapy, },
			[39] = new List<Move>() { MoveFactory.PlayRough, },
			[42] = new List<Move>() { MoveFactory.SweetScent, },
			[45] = new List<Move>() { MoveFactory.PetalDance, },
			[48] = new List<Move>() { MoveFactory.GrassyTerrain, },
		};
	}
}
