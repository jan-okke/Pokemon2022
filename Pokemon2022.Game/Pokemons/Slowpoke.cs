using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Slowpoke : Pokemon
	{
		public override string Name => "Slowpoke";
		public override int Generation => 1;
		public override string PokedexEntry => "It catches prey by dipping its tail in water at the side of a river. But it often forgets what it is doing and spends whole days just loafing at the water's edge.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.OwnTempo, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 65,
			Defense = 65,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Curse, },
			[3] = new List<Move>() { MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[9] = new List<Move>() { MoveFactory.Yawn, },
			[12] = new List<Move>() { MoveFactory.Confusion, },
			[15] = new List<Move>() { MoveFactory.Disable, },
			[18] = new List<Move>() { MoveFactory.WaterPulse, },
			[21] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[27] = new List<Move>() { MoveFactory.Amnesia, },
			[30] = new List<Move>() { MoveFactory.Surf, },
			[33] = new List<Move>() { MoveFactory.SlackOff, },
			[36] = new List<Move>() { MoveFactory.Psychic, },
			[39] = new List<Move>() { MoveFactory.PsychUp, },
			[42] = new List<Move>() { MoveFactory.RainDance, },
			[45] = new List<Move>() { MoveFactory.HealPulse, },
		};
	}
}
