using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Aegislash : Pokemon
	{
		public override string Name => "Aegislash";
		public override int Generation => 6;
		public override string PokedexEntry => "In this defensive stance, Aegislash uses its steel body and a force field of spectral power to reduce the damage of any attack.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.StanceChange, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 50,
			Defense = 140,
			SpecialAttack = 50,
			SpecialDefense = 140,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.KingsShield, },
			[1] = new List<Move>() { MoveFactory.KingsShield, MoveFactory.HeadSmash, MoveFactory.AerialAce, MoveFactory.MetalSound, MoveFactory.Slash, MoveFactory.NightSlash, MoveFactory.Retaliate, MoveFactory.IronDefense, MoveFactory.IronHead, MoveFactory.PowerTrick, MoveFactory.SwordsDance, MoveFactory.SacredSword, MoveFactory.Tackle, MoveFactory.FuryCutter, MoveFactory.ShadowSneak, MoveFactory.Autotomize, },
		};
	}
}
