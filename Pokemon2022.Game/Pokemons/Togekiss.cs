using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Togekiss : Pokemon
	{
		public override string Name => "Togekiss";
		public override int Generation => 4;
		public override string PokedexEntry => "It will never appear where there is strife. Its sightings have become rare recently.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hustle, AbilityFactory.SereneGrace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SuperLuck;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 50,
			Defense = 95,
			SpecialAttack = 120,
			SpecialDefense = 115,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AirSlash, },
			[1] = new List<Move>() { MoveFactory.AirSlash, MoveFactory.FairyWind, MoveFactory.SkyAttack, MoveFactory.AuraSphere, MoveFactory.ExtremeSpeed, MoveFactory.TriAttack, MoveFactory.Charm, MoveFactory.AncientPower, MoveFactory.Yawn, MoveFactory.Metronome, MoveFactory.AfterYou, MoveFactory.DoubleEdge, MoveFactory.Safeguard, MoveFactory.FollowMe, MoveFactory.BatonPass, MoveFactory.LastResort, MoveFactory.Wish, MoveFactory.Growl, MoveFactory.Pound, MoveFactory.SweetKiss, MoveFactory.LifeDew, },
		};
	}
}
