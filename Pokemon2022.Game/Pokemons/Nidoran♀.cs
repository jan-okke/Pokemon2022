using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class NidoranF : Pokemon
	{
		public override string Name => "Nidoran♀";
		public override int Generation => 1;
		public override string PokedexEntry => "Its highly toxic barbs are thought to have developed as protection for this small-bodied Pokémon. When enraged, it releases a horrible toxin from its horn.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Rivalry, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 47,
			Defense = 52,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 41
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.PoisonSting, },
			[5] = new List<Move>() { MoveFactory.Scratch, },
			[10] = new List<Move>() { MoveFactory.TailWhip, },
			[15] = new List<Move>() { MoveFactory.FurySwipes, },
			[20] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[25] = new List<Move>() { MoveFactory.DoubleKick, },
			[30] = new List<Move>() { MoveFactory.Bite, },
			[35] = new List<Move>() { MoveFactory.HelpingHand, },
			[40] = new List<Move>() { MoveFactory.Toxic, },
			[45] = new List<Move>() { MoveFactory.Flatter, },
			[50] = new List<Move>() { MoveFactory.Crunch, },
			[55] = new List<Move>() { MoveFactory.EarthPower, },
		};
	}
}
