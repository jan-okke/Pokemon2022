using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rolycoly : Pokemon
	{
		public override string Name => "Rolycoly";
		public override int Generation => 8;
		public override string PokedexEntry => "Most of its body has the same composition as coal. Fittingly, this Pokémon was first discovered in coal mines about 400 years ago.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SteamEngine, AbilityFactory.Heatproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlashFire;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 40,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Smokescreen, },
			[5] = new List<Move>() { MoveFactory.RapidSpin, },
			[10] = new List<Move>() { MoveFactory.SmackDown, },
			[15] = new List<Move>() { MoveFactory.RockPolish, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[25] = new List<Move>() { MoveFactory.Incinerate, },
			[30] = new List<Move>() { MoveFactory.StealthRock, },
			[35] = new List<Move>() { MoveFactory.HeatCrash, },
			[40] = new List<Move>() { MoveFactory.RockBlast, },
		};
	}
}
