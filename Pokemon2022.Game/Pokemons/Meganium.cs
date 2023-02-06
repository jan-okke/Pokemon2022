using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Meganium : Pokemon
	{
		public override string Name => "Meganium";
		public override int Generation => 2;
		public override string PokedexEntry => "The fragrance of a Meganium's flower soothes and calms emotions. In battle, it gives off more of its becalming scent to blunt the foe's fighting spirit.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LeafGuard;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 82,
			Defense = 100,
			SpecialAttack = 83,
			SpecialDefense = 100,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PetalDance, },
			[1] = new List<Move>() { MoveFactory.PetalDance, MoveFactory.PetalBlizzard, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.RazorLeaf, MoveFactory.PoisonPowder, },
			[6] = new List<Move>() { MoveFactory.RazorLeaf, },
			[9] = new List<Move>() { MoveFactory.PoisonPowder, },
			[12] = new List<Move>() { MoveFactory.Synthesis, },
			[18] = new List<Move>() { MoveFactory.Reflect, },
			[22] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[26] = new List<Move>() { MoveFactory.NaturePower, },
			[34] = new List<Move>() { MoveFactory.SweetScent, },
			[40] = new List<Move>() { MoveFactory.LightScreen, },
			[46] = new List<Move>() { MoveFactory.BodySlam, },
			[54] = new List<Move>() { MoveFactory.Safeguard, },
			[60] = new List<Move>() { MoveFactory.Aromatherapy, },
			[66] = new List<Move>() { MoveFactory.SolarBeam, },
			[70] = new List<Move>() { MoveFactory.PetalBlizzard, },
		};
	}
}
