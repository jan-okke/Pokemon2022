using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Deerling : Pokemon
	{
		public override string Name => "Deerling";
		public override int Generation => 5;
		public override string PokedexEntry => "The turning of the seasons changes the color and scent of this Pokémon's fur. People use it to mark the seasons.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.SapSipper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SereneGrace;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Camouflage, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.DoubleKick, },
			[13] = new List<Move>() { MoveFactory.LeechSeed, },
			[16] = new List<Move>() { MoveFactory.FeintAttack, },
			[20] = new List<Move>() { MoveFactory.TakeDown, },
			[24] = new List<Move>() { MoveFactory.JumpKick, },
			[28] = new List<Move>() { MoveFactory.Aromatherapy, },
			[32] = new List<Move>() { MoveFactory.EnergyBall, },
			[36] = new List<Move>() { MoveFactory.Charm, },
			[41] = new List<Move>() { MoveFactory.NaturePower, },
			[46] = new List<Move>() { MoveFactory.DoubleEdge, },
			[51] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}
