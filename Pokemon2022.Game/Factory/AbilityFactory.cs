using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Names;
using System.Collections.Generic;

namespace Pokemon2022.Game.Factory
{
	public class AbilityFactory
	{
		public static Ability Stench = new ()
		{
			Name = AbilityNames.STENCH,
			Description = "The stench may cause the target to flinch.",
		};
		public static Ability Drizzle = new ()
		{
			Name = AbilityNames.DRIZZLE,
			Description = "The Pokémon makes it rain if it appears in battle.",
		};
		public static Ability SpeedBoost = new ()
		{
			Name = AbilityNames.SPEEDBOOST,
			Description = "Its Speed stat is gradually boosted.",
		};
		public static Ability BattleArmor = new ()
		{
			Name = AbilityNames.BATTLEARMOR,
			Description = "The Pokémon is protected against critical hits.",
		};
		public static Ability Sturdy = new ()
		{
			Name = AbilityNames.STURDY,
			Description = "It cannot be knocked out with one hit.",
		};
		public static Ability Damp = new ()
		{
			Name = AbilityNames.DAMP,
			Description = "Prevents the use of self-destructing moves.",
		};
		public static Ability Limber = new ()
		{
			Name = AbilityNames.LIMBER,
			Description = "The Pokémon is protected from paralysis.",
		};
		public static Ability SandVeil = new ()
		{
			Name = AbilityNames.SANDVEIL,
			Description = "Boosts the Pokémon's evasion in a sandstorm.",
		};
		public static Ability Static = new ()
		{
			Name = AbilityNames.STATIC,
			Description = "Contact with the Pokémon may cause paralysis.",
		};
		public static Ability VoltAbsorb = new ()
		{
			Name = AbilityNames.VOLTABSORB,
			Description = "Restores HP if hit by an Electric-type move.",
		};
		public static Ability WaterAbsorb = new ()
		{
			Name = AbilityNames.WATERABSORB,
			Description = "Restores HP if hit by a Water-type move.",
		};
		public static Ability Oblivious = new ()
		{
			Name = AbilityNames.OBLIVIOUS,
			Description = "Prevents it from becoming infatuated.",
		};
		public static Ability CloudNine = new ()
		{
			Name = AbilityNames.CLOUDNINE,
			Description = "Eliminates the effects of weather.",
		};
		public static Ability CompoundEyes = new ()
		{
			Name = AbilityNames.COMPOUNDEYES,
			Description = "The Pokémon's accuracy is boosted.",
		};
		public static Ability Insomnia = new ()
		{
			Name = AbilityNames.INSOMNIA,
			Description = "Prevents the Pokémon from falling asleep.",
		};
		public static Ability ColorChange = new ()
		{
			Name = AbilityNames.COLORCHANGE,
			Description = "Changes the Pokémon's type to the foe's move.",
		};
		public static Ability Immunity = new ()
		{
			Name = AbilityNames.IMMUNITY,
			Description = "Prevents the Pokémon from getting poisoned.",
		};
		public static Ability FlashFire = new ()
		{
			Name = AbilityNames.FLASHFIRE,
			Description = "It powers up Fire-type moves if it's hit by one.",
		};
		public static Ability ShieldDust = new ()
		{
			Name = AbilityNames.SHIELDDUST,
			Description = "Blocks the added effects of attacks taken.",
		};
		public static Ability OwnTempo = new ()
		{
			Name = AbilityNames.OWNTEMPO,
			Description = "Prevents the Pokémon from becoming confused.",
		};
		public static Ability SuctionCups = new ()
		{
			Name = AbilityNames.SUCTIONCUPS,
			Description = "Negates all moves that force switching out.",
		};
		public static Ability Intimidate = new ()
		{
			Name = AbilityNames.INTIMIDATE,
			Description = "Lowers the foe's Attack stat.",
		};
		public static Ability ShadowTag = new ()
		{
			Name = AbilityNames.SHADOWTAG,
			Description = "Prevents the foe from escaping.",
		};
		public static Ability RoughSkin = new ()
		{
			Name = AbilityNames.ROUGHSKIN,
			Description = "Inflicts damage to the foe on contact.",
		};
		public static Ability WonderGuard = new ()
		{
			Name = AbilityNames.WONDERGUARD,
			Description = "Only super-effective moves will hit.",
		};
		public static Ability Levitate = new ()
		{
			Name = AbilityNames.LEVITATE,
			Description = "Gives full immunity to all Ground-type moves.",
		};
		public static Ability EffectSpore = new ()
		{
			Name = AbilityNames.EFFECTSPORE,
			Description = "Contact may poison or cause paralysis or sleep.",
		};
		public static Ability Synchronize = new ()
		{
			Name = AbilityNames.SYNCHRONIZE,
			Description = "Passes a burn, poison, or paralysis to the foe.",
		};
		public static Ability ClearBody = new ()
		{
			Name = AbilityNames.CLEARBODY,
			Description = "Prevents other Pokémon from lowering its stats.",
		};
		public static Ability NaturalCure = new ()
		{
			Name = AbilityNames.NATURALCURE,
			Description = "All status problems heal when it switches out.",
		};
		public static Ability LightningRod = new ()
		{
			Name = AbilityNames.LIGHTNINGROD,
			Description = "Draws in all Electric-type moves to up Sp. Attack.",
		};
		public static Ability SereneGrace = new ()
		{
			Name = AbilityNames.SERENEGRACE,
			Description = "Boosts the likelihood of added effects appearing.",
		};
		public static Ability SwiftSwim = new ()
		{
			Name = AbilityNames.SWIFTSWIM,
			Description = "Boosts the Pokémon's Speed in rain.",
		};
		public static Ability Chlorophyll = new ()
		{
			Name = AbilityNames.CHLOROPHYLL,
			Description = "Boosts the Pokémon's Speed in sunshine.",
		};
		public static Ability Illuminate = new ()
		{
			Name = AbilityNames.ILLUMINATE,
			Description = "Raises the likelihood of meeting wild Pokémon.",
		};
		public static Ability Trace = new ()
		{
			Name = AbilityNames.TRACE,
			Description = "The Pokémon copies a foe's Ability.",
		};
		public static Ability HugePower = new ()
		{
			Name = AbilityNames.HUGEPOWER,
			Description = "Raises the Pokémon's Attack stat.",
		};
		public static Ability PoisonPoint = new ()
		{
			Name = AbilityNames.POISONPOINT,
			Description = "Contact with the Pokémon may poison the attacker.",
		};
		public static Ability InnerFocus = new ()
		{
			Name = AbilityNames.INNERFOCUS,
			Description = "The Pokémon is protected from flinching.",
		};
		public static Ability MagmaArmor = new ()
		{
			Name = AbilityNames.MAGMAARMOR,
			Description = "Prevents the Pokémon from becoming frozen.",
		};
		public static Ability WaterVeil = new ()
		{
			Name = AbilityNames.WATERVEIL,
			Description = "Prevents the Pokémon from getting a burn.",
		};
		public static Ability MagnetPull = new ()
		{
			Name = AbilityNames.MAGNETPULL,
			Description = "Prevents Steel-type Pokémon from escaping.",
		};
		public static Ability Soundproof = new ()
		{
			Name = AbilityNames.SOUNDPROOF,
			Description = "Gives full immunity to all sound-based moves.",
		};
		public static Ability RainDish = new ()
		{
			Name = AbilityNames.RAINDISH,
			Description = "The Pokémon gradually regains HP in rain.",
		};
		public static Ability SandStream = new ()
		{
			Name = AbilityNames.SANDSTREAM,
			Description = "The Pokémon summons a sandstorm in battle.",
		};
		public static Ability Pressure = new ()
		{
			Name = AbilityNames.PRESSURE,
			Description = "The Pokémon raises the foe's PP usage.",
		};
		public static Ability ThickFat = new ()
		{
			Name = AbilityNames.THICKFAT,
			Description = "Ups resistance to Fire- and Ice-type moves.",
		};
		public static Ability EarlyBird = new ()
		{
			Name = AbilityNames.EARLYBIRD,
			Description = "The Pokémon awakens quickly from sleep.",
		};
		public static Ability FlameBody = new ()
		{
			Name = AbilityNames.FLAMEBODY,
			Description = "Contact with the Pokémon may burn the attacker.",
		};
		public static Ability RunAway = new ()
		{
			Name = AbilityNames.RUNAWAY,
			Description = "Enables a sure getaway from wild Pokémon.",
		};
		public static Ability KeenEye = new ()
		{
			Name = AbilityNames.KEENEYE,
			Description = "Prevents other Pokémon from lowering accuracy.",
		};
		public static Ability HyperCutter = new ()
		{
			Name = AbilityNames.HYPERCUTTER,
			Description = "Prevents other Pokémon from lowering Attack stat.",
		};
		public static Ability Pickup = new ()
		{
			Name = AbilityNames.PICKUP,
			Description = "The Pokémon may pick up items.",
		};
		public static Ability Truant = new ()
		{
			Name = AbilityNames.TRUANT,
			Description = "Pokémon can't attack on consecutive turns.",
		};
		public static Ability Hustle = new ()
		{
			Name = AbilityNames.HUSTLE,
			Description = "Boosts the Attack stat, but lowers accuracy.",
		};
		public static Ability CuteCharm = new ()
		{
			Name = AbilityNames.CUTECHARM,
			Description = "Contact with the Pokémon may cause infatuation.",
		};
		public static Ability Plus = new ()
		{
			Name = AbilityNames.PLUS,
			Description = "Ups Sp. Atk if another Pokémon has Plus or Minus.",
		};
		public static Ability Minus = new ()
		{
			Name = AbilityNames.MINUS,
			Description = "Ups Sp. Atk if another Pokémon has Plus or Minus.",
		};
		public static Ability Forecast = new ()
		{
			Name = AbilityNames.FORECAST,
			Description = "Castform transforms with the weather.",
		};
		public static Ability StickyHold = new ()
		{
			Name = AbilityNames.STICKYHOLD,
			Description = "Protects the Pokémon from item theft.",
		};
		public static Ability ShedSkin = new ()
		{
			Name = AbilityNames.SHEDSKIN,
			Description = "The Pokémon may heal its own status problems.",
		};
		public static Ability Guts = new ()
		{
			Name = AbilityNames.GUTS,
			Description = "Boosts Attack if there is a status problem.",
		};
		public static Ability MarvelScale = new ()
		{
			Name = AbilityNames.MARVELSCALE,
			Description = "Ups Defense if there is a status problem.",
		};
		public static Ability LiquidOoze = new ()
		{
			Name = AbilityNames.LIQUIDOOZE,
			Description = "Damages attackers using any draining move.",
		};
		public static Ability Overgrow = new ()
		{
			Name = AbilityNames.OVERGROW,
			Description = "Powers up Grass-type moves in a pinch.",
		};
		public static Ability Blaze = new ()
		{
			Name = AbilityNames.BLAZE,
			Description = "Powers up Fire-type moves in a pinch.",
		};
		public static Ability Torrent = new ()
		{
			Name = AbilityNames.TORRENT,
			Description = "Powers up Water-type moves in a pinch.",
		};
		public static Ability Swarm = new ()
		{
			Name = AbilityNames.SWARM,
			Description = "Powers up Bug-type moves in a pinch.",
		};
		public static Ability RockHead = new ()
		{
			Name = AbilityNames.ROCKHEAD,
			Description = "Protects the Pokémon from recoil damage.",
		};
		public static Ability Drought = new ()
		{
			Name = AbilityNames.DROUGHT,
			Description = "Turns the sunlight harsh if it is in battle.",
		};
		public static Ability ArenaTrap = new ()
		{
			Name = AbilityNames.ARENATRAP,
			Description = "Prevents the foe from fleeing.",
		};
		public static Ability VitalSpirit = new ()
		{
			Name = AbilityNames.VITALSPIRIT,
			Description = "Prevents the Pokémon from falling asleep.",
		};
		public static Ability WhiteSmoke = new ()
		{
			Name = AbilityNames.WHITESMOKE,
			Description = "Prevents other Pokémon from lowering its stats.",
		};
		public static Ability PurePower = new ()
		{
			Name = AbilityNames.PUREPOWER,
			Description = "Raises the Pokémon's Attack stat.",
		};
		public static Ability ShellArmor = new ()
		{
			Name = AbilityNames.SHELLARMOR,
			Description = "The Pokémon is protected against critical hits.",
		};
		public static Ability AirLock = new ()
		{
			Name = AbilityNames.AIRLOCK,
			Description = "Eliminates the effects of weather.",
		};
		public static Ability TangledFeet = new ()
		{
			Name = AbilityNames.TANGLEDFEET,
			Description = "Raises evasion if the Pokémon is confused.",
		};
		public static Ability MotorDrive = new ()
		{
			Name = AbilityNames.MOTORDRIVE,
			Description = "Raises Speed if hit by an Electric-type move.",
		};
		public static Ability Rivalry = new ()
		{
			Name = AbilityNames.RIVALRY,
			Description = "Deals more damage to a foe of the same gender.",
		};
		public static Ability Steadfast = new ()
		{
			Name = AbilityNames.STEADFAST,
			Description = "Raises Speed each time the Pokémon flinches.",
		};
		public static Ability SnowCloak = new ()
		{
			Name = AbilityNames.SNOWCLOAK,
			Description = "Raises evasion in a hailstorm.",
		};
		public static Ability Gluttony = new ()
		{
			Name = AbilityNames.GLUTTONY,
			Description = "Encourages the early use of a held Berry.",
		};
		public static Ability AngerPoint = new ()
		{
			Name = AbilityNames.ANGERPOINT,
			Description = "Maxes Attack after taking a critical hit.",
		};
		public static Ability Unburden = new ()
		{
			Name = AbilityNames.UNBURDEN,
			Description = "Raises Speed if a held item is used.",
		};
		public static Ability Heatproof = new ()
		{
			Name = AbilityNames.HEATPROOF,
			Description = "Weakens the power of Fire-type moves.",
		};
		public static Ability Simple = new ()
		{
			Name = AbilityNames.SIMPLE,
			Description = "The Pokémon is prone to wild stat changes.",
		};
		public static Ability DrySkin = new ()
		{
			Name = AbilityNames.DRYSKIN,
			Description = "Reduces HP if it is hot. Water restores HP.",
		};
		public static Ability Download = new ()
		{
			Name = AbilityNames.DOWNLOAD,
			Description = "Adjusts power according to a foe's defenses.",
		};
		public static Ability IronFist = new ()
		{
			Name = AbilityNames.IRONFIST,
			Description = "Boosts the power of punching moves.",
		};
		public static Ability PoisonHeal = new ()
		{
			Name = AbilityNames.POISONHEAL,
			Description = "Restores HP if the Pokémon is poisoned.",
		};
		public static Ability Adaptability = new ()
		{
			Name = AbilityNames.ADAPTABILITY,
			Description = "Powers up moves of the same type.",
		};
		public static Ability SkillLink = new ()
		{
			Name = AbilityNames.SKILLLINK,
			Description = "Increases the frequency of multi-strike moves.",
		};
		public static Ability Hydration = new ()
		{
			Name = AbilityNames.HYDRATION,
			Description = "Heals status problems if it is raining.",
		};
		public static Ability SolarPower = new ()
		{
			Name = AbilityNames.SOLARPOWER,
			Description = "In sunshine, Sp. Atk is boosted but HP decreases.",
		};
		public static Ability QuickFeet = new ()
		{
			Name = AbilityNames.QUICKFEET,
			Description = "Boosts Speed if there is a status problem.",
		};
		public static Ability Normalize = new ()
		{
			Name = AbilityNames.NORMALIZE,
			Description = "All the Pokémon's moves become the Normal type.",
		};
		public static Ability Sniper = new ()
		{
			Name = AbilityNames.SNIPER,
			Description = "Powers up moves if they become critical hits.",
		};
		public static Ability MagicGuard = new ()
		{
			Name = AbilityNames.MAGICGUARD,
			Description = "The Pokémon only takes damage from attacks.",
		};
		public static Ability NoGuard = new ()
		{
			Name = AbilityNames.NOGUARD,
			Description = "Ensures attacks by or against the Pokémon land.",
		};
		public static Ability Stall = new ()
		{
			Name = AbilityNames.STALL,
			Description = "The Pokémon moves after all other Pokémon do.",
		};
		public static Ability Technician = new ()
		{
			Name = AbilityNames.TECHNICIAN,
			Description = "Powers up the Pokémon's weaker moves.",
		};
		public static Ability LeafGuard = new ()
		{
			Name = AbilityNames.LEAFGUARD,
			Description = "Prevents problems with status in sunny weather.",
		};
		public static Ability Klutz = new ()
		{
			Name = AbilityNames.KLUTZ,
			Description = "The Pokémon can't use any held items.",
		};
		public static Ability MoldBreaker = new ()
		{
			Name = AbilityNames.MOLDBREAKER,
			Description = "Moves can be used regardless of Abilities.",
		};
		public static Ability SuperLuck = new ()
		{
			Name = AbilityNames.SUPERLUCK,
			Description = "Heightens the critical-hit ratios of moves.",
		};
		public static Ability Aftermath = new ()
		{
			Name = AbilityNames.AFTERMATH,
			Description = "Damages the attacker landing the finishing hit.",
		};
		public static Ability Anticipation = new ()
		{
			Name = AbilityNames.ANTICIPATION,
			Description = "Senses a foe's dangerous moves.",
		};
		public static Ability Forewarn = new ()
		{
			Name = AbilityNames.FOREWARN,
			Description = "Determines what moves a foe has.",
		};
		public static Ability Unaware = new ()
		{
			Name = AbilityNames.UNAWARE,
			Description = "Ignores any stat changes in the Pokémon.",
		};
		public static Ability TintedLens = new ()
		{
			Name = AbilityNames.TINTEDLENS,
			Description = "Powers up 'not very effective' moves.",
		};
		public static Ability Filter = new ()
		{
			Name = AbilityNames.FILTER,
			Description = "Reduces damage from super-effective attacks.",
		};
		public static Ability SlowStart = new ()
		{
			Name = AbilityNames.SLOWSTART,
			Description = "Temporarily halves Attack and Speed.",
		};
		public static Ability Scrappy = new ()
		{
			Name = AbilityNames.SCRAPPY,
			Description = "Enables moves to hit Ghost-type Pokémon.",
		};
		public static Ability StormDrain = new ()
		{
			Name = AbilityNames.STORMDRAIN,
			Description = "Draws in all Water-type moves to up Sp. Attack.",
		};
		public static Ability IceBody = new ()
		{
			Name = AbilityNames.ICEBODY,
			Description = "The Pokémon gradually regains HP in a hailstorm.",
		};
		public static Ability SolidRock = new ()
		{
			Name = AbilityNames.SOLIDROCK,
			Description = "Reduces damage from super-effective attacks.",
		};
		public static Ability SnowWarning = new ()
		{
			Name = AbilityNames.SNOWWARNING,
			Description = "The Pokémon summons a hailstorm in battle.",
		};
		public static Ability HoneyGather = new ()
		{
			Name = AbilityNames.HONEYGATHER,
			Description = "The Pokémon may gather Honey from somewhere.",
		};
		public static Ability Frisk = new ()
		{
			Name = AbilityNames.FRISK,
			Description = "The Pokémon can check a foe's held item.",
		};
		public static Ability Reckless = new ()
		{
			Name = AbilityNames.RECKLESS,
			Description = "Powers up moves that have recoil damage.",
		};
		public static Ability Multitype = new ()
		{
			Name = AbilityNames.MULTITYPE,
			Description = "Changes type to match the held Plate.",
		};
		public static Ability FlowerGift = new ()
		{
			Name = AbilityNames.FLOWERGIFT,
			Description = "Powers up party Pokémon when it is sunny.",
		};
		public static Ability BadDreams = new ()
		{
			Name = AbilityNames.BADDREAMS,
			Description = "Reduces a sleeping foe's HP.",
		};
		public static Ability Pickpocket = new ()
		{
			Name = AbilityNames.PICKPOCKET,
			Description = "Steals an item when hit by another Pokémon.",
		};
		public static Ability SheerForce = new ()
		{
			Name = AbilityNames.SHEERFORCE,
			Description = "Removes added effects to increase move damage.",
		};
		public static Ability Contrary = new ()
		{
			Name = AbilityNames.CONTRARY,
			Description = "Makes stat changes have an opposite effect.",
		};
		public static Ability Unnerve = new ()
		{
			Name = AbilityNames.UNNERVE,
			Description = "Makes the foe nervous and unable to eat Berries.",
		};
		public static Ability Defiant = new ()
		{
			Name = AbilityNames.DEFIANT,
			Description = "When its stats are lowered its Attack increases.",
		};
		public static Ability Defeatist = new ()
		{
			Name = AbilityNames.DEFEATIST,
			Description = "Lowers stats when HP becomes half or less.",
		};
		public static Ability CursedBody = new ()
		{
			Name = AbilityNames.CURSEDBODY,
			Description = "May disable a move used on the Pokémon.",
		};
		public static Ability Healer = new ()
		{
			Name = AbilityNames.HEALER,
			Description = "May heal an ally's status conditions.",
		};
		public static Ability FriendGuard = new ()
		{
			Name = AbilityNames.FRIENDGUARD,
			Description = "Reduces damage done to allies.",
		};
		public static Ability WeakArmor = new ()
		{
			Name = AbilityNames.WEAKARMOR,
			Description = "Physical attacks lower Defense and raise Speed.",
		};
		public static Ability HeavyMetal = new ()
		{
			Name = AbilityNames.HEAVYMETAL,
			Description = "Doubles the Pokémon's weight.",
		};
		public static Ability LightMetal = new ()
		{
			Name = AbilityNames.LIGHTMETAL,
			Description = "Halves the Pokémon's weight.",
		};
		public static Ability Multiscale = new ()
		{
			Name = AbilityNames.MULTISCALE,
			Description = "Reduces damage when HP is full.",
		};
		public static Ability ToxicBoost = new ()
		{
			Name = AbilityNames.TOXICBOOST,
			Description = "Powers up physical attacks when poisoned.",
		};
		public static Ability FlareBoost = new ()
		{
			Name = AbilityNames.FLAREBOOST,
			Description = "Powers up special attacks when burned.",
		};
		public static Ability Harvest = new ()
		{
			Name = AbilityNames.HARVEST,
			Description = "May create another Berry after one is used.",
		};
		public static Ability Telepathy = new ()
		{
			Name = AbilityNames.TELEPATHY,
			Description = "Anticipates an ally's attack and dodges it.",
		};
		public static Ability Moody = new ()
		{
			Name = AbilityNames.MOODY,
			Description = "Raises one stat and lowers another.",
		};
		public static Ability Overcoat = new ()
		{
			Name = AbilityNames.OVERCOAT,
			Description = "Protects the Pokémon from damage from weather.",
		};
		public static Ability PoisonTouch = new ()
		{
			Name = AbilityNames.POISONTOUCH,
			Description = "May poison targets when a Pokémon makes contact.",
		};
		public static Ability Regenerator = new ()
		{
			Name = AbilityNames.REGENERATOR,
			Description = "Restores a little HP when withdrawn from battle.",
		};
		public static Ability BigPecks = new ()
		{
			Name = AbilityNames.BIGPECKS,
			Description = "Protects from Defense-lowering attacks.",
		};
		public static Ability SandRush = new ()
		{
			Name = AbilityNames.SANDRUSH,
			Description = "Boosts the Pokémon's Speed in a sandstorm.",
		};
		public static Ability WonderSkin = new ()
		{
			Name = AbilityNames.WONDERSKIN,
			Description = "Makes status-changing moves more likely to miss.",
		};
		public static Ability Analytic = new ()
		{
			Name = AbilityNames.ANALYTIC,
			Description = "Boosts move power when the Pokémon moves last.",
		};
		public static Ability Illusion = new ()
		{
			Name = AbilityNames.ILLUSION,
			Description = "Comes out disguised as the Pokémon in back.",
		};
		public static Ability Imposter = new ()
		{
			Name = AbilityNames.IMPOSTER,
			Description = "It transforms itself into the Pokémon it is facing.",
		};
		public static Ability Infiltrator = new ()
		{
			Name = AbilityNames.INFILTRATOR,
			Description = "Passes through the foe's barrier and strikes.",
		};
		public static Ability Mummy = new ()
		{
			Name = AbilityNames.MUMMY,
			Description = "Contact with this Pokémon spreads this Ability.",
		};
		public static Ability Moxie = new ()
		{
			Name = AbilityNames.MOXIE,
			Description = "Boosts Attack after knocking out any Pokémon.",
		};
		public static Ability Justified = new ()
		{
			Name = AbilityNames.JUSTIFIED,
			Description = "Raises Attack when hit by a Dark-type move.",
		};
		public static Ability Rattled = new ()
		{
			Name = AbilityNames.RATTLED,
			Description = "Some move types scare it and boost its Speed.",
		};
		public static Ability MagicBounce = new ()
		{
			Name = AbilityNames.MAGICBOUNCE,
			Description = "Reflects status-changing moves.",
		};
		public static Ability SapSipper = new ()
		{
			Name = AbilityNames.SAPSIPPER,
			Description = "Boosts Attack when hit by a Grass-type move.",
		};
		public static Ability Prankster = new ()
		{
			Name = AbilityNames.PRANKSTER,
			Description = "Gives priority to a status move.",
		};
		public static Ability SandForce = new ()
		{
			Name = AbilityNames.SANDFORCE,
			Description = "Boosts certain moves' power in a sandstorm.",
		};
		public static Ability IronBarbs = new ()
		{
			Name = AbilityNames.IRONBARBS,
			Description = "Inflicts damage to the Pokémon on contact.",
		};
		public static Ability ZenMode = new ()
		{
			Name = AbilityNames.ZENMODE,
			Description = "Changes the Pokémon's shape when HP is halved.",
		};
		public static Ability VictoryStar = new ()
		{
			Name = AbilityNames.VICTORYSTAR,
			Description = "Boosts the accuracy of its allies and itself.",
		};
		public static Ability Turboblaze = new ()
		{
			Name = AbilityNames.TURBOBLAZE,
			Description = "Moves can be used regardless of Abilities.",
		};
		public static Ability Teravolt = new ()
		{
			Name = AbilityNames.TERAVOLT,
			Description = "Moves can be used regardless of Abilities.",
		};
		public static Ability AromaVeil = new ()
		{
			Name = AbilityNames.AROMAVEIL,
			Description = "Protects against attacks that limit move choices.",
		};
		public static Ability FlowerVeil = new ()
		{
			Name = AbilityNames.FLOWERVEIL,
			Description = "Protects Grass-type allies from stat/status effects.",
		};
		public static Ability CheekPouch = new ()
		{
			Name = AbilityNames.CHEEKPOUCH,
			Description = "Restores HP as well when the Pokémon eats a Berry.",
		};
		public static Ability Protean = new ()
		{
			Name = AbilityNames.PROTEAN,
			Description = "It changes type to that of the move it's about to use.",
		};
		public static Ability FurCoat = new ()
		{
			Name = AbilityNames.FURCOAT,
			Description = "Halves the damage from physical moves.",
		};
		public static Ability Magician = new ()
		{
			Name = AbilityNames.MAGICIAN,
			Description = "Steals the held item of a Pokémon it hits.",
		};
		public static Ability Bulletproof = new ()
		{
			Name = AbilityNames.BULLETPROOF,
			Description = "Protects the Pokémon from some ball and bomb moves.",
		};
		public static Ability Competitive = new ()
		{
			Name = AbilityNames.COMPETITIVE,
			Description = "Sharply boosts Sp. Atk when a stat is lowered.",
		};
		public static Ability StrongJaw = new ()
		{
			Name = AbilityNames.STRONGJAW,
			Description = "Boosts the power of biting moves.",
		};
		public static Ability Refrigerate = new ()
		{
			Name = AbilityNames.REFRIGERATE,
			Description = "Normal-type moves become Ice-type and powered up.",
		};
		public static Ability SweetVeil = new ()
		{
			Name = AbilityNames.SWEETVEIL,
			Description = "Prevents itself and allies from falling asleep.",
		};
		public static Ability StanceChange = new ()
		{
			Name = AbilityNames.STANCECHANGE,
			Description = "Changes between Blade and Shield Forme with attacks.",
		};
		public static Ability GaleWings = new ()
		{
			Name = AbilityNames.GALEWINGS,
			Description = "Flying-type moves gain priority when its HP is full.",
		};
		public static Ability MegaLauncher = new ()
		{
			Name = AbilityNames.MEGALAUNCHER,
			Description = "Powers up aura and pulse moves.",
		};
		public static Ability GrassPelt = new ()
		{
			Name = AbilityNames.GRASSPELT,
			Description = "Boosts the Defense stat on Grassy Terrain.",
		};
		public static Ability Symbiosis = new ()
		{
			Name = AbilityNames.SYMBIOSIS,
			Description = "Passes its held item to an ally that has used theirs.",
		};
		public static Ability ToughClaws = new ()
		{
			Name = AbilityNames.TOUGHCLAWS,
			Description = "Powers up moves that make direct contact.",
		};
		public static Ability Pixilate = new ()
		{
			Name = AbilityNames.PIXILATE,
			Description = "Normal-type moves become Fairy-type and powered up.",
		};
		public static Ability Gooey = new ()
		{
			Name = AbilityNames.GOOEY,
			Description = "Contact with it lowers the attacker's Speed stat.",
		};
		public static Ability Aerilate = new ()
		{
			Name = AbilityNames.AERILATE,
			Description = "Normal-type moves become Flying-type and power up.",
		};
		public static Ability ParentalBond = new ()
		{
			Name = AbilityNames.PARENTALBOND,
			Description = "Parent and child each attacks.",
		};
		public static Ability DarkAura = new ()
		{
			Name = AbilityNames.DARKAURA,
			Description = "Powers up each Pokémon's Dark-type moves.",
		};
		public static Ability FairyAura = new ()
		{
			Name = AbilityNames.FAIRYAURA,
			Description = "Powers up each Pokémon's Fairy-type moves.",
		};
		public static Ability AuraBreak = new ()
		{
			Name = AbilityNames.AURABREAK,
			Description = "Reverses 'Aura' Abilities to weaken affected moves.",
		};
		public static Ability PrimordialSea = new ()
		{
			Name = AbilityNames.PRIMORDIALSEA,
			Description = "Changes the weather to nullify Fire-type moves.",
		};
		public static Ability DesolateLand = new ()
		{
			Name = AbilityNames.DESOLATELAND,
			Description = "Changes the weather to nullify Water-type moves.",
		};
		public static Ability DeltaStream = new ()
		{
			Name = AbilityNames.DELTASTREAM,
			Description = "Alters weather to remove Flying-type's weaknesses.",
		};
		public static Ability Stamina = new ()
		{
			Name = AbilityNames.STAMINA,
			Description = "Boosts Defense when hit by an attack.",
		};
		public static Ability WimpOut = new ()
		{
			Name = AbilityNames.WIMPOUT,
			Description = "Cowardly switches out if its HP becomes half or less.",
		};
		public static Ability EmergencyExit = new ()
		{
			Name = AbilityNames.EMERGENCYEXIT,
			Description = "Switches out if its HP becomes half or less.",
		};
		public static Ability WaterCompaction = new ()
		{
			Name = AbilityNames.WATERCOMPACTION,
			Description = "Sharply ups Defense when hit by a Water-type move.",
		};
		public static Ability Merciless = new ()
		{
			Name = AbilityNames.MERCILESS,
			Description = "Its attacks are critical hits when it is poisoned.",
		};
		public static Ability ShieldsDown = new ()
		{
			Name = AbilityNames.SHIELDSDOWN,
			Description = "Its shell breaks if its HP becomes half or less.",
		};
		public static Ability Stakeout = new ()
		{
			Name = AbilityNames.STAKEOUT,
			Description = "Deals doubles damage to a target's replacement.",
		};
		public static Ability WaterBubble = new ()
		{
			Name = AbilityNames.WATERBUBBLE,
			Description = "Weakens incoming Fire-type moves and prevents burns.",
		};
		public static Ability Steelworker = new ()
		{
			Name = AbilityNames.STEELWORKER,
			Description = "Powers up Steel-type moves.",
		};
		public static Ability Berserk = new ()
		{
			Name = AbilityNames.BERSERK,
			Description = "Ups Sp. Atk if a hit makes its HP half or less.",
		};
		public static Ability SlushRush = new ()
		{
			Name = AbilityNames.SLUSHRUSH,
			Description = "Boosts the Pokémon's Speed stat in a hailstorm.",
		};
		public static Ability LongReach = new ()
		{
			Name = AbilityNames.LONGREACH,
			Description = "Uses moves without making contact with the target.",
		};
		public static Ability LiquidVoice = new ()
		{
			Name = AbilityNames.LIQUIDVOICE,
			Description = "Its sound-based moves become Water-type.",
		};
		public static Ability Triage = new ()
		{
			Name = AbilityNames.TRIAGE,
			Description = "Gives priority to a healing move.",
		};
		public static Ability Galvanize = new ()
		{
			Name = AbilityNames.GALVANIZE,
			Description = "Normal-type moves become Electric-type and powered.",
		};
		public static Ability SurgeSurfer = new ()
		{
			Name = AbilityNames.SURGESURFER,
			Description = "Doubles Speed on Electric Terrain.",
		};
		public static Ability Schooling = new ()
		{
			Name = AbilityNames.SCHOOLING,
			Description = "Forms a powerful school while it has a lot of HP.",
		};
		public static Ability Disguise = new ()
		{
			Name = AbilityNames.DISGUISE,
			Description = "Its shroud protects it from an attack just once.",
		};
		public static Ability BattleBond = new ()
		{
			Name = AbilityNames.BATTLEBOND,
			Description = "Defeating a foe lets it become Ash-Greninja.",
		};
		public static Ability PowerConstruct = new ()
		{
			Name = AbilityNames.POWERCONSTRUCT,
			Description = "Changes with other Cells if HP becomes half or less.",
		};
		public static Ability Corrosion = new ()
		{
			Name = AbilityNames.CORROSION,
			Description = "It can poison Steel- and Poison-type targets.",
		};
		public static Ability Comatose = new ()
		{
			Name = AbilityNames.COMATOSE,
			Description = "It's always drowsing, and attacks without waking.",
		};
		public static Ability QueenlyMajesty = new ()
		{
			Name = AbilityNames.QUEENLYMAJESTY,
			Description = "Makes foes unable to use priority attacks.",
		};
		public static Ability InnardsOut = new ()
		{
			Name = AbilityNames.INNARDSOUT,
			Description = "Damages an attacker that lands the finishing hit.",
		};
		public static Ability Dancer = new ()
		{
			Name = AbilityNames.DANCER,
			Description = "Repeats another Pokémon's dance move immediately.",
		};
		public static Ability Battery = new ()
		{
			Name = AbilityNames.BATTERY,
			Description = "Powers up ally Pokémon's special moves.",
		};
		public static Ability Fluffy = new ()
		{
			Name = AbilityNames.FLUFFY,
			Description = "Resists contact damage but weaker to Fire-type.",
		};
		public static Ability Dazzling = new ()
		{
			Name = AbilityNames.DAZZLING,
			Description = "Makes foes unable to use priority attacks.",
		};
		public static Ability SoulHeart = new ()
		{
			Name = AbilityNames.SOULHEART,
			Description = "Boosts Sp. Atk each time a Pokémon faints.",
		};
		public static Ability TanglingHair = new ()
		{
			Name = AbilityNames.TANGLINGHAIR,
			Description = "Contact with it lowers the attacker's Speed.",
		};
		public static Ability Receiver = new ()
		{
			Name = AbilityNames.RECEIVER,
			Description = "Copies the Ability of a defeated ally.",
		};
		public static Ability PowerofAlchemy = new ()
		{
			Name = AbilityNames.POWEROFALCHEMY,
			Description = "Copies the Ability of a defeated ally.",
		};
		public static Ability BeastBoost = new ()
		{
			Name = AbilityNames.BEASTBOOST,
			Description = "Boosts its best stat each time it deals a KO.",
		};
		public static Ability RKSSystem = new ()
		{
			Name = AbilityNames.RKSSYSTEM,
			Description = "Its type matches the memory disc it holds.",
		};
		public static Ability ElectricSurge = new ()
		{
			Name = AbilityNames.ELECTRICSURGE,
			Description = "Turns the ground into Electric Terrain.",
		};
		public static Ability PsychicSurge = new ()
		{
			Name = AbilityNames.PSYCHICSURGE,
			Description = "Turns the ground into Psychic Terrain.",
		};
		public static Ability MistySurge = new ()
		{
			Name = AbilityNames.MISTYSURGE,
			Description = "Turns the ground into Misty Terrain.",
		};
		public static Ability GrassySurge = new ()
		{
			Name = AbilityNames.GRASSYSURGE,
			Description = "Turns the ground into Grassy Terrain.",
		};
		public static Ability FullMetalBody = new ()
		{
			Name = AbilityNames.FULLMETALBODY,
			Description = "Prevents other Pokémon from lowering its stats.",
		};
		public static Ability ShadowShield = new ()
		{
			Name = AbilityNames.SHADOWSHIELD,
			Description = "Resists damage while its HP is full.",
		};
		public static Ability PrismArmor = new ()
		{
			Name = AbilityNames.PRISMARMOR,
			Description = "Reduces damage from super-effective attacks.",
		};
		public static Ability Neuroforce = new ()
		{
			Name = AbilityNames.NEUROFORCE,
			Description = "Powers up moves that are super-effective.",
		};
		public static Ability IntrepidSword = new ()
		{
			Name = AbilityNames.INTREPIDSWORD,
			Description = "Boosts Attack when entering a battle.",
		};
		public static Ability DauntlessShield = new ()
		{
			Name = AbilityNames.DAUNTLESSSHIELD,
			Description = "Boosts Defense when entering a battle.",
		};
		public static Ability Libero = new ()
		{
			Name = AbilityNames.LIBERO,
			Description = "It changes type to that of the move it's about to use.",
		};
		public static Ability BallFetch = new ()
		{
			Name = AbilityNames.BALLFETCH,
			Description = "Retrieves the first thrown Poké Ball if it failed.",
		};
		public static Ability CottonDown = new ()
		{
			Name = AbilityNames.COTTONDOWN,
			Description = "Scatters Speed-lowering cotton fluff when hit.",
		};
		public static Ability PropellerTail = new ()
		{
			Name = AbilityNames.PROPELLERTAIL,
			Description = "This Pokémon's moves cannot be redirected.",
		};
		public static Ability MirrorArmor = new ()
		{
			Name = AbilityNames.MIRRORARMOR,
			Description = "Bounces back stat-lowering effects.",
		};
		public static Ability GulpMissile = new ()
		{
			Name = AbilityNames.GULPMISSILE,
			Description = "Catches prey via Surf or Dive, spits it out when hit.",
		};
		public static Ability Stalwart = new ()
		{
			Name = AbilityNames.STALWART,
			Description = "This Pokémon's moves cannot be redirected.",
		};
		public static Ability SteamEngine = new ()
		{
			Name = AbilityNames.STEAMENGINE,
			Description = "Boosts Speed drastically if hit by a Fire or Water move.",
		};
		public static Ability PunkRock = new ()
		{
			Name = AbilityNames.PUNKROCK,
			Description = "Powers up own sound moves. Resists other sound moves.",
		};
		public static Ability SandSpit = new ()
		{
			Name = AbilityNames.SANDSPIT,
			Description = "Creates a sandstorm when hit by an attack.",
		};
		public static Ability IceScales = new ()
		{
			Name = AbilityNames.ICESCALES,
			Description = "Halves the damage taken from special moves.",
		};
		public static Ability Ripen = new ()
		{
			Name = AbilityNames.RIPEN,
			Description = "Ripens Berries and doubles their effect.",
		};
		public static Ability IceFace = new ()
		{
			Name = AbilityNames.ICEFACE,
			Description = "Blocks a physical hit, but the ice head breaks.",
		};
		public static Ability PowerSpot = new ()
		{
			Name = AbilityNames.POWERSPOT,
			Description = "Just being next to the Pokémon powers up moves.",
		};
		public static Ability Mimicry = new ()
		{
			Name = AbilityNames.MIMICRY,
			Description = "Changes type depending on the terrain.",
		};
		public static Ability ScreenCleaner = new ()
		{
			Name = AbilityNames.SCREENCLEANER,
			Description = "On entering battle, clears effects of Reflect, etc.",
		};
		public static Ability SteelySpirit = new ()
		{
			Name = AbilityNames.STEELYSPIRIT,
			Description = "Powers up ally Pokémon's Steel-type moves.",
		};
		public static Ability PerishBody = new ()
		{
			Name = AbilityNames.PERISHBODY,
			Description = "Both Pokémon faint 3 turns after taking a contact hit.",
		};
		public static Ability WanderingSpirit = new ()
		{
			Name = AbilityNames.WANDERINGSPIRIT,
			Description = "Swaps Abilities with contact-making Pokémon.",
		};
		public static Ability GorillaTactics = new ()
		{
			Name = AbilityNames.GORILLATACTICS,
			Description = "Boosts Attack, but allows only one move to be used.",
		};
		public static Ability NeutralizingGas = new ()
		{
			Name = AbilityNames.NEUTRALIZINGGAS,
			Description = "Nullifies the effects of all other Abilities.",
		};
		public static Ability PastelVeil = new ()
		{
			Name = AbilityNames.PASTELVEIL,
			Description = "Protects the Pokémon and its allies from poisoning.",
		};
		public static Ability HungerSwitch = new ()
		{
			Name = AbilityNames.HUNGERSWITCH,
			Description = "Changes between Full Belly and Hangry Mode each turn.",
		};
		public static Ability QuickDraw = new ()
		{
			Name = AbilityNames.QUICKDRAW,
			Description = "Enables the Pokémon to move first occasionally.",
		};
		public static Ability UnseenFist = new ()
		{
			Name = AbilityNames.UNSEENFIST,
			Description = "The Pokémon's contact moves ignore protections.",
		};
		public static Ability CuriousMedicine = new ()
		{
			Name = AbilityNames.CURIOUSMEDICINE,
			Description = "Removes all allies' stat changes on joining battle.",
		};
		public static Ability Transistor = new ()
		{
			Name = AbilityNames.TRANSISTOR,
			Description = "Powers up Electric-type moves.",
		};
		public static Ability DragonsMaw = new ()
		{
			Name = AbilityNames.DRAGONSMAW,
			Description = "Powers up Dragon-type moves.",
		};
		public static Ability ChillingNeigh = new ()
		{
			Name = AbilityNames.CHILLINGNEIGH,
			Description = "When knocking out a target, raises Attack.",
		};
		public static Ability GrimNeigh = new ()
		{
			Name = AbilityNames.GRIMNEIGH,
			Description = "When knocking out a target, raises Sp. Atk.",
		};
		public static Ability AsOne = new ()
		{
			Name = AbilityNames.ASONECHILLINGNEIGH,
			Description = "Combines Unnerve and Chilling Neigh Abilities.",
		};
		public static Ability AsOne2 = new ()
		{
			Name = AbilityNames.ASONEGRIMNEIGH,
			Description = "Combines Unnerve and Grim Neigh Abilities.",
		};
		public static List<Ability> Abilities = new() { Stench, Drizzle, SpeedBoost, BattleArmor, Sturdy, Damp, Limber, SandVeil, Static, VoltAbsorb, WaterAbsorb, Oblivious, CloudNine, CompoundEyes, Insomnia, ColorChange, Immunity, FlashFire, ShieldDust, OwnTempo, SuctionCups, Intimidate, ShadowTag, RoughSkin, WonderGuard, Levitate, EffectSpore, Synchronize, ClearBody, NaturalCure, LightningRod, SereneGrace, SwiftSwim, Chlorophyll, Illuminate, Trace, HugePower, PoisonPoint, InnerFocus, MagmaArmor, WaterVeil, MagnetPull, Soundproof, RainDish, SandStream, Pressure, ThickFat, EarlyBird, FlameBody, RunAway, KeenEye, HyperCutter, Pickup, Truant, Hustle, CuteCharm, Plus, Minus, Forecast, StickyHold, ShedSkin, Guts, MarvelScale, LiquidOoze, Overgrow, Blaze, Torrent, Swarm, RockHead, Drought, ArenaTrap, VitalSpirit, WhiteSmoke, PurePower, ShellArmor, AirLock, TangledFeet, MotorDrive, Rivalry, Steadfast, SnowCloak, Gluttony, AngerPoint, Unburden, Heatproof, Simple, DrySkin, Download, IronFist, PoisonHeal, Adaptability, SkillLink, Hydration, SolarPower, QuickFeet, Normalize, Sniper, MagicGuard, NoGuard, Stall, Technician, LeafGuard, Klutz, MoldBreaker, SuperLuck, Aftermath, Anticipation, Forewarn, Unaware, TintedLens, Filter, SlowStart, Scrappy, StormDrain, IceBody, SolidRock, SnowWarning, HoneyGather, Frisk, Reckless, Multitype, FlowerGift, BadDreams, Pickpocket, SheerForce, Contrary, Unnerve, Defiant, Defeatist, CursedBody, Healer, FriendGuard, WeakArmor, HeavyMetal, LightMetal, Multiscale, ToxicBoost, FlareBoost, Harvest, Telepathy, Moody, Overcoat, PoisonTouch, Regenerator, BigPecks, SandRush, WonderSkin, Analytic, Illusion, Imposter, Infiltrator, Mummy, Moxie, Justified, Rattled, MagicBounce, SapSipper, Prankster, SandForce, IronBarbs, ZenMode, VictoryStar, Turboblaze, Teravolt, AromaVeil, FlowerVeil, CheekPouch, Protean, FurCoat, Magician, Bulletproof, Competitive, StrongJaw, Refrigerate, SweetVeil, StanceChange, GaleWings, MegaLauncher, GrassPelt, Symbiosis, ToughClaws, Pixilate, Gooey, Aerilate, ParentalBond, DarkAura, FairyAura, AuraBreak, PrimordialSea, DesolateLand, DeltaStream, Stamina, WimpOut, EmergencyExit, WaterCompaction, Merciless, ShieldsDown, Stakeout, WaterBubble, Steelworker, Berserk, SlushRush, LongReach, LiquidVoice, Triage, Galvanize, SurgeSurfer, Schooling, Disguise, BattleBond, PowerConstruct, Corrosion, Comatose, QueenlyMajesty, InnardsOut, Dancer, Battery, Fluffy, Dazzling, SoulHeart, TanglingHair, Receiver, PowerofAlchemy, BeastBoost, RKSSystem, ElectricSurge, PsychicSurge, MistySurge, GrassySurge, FullMetalBody, ShadowShield, PrismArmor, Neuroforce, IntrepidSword, DauntlessShield, Libero, BallFetch, CottonDown, PropellerTail, MirrorArmor, GulpMissile, Stalwart, SteamEngine, PunkRock, SandSpit, IceScales, Ripen, IceFace, PowerSpot, Mimicry, ScreenCleaner, SteelySpirit, PerishBody, WanderingSpirit, GorillaTactics, NeutralizingGas, PastelVeil, HungerSwitch, QuickDraw, UnseenFist, CuriousMedicine, Transistor, DragonsMaw, ChillingNeigh, GrimNeigh, AsOne, AsOne2 };
	}
}