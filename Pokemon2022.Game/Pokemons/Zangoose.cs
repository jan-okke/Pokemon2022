using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zangoose : Pokemon
	{
		public override string Name => "Zangoose";
		public override int Generation => 3;
		public override string PokedexEntry => "When it battles, it stands on its hind legs and attacks with its sharply clawed forelegs. Its fur bristles if it encounters any Seviper.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Immunity, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ToxicBoost;
		public override Stats BaseStats => new Stats() {
			HP = 73,
			Attack = 115,
			Defense = 60,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[8] = new List<Move>() { MoveFactory.FuryCutter, },
			[12] = new List<Move>() { MoveFactory.HoneClaws, },
			[15] = new List<Move>() { MoveFactory.AerialAce, },
			[19] = new List<Move>() { MoveFactory.Slash, },
			[22] = new List<Move>() { MoveFactory.Revenge, },
			[26] = new List<Move>() { MoveFactory.CrushClaw, },
			[29] = new List<Move>() { MoveFactory.FalseSwipe, },
			[33] = new List<Move>() { MoveFactory.Facade, },
			[36] = new List<Move>() { MoveFactory.Detect, },
			[40] = new List<Move>() { MoveFactory.XScissor, },
			[43] = new List<Move>() { MoveFactory.Taunt, },
			[47] = new List<Move>() { MoveFactory.SwordsDance, },
			[50] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}
