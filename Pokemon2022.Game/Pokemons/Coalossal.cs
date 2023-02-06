using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Coalossal : Pokemon
	{
		public override string Name => "Coalossal";
		public override int Generation => 8;
		public override string PokedexEntry => "While it's engaged in battle, its mountain of coal will burn bright red, sending off sparks that scorch the surrounding area.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SteamEngine, AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlashFire;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 80,
			Defense = 120,
			SpecialAttack = 80,
			SpecialDefense = 90,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.TarShot, },
			[1] = new List<Move>() { MoveFactory.TarShot, MoveFactory.FlameCharge, MoveFactory.Tackle, MoveFactory.Smokescreen, MoveFactory.RapidSpin, MoveFactory.SmackDown, },
			[15] = new List<Move>() { MoveFactory.RockPolish, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[27] = new List<Move>() { MoveFactory.Incinerate, },
			[37] = new List<Move>() { MoveFactory.StealthRock, },
			[45] = new List<Move>() { MoveFactory.HeatCrash, },
			[54] = new List<Move>() { MoveFactory.RockBlast, },
			[63] = new List<Move>() { MoveFactory.BurnUp, },
		};
	}
}
