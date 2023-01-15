namespace Pokemon2022.FileWrite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WritePokemonFactoryCs();
        }
        public static void WritePokemonFactoryCs()
        {
            string path = "C:\\Users\\Jan\\Desktop\\Pokemon White X\\Pokemon White X_Mapping\\PBS";
            string writepath = "C:\\Users\\Jan\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Factory";

            string[] data = File.ReadAllLines(path + "\\pokemon.txt");
            List<string> pokemons = new();
            File.WriteAllText(writepath + "\\PokemonFactory.cs", "using Pokemon2022.Game.Entities;\nusing Pokemon2022.Game.Logic;\nusing Pokemon2022.Game.Entities.Names;\nusing Pokemon2022.Game.Entities.Enums;\nusing System.Collections.Generic;\n\nnamespace Pokemon2022.Game.Factory\n{\n\tpublic class PokemonFactory\n\t{\n");
            string upname = string.Empty;
            foreach (string line in data)
            {
                if (line.StartsWith("#")) upname = string.Empty;
                if (line.StartsWith("["))
                {
                    upname = line.Split(new[] { "[" }, StringSplitOptions.None)[1].Split(new[] { "]" }, StringSplitOptions.None)[0];
                }
                if (upname == string.Empty) continue;
                string[] split = line.Split(new[] { " = " }, StringSplitOptions.None);
                switch (split[0])
                {
                    case "Name":
                        string name = split[1];
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\tpublic static Pokemon {name.Replace(" ", "").Replace("-", "").Replace("'", "").Replace(".", "").Replace("♀", "F").Replace("♂", "M").Replace(":", "")} = new ()\n" + "\t\t{\n" + $"\t\t\tName = PokemonNames.{upname},\n");
                        pokemons.Add(name.Replace(" ", "").Replace("-", "").Replace("'", "").Replace(".", "").Replace("♀", "F").Replace("♂", "M").Replace(":", ""));
                        break;
                    case "Types":
                        string[] types = split[1].Split(new[] { "," }, StringSplitOptions.None);
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", "\t\t\tTypes = new PokemonType[]\n\t\t\t{\n");
                        foreach (string _type in types)
                        {
                            File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\t\tPokemonType.{char.ToUpper(_type[0])}{_type.Substring(1).ToLower()},\n");
                        }
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", "\t\t\t},\n");
                        break;
                    case "BaseStats":
                        string[] stats = split[1].Split(new[] { "," }, StringSplitOptions.None);
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", "\t\t\tBaseStats = new Stats()\n\t\t\t{\n");
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\t\tHP = {stats[0]},\n\t\t\t\tAttack = {stats[1]},\n\t\t\t\tDefense = {stats[2]},\n\t\t\t\tSpecialAttack = {stats[4]},\n\t\t\t\tSpecialDefense = {stats[5]},\n\t\t\t\tSpeed = {stats[3]}\n");
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", "\t\t\t},\n");
                        break;
                    case "GenderRatio":
                        break;
                    case "GrowthRate":
                        break;
                    case "BaseExp":
                        break;
                    case "EVs":
                        break;
                    case "CatchRate":
                        break;
                    case "Happiness":
                        break;
                    case "Abilities":
                        string[] abilities = split[1].Split(new[] { "," }, StringSplitOptions.None);
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", "\t\t\tAvailableAbilities = new List<Ability>()\n\t\t\t{\n");
                        foreach (string ability in abilities)
                        {
                            File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\t\tGameController.GetAbility(AbilityNames.{ability}),\n");
                            //File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\t\tAbilityFactory.{char.ToUpper(ability[0])}{ability.Substring(1).ToLower()},\n");
                        }
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", "\t\t\t},\n");
                        break;
                    case "HiddenAbilities":
                        string hidden = split[1];
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\tAvailableHiddenAbility = GameController.GetAbility(AbilityNames.{hidden}),\n");
                        break;
                    case "Moves":
                        //Dictionary<int, List<object>> d = new() { { 0, new List<object>() }, { 1, new()} };
                        Dictionary<int, List<string>> LearnSets = new();
                        string[] moveStrings = split[1].Split(new[] { "," }, StringSplitOptions.None);
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\tLevelUpLearnset = new() " + "{ ");
                        int level = 0;
                        string moveName = string.Empty;
                        for (int i = 0; i < moveStrings.Length; i++)
                        {
                            if (i % 2 == 0)
                            {
                                level = Convert.ToInt32(moveStrings[i]);
                                LearnSets.TryAdd(level, new List<string>());
                            }
                            else
                            {
                                moveName = moveStrings[i];
                                LearnSets[level].Add(moveName);
                            }
                        }
                        int j = 0;
                        foreach (int lv in LearnSets.Keys)
                        {
                            j++;
                            if (j != 1) File.AppendAllText(writepath + "\\PokemonFactory.cs", ", ");
                            File.AppendAllText(writepath + "\\PokemonFactory.cs", "{ " + $"{lv}, new List<Move>() " + "{ ");
                            int i = 0;
                            foreach (string m in LearnSets[lv])
                            {
                                i++;
                                if (i != 1) File.AppendAllText(writepath + "\\PokemonFactory.cs", ", ");
                                File.AppendAllText(writepath + "\\PokemonFactory.cs", $"GameController.GetMove(MoveNames.{m})");
                            }
                            File.AppendAllText(writepath + "\\PokemonFactory.cs", " } }");
                        }
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", " },\n");
                        break;
                    case "TutorMoves":
                        break;
                    case "EggMoves":
                        break;
                    case "EggGroups":
                        break;
                    case "HatchSteps":
                        break;
                    case "Height":
                        break;
                    case "Weight":
                        break;
                    case "Color":
                        break;
                    case "Shape":
                        break;
                    case "Habitat":
                        break;
                    case "Category":
                        break;
                    case "WildItemUncommon":
                        break;
                    case "Offspring":
                        break;
                    case "WildItemCommon":
                        break;
                    case "WildItemRare":
                        break;
                    case "Incense":
                        break;
                    case "FormName":
                        break;
                    case "Flags":
                        break; // only interesting for UltraBeast flag but ok
                    case "Pokedex":
                        string dex = split[1];
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\tPokedexEntry = \"{dex.Replace("\"", "'")}\",\n");
                        break;
                    case "Generation":
                        int generation = Convert.ToInt32(split[1]);
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\tGeneration = {generation},\n");
                        File.AppendAllText(writepath + "\\PokemonFactory.cs", $"\t\t\tFrontSprite = BitmapLoader.GetFrontSprite(PokemonNames.{upname}),\n\t\t\tBackSprite = BitmapLoader.GetBackSprite(PokemonNames.{upname})\n" + "\t\t};\n");
                        break;
                    case "Evolutions":
                        break;
                    default:
                        if (split[0] == $"[{upname}]") break;
                        Console.WriteLine(split[0]);
                        break;
                }
            }
            File.AppendAllText(writepath + "\\PokemonFactory.cs", "\t\tpublic static List<Pokemon> Pokemons = new() { ");
            int index = 0;
            foreach (string p in pokemons)
            {
                index++;
                if (index == 1) File.AppendAllText(writepath + "\\PokemonFactory.cs", p);
                else File.AppendAllText(writepath + "\\PokemonFactory.cs", $", {p}");
            }
            File.AppendAllText(writepath + "\\PokemonFactory.cs", " };\n\t}\n}");
        }
        public static void WriteMoveFactoryCs()
        {
            string path = "C:\\Users\\Jan-Okke\\Desktop\\stuff\\Pokemon DarkGold\\Pokemon White X_Mapping\\PBS\\Gen 8";
            string writepath = "C:\\Users\\Jan-Okke\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Factory";

            string[] data = File.ReadAllLines(path + "\\moves.txt");
            List<string> moves = new();
            File.WriteAllText(writepath + "\\MoveFactory.cs", "using Pokemon2022.Game.Entities;\nusing Pokemon2022.Game.Entities.Names;\nusing Pokemon2022.Game.Entities.Enums;\nusing System.Collections.Generic;\n\nnamespace Pokemon2022.Game.Factory\n{\n\tpublic class MoveFactory\n\t{\n");
            string upname = string.Empty;
            foreach (string line in data)
            {
                if (line.StartsWith("#")) upname = string.Empty;
                if (line.StartsWith("["))
                {
                    upname = line.Split(new[] { "[" }, StringSplitOptions.None)[1].Split(new[] { "]" }, StringSplitOptions.None)[0];
                }
                if (upname == string.Empty) continue;
                string[] split = line.Split(new[] { " = " }, StringSplitOptions.None);
                switch (split[0])
                {
                    case "Name":
                        string name = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\tpublic static Move {name.Replace(" ", "").Replace("-", "").Replace("'", "")} = new ()\n" + "\t\t{\n" + $"\t\t\tName = MoveNames.{upname},\n");
                        moves.Add(name.Replace(" ", "").Replace("-", "").Replace("'", ""));
                        break;
                    case "Type":
                        string _type = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tMoveType = PokemonType.{char.ToUpper(_type[0])}{_type.Substring(1).ToLower()},\n");
                        break;
                    case "Category":
                        string category = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tCategory = MoveCategory.{category},\n");
                        break;
                    case "Power":
                        string power = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tBasePower = {power},\n");
                        break;
                    case "Accuracy":
                        string accuracy = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tAccuracy = {accuracy},\n");
                        break;
                    case "TotalPP":
                        string pp = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tPowerPoints = {pp},\n");
                        break;
                    case "Target":
                        string target = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tTarget = MoveTarget.{target},\n");
                        break;
                    case "Priority":
                        string priority = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tPriority = {priority},\n");
                        break;
                    case "Description":
                        string description = split[1];
                        File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tDescription = \"{description.Replace("\"", "'")}\",\n");
                        File.AppendAllText(writepath + "\\MoveFactory.cs", "\t\t};\n");
                        break;
                    case "FunctionCode":
                        break;
                    case "Flags":
                        string[] flags = split[1].Split(new[] { "," }, StringSplitOptions.None);
                        foreach (string flag in flags)
                        {
                            switch (flag)
                            {
                                case "CanProtect":
                                    break;
                                case "CanMirrorMove":
                                    break;
                                case "CannotMetronome":
                                    break;
                                case "ThawsUser":
                                    break;
                                case "TramplesMinimize":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tTramplesMinimize = true,\n");
                                    break;
                                case "Contact":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tIsContactMove = true,\n");
                                    break;
                                case "Sound":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tIsSoundMove = true,\n");
                                    break;
                                case "Bomb":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tIsBombMove = true,\n");
                                    break;
                                case "HighCriticalHitRate":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tHasHighCritRate = true,\n");
                                    break;
                                case "Powder":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tIsPowderMove = true,\n");
                                    break;
                                case "Dance":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tIsDanceMove = true,\n");
                                    break;
                                case "Biting":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tIsBitingMove = true,\n");
                                    break;
                                case "Pulse":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tIsPulseMove = true,\n");
                                    break;
                                case "Punching":
                                    File.AppendAllText(writepath + "\\MoveFactory.cs", $"\t\t\tIsPunchingMove = true,\n");
                                    break;
                                default:
                                    Console.WriteLine(flag);
                                    break;
                            }
                        }
                        break;
                    case "EffectChance":
                        break;
                    default:
                        if (split[0] == $"[{upname}]") break;
                        Console.WriteLine(split[0]);
                        break;
                }
            }
            File.AppendAllText(writepath + "\\MoveFactory.cs", "\t\tpublic static List<Move> Moves = new() { ");
            int index = 0;
            foreach (string move in moves)
            {
                index++;
                if (index == 1) File.AppendAllText(writepath + "\\MoveFactory.cs", move);
                else File.AppendAllText(writepath + "\\MoveFactory.cs", $", {move}");
            }
            File.AppendAllText(writepath + "\\MoveFactory.cs", " };\n\t}\n}");
        }
        public static void WriteAbilityFactoryCs() // TODO As One
        {
            string path = "C:\\Users\\Jan-Okke\\Desktop\\stuff\\Pokemon DarkGold\\Pokemon White X_Mapping\\PBS\\Gen 8";
            string writepath = "C:\\Users\\Jan-Okke\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Factory";

            string[] data = File.ReadAllLines(path + "\\abilities.txt");
            List<string> abilities = new();

            File.WriteAllText(writepath + "\\AbilityFactory.cs", "using Pokemon2022.Game.Entities;\nusing Pokemon2022.Game.Entities.Names;\nusing System.Collections.Generic;\n\nnamespace Pokemon2022.Game.Factory\n{\n\tpublic class AbilityFactory\n\t{\n");
            string upname = string.Empty;
            foreach (string line in data)
            {
                if (line.StartsWith("#")) upname = string.Empty;
                if (line.StartsWith("["))
                {
                    upname = line.Split(new[] { "[" }, StringSplitOptions.None)[1].Split(new[] { "]" }, StringSplitOptions.None)[0];
                }
                if (upname == string.Empty) continue;
                string[] split = line.Split(new[] { " = " }, StringSplitOptions.None);
                switch (split[0])
                {
                    case "Name":
                        string abName = split[1];
                        File.AppendAllText(writepath + "\\AbilityFactory.cs", $"\t\tpublic static Ability {abName.Replace(" ", "").Replace("-", "").Replace("'", "")} = new ()\n" + "\t\t{\n" + $"\t\t\tName = AbilityNames.{upname},\n");
                        abilities.Add(abName.Replace(" ", "").Replace("-", "").Replace("'", ""));
                        break;
                    case "Description":
                        string description = split[1];
                        File.AppendAllText(writepath + "\\AbilityFactory.cs", $"\t\t\tDescription = \"{description.Replace("\"", "'")}\",\n");
                        File.AppendAllText(writepath + "\\AbilityFactory.cs", "\t\t};\n");
                        break;
                }
            }
            File.AppendAllText(writepath + "\\AbilityFactory.cs", "\t\tpublic static List<Ability> Abilities = new() { ");
            int index = 0;
            foreach (string ability in abilities)
            {
                index++;
                if (index == 1) File.AppendAllText(writepath + "\\AbilityFactory.cs", ability);
                else File.AppendAllText(writepath + "\\AbilityFactory.cs", $", {ability}");
            }
            File.AppendAllText(writepath + "\\AbilityFactory.cs", " };\n\t}\n}");
        }
        public static void WriteItemNamesCs()
        {
            string path = "C:\\Users\\Jan-Okke\\Desktop\\stuff\\Pokemon DarkGold\\Pokemon White X_Mapping\\PBS\\Gen 8";
            string writepath = "C:\\Users\\Jan-Okke\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Entities\\Names";

            string[] data = File.ReadAllLines(path + "\\items.txt");

            File.WriteAllText(writepath + "\\ItemNames.cs", "namespace Pokemon2022.Game.Entities.Names\n{\n\tpublic class ItemNames\n\t{\n");

            foreach (string line in data)
            {
                if (line.StartsWith("#")) continue;
                if (line.StartsWith("["))
                {
                    string upName = line.Split(new[] { "[" }, StringSplitOptions.None)[1].Split(new[] { "]" }, StringSplitOptions.None)[0];
                    File.AppendAllText(writepath + "\\ItemNames.cs", $"\t\tpublic const string {upName} = \"");
                    continue;
                }
                string[] split = line.Split(new[] { " = " }, StringSplitOptions.None);
                switch (split[0])
                {
                    case "Name":
                        string abName = split[1];
                        File.AppendAllText(writepath + "\\ItemNames.cs", $"{abName}\";\n");
                        break;
                }
            }
            File.AppendAllText(writepath + "\\ItemNames.cs", "\t}\n}");
        }
        public static void WriteMoveNamesCs()
        {
            string path = "C:\\Users\\Jan-Okke\\Desktop\\stuff\\Pokemon DarkGold\\Pokemon White X_Mapping\\PBS\\Gen 8";
            string writepath = "C:\\Users\\Jan-Okke\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Entities\\Names";

            string[] data = File.ReadAllLines(path + "\\moves.txt");

            File.WriteAllText(writepath + "\\MoveNames.cs", "namespace Pokemon2022.Game.Entities.Names\n{\n\tpublic class MoveNames\n\t{\n");

            foreach (string line in data)
            {
                if (line.StartsWith("#")) continue;
                if (line.StartsWith("["))
                {
                    string upName = line.Split(new[] { "[" }, StringSplitOptions.None)[1].Split(new[] { "]" }, StringSplitOptions.None)[0];
                    File.AppendAllText(writepath + "\\MoveNames.cs", $"\t\tpublic const string {upName} = \"");
                    continue;
                }
                string[] split = line.Split(new[] { " = " }, StringSplitOptions.None);
                switch (split[0])
                {
                    case "Name":
                        string abName = split[1];
                        File.AppendAllText(writepath + "\\MoveNames.cs", $"{abName}\";\n");
                        break;
                }
            }
            File.AppendAllText(writepath + "\\MoveNames.cs", "\t}\n}");
        }
        public static void WritePokemonNamesCs()
        {
            string path = "C:\\Users\\Jan-Okke\\Desktop\\stuff\\Pokemon DarkGold\\Pokemon White X_Mapping\\PBS\\Gen 8";
            string writepath = "C:\\Users\\Jan-Okke\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Entities\\Names";

            string[] data = File.ReadAllLines(path + "\\pokemon.txt");

            File.WriteAllText(writepath + "\\PokemonNames.cs", "namespace Pokemon2022.Game.Entities.Names\n{\n\tpublic class PokemonNames\n\t{\n");

            foreach (string line in data)
            {
                if (line.StartsWith("#")) continue;
                if (line.StartsWith("["))
                {
                    string upName = line.Split(new[] { "[" }, StringSplitOptions.None)[1].Split(new[] { "]" }, StringSplitOptions.None)[0];
                    File.AppendAllText(writepath + "\\PokemonNames.cs", $"\t\tpublic const string {upName} = \"");
                    continue;
                }
                string[] split = line.Split(new[] { " = " }, StringSplitOptions.None);
                switch (split[0])
                {
                    case "Name":
                        string abName = split[1];
                        File.AppendAllText(writepath + "\\PokemonNames.cs", $"{abName}\";\n");
                        break;
                }
            }
            File.AppendAllText(writepath + "\\PokemonNames.cs", "\t}\n}");
        }
        public static void WriteAbilityNamesCs()
        {
            string path = "C:\\Users\\Jan-Okke\\Desktop\\stuff\\Pokemon DarkGold\\Pokemon White X_Mapping\\PBS\\Gen 8";
            string writepath = "C:\\Users\\Jan-Okke\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Entities\\Names";

            string[] data = File.ReadAllLines(path + "\\abilities.txt");

            File.WriteAllText(writepath + "\\AbilityNames.cs", "namespace Pokemon2022.Game.Entities.Names\n{\n\tpublic class AbilityNames\n\t{\n");

            foreach (string line in data)
            {
                if (line.StartsWith("#")) continue;
                if (line.StartsWith("["))
                {
                    string upName = line.Split(new[] { "[" }, StringSplitOptions.None)[1].Split(new[] { "]" }, StringSplitOptions.None)[0];
                    File.AppendAllText(writepath + "\\AbilityNames.cs", $"\t\tpublic const string {upName} = \"");
                    continue;
                }
                string[] split = line.Split(new[] { " = " }, StringSplitOptions.None);
                switch (split[0])
                {
                    case "Name":
                        string abName = split[1];
                        File.AppendAllText(writepath + "\\AbilityNames.cs", $"{abName}\";\n");
                        break;
                }
            }
            File.AppendAllText(writepath + "\\AbilityNames.cs", "\t}\n}");
        }
    }
}