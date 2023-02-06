using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Eelektross : Pokemon
	{
		public override string Name => "Eelektross";
		public override int Generation => 5;
		public override string PokedexEntry => "With their sucker mouths, they suck in prey. Then they use their fangs to shock the prey with electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 115,
			Defense = 80,
			SpecialAttack = 105,
			SpecialDefense = 80,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Crunch, MoveFactory.Thrash, MoveFactory.ZapCannon, MoveFactory.GastroAcid, MoveFactory.Coil, MoveFactory.IonDeluge, MoveFactory.CrushClaw, MoveFactory.Headbutt, MoveFactory.Acid, MoveFactory.Discharge, },
		};
	}
}
