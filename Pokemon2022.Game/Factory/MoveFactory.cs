using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Names;
using Pokemon2022.Game.Entities.Enums;
using System.Collections.Generic;

namespace Pokemon2022.Game.Factory
{
	public class MoveFactory
	{
		public static Move Megahorn = new ()
		{
			Name = MoveNames.MEGAHORN,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Using its tough and impressive horn, the user rams into the target with no letup.",
		};
		public static Move AttackOrder = new ()
		{
			Name = MoveNames.ATTACKORDER,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			HasHighCritRate = true,
			Description = "The user calls out its underlings to pummel the target. Critical hits land more easily.",
		};
		public static Move BugBuzz = new ()
		{
			Name = MoveNames.BUGBUZZ,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "The user vibrates its wings to generate a damaging sound wave. It may also lower the target's Sp. Def stat.",
		};
		public static Move FirstImpression = new ()
		{
			Name = MoveNames.FIRSTIMPRESSION,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Priority = 2,
			IsContactMove = true,
			Description = "Although this move has great power, it only works the first turn the user is in battle.",
		};
		public static Move PollenPuff = new ()
		{
			Name = MoveNames.POLLENPUFF,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "Fires an exploding pollen puff at enemies, or a HP-restoring one at allies.",
		};
		public static Move LeechLife = new ()
		{
			Name = MoveNames.LEECHLIFE,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user drains the target's blood. The user's HP is restored by half the damage taken by the target.",
		};
		public static Move Lunge = new ()
		{
			Name = MoveNames.LUNGE,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user makes a lunge at the target, attacking with full force. This lowers the target's Attack stat.",
		};
		public static Move XScissor = new ()
		{
			Name = MoveNames.XSCISSOR,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slashes at the foe by crossing its scythes or claws as if they were a pair of scissors.",
		};
		public static Move SignalBeam = new ()
		{
			Name = MoveNames.SIGNALBEAM,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Special,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user attacks with a sinister beam of light. It may also confuse the target.",
		};
		public static Move SkitterSmack = new ()
		{
			Name = MoveNames.SKITTERSMACK,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user skitters behind the target to attack. This also lowers the target's Sp. Atk stat.",
		};
		public static Move Uturn = new ()
		{
			Name = MoveNames.UTURN,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.",
		};
		public static Move Steamroller = new ()
		{
			Name = MoveNames.STEAMROLLER,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			TramplesMinimize = true,
			Description = "The user crushes its foes by rolling over them. This attack may make the target flinch.",
		};
		public static Move BugBite = new ()
		{
			Name = MoveNames.BUGBITE,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user bites the target. If the target is holding a Berry, the user eats it and gains its effect.",
		};
		public static Move SilverWind = new ()
		{
			Name = MoveNames.SILVERWIND,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The foe is attacked with powdery scales blown by wind. It may also raise all the user's stats.",
		};
		public static Move FellStinger = new ()
		{
			Name = MoveNames.FELLSTINGER,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "When the user knocks out a target with this move, the user's Attack stat rises drastically.",
		};
		public static Move StruggleBug = new ()
		{
			Name = MoveNames.STRUGGLEBUG,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Special,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearFoes,
			Description = "While resisting, the user attacks the opposing Pokémon. The targets' Sp. Atk stat is reduced.",
		};
		public static Move FuryCutter = new ()
		{
			Name = MoveNames.FURYCUTTER,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 95,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is slashed with scythes or claws. Its power increases if it hits in succession.",
		};
		public static Move PinMissile = new ()
		{
			Name = MoveNames.PINMISSILE,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 95,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "Sharp spikes are shot at the target in rapid succession. They hit two to five times in a row.",
		};
		public static Move Twineedle = new ()
		{
			Name = MoveNames.TWINEEDLE,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The foe is stabbed twice by a pair of stingers. It may also poison the target.",
		};
		public static Move Infestation = new ()
		{
			Name = MoveNames.INFESTATION,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Special,
			BasePower = 20,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is infested and unable to flee for four to five turns.",
		};
		public static Move DefendOrder = new ()
		{
			Name = MoveNames.DEFENDORDER,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user calls out its underlings to shield its body, raising its Defense and Sp. Def stats.",
		};
		public static Move HealOrder = new ()
		{
			Name = MoveNames.HEALORDER,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user calls out its underlings to heal it. The user regains up to half of its max HP.",
		};
		public static Move Powder = new ()
		{
			Name = MoveNames.POWDER,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsPowderMove = true,
			Description = "The target is covered in a powder that explodes and damages it if it uses a Fire-type move.",
		};
		public static Move QuiverDance = new ()
		{
			Name = MoveNames.QUIVERDANCE,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			IsDanceMove = true,
			Description = "The user performs a beautiful dance. It boosts the user's Sp. Atk, Sp. Def, and Speed stats.",
		};
		public static Move RagePowder = new ()
		{
			Name = MoveNames.RAGEPOWDER,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Priority = 2,
			IsPowderMove = true,
			Description = "The user scatters irritating powder to draw attention to itself. Opponents aim only at the user.",
		};
		public static Move SpiderWeb = new ()
		{
			Name = MoveNames.SPIDERWEB,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user ensnares the target with thin, gooey silk so it can't flee from battle.",
		};
		public static Move StickyWeb = new ()
		{
			Name = MoveNames.STICKYWEB,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.FoeSide,
			Description = "Weaves a sticky net around the opposing team, which lowers their Speed stats upon switching in.",
		};
		public static Move StringShot = new ()
		{
			Name = MoveNames.STRINGSHOT,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 95,
			PowerPoints = 40,
			Target = MoveTarget.AllNearFoes,
			Description = "The foe is bound with silk blown from the user's mouth. This silk reduces the target's Speed.",
		};
		public static Move TailGlow = new ()
		{
			Name = MoveNames.TAILGLOW,
			MoveType = PokemonType.Bug,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user stares at flashing lights to focus its mind, drastically raising its Sp. Atk stat.",
		};
		public static Move HyperspaceFury = new ()
		{
			Name = MoveNames.HYPERSPACEFURY,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "Unleashes a barrage of multi-arm attacks, skipping protections. The user's Defense stat falls.",
		};
		public static Move FoulPlay = new ()
		{
			Name = MoveNames.FOULPLAY,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 95,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user turns the foe's power against it. It does more damage the higher the target's Attack stat.",
		};
		public static Move FieryWrath = new ()
		{
			Name = MoveNames.FIERYWRATH,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "The user transforms its wrath into a fire-like aura to attack. This may also make foes flinch.",
		};
		public static Move DarkestLariat = new ()
		{
			Name = MoveNames.DARKESTLARIAT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user swings both arms and hits the target. Ignores the target's stat changes.",
		};
		public static Move NightDaze = new ()
		{
			Name = MoveNames.NIGHTDAZE,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Special,
			BasePower = 85,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user lets loose a pitch-black shock wave at its target. It may also lower the target's accuracy.",
		};
		public static Move Crunch = new ()
		{
			Name = MoveNames.CRUNCH,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBitingMove = true,
			Description = "The user crunches up the target with sharp fangs. It may also lower the target's Defense stat.",
		};
		public static Move DarkPulse = new ()
		{
			Name = MoveNames.DARKPULSE,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.Other,
			IsPulseMove = true,
			Description = "The user releases a horrible aura imbued with dark thoughts. It may also make the target flinch.",
		};
		public static Move FalseSurrender = new ()
		{
			Name = MoveNames.FALSESURRENDER,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user pretends to bow its head, but then it stabs the target with its disheveled hair. Never misses.",
		};
		public static Move JawLock = new ()
		{
			Name = MoveNames.JAWLOCK,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "This move prevents the user and the target from switching out until either of them faints.",
		};
		public static Move ThroatChop = new ()
		{
			Name = MoveNames.THROATCHOP,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks the target's throat. The target cannot use sound-based moves for two turns.",
		};
		public static Move WickedBlow = new ()
		{
			Name = MoveNames.WICKEDBLOW,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Strikes with a fierce blow through mastery of the Dark style. Always results in a critical hit.",
		};
		public static Move LashOut = new ()
		{
			Name = MoveNames.LASHOUT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user lashes out to vent its frustration. Power is doubled if its stats dropped this turn.",
		};
		public static Move NightSlash = new ()
		{
			Name = MoveNames.NIGHTSLASH,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The user slashes the target the instant an opportunity arises. Critical hits land more easily.",
		};
		public static Move SuckerPunch = new ()
		{
			Name = MoveNames.SUCKERPUNCH,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Priority = 1,
			IsContactMove = true,
			Description = "This move enables the user to attack first. It fails if the target is not readying an attack, however.",
		};
		public static Move KnockOff = new ()
		{
			Name = MoveNames.KNOCKOFF,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slaps down the target's held item, preventing that item from being used in the battle.",
		};
		public static Move Assurance = new ()
		{
			Name = MoveNames.ASSURANCE,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "If the target has already taken some damage in the same turn, this attack's power is doubled.",
		};
		public static Move Bite = new ()
		{
			Name = MoveNames.BITE,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBitingMove = true,
			Description = "The target is bitten with viciously sharp fangs. It may make the target flinch.",
		};
		public static Move BrutalSwing = new ()
		{
			Name = MoveNames.BRUTALSWING,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearOthers,
			IsContactMove = true,
			Description = "The user swings its body around violently to inflict damage on everything in its vicinity.",
		};
		public static Move FeintAttack = new ()
		{
			Name = MoveNames.FEINTATTACK,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user draws up to the foe disarmingly, then throws a sucker punch. It hits without fail.",
		};
		public static Move Thief = new ()
		{
			Name = MoveNames.THIEF,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks and steals the foe's held item simultaneously. It can't steal if the user holds an item.",
		};
		public static Move Snarl = new ()
		{
			Name = MoveNames.SNARL,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Special,
			BasePower = 55,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.AllNearFoes,
			IsSoundMove = true,
			Description = "The user yells as if it is ranting about something, making the target's Sp. Atk stat decrease.",
		};
		public static Move Payback = new ()
		{
			Name = MoveNames.PAYBACK,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "If the user moves after the target, this attack's power will be doubled.",
		};
		public static Move Pursuit = new ()
		{
			Name = MoveNames.PURSUIT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "An attack move that inflicts double damage if used on a target that is switching out of battle.",
		};
		public static Move BeatUp = new ()
		{
			Name = MoveNames.BEATUP,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user gets all the party Pokémon to attack the foe. The more party Pokémon, the more damage.",
		};
		public static Move Fling = new ()
		{
			Name = MoveNames.FLING,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user flings its held item at the target to attack. Its power and effects depend on the item.",
		};
		public static Move PowerTrip = new ()
		{
			Name = MoveNames.POWERTRIP,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user boasts of its strength. Power increases the more the user's stats are raised.",
		};
		public static Move Punishment = new ()
		{
			Name = MoveNames.PUNISHMENT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "This attack's power increases the more the target has powered up with stat changes.",
		};
		public static Move DarkVoid = new ()
		{
			Name = MoveNames.DARKVOID,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 50,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "Opposing Pokémon are dragged into a world of total darkness that makes them sleep.",
		};
		public static Move Embargo = new ()
		{
			Name = MoveNames.EMBARGO,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "It prevents the target from using its held item. Its Trainer is also prevented from using items on it.",
		};
		public static Move FakeTears = new ()
		{
			Name = MoveNames.FAKETEARS,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user feigns crying to fluster the target, harshly lowering its Sp. Def stat.",
		};
		public static Move Flatter = new ()
		{
			Name = MoveNames.FLATTER,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "Flattery is used to confuse the target. However, it also raises the target's Sp. Atk stat.",
		};
		public static Move HoneClaws = new ()
		{
			Name = MoveNames.HONECLAWS,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.User,
			Description = "The user sharpens its claws to boost its Attack stat and accuracy.",
		};
		public static Move Memento = new ()
		{
			Name = MoveNames.MEMENTO,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user faints when using this move. In return, it harshly lowers the target's Attack and Sp. Atk.",
		};
		public static Move NastyPlot = new ()
		{
			Name = MoveNames.NASTYPLOT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user stimulates its brain by thinking bad thoughts. It sharply raises the user's Sp. Atk.",
		};
		public static Move Obstruct = new ()
		{
			Name = MoveNames.OBSTRUCT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "The user protects itself from all attacks. Direct contact lowers the attacker's Defense.",
		};
		public static Move PartingShot = new ()
		{
			Name = MoveNames.PARTINGSHOT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "With a parting threat, the user lowers the target's Attack and Sp. Atk stats. Then it switches out.",
		};
		public static Move Quash = new ()
		{
			Name = MoveNames.QUASH,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user suppresses the target and makes its move go last.",
		};
		public static Move Snatch = new ()
		{
			Name = MoveNames.SNATCH,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "The user steals the effects of any healing or stat-changing move the foe attempts to use.",
		};
		public static Move Switcheroo = new ()
		{
			Name = MoveNames.SWITCHEROO,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user trades held items with the target faster than the eye can follow.",
		};
		public static Move Taunt = new ()
		{
			Name = MoveNames.TAUNT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The target is taunted into a rage that allows it to use only attack moves for three turns.",
		};
		public static Move TopsyTurvy = new ()
		{
			Name = MoveNames.TOPSYTURVY,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "All stat changes affecting the target turn topsy-turvy and become the opposite of what they were.",
		};
		public static Move Torment = new ()
		{
			Name = MoveNames.TORMENT,
			MoveType = PokemonType.Dark,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user torments and enrages the foe, making it incapable of using the same move twice in a row.",
		};
		public static Move Eternabeam = new ()
		{
			Name = MoveNames.ETERNABEAM,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 160,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "This is Eternatus's most powerful attack in its original form. The user can't move on the next turn.",
		};
		public static Move DragonEnergy = new ()
		{
			Name = MoveNames.DRAGONENERGY,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Description = "Converts life-force into power to attack. The lower the user's HP, the lower the move's power.",
		};
		public static Move RoarofTime = new ()
		{
			Name = MoveNames.ROAROFTIME,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user blasts the target with power that distorts even time. The user must rest on the next turn.",
		};
		public static Move DracoMeteor = new ()
		{
			Name = MoveNames.DRACOMETEOR,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 130,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "Comets are summoned down from the sky. The attack's recoil harshly reduces the user's Sp. Atk stat.",
		};
		public static Move Outrage = new ()
		{
			Name = MoveNames.OUTRAGE,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.RandomNearFoe,
			IsContactMove = true,
			Description = "The user rampages and attacks for two to three turns. It then becomes confused, however.",
		};
		public static Move ClangingScales = new ()
		{
			Name = MoveNames.CLANGINGSCALES,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 110,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			IsSoundMove = true,
			Description = "The user rubs its scales and makes a huge noise. Also lowers the user's Defense stat.",
		};
		public static Move CoreEnforcer = new ()
		{
			Name = MoveNames.COREENFORCER,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "If the target has already moved this turn, the effect of its Ability is negated.",
		};
		public static Move DragonRush = new ()
		{
			Name = MoveNames.DRAGONRUSH,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 75,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			TramplesMinimize = true,
			Description = "The user tackles the foe while exhibiting overwhelming menace. It may also make the target flinch.",
		};
		public static Move DynamaxCannon = new ()
		{
			Name = MoveNames.DYNAMAXCANNON,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user unleashes a strong beam from its core.",
		};
		public static Move SpacialRend = new ()
		{
			Name = MoveNames.SPACIALREND,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 95,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			HasHighCritRate = true,
			Description = "The user tears the target along with the space around it. Critical hits land more easily.",
		};
		public static Move DragonHammer = new ()
		{
			Name = MoveNames.DRAGONHAMMER,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user uses its body like a hammer to attack the target and inflict damage.",
		};
		public static Move DragonPulse = new ()
		{
			Name = MoveNames.DRAGONPULSE,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.Other,
			IsPulseMove = true,
			Description = "The target is attacked with a shock wave generated by the user's gaping mouth.",
		};
		public static Move DragonClaw = new ()
		{
			Name = MoveNames.DRAGONCLAW,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slashes the target with huge, sharp claws.",
		};
		public static Move BreakingSwipe = new ()
		{
			Name = MoveNames.BREAKINGSWIPE,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.AllNearFoes,
			IsContactMove = true,
			Description = "The user swings its tough tail wildly and attacks all foes. This also lowers their Attack stats.",
		};
		public static Move DragonBreath = new ()
		{
			Name = MoveNames.DRAGONBREATH,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user exhales a mighty gust that inflicts damage. It may also leave the target with paralysis.",
		};
		public static Move DragonTail = new ()
		{
			Name = MoveNames.DRAGONTAIL,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Priority = -6,
			IsContactMove = true,
			Description = "The user knocks away the target and drags out another Pokémon in its party. In the wild, the battle ends.",
		};
		public static Move DragonDarts = new ()
		{
			Name = MoveNames.DRAGONDARTS,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user attacks twice using Dreepy. If there are two targets, this move hits each one once.",
		};
		public static Move DualChop = new ()
		{
			Name = MoveNames.DUALCHOP,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 90,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks its target by hitting it with brutal strikes. The target is hit twice in a row.",
		};
		public static Move Twister = new ()
		{
			Name = MoveNames.TWISTER,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearFoes,
			Description = "The user whips up a vicious tornado to tear at the opposing team. It may also make targets flinch.",
		};
		public static Move ScaleShot = new ()
		{
			Name = MoveNames.SCALESHOT,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 90,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "Attacks by shooting scales two to five times in a row. Boosts the user's Speed but lowers its Defense.",
		};
		public static Move DragonRage = new ()
		{
			Name = MoveNames.DRAGONRAGE,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "This attack hits the target with a shock wave of pure rage. This attack always inflicts 40 HP damage.",
		};
		public static Move ClangorousSoul = new ()
		{
			Name = MoveNames.CLANGOROUSSOUL,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.User,
			IsSoundMove = true,
			Description = "The user raises all its stats by using some of its HP.",
		};
		public static Move DragonDance = new ()
		{
			Name = MoveNames.DRAGONDANCE,
			MoveType = PokemonType.Dragon,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			IsDanceMove = true,
			Description = "The user vigorously performs a mystic, powerful dance that boosts its Attack and Speed stats.",
		};
		public static Move BoltStrike = new ()
		{
			Name = MoveNames.BOLTSTRIKE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 130,
			Accuracy = 85,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user charges at its foe, surrounding itself with lightning. It may also leave the target paralyzed.",
		};
		public static Move VoltTackle = new ()
		{
			Name = MoveNames.VOLTTACKLE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user electrifies itself, then charges at the foe. It causes considerable damage to the user as well.",
		};
		public static Move ZapCannon = new ()
		{
			Name = MoveNames.ZAPCANNON,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 50,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user fires an electric blast like a cannon to inflict damage and cause paralysis.",
		};
		public static Move AuraWheel = new ()
		{
			Name = MoveNames.AURAWHEEL,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 110,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "Morpeko attacks and raises its Speed with energy stored in its cheeks. Type changes with the user's form.",
		};
		public static Move Thunder = new ()
		{
			Name = MoveNames.THUNDER,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 110,
			Accuracy = 70,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A wicked thunderbolt is dropped on the foe to inflict damage. It may also leave the target paralyzed.",
		};
		public static Move FusionBolt = new ()
		{
			Name = MoveNames.FUSIONBOLT,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user throws down a giant thunderbolt. It does more damage if influenced by an enormous flame.",
		};
		public static Move PlasmaFists = new ()
		{
			Name = MoveNames.PLASMAFISTS,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user attacks with electrically charged fists. Normal-type moves become Electric-type.",
		};
		public static Move Thunderbolt = new ()
		{
			Name = MoveNames.THUNDERBOLT,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "A strong electric blast is loosed at the target. It may also leave the target with paralysis.",
		};
		public static Move WildCharge = new ()
		{
			Name = MoveNames.WILDCHARGE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user shrouds itself in electricity and smashes into its foe. It also damages the user a little.",
		};
		public static Move BoltBeak = new ()
		{
			Name = MoveNames.BOLTBEAK,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Stabs the target with an electrified beak. Power is doubled if the user attacks first.",
		};
		public static Move Discharge = new ()
		{
			Name = MoveNames.DISCHARGE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.AllNearOthers,
			Description = "A flare of electricity is loosed to strike the area around the user. It may also cause paralysis.",
		};
		public static Move Overdrive = new ()
		{
			Name = MoveNames.OVERDRIVE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			IsSoundMove = true,
			Description = "The user attacks all foes by twanging a guitar or bass guitar, causing a huge echo and strong vibration.",
		};
		public static Move ThunderCage = new ()
		{
			Name = MoveNames.THUNDERCAGE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 90,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user traps the target in a cage of sparking electricity for four to five turns.",
		};
		public static Move ZingZap = new ()
		{
			Name = MoveNames.ZINGZAP,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A strong electric blast crashes down on the target. This may also make the target flinch.",
		};
		public static Move ThunderPunch = new ()
		{
			Name = MoveNames.THUNDERPUNCH,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The target is punched with an electrified fist. It may also leave the target with paralysis.",
		};
		public static Move RisingVoltage = new ()
		{
			Name = MoveNames.RISINGVOLTAGE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user attacks with electric voltage rising from the ground. Power is doubled on Electric Terrain.",
		};
		public static Move VoltSwitch = new ()
		{
			Name = MoveNames.VOLTSWITCH,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.",
		};
		public static Move ParabolicCharge = new ()
		{
			Name = MoveNames.PARABOLICCHARGE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearOthers,
			Description = "The user attacks everything around it. The user's HP is restored by half the damage dealt.",
		};
		public static Move Spark = new ()
		{
			Name = MoveNames.SPARK,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user throws an electrically charged tackle at the target. It may also leave the target with paralysis.",
		};
		public static Move ThunderFang = new ()
		{
			Name = MoveNames.THUNDERFANG,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBitingMove = true,
			Description = "The user bites with electrified fangs. It may also make the target flinch or leave it with paralysis.",
		};
		public static Move ShockWave = new ()
		{
			Name = MoveNames.SHOCKWAVE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user strikes the target with a quick jolt of electricity. This attack cannot be evaded.",
		};
		public static Move Electroweb = new ()
		{
			Name = MoveNames.ELECTROWEB,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 55,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.AllNearFoes,
			Description = "The user captures and attacks foes by using an electric net, which lowers their Speed stat.",
		};
		public static Move ChargeBeam = new ()
		{
			Name = MoveNames.CHARGEBEAM,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 50,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user fires a concentrated bundle of electricity. It may also raise the user's Sp. Atk stat.",
		};
		public static Move ThunderShock = new ()
		{
			Name = MoveNames.THUNDERSHOCK,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Description = "A jolt of electricity is hurled at the foe to inflict damage. It may also leave the target with paralysis.",
		};
		public static Move Nuzzle = new ()
		{
			Name = MoveNames.NUZZLE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Physical,
			BasePower = 20,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user nuzzles its electrified cheeks against the target. This also leaves the target with paralysis.",
		};
		public static Move ElectroBall = new ()
		{
			Name = MoveNames.ELECTROBALL,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user hurls an electric orb at the foe. It does more damage the faster the user is.",
		};
		public static Move Charge = new ()
		{
			Name = MoveNames.CHARGE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user boosts the power of the Electric move it uses next. It also raises the user's Sp. Def stat.",
		};
		public static Move EerieImpulse = new ()
		{
			Name = MoveNames.EERIEIMPULSE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user's body generates an eerie impulse. Harshly lowers the target's Sp. Atk stat.",
		};
		public static Move ElectricTerrain = new ()
		{
			Name = MoveNames.ELECTRICTERRAIN,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "The user electrifies the ground for five turns. Pokémon on the ground no longer fall asleep.",
		};
		public static Move Electrify = new ()
		{
			Name = MoveNames.ELECTRIFY,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "If the target uses a move after being electrified, that move becomes Electric-type.",
		};
		public static Move IonDeluge = new ()
		{
			Name = MoveNames.IONDELUGE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 25,
			Target = MoveTarget.BothSides,
			Priority = 1,
			Description = "The user disperses electrically charged particles. Normal-type moves become Electric-type.",
		};
		public static Move MagnetRise = new ()
		{
			Name = MoveNames.MAGNETRISE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user levitates using electrically generated magnetism for five turns.",
		};
		public static Move MagneticFlux = new ()
		{
			Name = MoveNames.MAGNETICFLUX,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.UserAndAllies,
			Description = "Manipulates magnetic fields to raise the Defense and Sp. Def stats of allies with Plus or Minus Abilities.",
		};
		public static Move ThunderWave = new ()
		{
			Name = MoveNames.THUNDERWAVE,
			MoveType = PokemonType.Electric,
			Category = MoveCategory.Status,
			Accuracy = 90,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "A weak electric charge is launched at the target. It causes paralysis if it hits.",
		};
		public static Move LightofRuin = new ()
		{
			Name = MoveNames.LIGHTOFRUIN,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 140,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "Fires a powerful beam of light drawn from the Eternal Flower. It also damages the user a lot.",
		};
		public static Move FleurCannon = new ()
		{
			Name = MoveNames.FLEURCANNON,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 130,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user unleashes a strong beam. The attack's recoil harshly lowers the user's Sp. Atk stat.",
		};
		public static Move MistyExplosion = new ()
		{
			Name = MoveNames.MISTYEXPLOSION,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearOthers,
			Description = "The user attacks everything around and faints upon using this move. Power increases on Misty Terrain.",
		};
		public static Move Moonblast = new ()
		{
			Name = MoveNames.MOONBLAST,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 95,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by borrowing the power of the moon. This may also lower the target's Sp. Atk stat.",
		};
		public static Move PlayRough = new ()
		{
			Name = MoveNames.PLAYROUGH,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user plays rough with the target and attacks it. This may also lower the target's Attack stat.",
		};
		public static Move StrangeSteam = new ()
		{
			Name = MoveNames.STRANGESTEAM,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user attacks the target by emitting steam. This may also confuse the target.",
		};
		public static Move DazzlingGleam = new ()
		{
			Name = MoveNames.DAZZLINGGLEAM,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "The user damages opposing Pokémon by emitting a powerful flash.",
		};
		public static Move SpiritBreak = new ()
		{
			Name = MoveNames.SPIRITBREAK,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks the target with immense force. This also lowers the target's Sp. Atk stat.",
		};
		public static Move DrainingKiss = new ()
		{
			Name = MoveNames.DRAININGKISS,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user steals the target's HP with a kiss. The user's HP is restored by over half of the damage dealt.",
		};
		public static Move DisarmingVoice = new ()
		{
			Name = MoveNames.DISARMINGVOICE,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.AllNearFoes,
			IsSoundMove = true,
			Description = "Letting out a charming cry, the user does emotional damage to foes. This attack never misses.",
		};
		public static Move FairyWind = new ()
		{
			Name = MoveNames.FAIRYWIND,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Description = "The user stirs up a fairy wind and strikes the target with it.",
		};
		public static Move NaturesMadness = new ()
		{
			Name = MoveNames.NATURESMADNESS,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user hits the target with the force of nature. It halves the target's HP.",
		};
		public static Move AromaticMist = new ()
		{
			Name = MoveNames.AROMATICMIST,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearAlly,
			Description = "The user raises the Sp. Def stat of an ally Pokémon by using a mysterious aroma.",
		};
		public static Move BabyDollEyes = new ()
		{
			Name = MoveNames.BABYDOLLEYES,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Priority = 1,
			Description = "The user stares with its baby-doll eyes, which lowers the target's Attack stat. Always goes first.",
		};
		public static Move Charm = new ()
		{
			Name = MoveNames.CHARM,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user charmingly gazes at the foe, making it less wary. The target's Attack is harshly lowered.",
		};
		public static Move CraftyShield = new ()
		{
			Name = MoveNames.CRAFTYSHIELD,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.UserSide,
			Priority = 3,
			Description = "The user protects itself and its allies from status moves with a mysterious power.",
		};
		public static Move Decorate = new ()
		{
			Name = MoveNames.DECORATE,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user sharply raises the target's Attack and Sp. Atk stats by decorating the target.",
		};
		public static Move FairyLock = new ()
		{
			Name = MoveNames.FAIRYLOCK,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "By locking down the battlefield, the user keeps all Pokémon from fleeing during the next turn.",
		};
		public static Move FloralHealing = new ()
		{
			Name = MoveNames.FLORALHEALING,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user restores the target's HP by up to half of its max HP. It restores more HP when the terrain is grass.",
		};
		public static Move FlowerShield = new ()
		{
			Name = MoveNames.FLOWERSHIELD,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.AllBattlers,
			Description = "The user raises the Defense stats of all Grass-type Pokémon in battle with a mysterious power.",
		};
		public static Move Geomancy = new ()
		{
			Name = MoveNames.GEOMANCY,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user absorbs energy and sharply raises its Sp. Atk, Sp. Def, and Speed stats on the next turn.",
		};
		public static Move MistyTerrain = new ()
		{
			Name = MoveNames.MISTYTERRAIN,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "The user covers the ground with mist for five turns. Grounded Pokémon can't gain status conditions.",
		};
		public static Move Moonlight = new ()
		{
			Name = MoveNames.MOONLIGHT,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.User,
			Description = "The user restores its own HP. The amount of HP regained varies with the weather.",
		};
		public static Move SweetKiss = new ()
		{
			Name = MoveNames.SWEETKISS,
			MoveType = PokemonType.Fairy,
			Category = MoveCategory.Status,
			Accuracy = 75,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user kisses the target with a sweet, angelic cuteness that causes confusion.",
		};
		public static Move FocusPunch = new ()
		{
			Name = MoveNames.FOCUSPUNCH,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 150,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Priority = -3,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user focuses its mind before launching a punch. It will fail if the user is hit before it is used.",
		};
		public static Move MeteorAssault = new ()
		{
			Name = MoveNames.METEORASSAULT,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 150,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user attacks wildly with its thick leek. The user can't move on the next turn.",
		};
		public static Move HighJumpKick = new ()
		{
			Name = MoveNames.HIGHJUMPKICK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 130,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is attacked with a knee kick from a jump. If it misses, the user is hurt instead.",
		};
		public static Move CloseCombat = new ()
		{
			Name = MoveNames.CLOSECOMBAT,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user fights the foe up close without guarding itself. It also cuts the user's Defense and Sp. Def.",
		};
		public static Move FocusBlast = new ()
		{
			Name = MoveNames.FOCUSBLAST,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 70,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user heightens its mental focus and unleashes its power. It may also lower the target's Sp. Def.",
		};
		public static Move Superpower = new ()
		{
			Name = MoveNames.SUPERPOWER,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks the target with great power. However, it also lowers the user's Attack and Defense.",
		};
		public static Move CrossChop = new ()
		{
			Name = MoveNames.CROSSCHOP,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 80,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The user delivers a double chop with its forearms crossed. Critical hits land more easily.",
		};
		public static Move DynamicPunch = new ()
		{
			Name = MoveNames.DYNAMICPUNCH,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 50,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user punches the target with full, concentrated power. It confuses the target if it hits.",
		};
		public static Move FlyingPress = new ()
		{
			Name = MoveNames.FLYINGPRESS,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.Other,
			IsContactMove = true,
			TramplesMinimize = true,
			Description = "The user dives down onto the target from the sky. This move is Fighting and Flying type simultaneously.",
		};
		public static Move HammerArm = new ()
		{
			Name = MoveNames.HAMMERARM,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user swings and hits with its strong and heavy fist. It lowers the user's Speed, however.",
		};
		public static Move JumpKick = new ()
		{
			Name = MoveNames.JUMPKICK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user jumps up high, then strikes with a kick. If the kick misses, the user hurts itself.",
		};
		public static Move SacredSword = new ()
		{
			Name = MoveNames.SACREDSWORD,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks by slicing with its long horns. The target's stat changes don't affect the damage.",
		};
		public static Move ThunderousKick = new ()
		{
			Name = MoveNames.THUNDEROUSKICK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Overwhelms the target with lightning-like movement, then kicks. Lowers the target's Defense stat.",
		};
		public static Move SecretSword = new ()
		{
			Name = MoveNames.SECRETSWORD,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Special,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user cuts with its long horn. The odd power contained in it does physical damage to the foe.",
		};
		public static Move SkyUppercut = new ()
		{
			Name = MoveNames.SKYUPPERCUT,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 90,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user attacks the target with an uppercut thrown skyward with force.",
		};
		public static Move AuraSphere = new ()
		{
			Name = MoveNames.AURASPHERE,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.Other,
			IsPulseMove = true,
			IsBombMove = true,
			Description = "The user looses a blast of aura power from deep within its body. This move is certain to hit.",
		};
		public static Move BodyPress = new ()
		{
			Name = MoveNames.BODYPRESS,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks by slamming its body into the target. Power increases the higher the user's Defense is.",
		};
		public static Move Submission = new ()
		{
			Name = MoveNames.SUBMISSION,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 80,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user grabs the target and recklessly dives for the ground. It also hurts the user slightly.",
		};
		public static Move BrickBreak = new ()
		{
			Name = MoveNames.BRICKBREAK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks with a swift chop. It can also break any barrier such as Light Screen and Reflect.",
		};
		public static Move DrainPunch = new ()
		{
			Name = MoveNames.DRAINPUNCH,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "An energy-draining punch. The user's HP is restored by half the damage taken by the target.",
		};
		public static Move VitalThrow = new ()
		{
			Name = MoveNames.VITALTHROW,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Priority = -1,
			IsContactMove = true,
			Description = "The user attacks last. In return, this throw move is guaranteed not to miss.",
		};
		public static Move WakeUpSlap = new ()
		{
			Name = MoveNames.WAKEUPSLAP,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "This attack inflicts big damage on a sleeping target. It also wakes the target up, however.",
		};
		public static Move LowSweep = new ()
		{
			Name = MoveNames.LOWSWEEP,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks the target's legs swiftly, reducing the target's Speed stat.",
		};
		public static Move CircleThrow = new ()
		{
			Name = MoveNames.CIRCLETHROW,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Priority = -6,
			IsContactMove = true,
			Description = "The user throws the target and drags out another Pokémon in its party. In the wild, the battle ends.",
		};
		public static Move ForcePalm = new ()
		{
			Name = MoveNames.FORCEPALM,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is attacked with a shock wave. It may also leave the target with paralysis.",
		};
		public static Move Revenge = new ()
		{
			Name = MoveNames.REVENGE,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Priority = -4,
			IsContactMove = true,
			Description = "An attack move that inflicts double the damage if the user has been hurt by the foe in the same turn.",
		};
		public static Move RollingKick = new ()
		{
			Name = MoveNames.ROLLINGKICK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user lashes out with a quick, spinning kick. It may also make the target flinch.",
		};
		public static Move StormThrow = new ()
		{
			Name = MoveNames.STORMTHROW,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user strikes the target with a fierce blow. This attack always results in a critical hit.",
		};
		public static Move KarateChop = new ()
		{
			Name = MoveNames.KARATECHOP,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The target is attacked with a sharp chop. Critical hits land more easily.",
		};
		public static Move MachPunch = new ()
		{
			Name = MoveNames.MACHPUNCH,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Priority = 1,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user throws a punch at blinding speed. It is certain to strike first.",
		};
		public static Move PowerUpPunch = new ()
		{
			Name = MoveNames.POWERUPPUNCH,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "Striking opponents repeatedly makes the user's fists harder, raising the user's Attack stat.",
		};
		public static Move RockSmash = new ()
		{
			Name = MoveNames.ROCKSMASH,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks with a punch that can shatter a rock. It may also lower the foe's Defense stat.",
		};
		public static Move VacuumWave = new ()
		{
			Name = MoveNames.VACUUMWAVE,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Priority = 1,
			Description = "The user whirls its fists to send a wave of pure vacuum at the target. This move always goes first.",
		};
		public static Move DoubleKick = new ()
		{
			Name = MoveNames.DOUBLEKICK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 30,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is quickly kicked twice in succession using both feet.",
		};
		public static Move ArmThrust = new ()
		{
			Name = MoveNames.ARMTHRUST,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 15,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user looses a flurry of open-palmed arm thrusts that hit two to five times in a row.",
		};
		public static Move TripleKick = new ()
		{
			Name = MoveNames.TRIPLEKICK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 10,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A consecutive three-kick attack that becomes more powerful with each successive hit.",
		};
		public static Move Counter = new ()
		{
			Name = MoveNames.COUNTER,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.None,
			Priority = -5,
			IsContactMove = true,
			Description = "A retaliation move that counters any physical attack, inflicting double the damage taken.",
		};
		public static Move FinalGambit = new ()
		{
			Name = MoveNames.FINALGAMBIT,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user risks all to attack the foe. The user faints but does damage equal to its HP.",
		};
		public static Move LowKick = new ()
		{
			Name = MoveNames.LOWKICK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A powerful low kick that makes the foe fall over. It inflicts greater damage on heavier foes.",
		};
		public static Move Reversal = new ()
		{
			Name = MoveNames.REVERSAL,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "An all-out attack that becomes more powerful the less HP the user has.",
		};
		public static Move SeismicToss = new ()
		{
			Name = MoveNames.SEISMICTOSS,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is thrown using the power of gravity. It inflicts damage equal to the user's level.",
		};
		public static Move BulkUp = new ()
		{
			Name = MoveNames.BULKUP,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user tenses its muscles to bulk up its body, boosting both its Attack and Defense stats.",
		};
		public static Move Coaching = new ()
		{
			Name = MoveNames.COACHING,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.AllAllies,
			Description = "The user properly coaches its ally Pokémon, boosting their Attack and Defense stats.",
		};
		public static Move Detect = new ()
		{
			Name = MoveNames.DETECT,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "It enables the user to evade all attacks. Its chance of failing rises if it is used in succession.",
		};
		public static Move MatBlock = new ()
		{
			Name = MoveNames.MATBLOCK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.UserSide,
			Description = "Using a pulled-up mat as a shield, the user protects itself and its allies from damaging moves.",
		};
		public static Move NoRetreat = new ()
		{
			Name = MoveNames.NORETREAT,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.User,
			Description = "This move raises all the user's stats but prevents the user from switching out or fleeing.",
		};
		public static Move Octolock = new ()
		{
			Name = MoveNames.OCTOLOCK,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "Locks the target in and prevents it from fleeing. Also lowers the target's Defense and Sp. Def each turn.",
		};
		public static Move QuickGuard = new ()
		{
			Name = MoveNames.QUICKGUARD,
			MoveType = PokemonType.Fighting,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.UserSide,
			Priority = 3,
			Description = "The user protects itself and its allies from priority moves. If may fail if used in succession.",
		};
		public static Move Vcreate = new ()
		{
			Name = MoveNames.VCREATE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 180,
			Accuracy = 95,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "With a fiery forehead, the user hurls itself at the foe. It lowers the user's Defense, Sp. Def, and Speed.",
		};
		public static Move BlastBurn = new ()
		{
			Name = MoveNames.BLASTBURN,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The target is razed by a fiery explosion. The user must rest on the next turn, however.",
		};
		public static Move Eruption = new ()
		{
			Name = MoveNames.ERUPTION,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks in an explosive fury. The lower the user's HP, the less powerful this attack becomes.",
		};
		public static Move MindBlown = new ()
		{
			Name = MoveNames.MINDBLOWN,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearOthers,
			Description = "The user attacks everything by causing its own head to explode. This also damages the user.",
		};
		public static Move ShellTrap = new ()
		{
			Name = MoveNames.SHELLTRAP,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Priority = -3,
			Description = "The user sets a shell trap. If it is hit by a physical move, the trap explodes and hurt the attacker.",
		};
		public static Move BlueFlare = new ()
		{
			Name = MoveNames.BLUEFLARE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 130,
			Accuracy = 85,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by engulfing the foe in a beautiful, yet intense, blue flame. It may also burn the foe.",
		};
		public static Move BurnUp = new ()
		{
			Name = MoveNames.BURNUP,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 130,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "To inflict massive damage, the user burns itself out. The user will no longer be Fire type.",
		};
		public static Move Overheat = new ()
		{
			Name = MoveNames.OVERHEAT,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 130,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user attacks the target at full power. The attack's recoil sharply reduces the user's Sp. Atk stat.",
		};
		public static Move FlareBlitz = new ()
		{
			Name = MoveNames.FLAREBLITZ,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user cloaks itself in fire and charges at the foe. The user also takes damage and may burn the target.",
		};
		public static Move PyroBall = new ()
		{
			Name = MoveNames.PYROBALL,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "Attacks by igniting a small stone and launching it as a fiery ball. May also burn the target.",
		};
		public static Move FireBlast = new ()
		{
			Name = MoveNames.FIREBLAST,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 110,
			Accuracy = 85,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The foe is attacked with an intense blast of all-consuming fire. It may also leave the target with a burn.",
		};
		public static Move FusionFlare = new ()
		{
			Name = MoveNames.FUSIONFLARE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user brings down a giant flame. It does more damage if influenced by an enormous thunderbolt.",
		};
		public static Move Inferno = new ()
		{
			Name = MoveNames.INFERNO,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 50,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by engulfing the target in an intense fire. It leaves the target with a burn.",
		};
		public static Move MagmaStorm = new ()
		{
			Name = MoveNames.MAGMASTORM,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 75,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The target becomes trapped within a maelstrom of fire that rages for four to five turns.",
		};
		public static Move SacredFire = new ()
		{
			Name = MoveNames.SACREDFIRE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 95,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The target is razed with a mystical fire of great intensity. It may also leave the target with a burn.",
		};
		public static Move SearingShot = new ()
		{
			Name = MoveNames.SEARINGSHOT,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearOthers,
			IsBombMove = true,
			Description = "An inferno of scarlet flames torches everything around the user. It may leave the foe with a burn.",
		};
		public static Move HeatWave = new ()
		{
			Name = MoveNames.HEATWAVE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 95,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks by exhaling hot breath on the opposing team. It may also leave targets with a burn.",
		};
		public static Move Flamethrower = new ()
		{
			Name = MoveNames.FLAMETHROWER,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The target is scorched with an intense blast of fire. It may also leave the target with a burn.",
		};
		public static Move BlazeKick = new ()
		{
			Name = MoveNames.BLAZEKICK,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The user launches a kick with a high critical-hit ratio. It may also leave the target with a burn.",
		};
		public static Move FieryDance = new ()
		{
			Name = MoveNames.FIERYDANCE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsDanceMove = true,
			Description = "Cloaked in flames, the user dances and flaps its wings. It may also raise the user's Sp. Atk stat.",
		};
		public static Move FireLash = new ()
		{
			Name = MoveNames.FIRELASH,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user strikes the target with a burning lash. This also lowers the target's Defense stat.",
		};
		public static Move FirePledge = new ()
		{
			Name = MoveNames.FIREPLEDGE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A column of fire hits opposing Pokémon. When used with its Grass equivalent, it makes a sea of fire.",
		};
		public static Move LavaPlume = new ()
		{
			Name = MoveNames.LAVAPLUME,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.AllNearOthers,
			Description = "An inferno of scarlet flames torches everything around the user. It may leave targets with a burn.",
		};
		public static Move FirePunch = new ()
		{
			Name = MoveNames.FIREPUNCH,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The target is punched with a fiery fist. It may leave the target with a burn.",
		};
		public static Move MysticalFire = new ()
		{
			Name = MoveNames.MYSTICALFIRE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by breathing a special, hot fire. This also lowers the target's Sp. Atk stat.",
		};
		public static Move BurningJealousy = new ()
		{
			Name = MoveNames.BURNINGJEALOUSY,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks with energy from jealousy. This burns all foes that had their stats boosted this turn.",
		};
		public static Move FlameBurst = new ()
		{
			Name = MoveNames.FLAMEBURST,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user attacks the foe with a bursting flame. It also damages Pokémon next to the target.",
		};
		public static Move FireFang = new ()
		{
			Name = MoveNames.FIREFANG,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBitingMove = true,
			Description = "The user bites with flame-cloaked fangs. It may also make the target flinch or leave it burned.",
		};
		public static Move FlameWheel = new ()
		{
			Name = MoveNames.FLAMEWHEEL,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user cloaks itself in fire and charges at the target. It may also leave the target with a burn.",
		};
		public static Move Incinerate = new ()
		{
			Name = MoveNames.INCINERATE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks the foe with fire. The target's held Berry becomes burnt up and unusable.",
		};
		public static Move FlameCharge = new ()
		{
			Name = MoveNames.FLAMECHARGE,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user cloaks itself in flame and attacks. Building up more power, it raises the user's Speed stat.",
		};
		public static Move Ember = new ()
		{
			Name = MoveNames.EMBER,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			Description = "The target is attacked with small flames. It may also leave the target with a burn.",
		};
		public static Move FireSpin = new ()
		{
			Name = MoveNames.FIRESPIN,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Special,
			BasePower = 35,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The target becomes trapped within a fierce vortex of fire that rages for four to five turns.",
		};
		public static Move HeatCrash = new ()
		{
			Name = MoveNames.HEATCRASH,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			TramplesMinimize = true,
			Description = "The user slams the foe with its flaming body. The heavier the user is, the greater the damage.",
		};
		public static Move SunnyDay = new ()
		{
			Name = MoveNames.SUNNYDAY,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.BothSides,
			Description = "The user intensifies the sun for five turns, powering up Fire-type moves.",
		};
		public static Move WillOWisp = new ()
		{
			Name = MoveNames.WILLOWISP,
			MoveType = PokemonType.Fire,
			Category = MoveCategory.Status,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user shoots a sinister, bluish-white flame at the target to inflict a burn.",
		};
		public static Move SkyAttack = new ()
		{
			Name = MoveNames.SKYATTACK,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 140,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.Other,
			HasHighCritRate = true,
			Description = "A second-turn attack move where critical hits land more easily. It may also make the target flinch.",
		};
		public static Move BraveBird = new ()
		{
			Name = MoveNames.BRAVEBIRD,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The user tucks in its wings and charges from a low altitude. The user also takes serious damage.",
		};
		public static Move DragonAscent = new ()
		{
			Name = MoveNames.DRAGONASCENT,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user soars upward and drops at high speeds. Its Defense and Sp. Def stats are lowered.",
		};
		public static Move Hurricane = new ()
		{
			Name = MoveNames.HURRICANE,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Special,
			BasePower = 110,
			Accuracy = 70,
			PowerPoints = 10,
			Target = MoveTarget.Other,
			Description = "The user wraps its foe in a fierce wind that flies up into the sky. It may also confuse the foe.",
		};
		public static Move Aeroblast = new ()
		{
			Name = MoveNames.AEROBLAST,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 95,
			PowerPoints = 5,
			Target = MoveTarget.Other,
			HasHighCritRate = true,
			Description = "A vortex of air is shot at the target to inflict damage. Critical hits land more easily.",
		};
		public static Move BeakBlast = new ()
		{
			Name = MoveNames.BEAKBLAST,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Priority = -3,
			IsBombMove = true,
			Description = "The user heats up its beak before attacking. Making contact in this time results in a burn.",
		};
		public static Move Fly = new ()
		{
			Name = MoveNames.FLY,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The user soars, then strikes on the second turn. It can also be used for flying to any familiar town.",
		};
		public static Move Bounce = new ()
		{
			Name = MoveNames.BOUNCE,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 85,
			PowerPoints = 5,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The user bounces up high, then drops on the foe on the second turn. It may also paralyze the foe.",
		};
		public static Move DrillPeck = new ()
		{
			Name = MoveNames.DRILLPECK,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "A corkscrewing attack with the sharp beak acting as a drill.",
		};
		public static Move OblivionWing = new ()
		{
			Name = MoveNames.OBLIVIONWING,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.Other,
			Description = "The user absorbs its target's HP. The user's HP is restored by over half of the damage dealt.",
		};
		public static Move AirSlash = new ()
		{
			Name = MoveNames.AIRSLASH,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Special,
			BasePower = 75,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.Other,
			Description = "The user attacks with a blade of air that slices even the sky. It may also make the target flinch.",
		};
		public static Move Chatter = new ()
		{
			Name = MoveNames.CHATTER,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.Other,
			IsSoundMove = true,
			Description = "The user attacks using a sound wave based on words it has learned. It may also confuse the target.",
		};
		public static Move AerialAce = new ()
		{
			Name = MoveNames.AERIALACE,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The user confounds the foe with speed, then slashes. The attack lands without fail.",
		};
		public static Move AirCutter = new ()
		{
			Name = MoveNames.AIRCUTTER,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 95,
			PowerPoints = 25,
			Target = MoveTarget.AllNearFoes,
			HasHighCritRate = true,
			Description = "The user launches razor-like wind to slash the opposing team. Critical hits land more easily.",
		};
		public static Move Pluck = new ()
		{
			Name = MoveNames.PLUCK,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The user pecks the target. If the target is holding a Berry, the user eats it and gains its effect.",
		};
		public static Move SkyDrop = new ()
		{
			Name = MoveNames.SKYDROP,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The user takes the foe into the sky, then drops it on the next turn. The foe cannot attack while airborne.",
		};
		public static Move WingAttack = new ()
		{
			Name = MoveNames.WINGATTACK,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 35,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The target is struck with large, imposing wings spread wide to inflict damage.",
		};
		public static Move Acrobatics = new ()
		{
			Name = MoveNames.ACROBATICS,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 55,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The user nimbly strikes the foe. This attack does more damage if the user is not holding an item.",
		};
		public static Move DualWingbeat = new ()
		{
			Name = MoveNames.DUALWINGBEAT,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slams the target with its wings. The target is hit twice in a row.",
		};
		public static Move Gust = new ()
		{
			Name = MoveNames.GUST,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 35,
			Target = MoveTarget.Other,
			Description = "A gust of wind is whipped up by wings and launched at the target to inflict damage.",
		};
		public static Move Peck = new ()
		{
			Name = MoveNames.PECK,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Physical,
			BasePower = 35,
			Accuracy = 100,
			PowerPoints = 35,
			Target = MoveTarget.Other,
			IsContactMove = true,
			Description = "The target is jabbed with a sharply pointed beak or horn.",
		};
		public static Move Defog = new ()
		{
			Name = MoveNames.DEFOG,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "A strong wind blows away the foe's obstacles such as Light Screen. It also lowers their evasion.",
		};
		public static Move FeatherDance = new ()
		{
			Name = MoveNames.FEATHERDANCE,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsDanceMove = true,
			Description = "The user covers the target's body with a mass of down that harshly lowers its Attack stat.",
		};
		public static Move MirrorMove = new ()
		{
			Name = MoveNames.MIRRORMOVE,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user counters the target by mimicking the target's last move.",
		};
		public static Move Roost = new ()
		{
			Name = MoveNames.ROOST,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user lands and rests its body. It restores the user's HP by up to half of its max HP.",
		};
		public static Move Tailwind = new ()
		{
			Name = MoveNames.TAILWIND,
			MoveType = PokemonType.Flying,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.UserSide,
			Description = "The user whips up a turbulent whirlwind that ups the Speed of all party Pokémon for four turns.",
		};
		public static Move AstralBarrage = new ()
		{
			Name = MoveNames.ASTRALBARRAGE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks by sending a frightful amount of small ghosts at opposing Pokémon.",
		};
		public static Move ShadowForce = new ()
		{
			Name = MoveNames.SHADOWFORCE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user disappears, then strikes the foe on the second turn. It hits even if the foe protects itself.",
		};
		public static Move Poltergeist = new ()
		{
			Name = MoveNames.POLTERGEIST,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 110,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "Attacks the target by controlling its item. The move fails if the target doesn't have an item.",
		};
		public static Move MoongeistBeam = new ()
		{
			Name = MoveNames.MOONGEISTBEAM,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user emits a sinister ray. This move can be used on the target regardless of its Abilities.",
		};
		public static Move PhantomForce = new ()
		{
			Name = MoveNames.PHANTOMFORCE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user vanishes somewhere, then strikes on the next turn. Hits through protections.",
		};
		public static Move SpectralThief = new ()
		{
			Name = MoveNames.SPECTRALTHIEF,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user hides in the target's shadow, steals the target's stat boosts, and then attacks.",
		};
		public static Move ShadowBone = new ()
		{
			Name = MoveNames.SHADOWBONE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user beats the target with a bone containing a spirit. May lower the target's Defense stat.",
		};
		public static Move ShadowBall = new ()
		{
			Name = MoveNames.SHADOWBALL,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user hurls a shadowy blob at the target. It may also lower the target's Sp. Def stat.",
		};
		public static Move SpiritShackle = new ()
		{
			Name = MoveNames.SPIRITSHACKLE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user attacks while also stitching the target's shadow to the ground to prevent it fleeing.",
		};
		public static Move ShadowClaw = new ()
		{
			Name = MoveNames.SHADOWCLAW,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The user slashes with a sharp claw made from shadows. Critical hits land more easily.",
		};
		public static Move Hex = new ()
		{
			Name = MoveNames.HEX,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "This relentless attack does massive damage to a target affected by status problems.",
		};
		public static Move OminousWind = new ()
		{
			Name = MoveNames.OMINOUSWIND,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user blasts the target with a gust of repulsive wind. It may also raise all the user's stats at once.",
		};
		public static Move ShadowPunch = new ()
		{
			Name = MoveNames.SHADOWPUNCH,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user throws a punch from the shadows. The punch lands without fail.",
		};
		public static Move ShadowSneak = new ()
		{
			Name = MoveNames.SHADOWSNEAK,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Priority = 1,
			IsContactMove = true,
			Description = "The user extends its shadow and attacks the target from behind. This move always goes first.",
		};
		public static Move Astonish = new ()
		{
			Name = MoveNames.ASTONISH,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 30,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks the target while shouting in a startling fashion. It may also make the target flinch.",
		};
		public static Move Lick = new ()
		{
			Name = MoveNames.LICK,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Physical,
			BasePower = 30,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is licked with a long tongue, causing damage. It may also leave the target with paralysis.",
		};
		public static Move NightShade = new ()
		{
			Name = MoveNames.NIGHTSHADE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user makes the foe see a frightening mirage. It inflicts damage matching the user's level.",
		};
		public static Move ConfuseRay = new ()
		{
			Name = MoveNames.CONFUSERAY,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The target is exposed to a sinister ray that triggers confusion.",
		};
		public static Move Curse = new ()
		{
			Name = MoveNames.CURSE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "A move that works differently for the Ghost type than for all the other types.",
		};
		public static Move DestinyBond = new ()
		{
			Name = MoveNames.DESTINYBOND,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.User,
			Description = "When this move is used, if the user faints, the foe that landed the knockout hit also faints.",
		};
		public static Move Grudge = new ()
		{
			Name = MoveNames.GRUDGE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.User,
			Description = "If the user faints, the user's grudge fully depletes the PP of the foe's move that knocked it out.",
		};
		public static Move Nightmare = new ()
		{
			Name = MoveNames.NIGHTMARE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "A sleeping target sees a nightmare that inflicts some damage every turn.",
		};
		public static Move Spite = new ()
		{
			Name = MoveNames.SPITE,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user unleashes its grudge on the move last used by the target by cutting 4 PP from it.",
		};
		public static Move TrickorTreat = new ()
		{
			Name = MoveNames.TRICKORTREAT,
			MoveType = PokemonType.Ghost,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user takes the target trick-or-treating. This adds Ghost type to the target's type.",
		};
		public static Move FrenzyPlant = new ()
		{
			Name = MoveNames.FRENZYPLANT,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user slams the target with an enormous tree. The user can't move on the next turn.",
		};
		public static Move LeafStorm = new ()
		{
			Name = MoveNames.LEAFSTORM,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 130,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "A storm of sharp is whipped up. The attack's recoil harshly reduces the user's Sp. Atk stat.",
		};
		public static Move SolarBlade = new ()
		{
			Name = MoveNames.SOLARBLADE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 125,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user gathers light energy into a blade, attacking the target on the next turn.",
		};
		public static Move PetalDance = new ()
		{
			Name = MoveNames.PETALDANCE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.RandomNearFoe,
			IsContactMove = true,
			IsDanceMove = true,
			Description = "The user attacks by scattering petals for two to three turns. The user then becomes confused.",
		};
		public static Move PowerWhip = new ()
		{
			Name = MoveNames.POWERWHIP,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user violently whirls its vines or tentacles to harshly lash the target.",
		};
		public static Move SeedFlare = new ()
		{
			Name = MoveNames.SEEDFLARE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 85,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user generates a shock wave from within its body. It may harshly lower the target's Sp. Def.",
		};
		public static Move SolarBeam = new ()
		{
			Name = MoveNames.SOLARBEAM,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A two-turn attack. The user gathers light, then blasts a bundled beam on the second turn.",
		};
		public static Move WoodHammer = new ()
		{
			Name = MoveNames.WOODHAMMER,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slams its rugged body into the target to attack. The user also sustains serious damage.",
		};
		public static Move EnergyBall = new ()
		{
			Name = MoveNames.ENERGYBALL,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user draws power from nature and fires it at the target. It may also lower the target's Sp. Def.",
		};
		public static Move LeafBlade = new ()
		{
			Name = MoveNames.LEAFBLADE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The user handles a sharp leaf like a sword and attacks by slashing. It has a high critical-hit ratio.",
		};
		public static Move PetalBlizzard = new ()
		{
			Name = MoveNames.PETALBLIZZARD,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.AllNearOthers,
			Description = "The user stirs up a violent petal blizzard and attacks everything around it.",
		};
		public static Move AppleAcid = new ()
		{
			Name = MoveNames.APPLEACID,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "Attacks with an acidic liquid created from tart apples. This also lowers the target's Sp. Def.",
		};
		public static Move DrumBeating = new ()
		{
			Name = MoveNames.DRUMBEATING,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user plays its drum, controlling roots to attack. This also lowers the target's Speed stat.",
		};
		public static Move GrassPledge = new ()
		{
			Name = MoveNames.GRASSPLEDGE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A column of grass hits the foes. When used with its water equivalent, it creates a vast swamp.",
		};
		public static Move GravApple = new ()
		{
			Name = MoveNames.GRAVAPPLE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user inflicts damage by dropping an apple from high above. This also lowers the target's Defense.",
		};
		public static Move SeedBomb = new ()
		{
			Name = MoveNames.SEEDBOMB,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user slams a barrage of hard-shelled seeds down on the target from above.",
		};
		public static Move GigaDrain = new ()
		{
			Name = MoveNames.GIGADRAIN,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.",
		};
		public static Move HornLeech = new ()
		{
			Name = MoveNames.HORNLEECH,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user drains the foe's energy with its horns. The user's HP is restored by half the damage inflicted.",
		};
		public static Move GrassyGlide = new ()
		{
			Name = MoveNames.GRASSYGLIDE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Gliding on the ground, the user attacks the target. This move always goes first on Grassy Terrain.",
		};
		public static Move TropKick = new ()
		{
			Name = MoveNames.TROPKICK,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user lands an intense tropical kick on the target. This also lowers the target's Attack stat.",
		};
		public static Move LeafTornado = new ()
		{
			Name = MoveNames.LEAFTORNADO,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user attacks its foe by encircling it in sharp leaves. This attack may also lower the foe's accuracy.",
		};
		public static Move MagicalLeaf = new ()
		{
			Name = MoveNames.MAGICALLEAF,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user scatters curious leaves that chase the target. This attack will not miss.",
		};
		public static Move NeedleArm = new ()
		{
			Name = MoveNames.NEEDLEARM,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks by wildly swinging its thorny arms. It may also make the target flinch.",
		};
		public static Move RazorLeaf = new ()
		{
			Name = MoveNames.RAZORLEAF,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 55,
			Accuracy = 95,
			PowerPoints = 25,
			Target = MoveTarget.AllNearFoes,
			HasHighCritRate = true,
			Description = "Sharp-edged leaves are launched to slash at the opposing team. Critical hits land more easily.",
		};
		public static Move VineWhip = new ()
		{
			Name = MoveNames.VINEWHIP,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 45,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is struck with slender, whiplike vines to inflict damage.",
		};
		public static Move BranchPoke = new ()
		{
			Name = MoveNames.BRANCHPOKE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks the target by poking it with a sharply pointed branch.",
		};
		public static Move Leafage = new ()
		{
			Name = MoveNames.LEAFAGE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by pelting the target with leaves.",
		};
		public static Move MegaDrain = new ()
		{
			Name = MoveNames.MEGADRAIN,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.",
		};
		public static Move SnapTrap = new ()
		{
			Name = MoveNames.SNAPTRAP,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 35,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user snares the target in a snap trap for four to five turns.",
		};
		public static Move BulletSeed = new ()
		{
			Name = MoveNames.BULLETSEED,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user forcefully shoots seeds at the target. Two to five seeds are shot in rapid succession.",
		};
		public static Move Absorb = new ()
		{
			Name = MoveNames.ABSORB,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 20,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			Description = "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.",
		};
		public static Move GrassKnot = new ()
		{
			Name = MoveNames.GRASSKNOT,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user snares the target with grass and trips it. The heavier the target, the greater the damage.",
		};
		public static Move Aromatherapy = new ()
		{
			Name = MoveNames.AROMATHERAPY,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.UserAndAllies,
			Description = "The user releases a soothing scent that heals all status problems affecting the user's party.",
		};
		public static Move CottonGuard = new ()
		{
			Name = MoveNames.COTTONGUARD,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user protects itself by wrapping its body in soft cotton, drastically raising its Defense stat.",
		};
		public static Move CottonSpore = new ()
		{
			Name = MoveNames.COTTONSPORE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 40,
			Target = MoveTarget.AllNearFoes,
			IsPowderMove = true,
			Description = "The user releases cotton-like spores that cling to the foe, harshly reducing its Speed stat.",
		};
		public static Move ForestsCurse = new ()
		{
			Name = MoveNames.FORESTSCURSE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user puts a forest curse on the target. The target is now Grass type as well.",
		};
		public static Move GrassWhistle = new ()
		{
			Name = MoveNames.GRASSWHISTLE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 55,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "The user plays a pleasant melody that lulls the target into a deep sleep.",
		};
		public static Move GrassyTerrain = new ()
		{
			Name = MoveNames.GRASSYTERRAIN,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "The user turns the ground to grass for five turns. Grounded Pokémon restore a little HP every turn.",
		};
		public static Move Ingrain = new ()
		{
			Name = MoveNames.INGRAIN,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user lays roots that restore its HP on every turn. Because it is rooted, it can't switch out.",
		};
		public static Move JungleHealing = new ()
		{
			Name = MoveNames.JUNGLEHEALING,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.UserAndAllies,
			Description = "The user becomes one with the jungle, and restores HP and cures status conditions of itself and allies.",
		};
		public static Move LeechSeed = new ()
		{
			Name = MoveNames.LEECHSEED,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A seed is planted on the target. It steals some HP from the target every turn.",
		};
		public static Move SleepPowder = new ()
		{
			Name = MoveNames.SLEEPPOWDER,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 75,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsPowderMove = true,
			Description = "The user scatters a big cloud of sleep-inducing dust around the target.",
		};
		public static Move SpikyShield = new ()
		{
			Name = MoveNames.SPIKYSHIELD,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "Protects the user from attacks. Also damages attackers that make contact with the user.",
		};
		public static Move Spore = new ()
		{
			Name = MoveNames.SPORE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsPowderMove = true,
			Description = "The user scatters bursts of spores that induce sleep.",
		};
		public static Move StrengthSap = new ()
		{
			Name = MoveNames.STRENGTHSAP,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user restores its HP by the target's Attack stat amount. Then lowers the target's Attack stat.",
		};
		public static Move StunSpore = new ()
		{
			Name = MoveNames.STUNSPORE,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 75,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			IsPowderMove = true,
			Description = "The user scatters a cloud of paralyzing powder. It may leave the target with paralysis.",
		};
		public static Move Synthesis = new ()
		{
			Name = MoveNames.SYNTHESIS,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.User,
			Description = "The user restores its own HP. The amount of HP regained varies with the weather.",
		};
		public static Move WorrySeed = new ()
		{
			Name = MoveNames.WORRYSEED,
			MoveType = PokemonType.Grass,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A seed that causes worry is planted on the foe. It prevents sleep by making its Ability Insomnia.",
		};
		public static Move PrecipiceBlades = new ()
		{
			Name = MoveNames.PRECIPICEBLADES,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks its foes by manifesting the power of the land in fearsome blades of stone.",
		};
		public static Move Earthquake = new ()
		{
			Name = MoveNames.EARTHQUAKE,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearOthers,
			Description = "The user sets off an earthquake that strikes every Pokémon around it.",
		};
		public static Move HighHorsepower = new ()
		{
			Name = MoveNames.HIGHHORSEPOWER,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 95,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user fiercely attacks the target using its entire body.",
		};
		public static Move EarthPower = new ()
		{
			Name = MoveNames.EARTHPOWER,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user makes the ground under the foe erupt with power. It may also lower the target's Sp. Def.",
		};
		public static Move LandsWrath = new ()
		{
			Name = MoveNames.LANDSWRATH,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "The user gathers the energy of the land and focuses that power on foes to damage them.",
		};
		public static Move ThousandArrows = new ()
		{
			Name = MoveNames.THOUSANDARROWS,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "This move also hits Pokémon that are in the air. Those Pokémon are knocked down to the ground.",
		};
		public static Move ThousandWaves = new ()
		{
			Name = MoveNames.THOUSANDWAVES,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks with a wave that crawls along the ground. Those it hits can't flee from battle.",
		};
		public static Move Dig = new ()
		{
			Name = MoveNames.DIG,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user burrows, then attacks on the second turn. It can also be used to exit dungeons.",
		};
		public static Move DrillRun = new ()
		{
			Name = MoveNames.DRILLRUN,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The user crashes into its target while rotating its body like a drill. Critical hits land more easily.",
		};
		public static Move StompingTantrum = new ()
		{
			Name = MoveNames.STOMPINGTANTRUM,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks driven by frustration. Power increases if the user's previous move failed.",
		};
		public static Move ScorchingSands = new ()
		{
			Name = MoveNames.SCORCHINGSANDS,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Special,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user throws scorching sand at the target to attack. This may also burn the target.",
		};
		public static Move BoneClub = new ()
		{
			Name = MoveNames.BONECLUB,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 85,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user clubs the target with a bone. It may also make the target flinch.",
		};
		public static Move MudBomb = new ()
		{
			Name = MoveNames.MUDBOMB,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user launches a hard-packed mud ball to attack. It may also lower the target's accuracy.",
		};
		public static Move Bulldoze = new ()
		{
			Name = MoveNames.BULLDOZE,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearOthers,
			Description = "The user strikes everything around it by stomping on the ground. It reduces hit Pokémon's Speed.",
		};
		public static Move MudShot = new ()
		{
			Name = MoveNames.MUDSHOT,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Special,
			BasePower = 55,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by hurling a blob of mud at the target. It also reduces the target's Speed.",
		};
		public static Move Bonemerang = new ()
		{
			Name = MoveNames.BONEMERANG,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user throws the bone it holds. The bone loops to hit the target twice, coming and going.",
		};
		public static Move SandTomb = new ()
		{
			Name = MoveNames.SANDTOMB,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 35,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user traps the target inside a harshly raging sandstorm for four to five turns.",
		};
		public static Move BoneRush = new ()
		{
			Name = MoveNames.BONERUSH,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user strikes the target with a hard bone two to five times in a row.",
		};
		public static Move MudSlap = new ()
		{
			Name = MoveNames.MUDSLAP,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Special,
			BasePower = 20,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user hurls mud in the target's face to inflict damage and lower its accuracy.",
		};
		public static Move Fissure = new ()
		{
			Name = MoveNames.FISSURE,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 30,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user opens up a fissure in the ground and drops the foe in. The target instantly faints if it hits.",
		};
		public static Move Magnitude = new ()
		{
			Name = MoveNames.MAGNITUDE,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.AllNearOthers,
			Description = "The user looses a ground-shaking quake affecting everyone around the user. Its power varies.",
		};
		public static Move MudSport = new ()
		{
			Name = MoveNames.MUDSPORT,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.BothSides,
			Description = "The user covers itself with mud. It weakens Electric-type moves while the user is in the battle.",
		};
		public static Move Rototiller = new ()
		{
			Name = MoveNames.ROTOTILLER,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.AllBattlers,
			Description = "The user tills the soil to encourage plant growth. This raises the Attack and Sp. Atk of Grass types.",
		};
		public static Move SandAttack = new ()
		{
			Name = MoveNames.SANDATTACK,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "Sand is hurled in the target's face, reducing its accuracy.",
		};
		public static Move ShoreUp = new ()
		{
			Name = MoveNames.SHOREUP,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user regains up to half of its max HP. It restores more HP in a sandstorm.",
		};
		public static Move Spikes = new ()
		{
			Name = MoveNames.SPIKES,
			MoveType = PokemonType.Ground,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.FoeSide,
			Description = "The user lays a trap of spikes at the foe's feet. The trap hurts foes that switch into battle.",
		};
		public static Move FreezeShock = new ()
		{
			Name = MoveNames.FREEZESHOCK,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 140,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "On the second turn, the user hits the foe with electrically charged ice. It may also paralyze the foe.",
		};
		public static Move IceBurn = new ()
		{
			Name = MoveNames.ICEBURN,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 140,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "On the second turn, an ultracold, freezing wind surrounds the foe. This may leave it with a burn.",
		};
		public static Move GlacialLance = new ()
		{
			Name = MoveNames.GLACIALLANCE,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 130,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks by hurling a blizzard-cloaked icicle lance at opposing Pokémon.",
		};
		public static Move Blizzard = new ()
		{
			Name = MoveNames.BLIZZARD,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 110,
			Accuracy = 70,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Description = "A howling blizzard is summoned to strike the opposing team. It may also freeze them solid.",
		};
		public static Move IceHammer = new ()
		{
			Name = MoveNames.ICEHAMMER,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user swings and hits with its strong, heavy fist. It lowers the user's Speed, however.",
		};
		public static Move IceBeam = new ()
		{
			Name = MoveNames.ICEBEAM,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The target is struck with an icy-cold beam of energy. It may also freeze the target solid.",
		};
		public static Move IcicleCrash = new ()
		{
			Name = MoveNames.ICICLECRASH,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by harshly dropping an icicle onto the foe. It may also make the target flinch.",
		};
		public static Move IcePunch = new ()
		{
			Name = MoveNames.ICEPUNCH,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The target is punched with an icy fist. It may also leave the target frozen.",
		};
		public static Move FreezeDry = new ()
		{
			Name = MoveNames.FREEZEDRY,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user rapidly cools the target. This may freeze the target. Is super-effective on Water types.",
		};
		public static Move AuroraBeam = new ()
		{
			Name = MoveNames.AURORABEAM,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The target is hit with a rainbow-colored beam. This may also lower the target's Attack stat.",
		};
		public static Move Glaciate = new ()
		{
			Name = MoveNames.GLACIATE,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks by blowing freezing cold air at the foe. This attack reduces the targets' Speed stat.",
		};
		public static Move IceFang = new ()
		{
			Name = MoveNames.ICEFANG,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBitingMove = true,
			Description = "The user bites with cold-infused fangs. It may also make the target flinch or leave it frozen.",
		};
		public static Move Avalanche = new ()
		{
			Name = MoveNames.AVALANCHE,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Priority = -4,
			IsContactMove = true,
			Description = "An attack move that inflicts double the damage if the user has been hurt by the foe in the same turn.",
		};
		public static Move FrostBreath = new ()
		{
			Name = MoveNames.FROSTBREATH,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user blows a cold breath on the target. This attack always results in a critical hit.",
		};
		public static Move IcyWind = new ()
		{
			Name = MoveNames.ICYWIND,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 55,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks with a gust of chilled air. It also lowers the targets' Speed stat.",
		};
		public static Move IceShard = new ()
		{
			Name = MoveNames.ICESHARD,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Priority = 1,
			Description = "The user flash freezes chunks of ice and hurls them at the target. This move always goes first.",
		};
		public static Move PowderSnow = new ()
		{
			Name = MoveNames.POWDERSNOW,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks with a chilling gust of powdery snow. It may also freeze the targets.",
		};
		public static Move IceBall = new ()
		{
			Name = MoveNames.ICEBALL,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 30,
			Accuracy = 90,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBombMove = true,
			Description = "The user continually rolls into the target over five turns. It becomes stronger each time it hits.",
		};
		public static Move IcicleSpear = new ()
		{
			Name = MoveNames.ICICLESPEAR,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Description = "The user launches sharp icicles at the target. It strikes two to five times in a row.",
		};
		public static Move TripleAxel = new ()
		{
			Name = MoveNames.TRIPLEAXEL,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Physical,
			BasePower = 20,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A consecutive three-kick attack that becomes more powerful with each successful hit.",
		};
		public static Move SheerCold = new ()
		{
			Name = MoveNames.SHEERCOLD,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 30,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The foe is attacked with a blast of absolute-zero cold. The target instantly faints if it hits.",
		};
		public static Move AuroraVeil = new ()
		{
			Name = MoveNames.AURORAVEIL,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.UserSide,
			Description = "This move reduces damage from attacks for five turns. This can be used only in a hailstorm.",
		};
		public static Move Hail = new ()
		{
			Name = MoveNames.HAIL,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "The user summons a hail storm lasting five turns. It damages all Pokémon except the Ice type.",
		};
		public static Move Haze = new ()
		{
			Name = MoveNames.HAZE,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.BothSides,
			Description = "The user creates a haze that eliminates every stat change among all the Pokémon engaged in battle.",
		};
		public static Move Mist = new ()
		{
			Name = MoveNames.MIST,
			MoveType = PokemonType.Ice,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.UserSide,
			Description = "The user cloaks its body with a white mist that prevents any of its stats from being cut for five turns.",
		};
		public static Move Explosion = new ()
		{
			Name = MoveNames.EXPLOSION,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 250,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearOthers,
			Description = "The user explodes to inflict damage on those around it. The user faints upon using this move.",
		};
		public static Move SelfDestruct = new ()
		{
			Name = MoveNames.SELFDESTRUCT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 200,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearOthers,
			Description = "The user blows up to inflict damage on all Pokémon in battle. The user faints upon using this move.",
		};
		public static Move GigaImpact = new ()
		{
			Name = MoveNames.GIGAIMPACT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 150,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user charges at the target using every bit of its power. The user must rest on the next turn.",
		};
		public static Move HyperBeam = new ()
		{
			Name = MoveNames.HYPERBEAM,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The foe is attacked with a powerful beam. The user must rest on the next turn to regain its energy.",
		};
		public static Move Boomburst = new ()
		{
			Name = MoveNames.BOOMBURST,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 140,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearOthers,
			IsSoundMove = true,
			Description = "The user attacks everything around it with the destructive power of a terrible, explosive sound.",
		};
		public static Move LastResort = new ()
		{
			Name = MoveNames.LASTRESORT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 140,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "This move can be used only after the user has used all the other moves it knows in the battle.",
		};
		public static Move SkullBash = new ()
		{
			Name = MoveNames.SKULLBASH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 130,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user tucks in its head to raise its Defense in the first turn, then rams the foe on the next turn.",
		};
		public static Move DoubleEdge = new ()
		{
			Name = MoveNames.DOUBLEEDGE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A reckless, life-risking tackle. It also damages the user by a fairly large amount, however.",
		};
		public static Move HeadCharge = new ()
		{
			Name = MoveNames.HEADCHARGE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user charges its head into the foe, using its powerful guard hair. The user also takes damage.",
		};
		public static Move MegaKick = new ()
		{
			Name = MoveNames.MEGAKICK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 75,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is attacked by a kick launched with muscle-packed power.",
		};
		public static Move MultiAttack = new ()
		{
			Name = MoveNames.MULTIATTACK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Cloaking itself in high energy, the user slams into the target. This move's type depends on the held memory.",
		};
		public static Move TechnoBlast = new ()
		{
			Name = MoveNames.TECHNOBLAST,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user fires a beam of light at its target. The type changes depending on the Drive the user holds.",
		};
		public static Move Thrash = new ()
		{
			Name = MoveNames.THRASH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.RandomNearFoe,
			IsContactMove = true,
			Description = "The user rampages and attacks for two to three turns. It then becomes confused, however.",
		};
		public static Move EggBomb = new ()
		{
			Name = MoveNames.EGGBOMB,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 75,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "A large egg is hurled at the target with maximum force to inflict damage.",
		};
		public static Move Judgment = new ()
		{
			Name = MoveNames.JUDGMENT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user releases countless shots of light. Its type varies with the kind of Plate the user is holding.",
		};
		public static Move HyperVoice = new ()
		{
			Name = MoveNames.HYPERVOICE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			IsSoundMove = true,
			Description = "The user lets loose a horribly echoing shout with the power to inflict damage.",
		};
		public static Move RevelationDance = new ()
		{
			Name = MoveNames.REVELATIONDANCE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsDanceMove = true,
			Description = "The user attacks the target by dancing very hard. The user's type determines the type of this move.",
		};
		public static Move RockClimb = new ()
		{
			Name = MoveNames.ROCKCLIMB,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 85,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks the target by smashing into it with incredible force. It may also confuse the target.",
		};
		public static Move TakeDown = new ()
		{
			Name = MoveNames.TAKEDOWN,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 85,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A reckless, full-body charge attack for slamming into the foe. It also damages the user a little.",
		};
		public static Move Uproar = new ()
		{
			Name = MoveNames.UPROAR,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.RandomNearFoe,
			IsSoundMove = true,
			Description = "The user attacks in an uproar for three turns. Over that time, no one can fall asleep.",
		};
		public static Move BodySlam = new ()
		{
			Name = MoveNames.BODYSLAM,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			TramplesMinimize = true,
			Description = "The user drops onto the target with its full body weight. It may leave the target with paralysis.",
		};
		public static Move ExtremeSpeed = new ()
		{
			Name = MoveNames.EXTREMESPEED,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Priority = 2,
			IsContactMove = true,
			Description = "The user charges the target at blinding speed. This attack always goes before any other move.",
		};
		public static Move HyperFang = new ()
		{
			Name = MoveNames.HYPERFANG,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 90,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBitingMove = true,
			Description = "The user bites hard on the target with its sharp front fangs. It may also make the target flinch.",
		};
		public static Move MegaPunch = new ()
		{
			Name = MoveNames.MEGAPUNCH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 85,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The target is slugged by a punch thrown with muscle-packed power.",
		};
		public static Move RazorWind = new ()
		{
			Name = MoveNames.RAZORWIND,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			HasHighCritRate = true,
			Description = "A two-turn attack. Blades of wind hit the foe on the second turn. Critical hits land more easily.",
		};
		public static Move Slam = new ()
		{
			Name = MoveNames.SLAM,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 75,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is slammed with a long tail, vines, etc., to inflict damage.",
		};
		public static Move Strength = new ()
		{
			Name = MoveNames.STRENGTH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is slugged with a punch thrown at maximum power. It can also be used to move heavy boulders.",
		};
		public static Move TriAttack = new ()
		{
			Name = MoveNames.TRIATTACK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user strikes with a simultaneous three-beam attack. May also paralyze, burn, or freeze the target.",
		};
		public static Move CrushClaw = new ()
		{
			Name = MoveNames.CRUSHCLAW,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slashes the target with hard and sharp claws. It may also lower the target's Defense.",
		};
		public static Move RelicSong = new ()
		{
			Name = MoveNames.RELICSONG,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 75,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			IsSoundMove = true,
			Description = "An ancient song appeals to the hearts of those listening. It may also induce sleep.",
		};
		public static Move ChipAway = new ()
		{
			Name = MoveNames.CHIPAWAY,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Seeking an opening, the user strikes continually. The foe's stat changes don't affect the damage.",
		};
		public static Move DizzyPunch = new ()
		{
			Name = MoveNames.DIZZYPUNCH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The target is hit with rhythmically launched punches that may also leave it confused.",
		};
		public static Move Facade = new ()
		{
			Name = MoveNames.FACADE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "An attack move that doubles its power if the user is poisoned, burned, or has paralysis.",
		};
		public static Move Headbutt = new ()
		{
			Name = MoveNames.HEADBUTT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user sticks out its head and attacks by charging into the foe. It may also make the target flinch.",
		};
		public static Move Retaliate = new ()
		{
			Name = MoveNames.RETALIATE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Gets revenge for a fainted ally. If an ally fainted in the last turn, this attack's damage increases.",
		};
		public static Move SecretPower = new ()
		{
			Name = MoveNames.SECRETPOWER,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user attacks with a secret power. Its added effects vary depending on the user's environment.",
		};
		public static Move Slash = new ()
		{
			Name = MoveNames.SLASH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The target is attacked with a slash of claws or blades. Critical hits land more easily.",
		};
		public static Move SmellingSalts = new ()
		{
			Name = MoveNames.SMELLINGSALTS,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "This attack inflicts double damage on a paralyzed foe. It also cures the target's paralysis, however.",
		};
		public static Move HornAttack = new ()
		{
			Name = MoveNames.HORNATTACK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is jabbed with a sharply pointed horn to inflict damage.",
		};
		public static Move Stomp = new ()
		{
			Name = MoveNames.STOMP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			TramplesMinimize = true,
			Description = "The target is stomped with a big foot. It may also make the target flinch.",
		};
		public static Move Covet = new ()
		{
			Name = MoveNames.COVET,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user endearingly approaches the target, then steals the target's held item.",
		};
		public static Move HiddenPower = new ()
		{
			Name = MoveNames.HIDDENPOWER,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "A unique attack that varies in type and intensity depending on the Pokémon using it.",
		};
		public static Move Round = new ()
		{
			Name = MoveNames.ROUND,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "The user attacks with a song. Others can join in the Round and make the attack do greater damage.",
		};
		public static Move Swift = new ()
		{
			Name = MoveNames.SWIFT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.AllNearFoes,
			Description = "Star-shaped rays are shot at the opposing team. This attack never misses.",
		};
		public static Move ViseGrip = new ()
		{
			Name = MoveNames.VISEGRIP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 55,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is gripped and squeezed from both sides to inflict damage.",
		};
		public static Move Cut = new ()
		{
			Name = MoveNames.CUT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 95,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is cut with a scythe or a claw. It can also be used to cut down thin trees.",
		};
		public static Move RapidSpin = new ()
		{
			Name = MoveNames.RAPIDSPIN,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A spin attack that raises the user's Speed and eliminates the effects of Bind, Spikes, etc.",
		};
		public static Move Snore = new ()
		{
			Name = MoveNames.SNORE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "An attack that can be used only if the user is asleep. The harsh noise may also make the target flinch.",
		};
		public static Move Struggle = new ()
		{
			Name = MoveNames.STRUGGLE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 0,
			PowerPoints = 1,
			Target = MoveTarget.RandomNearFoe,
			IsContactMove = true,
			Description = "An attack that is used in desperation only if the user has no PP. It also hurts the user slightly.",
		};
		public static Move TerrainPulse = new ()
		{
			Name = MoveNames.TERRAINPULSE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsPulseMove = true,
			Description = "Utilizes the power of the terrain to attack. This move's type and power vary with the terrain.",
		};
		public static Move WeatherBall = new ()
		{
			Name = MoveNames.WEATHERBALL,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "An attack move that varies in power and type depending on the weather.",
		};
		public static Move EchoedVoice = new ()
		{
			Name = MoveNames.ECHOEDVOICE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "The user attacks the foe with an echoing voice. If this move is used every turn, it does greater damage.",
		};
		public static Move FakeOut = new ()
		{
			Name = MoveNames.FAKEOUT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Priority = 3,
			IsContactMove = true,
			Description = "An attack that hits first and makes the target flinch. It only works the first turn the user is in battle.",
		};
		public static Move FalseSwipe = new ()
		{
			Name = MoveNames.FALSESWIPE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A restrained attack that prevents the target from fainting. The target is left with at least 1 HP.",
		};
		public static Move HoldBack = new ()
		{
			Name = MoveNames.HOLDBACK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user holds back when it attacks, and the target is left with at least 1 HP.",
		};
		public static Move PayDay = new ()
		{
			Name = MoveNames.PAYDAY,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "Numerous coins are hurled at the target to inflict damage. Money is earned after battle.",
		};
		public static Move Pound = new ()
		{
			Name = MoveNames.POUND,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 35,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is physically pounded with a long tail or a foreleg, etc.",
		};
		public static Move QuickAttack = new ()
		{
			Name = MoveNames.QUICKATTACK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Priority = 1,
			IsContactMove = true,
			Description = "The user lunges at the target at a speed that makes it almost invisible. It is sure to strike first.",
		};
		public static Move Scratch = new ()
		{
			Name = MoveNames.SCRATCH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 35,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Hard, pointed, and sharp claws rake the target to inflict damage.",
		};
		public static Move Tackle = new ()
		{
			Name = MoveNames.TACKLE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 35,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A physical attack in which the user charges and slams into the target with its whole body.",
		};
		public static Move DoubleHit = new ()
		{
			Name = MoveNames.DOUBLEHIT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 35,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slams the target with a long tail, vines, or tentacle. The target is hit twice in a row.",
		};
		public static Move Feint = new ()
		{
			Name = MoveNames.FEINT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 30,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Priority = 2,
			Description = "An attack that hits a target using Protect or Detect. It also lifts the effects of those moves.",
		};
		public static Move TailSlap = new ()
		{
			Name = MoveNames.TAILSLAP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks by striking the target with its hard tail. It hits the Pokémon two to five times in a row.",
		};
		public static Move Rage = new ()
		{
			Name = MoveNames.RAGE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 20,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "As long as this move is in use, the user's Attack rises each time the user is hit in battle.",
		};
		public static Move SpikeCannon = new ()
		{
			Name = MoveNames.SPIKECANNON,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 20,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "Sharp spikes are shot at the target in rapid succession. They hit two to five times in a row.",
		};
		public static Move CometPunch = new ()
		{
			Name = MoveNames.COMETPUNCH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 18,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The target is hit with a flurry of punches that strike two to five times in a row.",
		};
		public static Move FurySwipes = new ()
		{
			Name = MoveNames.FURYSWIPES,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 18,
			Accuracy = 80,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is raked with sharp claws or scythes for two to five times in quick succession.",
		};
		public static Move Barrage = new ()
		{
			Name = MoveNames.BARRAGE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 15,
			Accuracy = 85,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "Round objects are hurled at the target to strike two to five times in a row.",
		};
		public static Move Bind = new ()
		{
			Name = MoveNames.BIND,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 15,
			Accuracy = 85,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Things such as long bodies or tentacles are used to bind and squeeze the foe for four to five turns.",
		};
		public static Move DoubleSlap = new ()
		{
			Name = MoveNames.DOUBLESLAP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 15,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is slapped repeatedly, back and forth, two to five times in a row.",
		};
		public static Move FuryAttack = new ()
		{
			Name = MoveNames.FURYATTACK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 15,
			Accuracy = 85,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is jabbed repeatedly with a horn or beak two to five times in a row.",
		};
		public static Move Wrap = new ()
		{
			Name = MoveNames.WRAP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 15,
			Accuracy = 90,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A long body or vines are used to wrap and squeeze the target for four to five turns.",
		};
		public static Move Constrict = new ()
		{
			Name = MoveNames.CONSTRICT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 10,
			Accuracy = 100,
			PowerPoints = 35,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The foe is attacked with long, creeping tentacles or vines. It may also lower the target's Speed.",
		};
		public static Move Bide = new ()
		{
			Name = MoveNames.BIDE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.None,
			Priority = 1,
			IsContactMove = true,
			Description = "The user endures attacks for two turns, then strikes back to cause double the damage taken.",
		};
		public static Move CrushGrip = new ()
		{
			Name = MoveNames.CRUSHGRIP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is crushed with great force. The attack is more powerful the more HP the target has left.",
		};
		public static Move Endeavor = new ()
		{
			Name = MoveNames.ENDEAVOR,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "An attack move that cuts down the target's HP to equal the user's HP.",
		};
		public static Move Flail = new ()
		{
			Name = MoveNames.FLAIL,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user flails about aimlessly to attack. It becomes more powerful the less HP the user has.",
		};
		public static Move Frustration = new ()
		{
			Name = MoveNames.FRUSTRATION,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A full-power attack that grows more powerful the less the user likes its Trainer.",
		};
		public static Move Guillotine = new ()
		{
			Name = MoveNames.GUILLOTINE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 30,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A vicious, tearing attack with big pincers. The target will faint instantly if this attack hits.",
		};
		public static Move HornDrill = new ()
		{
			Name = MoveNames.HORNDRILL,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 30,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user stabs the foe with a horn that rotates like a drill. If it hits, the target faints instantly.",
		};
		public static Move NaturalGift = new ()
		{
			Name = MoveNames.NATURALGIFT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user draws power to attack by using its held Berry. The Berry determines its type and power.",
		};
		public static Move Present = new ()
		{
			Name = MoveNames.PRESENT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 90,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by giving the target a gift with a hidden trap. It restores HP sometimes, however.",
		};
		public static Move Return = new ()
		{
			Name = MoveNames.RETURN,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "A full-power attack that grows more powerful the more the user likes its Trainer.",
		};
		public static Move SonicBoom = new ()
		{
			Name = MoveNames.SONICBOOM,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 90,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The target is hit with a destructive shock wave that always inflicts 20 HP damage.",
		};
		public static Move SpitUp = new ()
		{
			Name = MoveNames.SPITUP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The power stored using the move Stockpile is released all at once in an attack.",
		};
		public static Move SuperFang = new ()
		{
			Name = MoveNames.SUPERFANG,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user chomps hard on the target with its sharp front fangs. It cuts the target's HP to half.",
		};
		public static Move TrumpCard = new ()
		{
			Name = MoveNames.TRUMPCARD,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The fewer PP this move has, the greater its attack power.",
		};
		public static Move WringOut = new ()
		{
			Name = MoveNames.WRINGOUT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user powerfully wrings the foe. The more HP the foe has, the greater this attack's power.",
		};
		public static Move Acupressure = new ()
		{
			Name = MoveNames.ACUPRESSURE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.UserOrNearAlly,
			Description = "The user applies pressure to stress points, sharply boosting one of its stats.",
		};
		public static Move AfterYou = new ()
		{
			Name = MoveNames.AFTERYOU,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user helps the target and makes it use its move right after the user.",
		};
		public static Move Assist = new ()
		{
			Name = MoveNames.ASSIST,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user hurriedly and randomly uses a move among those known by other Pokémon in the party.",
		};
		public static Move Attract = new ()
		{
			Name = MoveNames.ATTRACT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "If it is the opposite gender of the user, the target becomes infatuated and less likely to attack.",
		};
		public static Move BatonPass = new ()
		{
			Name = MoveNames.BATONPASS,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.User,
			Description = "The user switches places with a party Pokémon in waiting, passing along any stat changes.",
		};
		public static Move BellyDrum = new ()
		{
			Name = MoveNames.BELLYDRUM,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user maximizes its Attack stat in exchange for HP equal to half its max HP.",
		};
		public static Move Bestow = new ()
		{
			Name = MoveNames.BESTOW,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user passes its held item to the target when the target isn't holding an item.",
		};
		public static Move Block = new ()
		{
			Name = MoveNames.BLOCK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user blocks the target's way with arms spread wide to prevent escape.",
		};
		public static Move Camouflage = new ()
		{
			Name = MoveNames.CAMOUFLAGE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user's type is changed depending on its environment, such as at water's edge, in grass, or in a cave.",
		};
		public static Move Captivate = new ()
		{
			Name = MoveNames.CAPTIVATE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearFoes,
			Description = "If it is the opposite gender of the user, the target is charmed into harshly lowering its Sp. Atk stat.",
		};
		public static Move Celebrate = new ()
		{
			Name = MoveNames.CELEBRATE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.User,
			Description = "The Pokémon congratulates you on your special day!",
		};
		public static Move Confide = new ()
		{
			Name = MoveNames.CONFIDE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "The user tells the target a secret. The target loses focus and its Sp. Atk stat is lowered.",
		};
		public static Move Conversion = new ()
		{
			Name = MoveNames.CONVERSION,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.User,
			Description = "The user changes its type to become the same type as one of its moves.",
		};
		public static Move Conversion2 = new ()
		{
			Name = MoveNames.CONVERSION2,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Description = "The user changes its type to make itself resistant to the type of the attack the opponent used last.",
		};
		public static Move Copycat = new ()
		{
			Name = MoveNames.COPYCAT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user mimics the move used immediately before it. The move fails if no other move has been used yet.",
		};
		public static Move CourtChange = new ()
		{
			Name = MoveNames.COURTCHANGE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "With its mysterious power, the user swaps the effects on either side of the field.",
		};
		public static Move DefenseCurl = new ()
		{
			Name = MoveNames.DEFENSECURL,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.User,
			Description = "The user curls up to conceal weak spots and raise its Defense stat.",
		};
		public static Move Disable = new ()
		{
			Name = MoveNames.DISABLE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "For four turns, this move prevents the target from using the move it last used.",
		};
		public static Move DoubleTeam = new ()
		{
			Name = MoveNames.DOUBLETEAM,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.User,
			Description = "By moving rapidly, the user makes illusory copies of itself to raise its evasiveness.",
		};
		public static Move Encore = new ()
		{
			Name = MoveNames.ENCORE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user compels the target to keep using only the move it last used for three turns.",
		};
		public static Move Endure = new ()
		{
			Name = MoveNames.ENDURE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "The user endures any attack with at least 1 HP. Its chance of failing rises if it is used in succession.",
		};
		public static Move Entrainment = new ()
		{
			Name = MoveNames.ENTRAINMENT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user dances to compel the target to mimic it, making the target's Ability the same as the user's.",
		};
		public static Move Flash = new ()
		{
			Name = MoveNames.FLASH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user flashes a light that cuts the target's accuracy. It can also be used to illuminate caves.",
		};
		public static Move FocusEnergy = new ()
		{
			Name = MoveNames.FOCUSENERGY,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.User,
			Description = "The user takes a deep breath and focuses so that critical hits land more easily.",
		};
		public static Move FollowMe = new ()
		{
			Name = MoveNames.FOLLOWME,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Priority = 2,
			Description = "The user draws attention to itself, making all targets take aim only at the user.",
		};
		public static Move Foresight = new ()
		{
			Name = MoveNames.FORESIGHT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			Description = "Enables the user to hit a Ghost type with any kind of move. It also enables the user to hit an evasive foe.",
		};
		public static Move Glare = new ()
		{
			Name = MoveNames.GLARE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Description = "The user intimidates the target with the pattern on its belly to cause paralysis.",
		};
		public static Move Growl = new ()
		{
			Name = MoveNames.GROWL,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 40,
			Target = MoveTarget.AllNearFoes,
			IsSoundMove = true,
			Description = "The user growls in an endearing way, making the foe less wary. The foe's Attack stat is lowered.",
		};
		public static Move Growth = new ()
		{
			Name = MoveNames.GROWTH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user's body grows all at once, raising the Atk and Sp. Atk stats.",
		};
		public static Move HappyHour = new ()
		{
			Name = MoveNames.HAPPYHOUR,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.UserSide,
			Description = "Using Happy Hour doubles the amount of prize money received after battle.",
		};
		public static Move Harden = new ()
		{
			Name = MoveNames.HARDEN,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.User,
			Description = "The user stiffens all the muscles in its body to raise its Defense stat.",
		};
		public static Move HealBell = new ()
		{
			Name = MoveNames.HEALBELL,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.UserAndAllies,
			IsSoundMove = true,
			Description = "The user makes a soothing bell chime to heal the status problems of all the party Pokémon.",
		};
		public static Move HelpingHand = new ()
		{
			Name = MoveNames.HELPINGHAND,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearAlly,
			Priority = 5,
			Description = "The user assists an ally by boosting the power of its attack.",
		};
		public static Move HoldHands = new ()
		{
			Name = MoveNames.HOLDHANDS,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.NearAlly,
			Description = "The user and an ally hold hands. This makes them very happy.",
		};
		public static Move Howl = new ()
		{
			Name = MoveNames.HOWL,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.UserAndAllies,
			IsSoundMove = true,
			Description = "The user howls loudly to raise the spirit of itself and allies, boosting their Attack stats.",
		};
		public static Move LaserFocus = new ()
		{
			Name = MoveNames.LASERFOCUS,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.User,
			Description = "The user focuses intensely. The attack on the next turn always results in a critical hit.",
		};
		public static Move Leer = new ()
		{
			Name = MoveNames.LEER,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.AllNearFoes,
			Description = "The user gains an intimidating leer with sharp eyes. The target's Defense stat is reduced.",
		};
		public static Move LockOn = new ()
		{
			Name = MoveNames.LOCKON,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user takes sure aim at the target. It ensures the next attack does not fail to hit the target.",
		};
		public static Move LovelyKiss = new ()
		{
			Name = MoveNames.LOVELYKISS,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 75,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "With a scary face, the user tries to force a kiss on the target. If it suceeds, the target falls asleep.",
		};
		public static Move LuckyChant = new ()
		{
			Name = MoveNames.LUCKYCHANT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.UserSide,
			Description = "The user chants an incantation toward the sky, preventing the foe from landing critical hits.",
		};
		public static Move MeFirst = new ()
		{
			Name = MoveNames.MEFIRST,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearFoe,
			Description = "The user tries to cut ahead of the foe to steal and use the foe's intended move with greater power.",
		};
		public static Move MeanLook = new ()
		{
			Name = MoveNames.MEANLOOK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user pins the target with a dark, arresting look. The target becomes unable to flee.",
		};
		public static Move Metronome = new ()
		{
			Name = MoveNames.METRONOME,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user waggles a finger and stimulates its brain into randomly using nearly any move.",
		};
		public static Move MilkDrink = new ()
		{
			Name = MoveNames.MILKDRINK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user restores its own HP by up to half of its maximum HP. May also be used in the field to heal HP.",
		};
		public static Move Mimic = new ()
		{
			Name = MoveNames.MIMIC,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user copies the move last used by the foe. The move can be used until the user is switched out.",
		};
		public static Move MindReader = new ()
		{
			Name = MoveNames.MINDREADER,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user senses the foe's movements with its mind to ensure its next attack does not miss the foe.",
		};
		public static Move Minimize = new ()
		{
			Name = MoveNames.MINIMIZE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user compresses its body to make itself look smaller, which sharply raises its evasiveness.",
		};
		public static Move MorningSun = new ()
		{
			Name = MoveNames.MORNINGSUN,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.User,
			Description = "The user restores its own HP. The amount of HP regained varies with the weather.",
		};
		public static Move NaturePower = new ()
		{
			Name = MoveNames.NATUREPOWER,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "An attack that makes use of nature's power. Its effects vary depending on the user's environment.",
		};
		public static Move NobleRoar = new ()
		{
			Name = MoveNames.NOBLEROAR,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "Letting out a noble roar, the user intimidates the target and lowers its Attack and Sp. Atk.",
		};
		public static Move OdorSleuth = new ()
		{
			Name = MoveNames.ODORSLEUTH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			Description = "Enables the user to hit a Ghost type with any type of move. It also enables the user to hit an evasive foe.",
		};
		public static Move PainSplit = new ()
		{
			Name = MoveNames.PAINSPLIT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user adds its HP to the target's HP, then equally shares the combined HP with the target.",
		};
		public static Move PerishSong = new ()
		{
			Name = MoveNames.PERISHSONG,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.AllBattlers,
			IsSoundMove = true,
			Description = "Any Pokémon that hears this song faints in three turns, unless it switches out of battle.",
		};
		public static Move PlayNice = new ()
		{
			Name = MoveNames.PLAYNICE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user and target become friends. The target loses its will to fight, lowering its Attack stat.",
		};
		public static Move Protect = new ()
		{
			Name = MoveNames.PROTECT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "It enables the user to evade all attacks. Its chance of failing rises if it is used in succession.",
		};
		public static Move PsychUp = new ()
		{
			Name = MoveNames.PSYCHUP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user hypnotizes itself into copying any stat change made by the target.",
		};
		public static Move Recover = new ()
		{
			Name = MoveNames.RECOVER,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "Restoring its own cells, the user restores its own HP by half of its max HP.",
		};
		public static Move Recycle = new ()
		{
			Name = MoveNames.RECYCLE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user recycles a held item that has been used in battle so it can be used again.",
		};
		public static Move ReflectType = new ()
		{
			Name = MoveNames.REFLECTTYPE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user reflects the target's type, making it the same type as the target.",
		};
		public static Move Refresh = new ()
		{
			Name = MoveNames.REFRESH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user rests to cure itself of a poisoning, burn, or paralysis.",
		};
		public static Move Roar = new ()
		{
			Name = MoveNames.ROAR,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Priority = -6,
			IsSoundMove = true,
			Description = "The target is scared off and replaced by another Pokémon in its party. In the wild, the battle ends.",
		};
		public static Move Safeguard = new ()
		{
			Name = MoveNames.SAFEGUARD,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 25,
			Target = MoveTarget.UserSide,
			Description = "The user creates a protective field that prevents status problems for five turns.",
		};
		public static Move ScaryFace = new ()
		{
			Name = MoveNames.SCARYFACE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user frightens the target with a scary face to harshly reduce its Speed stat.",
		};
		public static Move Screech = new ()
		{
			Name = MoveNames.SCREECH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 85,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "An earsplitting screech harshly reduces the target's Defense stat.",
		};
		public static Move Sharpen = new ()
		{
			Name = MoveNames.SHARPEN,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.User,
			Description = "The user reduces its polygon count to make itself more jagged, raising the Attack stat.",
		};
		public static Move ShellSmash = new ()
		{
			Name = MoveNames.SHELLSMASH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.User,
			Description = "The user breaks its shell, lowering its defenses but sharply raising attacking and Speed stats.",
		};
		public static Move SimpleBeam = new ()
		{
			Name = MoveNames.SIMPLEBEAM,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user's mysterious psychic wave changes the target's Ability to Simple.",
		};
		public static Move Sing = new ()
		{
			Name = MoveNames.SING,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 55,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "A soothing lullaby is sung in a calming voice that puts the target into a deep slumber.",
		};
		public static Move Sketch = new ()
		{
			Name = MoveNames.SKETCH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 1,
			Target = MoveTarget.NearOther,
			Description = "It enables the user to permanently learn the move last used by the foe. Once used, Sketch disappears.",
		};
		public static Move SlackOff = new ()
		{
			Name = MoveNames.SLACKOFF,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user slacks off, restoring its own HP by up to half of its maximum HP.",
		};
		public static Move SleepTalk = new ()
		{
			Name = MoveNames.SLEEPTALK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "While it is asleep, the user randomly uses one of the moves it knows.",
		};
		public static Move Smokescreen = new ()
		{
			Name = MoveNames.SMOKESCREEN,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user releases an obscuring cloud of smoke or ink. It reduces the target's accuracy.",
		};
		public static Move SoftBoiled = new ()
		{
			Name = MoveNames.SOFTBOILED,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user restores its own HP by up to half of its maximum HP. May also be used in the field to heal HP.",
		};
		public static Move Splash = new ()
		{
			Name = MoveNames.SPLASH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.User,
			Description = "The user just flops and splashes around to no effect at all...",
		};
		public static Move Spotlight = new ()
		{
			Name = MoveNames.SPOTLIGHT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Priority = 3,
			Description = "The user shines a spotlight on the target so that only it will be attacked during the turn.",
		};
		public static Move Stockpile = new ()
		{
			Name = MoveNames.STOCKPILE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user charges up power and raises both its Defense and Sp. Def. The move can be used three times.",
		};
		public static Move StuffCheeks = new ()
		{
			Name = MoveNames.STUFFCHEEKS,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user eats its held Berry, then sharply raises its Defense stat.",
		};
		public static Move Substitute = new ()
		{
			Name = MoveNames.SUBSTITUTE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user makes a copy of itself using some of its HP. The copy serves as the user's decoy.",
		};
		public static Move Supersonic = new ()
		{
			Name = MoveNames.SUPERSONIC,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 55,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "The user generates odd sound waves from its body. It may confuse the target.",
		};
		public static Move Swagger = new ()
		{
			Name = MoveNames.SWAGGER,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user enrages and confuses the target. However, it also sharply raises the target's Attack stat.",
		};
		public static Move Swallow = new ()
		{
			Name = MoveNames.SWALLOW,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The power stored using the move Stockpile is absorbed by the user to heal its HP.",
		};
		public static Move SweetScent = new ()
		{
			Name = MoveNames.SWEETSCENT,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearFoes,
			Description = "A sweet scent that lowers the foe's evasiveness. It also lures wild Pokémon if used in grass, etc.",
		};
		public static Move SwordsDance = new ()
		{
			Name = MoveNames.SWORDSDANCE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			IsDanceMove = true,
			Description = "A frenetic dance to uplift the fighting spirit. It sharply raises the user's Attack stat.",
		};
		public static Move TailWhip = new ()
		{
			Name = MoveNames.TAILWHIP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.AllNearFoes,
			Description = "The user wags its tail cutely, making opposing Pokémon less wary and lowering their Defense stat.",
		};
		public static Move TearfulLook = new ()
		{
			Name = MoveNames.TEARFULLOOK,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "Gets teary eyed to make the target lose its will to fight. Lowers the target's Attack and Sp. Atk.",
		};
		public static Move Teatime = new ()
		{
			Name = MoveNames.TEATIME,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.AllBattlers,
			Description = "The user has teatime with all the Pokémon in the battle. Each Pokémon eats its held Berry.",
		};
		public static Move TeeterDance = new ()
		{
			Name = MoveNames.TEETERDANCE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearOthers,
			IsDanceMove = true,
			Description = "The user performs a wobbly dance that confuses the Pokémon around it.",
		};
		public static Move Tickle = new ()
		{
			Name = MoveNames.TICKLE,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user tickles the target into laughing, reducing its Attack and Defense stats.",
		};
		public static Move Transform = new ()
		{
			Name = MoveNames.TRANSFORM,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user transforms into a copy of the target right down to having the same move set.",
		};
		public static Move Whirlwind = new ()
		{
			Name = MoveNames.WHIRLWIND,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Priority = -6,
			Description = "The foe is blown away, to be replaced by another Pokémon in its party. In the wild, the battle ends.",
		};
		public static Move Wish = new ()
		{
			Name = MoveNames.WISH,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "One turn after this move is used, the target's HP is restored by half the user's maximum HP.",
		};
		public static Move WorkUp = new ()
		{
			Name = MoveNames.WORKUP,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.User,
			Description = "The user is roused, and its Attack and Sp. Atk stats increase.",
		};
		public static Move Yawn = new ()
		{
			Name = MoveNames.YAWN,
			MoveType = PokemonType.Normal,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user lets loose a huge yawn that lulls the target into falling asleep on the next turn.",
		};
		public static Move Belch = new ()
		{
			Name = MoveNames.BELCH,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user lets out a damaging belch at the target. The user must eat a held Berry to use this move.",
		};
		public static Move GunkShot = new ()
		{
			Name = MoveNames.GUNKSHOT,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Physical,
			BasePower = 120,
			Accuracy = 80,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user shoots filthy garbage at the target to attack. It may also poison the target.",
		};
		public static Move SludgeWave = new ()
		{
			Name = MoveNames.SLUDGEWAVE,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 95,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearOthers,
			Description = "It swamps the area around the user with a giant sludge wave. It may also poison those hit.",
		};
		public static Move ShellSideArm = new ()
		{
			Name = MoveNames.SHELLSIDEARM,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "Inflicts physical or special damage, whichever will be more effective. May also poison the target.",
		};
		public static Move SludgeBomb = new ()
		{
			Name = MoveNames.SLUDGEBOMB,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "Unsanitary sludge is hurled at the target. It may also poison the target.",
		};
		public static Move PoisonJab = new ()
		{
			Name = MoveNames.POISONJAB,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is stabbed with a tentacle or arm seeped with poison. It may also poison the target.",
		};
		public static Move CrossPoison = new ()
		{
			Name = MoveNames.CROSSPOISON,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "A slashing attack with a poisonous blade that may also poison the foe. Critical hits land more easily.",
		};
		public static Move Sludge = new ()
		{
			Name = MoveNames.SLUDGE,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "Unsanitary sludge is hurled at the target. It may also poison the target.",
		};
		public static Move Venoshock = new ()
		{
			Name = MoveNames.VENOSHOCK,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user drenches the foe in a special poisonous liquid. Its power doubles if the target is poisoned.",
		};
		public static Move ClearSmog = new ()
		{
			Name = MoveNames.CLEARSMOG,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 50,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user attacks by throwing a clump of special mud. All status changes are returned to normal.",
		};
		public static Move PoisonFang = new ()
		{
			Name = MoveNames.POISONFANG,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBitingMove = true,
			Description = "The user bites the target with toxic fangs. It may also leave the target badly poisoned.",
		};
		public static Move PoisonTail = new ()
		{
			Name = MoveNames.POISONTAIL,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The user hits the target with its tail. It may also poison the target. Critical hits land more easily.",
		};
		public static Move Acid = new ()
		{
			Name = MoveNames.ACID,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.AllNearFoes,
			Description = "The foe is attacked with a spray of harsh acid. It may also lower the target's Sp. Def stat.",
		};
		public static Move AcidSpray = new ()
		{
			Name = MoveNames.ACIDSPRAY,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user spits fluid that works to melt the target. This harshly reduces the target's Sp. Def stat.",
		};
		public static Move Smog = new ()
		{
			Name = MoveNames.SMOG,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Special,
			BasePower = 30,
			Accuracy = 70,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The target is attacked with a discharge of filthy gases. It may also poison the target.",
		};
		public static Move PoisonSting = new ()
		{
			Name = MoveNames.POISONSTING,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Physical,
			BasePower = 15,
			Accuracy = 100,
			PowerPoints = 35,
			Target = MoveTarget.NearOther,
			Description = "The user stabs the target with a poisonous stinger. This may also poison the target.",
		};
		public static Move AcidArmor = new ()
		{
			Name = MoveNames.ACIDARMOR,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user alters its cellular structure to liquefy itself, sharply raising its Defense stat.",
		};
		public static Move BanefulBunker = new ()
		{
			Name = MoveNames.BANEFULBUNKER,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "Protects the user from attacks. Also poisons any attacker that makes contact with the user.",
		};
		public static Move Coil = new ()
		{
			Name = MoveNames.COIL,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user coils up and concentrates. This raises its Attack and Defense stats as well as its accuracy.",
		};
		public static Move CorrosiveGas = new ()
		{
			Name = MoveNames.CORROSIVEGAS,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 40,
			Target = MoveTarget.AllNearOthers,
			Description = "The user surrounds everything around it with highly acidic gas and melts away items they hold.",
		};
		public static Move GastroAcid = new ()
		{
			Name = MoveNames.GASTROACID,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user hurls up its stomach acids on the foe. The fluid negates the effect of the target's Ability.",
		};
		public static Move PoisonGas = new ()
		{
			Name = MoveNames.POISONGAS,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 90,
			PowerPoints = 40,
			Target = MoveTarget.AllNearFoes,
			Description = "A cloud of poison gas is sprayed in the face of opposing Pokémon. It may poison those hit.",
		};
		public static Move PoisonPowder = new ()
		{
			Name = MoveNames.POISONPOWDER,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 75,
			PowerPoints = 35,
			Target = MoveTarget.NearOther,
			IsPowderMove = true,
			Description = "The user scatters a cloud of poisonous dust on the target. It may poison the target.",
		};
		public static Move Purify = new ()
		{
			Name = MoveNames.PURIFY,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user heals the target's status condition. If so, it also restores the user's own HP.",
		};
		public static Move Toxic = new ()
		{
			Name = MoveNames.TOXIC,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A move that leaves the target badly poisoned. Its poison damage worsens every turn.",
		};
		public static Move ToxicSpikes = new ()
		{
			Name = MoveNames.TOXICSPIKES,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.FoeSide,
			Description = "The user lays a trap of poison spikes at the foe's feet. They poison foes that switch into battle.",
		};
		public static Move ToxicThread = new ()
		{
			Name = MoveNames.TOXICTHREAD,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user shoots poisonous threads to poison the target and lower the target's Speed stat.",
		};
		public static Move VenomDrench = new ()
		{
			Name = MoveNames.VENOMDRENCH,
			MoveType = PokemonType.Poison,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.AllNearFoes,
			Description = "Foes are drenched in an odd liquid that lowers the Attack, Sp. Atk, and Speed of poisoned Pokémon.",
		};
		public static Move PrismaticLaser = new ()
		{
			Name = MoveNames.PRISMATICLASER,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 160,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user shoots powerful lasers using the power of a prism. The user can't move on the next turn.",
		};
		public static Move PsychoBoost = new ()
		{
			Name = MoveNames.PSYCHOBOOST,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 140,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user attacks the target at full power. The attack's recoil harshly reduces the user's Sp. Atk stat.",
		};
		public static Move FutureSight = new ()
		{
			Name = MoveNames.FUTURESIGHT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "Two turns after this move is used, a hunk of psychic energy attacks the target.",
		};
		public static Move Synchronoise = new ()
		{
			Name = MoveNames.SYNCHRONOISE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearOthers,
			Description = "Using an odd shock wave, the user damages any Pokémon of the same type as the user.",
		};
		public static Move DreamEater = new ()
		{
			Name = MoveNames.DREAMEATER,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user eats the dreams of a sleeping foe. It absorbs half the damage caused to heal the user's HP.",
		};
		public static Move PhotonGeyser = new ()
		{
			Name = MoveNames.PHOTONGEYSER,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user attacks with a pillar of light. This move the higher of the user's Attack or Sp. Atk stat.",
		};
		public static Move Psystrike = new ()
		{
			Name = MoveNames.PSYSTRIKE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user materializes an odd psychic wave to attack the target. This attack does physical damage.",
		};
		public static Move FreezingGlare = new ()
		{
			Name = MoveNames.FREEZINGGLARE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user shoots its psychic power from its eyes to attack. This may also leave the target frozen.",
		};
		public static Move Psychic = new ()
		{
			Name = MoveNames.PSYCHIC,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The target is hit by a strong telekinetic force. It may also reduce the target's Sp. Def stat.",
		};
		public static Move PsychicFangs = new ()
		{
			Name = MoveNames.PSYCHICFANGS,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBitingMove = true,
			Description = "The user bites the target using psychic capabilities. This can also destroy Light Screen and Reflect.",
		};
		public static Move EerieSpell = new ()
		{
			Name = MoveNames.EERIESPELL,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "The user attacks with tremendous psychic power. This also removes 3 PP from the target's last move.",
		};
		public static Move ExpandingForce = new ()
		{
			Name = MoveNames.EXPANDINGFORCE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user attacks the target with psychic power. Powers up and hits all foes on Psychic Terrain.",
		};
		public static Move Extrasensory = new ()
		{
			Name = MoveNames.EXTRASENSORY,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user attacks with an odd, unseeable power. It may also make the target flinch.",
		};
		public static Move HyperspaceHole = new ()
		{
			Name = MoveNames.HYPERSPACEHOLE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "Using a hyperspace hole, the user appears right next to the target and strikes. Skips protections.",
		};
		public static Move Psyshock = new ()
		{
			Name = MoveNames.PSYSHOCK,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user materializes an odd psychic wave to attack the target. This attack does physical damage.",
		};
		public static Move ZenHeadbutt = new ()
		{
			Name = MoveNames.ZENHEADBUTT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 90,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user focuses its willpower to its head and attacks the foe. It may also make the target flinch.",
		};
		public static Move LusterPurge = new ()
		{
			Name = MoveNames.LUSTERPURGE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user lets loose a damaging burst of light. It may also reduce the target's Sp. Def stat.",
		};
		public static Move MistBall = new ()
		{
			Name = MoveNames.MISTBALL,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "A mistlike flurry of down envelops and damages the target. It may also lower the target's Sp. Atk.",
		};
		public static Move PsychoCut = new ()
		{
			Name = MoveNames.PSYCHOCUT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			HasHighCritRate = true,
			Description = "The user tears at the target with blades formed by psychic power. Critical hits land more easily.",
		};
		public static Move Psybeam = new ()
		{
			Name = MoveNames.PSYBEAM,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The target is attacked with a peculiar ray. It may also cause confusion.",
		};
		public static Move HeartStamp = new ()
		{
			Name = MoveNames.HEARTSTAMP,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user unleashes a vicious blow after its cute act makes the foe less wary. It may also cause flinching.",
		};
		public static Move Confusion = new ()
		{
			Name = MoveNames.CONFUSION,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			Description = "The target is hit by a weak telekinetic force. It may also leave the target confused.",
		};
		public static Move StoredPower = new ()
		{
			Name = MoveNames.STOREDPOWER,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 20,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user attacks with stored power. The more the user's stats are raised, the greater the damage.",
		};
		public static Move MirrorCoat = new ()
		{
			Name = MoveNames.MIRRORCOAT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.None,
			Priority = -5,
			Description = "A retaliation move that counters any special attack, inflicting double the damage taken.",
		};
		public static Move Psywave = new ()
		{
			Name = MoveNames.PSYWAVE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Special,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The target is attacked with an odd psychic wave. The attack varies in intensity.",
		};
		public static Move Agility = new ()
		{
			Name = MoveNames.AGILITY,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.User,
			Description = "The user relaxes and lightens its body to move faster. It sharply boosts the Speed stat.",
		};
		public static Move AllySwitch = new ()
		{
			Name = MoveNames.ALLYSWITCH,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.User,
			Priority = 2,
			Description = "The user teleports using a strange power and switches its place with one of its allies.",
		};
		public static Move Amnesia = new ()
		{
			Name = MoveNames.AMNESIA,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user temporarily empties its mind to forget its concerns. It sharply raises the user's Sp. Def stat.",
		};
		public static Move Barrier = new ()
		{
			Name = MoveNames.BARRIER,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user throws up a sturdy wall that sharply raises its Defense stat.",
		};
		public static Move CalmMind = new ()
		{
			Name = MoveNames.CALMMIND,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user quietly focuses its mind and calms its spirit to raise its Sp. Atk and Sp. Def stats.",
		};
		public static Move CosmicPower = new ()
		{
			Name = MoveNames.COSMICPOWER,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user absorbs a mystical power from space to raise its Defense and Sp. Def stats.",
		};
		public static Move Gravity = new ()
		{
			Name = MoveNames.GRAVITY,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.BothSides,
			Description = "Gravity is intensified for five turns, making moves involving flying unusable and negating Levitation.",
		};
		public static Move GuardSplit = new ()
		{
			Name = MoveNames.GUARDSPLIT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user employs its psychic power to average its Defense and Sp. Def stats with those of its target.",
		};
		public static Move GuardSwap = new ()
		{
			Name = MoveNames.GUARDSWAP,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user employs its psychic power to switch changes to its Defense and Sp. Def with the target.",
		};
		public static Move HealBlock = new ()
		{
			Name = MoveNames.HEALBLOCK,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.AllNearFoes,
			Description = "For five turns, the foe is prevented from using any moves, Abilities, or held items that recover HP.",
		};
		public static Move HealPulse = new ()
		{
			Name = MoveNames.HEALPULSE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.Other,
			IsPulseMove = true,
			Description = "The user emits a healing pulse which restores the target's HP by up to half of its max HP.",
		};
		public static Move HealingWish = new ()
		{
			Name = MoveNames.HEALINGWISH,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user faints. In return, the Pokémon taking its place will have its HP restored and status cured.",
		};
		public static Move HeartSwap = new ()
		{
			Name = MoveNames.HEARTSWAP,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user employs its psychic power to switch stat changes with the target.",
		};
		public static Move Hypnosis = new ()
		{
			Name = MoveNames.HYPNOSIS,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 60,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user employs hypnotic suggestion to make the target fall into a deep sleep.",
		};
		public static Move Imprison = new ()
		{
			Name = MoveNames.IMPRISON,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "If the foe knows any move also known by the user, the foe is prevented from using it.",
		};
		public static Move Instruct = new ()
		{
			Name = MoveNames.INSTRUCT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user instructs the target to use the target's last move again.",
		};
		public static Move Kinesis = new ()
		{
			Name = MoveNames.KINESIS,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 80,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user distracts the target by bending a spoon. It lowers the target's accuracy.",
		};
		public static Move LightScreen = new ()
		{
			Name = MoveNames.LIGHTSCREEN,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 30,
			Target = MoveTarget.UserSide,
			Description = "A wondrous wall of light is put up to suppress damage from special attacks for five turns.",
		};
		public static Move LunarDance = new ()
		{
			Name = MoveNames.LUNARDANCE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			IsDanceMove = true,
			Description = "The user faints. In return, the Pokémon taking its place will have its status and HP fully restored.",
		};
		public static Move MagicCoat = new ()
		{
			Name = MoveNames.MAGICCOAT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "A barrier reflects back to the target moves like Leech Seed and moves that damage status.",
		};
		public static Move MagicPowder = new ()
		{
			Name = MoveNames.MAGICPOWDER,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsPowderMove = true,
			Description = "The user scatters a cloud of magic powder that changes the target to Psychic type.",
		};
		public static Move MagicRoom = new ()
		{
			Name = MoveNames.MAGICROOM,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "The user creates a bizarre area in which Pokémon's held items lose their effects for five turns.",
		};
		public static Move Meditate = new ()
		{
			Name = MoveNames.MEDITATE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.User,
			Description = "The user meditates to awaken the power deep within its body and raise its Attack stat.",
		};
		public static Move MiracleEye = new ()
		{
			Name = MoveNames.MIRACLEEYE,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			Description = "Enables the user to hit a Dark type with any type of move. It also enables the user to hit an evasive foe.",
		};
		public static Move PowerSplit = new ()
		{
			Name = MoveNames.POWERSPLIT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user employs its psychic power to average its Attack and Sp. Atk stats with those of the target.",
		};
		public static Move PowerSwap = new ()
		{
			Name = MoveNames.POWERSWAP,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user employs its psychic power to switch changes to its Attack and Sp. Atk with the target.",
		};
		public static Move PowerTrick = new ()
		{
			Name = MoveNames.POWERTRICK,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user employs its psychic power to switch its Attack with its Defense stat.",
		};
		public static Move PsychicTerrain = new ()
		{
			Name = MoveNames.PSYCHICTERRAIN,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "Protects grounded Pokémon from priority moves and powers up Psychic-type moves for five turns.",
		};
		public static Move PsychoShift = new ()
		{
			Name = MoveNames.PSYCHOSHIFT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "Using its psychic power of suggestion, the user transfers its status problems to the target.",
		};
		public static Move Reflect = new ()
		{
			Name = MoveNames.REFLECT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.UserSide,
			Description = "A wondrous wall of light is put up to suppress damage from physical attacks for five turns.",
		};
		public static Move Rest = new ()
		{
			Name = MoveNames.REST,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user goes to sleep for two turns. It fully restores the user's HP and heals any status problem.",
		};
		public static Move RolePlay = new ()
		{
			Name = MoveNames.ROLEPLAY,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user mimics the target completely, copying the target's natural Ability.",
		};
		public static Move SkillSwap = new ()
		{
			Name = MoveNames.SKILLSWAP,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user employs its psychic power to exchange Abilities with the target.",
		};
		public static Move SpeedSwap = new ()
		{
			Name = MoveNames.SPEEDSWAP,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user exchanges Speed stats with the target.",
		};
		public static Move Telekinesis = new ()
		{
			Name = MoveNames.TELEKINESIS,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user makes the target float with its psychic power. The target is easier to hit for three turns.",
		};
		public static Move Teleport = new ()
		{
			Name = MoveNames.TELEPORT,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Priority = -6,
			Description = "The user switches place with a party Pokémon. Also warps to the last Pokémon Center visited.",
		};
		public static Move Trick = new ()
		{
			Name = MoveNames.TRICK,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user catches the target off guard and swaps its held item with its own.",
		};
		public static Move TrickRoom = new ()
		{
			Name = MoveNames.TRICKROOM,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.BothSides,
			Priority = -7,
			Description = "The user creates a bizarre area in which slower Pokémon get to move first for five turns.",
		};
		public static Move WonderRoom = new ()
		{
			Name = MoveNames.WONDERROOM,
			MoveType = PokemonType.Psychic,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Priority = -7,
			Description = "The user creates a bizarre area in which Pokémon's Defense and Sp. Def stats are swapped for 5 turns.",
		};
		public static Move HeadSmash = new ()
		{
			Name = MoveNames.HEADSMASH,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 150,
			Accuracy = 80,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks the foe with a hazardous, full-power headbutt. The user also takes terrible damage.",
		};
		public static Move RockWrecker = new ()
		{
			Name = MoveNames.ROCKWRECKER,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 150,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user launches a huge boulder at the target to attack. It must rest on the next turn, however.",
		};
		public static Move MeteorBeam = new ()
		{
			Name = MoveNames.METEORBEAM,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Special,
			BasePower = 120,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "Gathers space power and boosts its Sp. Atk stat on the first turn, attacks on the next turn.",
		};
		public static Move DiamondStorm = new ()
		{
			Name = MoveNames.DIAMONDSTORM,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 95,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Description = "The user whips up a storm of diamonds to damage foes. This may also sharply raise the user's Defense stat.",
		};
		public static Move StoneEdge = new ()
		{
			Name = MoveNames.STONEEDGE,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 80,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			HasHighCritRate = true,
			Description = "The user stabs the foe with sharpened stones from below. It has a high critical-hit ratio.",
		};
		public static Move PowerGem = new ()
		{
			Name = MoveNames.POWERGEM,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user attacks with a ray of light that sparkles as if it were made of gemstones.",
		};
		public static Move RockSlide = new ()
		{
			Name = MoveNames.ROCKSLIDE,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "Large boulders are hurled at the foes to inflict damage. It may also make the targets flinch.",
		};
		public static Move AncientPower = new ()
		{
			Name = MoveNames.ANCIENTPOWER,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user attacks with a prehistoric power. It may also raise all the user's stats at once.",
		};
		public static Move RockTomb = new ()
		{
			Name = MoveNames.ROCKTOMB,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 95,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "Boulders are hurled at the target. It also lowers the target's Speed by preventing its movement.",
		};
		public static Move RockThrow = new ()
		{
			Name = MoveNames.ROCKTHROW,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 90,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user picks up and throws a small rock at the target to attack.",
		};
		public static Move SmackDown = new ()
		{
			Name = MoveNames.SMACKDOWN,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user throws a stone or projectile to attack. A flying Pokémon will fall to the ground when hit.",
		};
		public static Move Accelerock = new ()
		{
			Name = MoveNames.ACCELEROCK,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Priority = 1,
			IsContactMove = true,
			Description = "The user smashes into the target at high speed. This move always goes first.",
		};
		public static Move Rollout = new ()
		{
			Name = MoveNames.ROLLOUT,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 30,
			Accuracy = 90,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user continually rolls into the target over five turns. It becomes stronger each time it hits.",
		};
		public static Move RockBlast = new ()
		{
			Name = MoveNames.ROCKBLAST,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user hurls hard rocks at the target. Two to five rocks are launched in quick succession.",
		};
		public static Move RockPolish = new ()
		{
			Name = MoveNames.ROCKPOLISH,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user polishes its body to reduce drag. It can sharply raise the Speed stat.",
		};
		public static Move Sandstorm = new ()
		{
			Name = MoveNames.SANDSTORM,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.BothSides,
			Description = "Summons a five-turn sandstorm to hurt all combatants except the Rock, Ground, and Steel types.",
		};
		public static Move StealthRock = new ()
		{
			Name = MoveNames.STEALTHROCK,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.FoeSide,
			Description = "The user lays a trap of levitating stones around the foe. The trap hurts foes that switch into battle.",
		};
		public static Move TarShot = new ()
		{
			Name = MoveNames.TARSHOT,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "Pours sticky tar over the target, lowering its Speed and making it weaker to Fire-type moves.",
		};
		public static Move WideGuard = new ()
		{
			Name = MoveNames.WIDEGUARD,
			MoveType = PokemonType.Rock,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.UserSide,
			Priority = 3,
			Description = "The user and its allies are protected from wide-ranging attacks for a turn. May fail if used in succession.",
		};
		public static Move DoomDesire = new ()
		{
			Name = MoveNames.DOOMDESIRE,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Special,
			BasePower = 140,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "Two turns after this move is used, the user blasts the target with a concentrated bundle of light.",
		};
		public static Move SteelBeam = new ()
		{
			Name = MoveNames.STEELBEAM,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Special,
			BasePower = 140,
			Accuracy = 95,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user fires a beam of steel that it collected from its entire body. This also damages the user.",
		};
		public static Move SteelRoller = new ()
		{
			Name = MoveNames.STEELROLLER,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 130,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks while destroying the terrain. This move fails when the ground isn't a terrain.",
		};
		public static Move BehemothBash = new ()
		{
			Name = MoveNames.BEHEMOTHBASH,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user becomes a gigantic shield and slams into the target.",
		};
		public static Move BehemothBlade = new ()
		{
			Name = MoveNames.BEHEMOTHBLADE,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user becomes a gigantic sword and cuts the target.",
		};
		public static Move IronTail = new ()
		{
			Name = MoveNames.IRONTAIL,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 75,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is slammed with a steel-hard tail. It may also lower the target's Defense stat.",
		};
		public static Move SunsteelStrike = new ()
		{
			Name = MoveNames.SUNSTEELSTRIKE,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slams into the target with the force of a meteor. Can't be stopped by the target's Ability.",
		};
		public static Move MeteorMash = new ()
		{
			Name = MoveNames.METEORMASH,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The target is hit with a hard punch fired like a meteor. It may also raise the user's Attack.",
		};
		public static Move AnchorShot = new ()
		{
			Name = MoveNames.ANCHORSHOT,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user entangles the target with its anchor chain. The target becomes unable to flee.",
		};
		public static Move FlashCannon = new ()
		{
			Name = MoveNames.FLASHCANNON,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user gathers all its light energy and releases it at once. It may also lower the target's Sp. Def stat.",
		};
		public static Move IronHead = new ()
		{
			Name = MoveNames.IRONHEAD,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The foe slams the target with its steel-hard head. It may also make the target flinch.",
		};
		public static Move SmartStrike = new ()
		{
			Name = MoveNames.SMARTSTRIKE,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user stabs the target with a sharp horn. This attack never misses.",
		};
		public static Move SteelWing = new ()
		{
			Name = MoveNames.STEELWING,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 70,
			Accuracy = 90,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is hit with wings of steel. It may also raise the user's Defense stat.",
		};
		public static Move DoubleIronBash = new ()
		{
			Name = MoveNames.DOUBLEIRONBASH,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user rotates, centering the hex nut in its chest, and then strikes twice. May cause flinching.",
		};
		public static Move MirrorShot = new ()
		{
			Name = MoveNames.MIRRORSHOT,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "The user looses a flash of energy from its polished body. It may also lower the target's accuracy.",
		};
		public static Move MagnetBomb = new ()
		{
			Name = MoveNames.MAGNETBOMB,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user launches steel bombs that stick to the target. This attack will not miss.",
		};
		public static Move GearGrind = new ()
		{
			Name = MoveNames.GEARGRIND,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks by throwing two steel gears at its target.",
		};
		public static Move MetalClaw = new ()
		{
			Name = MoveNames.METALCLAW,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 50,
			Accuracy = 95,
			PowerPoints = 35,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is raked with steel claws. It may also raise the user's Attack stat.",
		};
		public static Move BulletPunch = new ()
		{
			Name = MoveNames.BULLETPUNCH,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.NearOther,
			Priority = 1,
			IsContactMove = true,
			IsPunchingMove = true,
			Description = "The user strikes the target with tough punches as fast as bullets. This move always goes first.",
		};
		public static Move GyroBall = new ()
		{
			Name = MoveNames.GYROBALL,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			IsBombMove = true,
			Description = "The user tackles the target with a high-speed spin. The slower the user, the greater the damage.",
		};
		public static Move HeavySlam = new ()
		{
			Name = MoveNames.HEAVYSLAM,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			TramplesMinimize = true,
			Description = "The user slams into the foe with its heavy body. The heavier the user, the greater the damage.",
		};
		public static Move MetalBurst = new ()
		{
			Name = MoveNames.METALBURST,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Physical,
			BasePower = 1,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.None,
			Description = "The user retaliates with much greater power against the target that last inflicted damage on it.",
		};
		public static Move Autotomize = new ()
		{
			Name = MoveNames.AUTOTOMIZE,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.User,
			Description = "The user sheds part of its body to make itself lighter and sharply raise its Speed stat.",
		};
		public static Move GearUp = new ()
		{
			Name = MoveNames.GEARUP,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.UserAndAllies,
			Description = "The user engages its gears to raise the Attack and Sp. Atk of allies with the Plus or Minus Ability.",
		};
		public static Move IronDefense = new ()
		{
			Name = MoveNames.IRONDEFENSE,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.User,
			Description = "The user hardens its body's surface like iron, sharply raising its Defense stat.",
		};
		public static Move KingsShield = new ()
		{
			Name = MoveNames.KINGSSHIELD,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Priority = 4,
			Description = "Protects itself from damage. It also harshly lowers the Attack of attackers that make contact.",
		};
		public static Move MetalSound = new ()
		{
			Name = MoveNames.METALSOUND,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Status,
			Accuracy = 85,
			PowerPoints = 40,
			Target = MoveTarget.NearOther,
			IsSoundMove = true,
			Description = "A horrible sound like scraping metal harshly reduces the target's Sp. Def stat.",
		};
		public static Move ShiftGear = new ()
		{
			Name = MoveNames.SHIFTGEAR,
			MoveType = PokemonType.Steel,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.User,
			Description = "The user rotates its gears, raising its Attack and sharply raising its Speed.",
		};
		public static Move HydroCannon = new ()
		{
			Name = MoveNames.HYDROCANNON,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 90,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The target is hit with a watery blast. The user must rest on the next turn, however.",
		};
		public static Move WaterSpout = new ()
		{
			Name = MoveNames.WATERSPOUT,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 150,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.AllNearFoes,
			Description = "The user spouts water to damage the foe. The lower the user's HP, the less powerful it becomes.",
		};
		public static Move HydroPump = new ()
		{
			Name = MoveNames.HYDROPUMP,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 110,
			Accuracy = 80,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The target is blasted by a huge volume of water launched under great pressure.",
		};
		public static Move OriginPulse = new ()
		{
			Name = MoveNames.ORIGINPULSE,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 110,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			IsPulseMove = true,
			Description = "The user attacks opposing Pokémon with countless beams of light that glow a deep and brilliant blue.",
		};
		public static Move SteamEruption = new ()
		{
			Name = MoveNames.STEAMERUPTION,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 110,
			Accuracy = 95,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			Description = "The user immerses the target in superheated steam. This may also leave the target with a burn.",
		};
		public static Move Crabhammer = new ()
		{
			Name = MoveNames.CRABHAMMER,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 100,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			HasHighCritRate = true,
			Description = "The target is hammered with a large pincer. Critical hits land more easily.",
		};
		public static Move AquaTail = new ()
		{
			Name = MoveNames.AQUATAIL,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 90,
			Accuracy = 90,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user attacks by swinging its tail as if it were a vicious wave in a raging storm.",
		};
		public static Move MuddyWater = new ()
		{
			Name = MoveNames.MUDDYWATER,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.AllNearFoes,
			Description = "The user attacks by shooting muddy water at the opposing team. It may also lower the target's accuracy.",
		};
		public static Move SparklingAria = new ()
		{
			Name = MoveNames.SPARKLINGARIA,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.AllNearOthers,
			IsSoundMove = true,
			Description = "The user bursts into song, emitting many bubbles. Any burnt Pokémon will be healed by these bubbles.",
		};
		public static Move Surf = new ()
		{
			Name = MoveNames.SURF,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 90,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.AllNearOthers,
			Description = "It swamps the area around the user with a giant wave. It can also be used for crossing water.",
		};
		public static Move FishiousRend = new ()
		{
			Name = MoveNames.FISHIOUSREND,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user rends the target with its hard gills. Power doubles if the user moves first.",
		};
		public static Move Liquidation = new ()
		{
			Name = MoveNames.LIQUIDATION,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 85,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user slams into the target using a full-force blast of water. May lower the target's Defense.",
		};
		public static Move Dive = new ()
		{
			Name = MoveNames.DIVE,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Diving on the first turn, the user rises and hits on the next turn. It can be used to dive in the ocean.",
		};
		public static Move Scald = new ()
		{
			Name = MoveNames.SCALD,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "The user shoots boiling hot water at its target. It may also leave the target with a burn.",
		};
		public static Move SnipeShot = new ()
		{
			Name = MoveNames.SNIPESHOT,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			HasHighCritRate = true,
			Description = "The user ignores any effects that redirect moves, allowing this move to hit the chosen target.",
		};
		public static Move WaterPledge = new ()
		{
			Name = MoveNames.WATERPLEDGE,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "A column of water strikes the target. When combined with its fire equivalent, it makes a rainbow.",
		};
		public static Move Waterfall = new ()
		{
			Name = MoveNames.WATERFALL,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 80,
			Accuracy = 100,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user charges at the target and may make it flinch. It can also be used to climb a waterfall.",
		};
		public static Move RazorShell = new ()
		{
			Name = MoveNames.RAZORSHELL,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 75,
			Accuracy = 95,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The user cuts the foe with sharp shells. It may also lower the target's Defense stat.",
		};
		public static Move Brine = new ()
		{
			Name = MoveNames.BRINE,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			Description = "If the target's HP is down to about half, this attack will hit with double the power.",
		};
		public static Move BubbleBeam = new ()
		{
			Name = MoveNames.BUBBLEBEAM,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "A spray of bubbles is forcefully ejected at the target. It may also lower its Speed stat.",
		};
		public static Move Octazooka = new ()
		{
			Name = MoveNames.OCTAZOOKA,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 65,
			Accuracy = 85,
			PowerPoints = 10,
			Target = MoveTarget.NearOther,
			IsBombMove = true,
			Description = "The user attacks by spraying ink in the foe's face or eyes. It may also lower the target's accuracy.",
		};
		public static Move FlipTurn = new ()
		{
			Name = MoveNames.FLIPTURN,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.",
		};
		public static Move WaterPulse = new ()
		{
			Name = MoveNames.WATERPULSE,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 60,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.Other,
			IsPulseMove = true,
			Description = "The user attacks the target with a pulsing blast of water. It may also confuse the target.",
		};
		public static Move AquaJet = new ()
		{
			Name = MoveNames.AQUAJET,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Priority = 1,
			IsContactMove = true,
			Description = "The user lunges at the target at a speed that makes it almost invisible. It is sure to strike first.",
		};
		public static Move Bubble = new ()
		{
			Name = MoveNames.BUBBLE,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 30,
			Target = MoveTarget.AllNearFoes,
			Description = "A spray of countless bubbles is jetted at the opposing team. It may also lower the targets' Speed stats.",
		};
		public static Move WaterGun = new ()
		{
			Name = MoveNames.WATERGUN,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 40,
			Accuracy = 100,
			PowerPoints = 25,
			Target = MoveTarget.NearOther,
			Description = "The target is blasted with a forceful shot of water.",
		};
		public static Move Clamp = new ()
		{
			Name = MoveNames.CLAMP,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 35,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "The target is clamped and squeezed by the user's very thick and sturdy shell for four to five turns.",
		};
		public static Move Whirlpool = new ()
		{
			Name = MoveNames.WHIRLPOOL,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 35,
			Accuracy = 85,
			PowerPoints = 15,
			Target = MoveTarget.NearOther,
			Description = "Traps foes in a violent swirling whirlpool for four to five turns.",
		};
		public static Move SurgingStrikes = new ()
		{
			Name = MoveNames.SURGINGSTRIKES,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Physical,
			BasePower = 25,
			Accuracy = 100,
			PowerPoints = 5,
			Target = MoveTarget.NearOther,
			IsContactMove = true,
			Description = "Hits three times in a row with mastery of the Water style. This attack always deals critical hits.",
		};
		public static Move WaterShuriken = new ()
		{
			Name = MoveNames.WATERSHURIKEN,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Special,
			BasePower = 15,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Priority = 1,
			Description = "The user hits the target with throwing stars 2-5 times in a row. This move always goes first.",
		};
		public static Move AquaRing = new ()
		{
			Name = MoveNames.AQUARING,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 20,
			Target = MoveTarget.User,
			Description = "The user envelops itself in a veil made of water. It regains some HP on every turn.",
		};
		public static Move LifeDew = new ()
		{
			Name = MoveNames.LIFEDEW,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 10,
			Target = MoveTarget.UserAndAllies,
			Description = "The user scatters mysterious water around and restores the HP of itself and its allies.",
		};
		public static Move RainDance = new ()
		{
			Name = MoveNames.RAINDANCE,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 5,
			Target = MoveTarget.BothSides,
			Description = "The user summons a heavy rain that falls for five turns, powering up Water-type moves.",
		};
		public static Move Soak = new ()
		{
			Name = MoveNames.SOAK,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Status,
			Accuracy = 100,
			PowerPoints = 20,
			Target = MoveTarget.NearOther,
			Description = "The user shoots a torrent of water at the target and changes the target's type to Water.",
		};
		public static Move WaterSport = new ()
		{
			Name = MoveNames.WATERSPORT,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 15,
			Target = MoveTarget.BothSides,
			Description = "The user soaks itself with water. The move weakens Fire-type moves while the user is in the battle.",
		};
		public static Move Withdraw = new ()
		{
			Name = MoveNames.WITHDRAW,
			MoveType = PokemonType.Water,
			Category = MoveCategory.Status,
			Accuracy = 0,
			PowerPoints = 40,
			Target = MoveTarget.User,
			Description = "The user withdraws its body into its hard shell, raising its Defense stat.",
		};
		public static List<Move> Moves = new() { Megahorn, AttackOrder, BugBuzz, FirstImpression, PollenPuff, LeechLife, Lunge, XScissor, SignalBeam, SkitterSmack, Uturn, Steamroller, BugBite, SilverWind, FellStinger, StruggleBug, FuryCutter, PinMissile, Twineedle, Infestation, DefendOrder, HealOrder, Powder, QuiverDance, RagePowder, SpiderWeb, StickyWeb, StringShot, TailGlow, HyperspaceFury, FoulPlay, FieryWrath, DarkestLariat, NightDaze, Crunch, DarkPulse, FalseSurrender, JawLock, ThroatChop, WickedBlow, LashOut, NightSlash, SuckerPunch, KnockOff, Assurance, Bite, BrutalSwing, FeintAttack, Thief, Snarl, Payback, Pursuit, BeatUp, Fling, PowerTrip, Punishment, DarkVoid, Embargo, FakeTears, Flatter, HoneClaws, Memento, NastyPlot, Obstruct, PartingShot, Quash, Snatch, Switcheroo, Taunt, TopsyTurvy, Torment, Eternabeam, DragonEnergy, RoarofTime, DracoMeteor, Outrage, ClangingScales, CoreEnforcer, DragonRush, DynamaxCannon, SpacialRend, DragonHammer, DragonPulse, DragonClaw, BreakingSwipe, DragonBreath, DragonTail, DragonDarts, DualChop, Twister, ScaleShot, DragonRage, ClangorousSoul, DragonDance, BoltStrike, VoltTackle, ZapCannon, AuraWheel, Thunder, FusionBolt, PlasmaFists, Thunderbolt, WildCharge, BoltBeak, Discharge, Overdrive, ThunderCage, ZingZap, ThunderPunch, RisingVoltage, VoltSwitch, ParabolicCharge, Spark, ThunderFang, ShockWave, Electroweb, ChargeBeam, ThunderShock, Nuzzle, ElectroBall, Charge, EerieImpulse, ElectricTerrain, Electrify, IonDeluge, MagnetRise, MagneticFlux, ThunderWave, LightofRuin, FleurCannon, MistyExplosion, Moonblast, PlayRough, StrangeSteam, DazzlingGleam, SpiritBreak, DrainingKiss, DisarmingVoice, FairyWind, NaturesMadness, AromaticMist, BabyDollEyes, Charm, CraftyShield, Decorate, FairyLock, FloralHealing, FlowerShield, Geomancy, MistyTerrain, Moonlight, SweetKiss, FocusPunch, MeteorAssault, HighJumpKick, CloseCombat, FocusBlast, Superpower, CrossChop, DynamicPunch, FlyingPress, HammerArm, JumpKick, SacredSword, ThunderousKick, SecretSword, SkyUppercut, AuraSphere, BodyPress, Submission, BrickBreak, DrainPunch, VitalThrow, WakeUpSlap, LowSweep, CircleThrow, ForcePalm, Revenge, RollingKick, StormThrow, KarateChop, MachPunch, PowerUpPunch, RockSmash, VacuumWave, DoubleKick, ArmThrust, TripleKick, Counter, FinalGambit, LowKick, Reversal, SeismicToss, BulkUp, Coaching, Detect, MatBlock, NoRetreat, Octolock, QuickGuard, Vcreate, BlastBurn, Eruption, MindBlown, ShellTrap, BlueFlare, BurnUp, Overheat, FlareBlitz, PyroBall, FireBlast, FusionFlare, Inferno, MagmaStorm, SacredFire, SearingShot, HeatWave, Flamethrower, BlazeKick, FieryDance, FireLash, FirePledge, LavaPlume, FirePunch, MysticalFire, BurningJealousy, FlameBurst, FireFang, FlameWheel, Incinerate, FlameCharge, Ember, FireSpin, HeatCrash, SunnyDay, WillOWisp, SkyAttack, BraveBird, DragonAscent, Hurricane, Aeroblast, BeakBlast, Fly, Bounce, DrillPeck, OblivionWing, AirSlash, Chatter, AerialAce, AirCutter, Pluck, SkyDrop, WingAttack, Acrobatics, DualWingbeat, Gust, Peck, Defog, FeatherDance, MirrorMove, Roost, Tailwind, AstralBarrage, ShadowForce, Poltergeist, MoongeistBeam, PhantomForce, SpectralThief, ShadowBone, ShadowBall, SpiritShackle, ShadowClaw, Hex, OminousWind, ShadowPunch, ShadowSneak, Astonish, Lick, NightShade, ConfuseRay, Curse, DestinyBond, Grudge, Nightmare, Spite, TrickorTreat, FrenzyPlant, LeafStorm, SolarBlade, PetalDance, PowerWhip, SeedFlare, SolarBeam, WoodHammer, EnergyBall, LeafBlade, PetalBlizzard, AppleAcid, DrumBeating, GrassPledge, GravApple, SeedBomb, GigaDrain, HornLeech, GrassyGlide, TropKick, LeafTornado, MagicalLeaf, NeedleArm, RazorLeaf, VineWhip, BranchPoke, Leafage, MegaDrain, SnapTrap, BulletSeed, Absorb, GrassKnot, Aromatherapy, CottonGuard, CottonSpore, ForestsCurse, GrassWhistle, GrassyTerrain, Ingrain, JungleHealing, LeechSeed, SleepPowder, SpikyShield, Spore, StrengthSap, StunSpore, Synthesis, WorrySeed, PrecipiceBlades, Earthquake, HighHorsepower, EarthPower, LandsWrath, ThousandArrows, ThousandWaves, Dig, DrillRun, StompingTantrum, ScorchingSands, BoneClub, MudBomb, Bulldoze, MudShot, Bonemerang, SandTomb, BoneRush, MudSlap, Fissure, Magnitude, MudSport, Rototiller, SandAttack, ShoreUp, Spikes, FreezeShock, IceBurn, GlacialLance, Blizzard, IceHammer, IceBeam, IcicleCrash, IcePunch, FreezeDry, AuroraBeam, Glaciate, IceFang, Avalanche, FrostBreath, IcyWind, IceShard, PowderSnow, IceBall, IcicleSpear, TripleAxel, SheerCold, AuroraVeil, Hail, Haze, Mist, Explosion, SelfDestruct, GigaImpact, HyperBeam, Boomburst, LastResort, SkullBash, DoubleEdge, HeadCharge, MegaKick, MultiAttack, TechnoBlast, Thrash, EggBomb, Judgment, HyperVoice, RevelationDance, RockClimb, TakeDown, Uproar, BodySlam, ExtremeSpeed, HyperFang, MegaPunch, RazorWind, Slam, Strength, TriAttack, CrushClaw, RelicSong, ChipAway, DizzyPunch, Facade, Headbutt, Retaliate, SecretPower, Slash, SmellingSalts, HornAttack, Stomp, Covet, HiddenPower, Round, Swift, ViseGrip, Cut, RapidSpin, Snore, Struggle, TerrainPulse, WeatherBall, EchoedVoice, FakeOut, FalseSwipe, HoldBack, PayDay, Pound, QuickAttack, Scratch, Tackle, DoubleHit, Feint, TailSlap, Rage, SpikeCannon, CometPunch, FurySwipes, Barrage, Bind, DoubleSlap, FuryAttack, Wrap, Constrict, Bide, CrushGrip, Endeavor, Flail, Frustration, Guillotine, HornDrill, NaturalGift, Present, Return, SonicBoom, SpitUp, SuperFang, TrumpCard, WringOut, Acupressure, AfterYou, Assist, Attract, BatonPass, BellyDrum, Bestow, Block, Camouflage, Captivate, Celebrate, Confide, Conversion, Conversion2, Copycat, CourtChange, DefenseCurl, Disable, DoubleTeam, Encore, Endure, Entrainment, Flash, FocusEnergy, FollowMe, Foresight, Glare, Growl, Growth, HappyHour, Harden, HealBell, HelpingHand, HoldHands, Howl, LaserFocus, Leer, LockOn, LovelyKiss, LuckyChant, MeFirst, MeanLook, Metronome, MilkDrink, Mimic, MindReader, Minimize, MorningSun, NaturePower, NobleRoar, OdorSleuth, PainSplit, PerishSong, PlayNice, Protect, PsychUp, Recover, Recycle, ReflectType, Refresh, Roar, Safeguard, ScaryFace, Screech, Sharpen, ShellSmash, SimpleBeam, Sing, Sketch, SlackOff, SleepTalk, Smokescreen, SoftBoiled, Splash, Spotlight, Stockpile, StuffCheeks, Substitute, Supersonic, Swagger, Swallow, SweetScent, SwordsDance, TailWhip, TearfulLook, Teatime, TeeterDance, Tickle, Transform, Whirlwind, Wish, WorkUp, Yawn, Belch, GunkShot, SludgeWave, ShellSideArm, SludgeBomb, PoisonJab, CrossPoison, Sludge, Venoshock, ClearSmog, PoisonFang, PoisonTail, Acid, AcidSpray, Smog, PoisonSting, AcidArmor, BanefulBunker, Coil, CorrosiveGas, GastroAcid, PoisonGas, PoisonPowder, Purify, Toxic, ToxicSpikes, ToxicThread, VenomDrench, PrismaticLaser, PsychoBoost, FutureSight, Synchronoise, DreamEater, PhotonGeyser, Psystrike, FreezingGlare, Psychic, PsychicFangs, EerieSpell, ExpandingForce, Extrasensory, HyperspaceHole, Psyshock, ZenHeadbutt, LusterPurge, MistBall, PsychoCut, Psybeam, HeartStamp, Confusion, StoredPower, MirrorCoat, Psywave, Agility, AllySwitch, Amnesia, Barrier, CalmMind, CosmicPower, Gravity, GuardSplit, GuardSwap, HealBlock, HealPulse, HealingWish, HeartSwap, Hypnosis, Imprison, Instruct, Kinesis, LightScreen, LunarDance, MagicCoat, MagicPowder, MagicRoom, Meditate, MiracleEye, PowerSplit, PowerSwap, PowerTrick, PsychicTerrain, PsychoShift, Reflect, Rest, RolePlay, SkillSwap, SpeedSwap, Telekinesis, Teleport, Trick, TrickRoom, WonderRoom, HeadSmash, RockWrecker, MeteorBeam, DiamondStorm, StoneEdge, PowerGem, RockSlide, AncientPower, RockTomb, RockThrow, SmackDown, Accelerock, Rollout, RockBlast, RockPolish, Sandstorm, StealthRock, TarShot, WideGuard, DoomDesire, SteelBeam, SteelRoller, BehemothBash, BehemothBlade, IronTail, SunsteelStrike, MeteorMash, AnchorShot, FlashCannon, IronHead, SmartStrike, SteelWing, DoubleIronBash, MirrorShot, MagnetBomb, GearGrind, MetalClaw, BulletPunch, GyroBall, HeavySlam, MetalBurst, Autotomize, GearUp, IronDefense, KingsShield, MetalSound, ShiftGear, HydroCannon, WaterSpout, HydroPump, OriginPulse, SteamEruption, Crabhammer, AquaTail, MuddyWater, SparklingAria, Surf, FishiousRend, Liquidation, Dive, Scald, SnipeShot, WaterPledge, Waterfall, RazorShell, Brine, BubbleBeam, Octazooka, FlipTurn, WaterPulse, AquaJet, Bubble, WaterGun, Clamp, Whirlpool, SurgingStrikes, WaterShuriken, AquaRing, LifeDew, RainDance, Soak, WaterSport, Withdraw };
	}
}