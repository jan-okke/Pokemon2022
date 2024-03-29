﻿using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Logic;
using Pokemon2022.Game.Factory;
using Pokemon2022.Console;
using Pokemon2022.Game.Extensions;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Pokemons;
using System.Diagnostics;
using Pokemon2022.Game.TeamLoaderExtention;

//for (int i = 0; i < 10; i++)
//PBSMaker.GenerateTrainer("Camper", "John", new List<PokemonType>() { PokemonType.Water }, 4, 7, 2, new List<int>() { 2 }, 500, 800);

#region Teststuff
/*
Pokemon playerPokemon = GameController.NewPokemon("Charmander", 5, new() { GameController.GetMove("Tackle")});
PokemonParty playerParty = new() { Pokemons = new() { playerPokemon } };
Battle testBattle = GameController.StartWildBattle(playerParty, "Bulbasaur", 5);

Console.WriteLine(Calculations.CalculateDamage(testBattle, playerPokemon, testBattle.EnemyParty.GetFirstAlivePokemon(), playerPokemon.Moves[0]));
*/

//PokemonParty playerParty = Loader.LoadFromFile("C:\\Users\\jan-okke.rockmann\\source\\repos\\jan-okke\\Pokemon2022\\Pokemon2022.Game\\Data\\Teams\\falkner.txt");
//PokemonParty enemyParty = Loader.LoadFromFile("C:\\Users\\jan-okke.rockmann\\source\\repos\\jan-okke\\Pokemon2022\\Pokemon2022.Game\\Data\\Teams\\elderteam.txt");

PokemonParty playerParty = Loader.LoadFromFile("C:\\Users\\Jan\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Data\\Teams\\falkner.txt");
PokemonParty enemyParty = Loader.LoadFromFile("C:\\Users\\Jan\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Data\\Teams\\bugsy.txt");

Analyzer.Analyze(playerParty.GetFirstAlivePokemon(), enemyParty.GetFirstAlivePokemon(), GameController.StartTrainerBattle(playerParty, enemyParty), 10);

//NewAnalyzer.AnalyzeBattle(GameController.StartTrainerBattle(playerParty, enemyParty), 10);
//Console.WriteLine("Ok");
//new BattleSimulation(playerParty, enemyParty);
//Battle testBattle = GameController.StartTrainerBattle(playerParty, enemyParty);
//Pokemon playerPokemon = playerParty.GetFirstAlivePokemon();
//Pokemon enemyPokemon = enemyParty.GetFirstAlivePokemon();

/*
foreach (Move move in GameController.GetMovesAtLevel(GameController.NewPokemon("Charmander", 25), 25))
{
    Console.WriteLine(move.Name);
}
*/

//Dictionary<long, string> Outputs = Analyzer.Analyze(playerPokemon, enemyPokemon, testBattle, 2);

/*    
= new();
List<State> States = new();
List<State> _States = new();
int index = 0;
int atkWinCount = 0;
int oppWinCount = 0;
int total = 0;

foreach (Move attMove in playerPokemon.Moves)
{
    foreach (Move oppMove in enemyPokemon.Moves)
    {
        index++;
        Pokemon att = playerPokemon.Clone();
        Pokemon opp = enemyPokemon.Clone();
        Move atMove = attMove.Clone();
        Move opMove = oppMove.Clone();
        Battle bat = testBattle.Clone();
        //Console.WriteLine($"{att.GetHashCode()} | {opp.GetHashCode()}");
        BattleLogic.BattleTurn(att, opp, atMove, opMove, bat);
        string before = $"Outcome [{index}] {attMove.Name} | {oppMove.Name}\n" +
            $"Attacker: {att.CurrentHP} / {att.Stats.HP}\n" +
            $"Defender: {opp.CurrentHP} / {opp.Stats.HP}";
        Outputs.Add(index*1000, before);
        if (att.IsAlive && opp.IsAlive) States.Add(new(att, opp, bat, atMove, opMove, index));
        if (att.IsAlive && !opp.IsAlive) atkWinCount++;
        if (!att.IsAlive && opp.IsAlive) oppWinCount++;
        total++;
    }
}

foreach (State state in States)
{
    index = 0;
    foreach (Move attMove in state.PlayerPokemon.Moves)
    {
        foreach (Move oppMove in state.OpponentPokemon.Moves)
        {
            index++;
            Pokemon att = state.PlayerPokemon.Clone();
            Pokemon opp = state.OpponentPokemon.Clone();
            Move atMove = attMove.Clone();
            Move opMove = oppMove.Clone();
            Battle bat = state.Battle.Clone();
            //Console.WriteLine($"{att.GetHashCode()} | {opp.GetHashCode()}");
            BattleLogic.BattleTurn(att, opp, atMove, opMove, bat);
            Outputs.Add(state.Index*1000+index, $"Outcome [{state.Index}.{index}] {state.AttackerMove.Name} | {state.OpponentMove.Name} | {attMove.Name} | {oppMove.Name}\n" +
                $"Attacker: {att.CurrentHP} / {att.Stats.HP}\n" +
                $"Defender: {opp.CurrentHP} / {opp.Stats.HP}");
            if (att.IsAlive && !opp.IsAlive) atkWinCount++;
            if (!att.IsAlive && opp.IsAlive) oppWinCount++;
            //if (att.IsAlive && opp.IsAlive) _States.Add(new(att, opp, bat));
            total++;
        }
    }
}

List<long> keys = new();

foreach (long key in Outputs.Keys)
{
    keys.Add(key);
}

keys.Sort();

foreach (long key in keys)
{
    Console.WriteLine(Outputs[key]);
}
*/
/*
Console.WriteLine(atkWinCount);
Console.WriteLine(oppWinCount);
Console.WriteLine(total);
*/
//Console.WriteLine("Done");
//Console.ReadLine();
#endregion


//void WriteNewFiles()
//{
//    foreach (Pokemon p in PokemonFactory.Pokemons)
//    {
//        string text = "" +
//            "using Pokemon2022.Game.Entities;\n" +
//            "using Pokemon2022.Game.Entities.Enums;\n" +
//            "using Pokemon2022.Game.Factory;\n" +
//            "using System.Collections.Generic;\n" +
//            "\n" +
//            "namespace Pokemon2022.Game.Pokemons\n" +
//            "{\n" +
//            $"\tpublic class {p.Name.Replace("'", "").Replace("-", "").Replace(" ", "").Replace(".", "").Replace("♂", "M").Replace("♀", "F")} : Pokemon\n" +
//            "\t{\n" +
//            $"\t\tpublic override string Name => \"{p.Name}\";\n" +
//            $"\t\tpublic override int Generation => {p.Generation};\n" +
//            $"\t\tpublic override string PokedexEntry => \"{p.PokedexEntry}\";\n" +
//            "\t\tpublic override PokemonType[] Types => new PokemonType[] {";
//        text += $"PokemonType.{p.Types[0]}";
//        if (p.Types.Length > 1) { text += $", PokemonType.{p.Types[1]}"; }
//        text += " };\n" +
//            "\t\tpublic override List<Ability> AvailableAbilities => new List<Ability>() { ";
//        foreach (Ability a in p.AvailableAbilities)
//        {
//            text += $"AbilityFactory.{a.Name.Replace(" ", "").Replace("'", "").Replace("-", "")}, ";
//        }
//        text += "};\n";
//        if (p.AvailableHiddenAbility.Name != "")
//        {
//            text += $"\t\tpublic override Ability AvailableHiddenAbility => AbilityFactory.{p.AvailableHiddenAbility.Name.Replace(" ", "").Replace("'", "").Replace("-", "")};\n";
//        }
//        text += "\t\tpublic override Stats BaseStats => new Stats() {\n" +
//            $"\t\t\tHP = {p.BaseStats.HP},\n" +
//            $"\t\t\tAttack = {p.BaseStats.Attack},\n" +
//            $"\t\t\tDefense = {p.BaseStats.Defense},\n" +
//            $"\t\t\tSpecialAttack = {p.BaseStats.SpecialAttack},\n" +
//            $"\t\t\tSpecialDefense = {p.BaseStats.SpecialDefense},\n" +
//            $"\t\t\tSpeed = {p.BaseStats.Speed}\n" +
//            "\t\t};\n";
//        text += "\t\tpublic override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()\n" +
//            "\t\t{\n";
//        foreach (int key in p.LevelUpLearnset.Keys)
//        {
//            text += $"\t\t\t[{key}] = new List<Move>() " + "{ ";
//            foreach (Move m in p.LevelUpLearnset[key]) 
//            {
//                text += $"MoveFactory.{m.Name.Replace(" ", "").Replace("'", "").Replace("-", "")}, ";
//            }
//            text += "},\n";
//        }
//        text += "\t\t};\n" +
//            "\t}\n" +
//            "}\n";
//        File.WriteAllText($"C:\\Users\\Jan\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Pokemons\\{p.Name}.cs", text);
//    }
//}

//Bulbasaur bulb = Pokemon.NewPokemon<Bulbasaur>("Bulbasaur");
////Console.WriteLine(bulb.GetHashCode());
////Console.WriteLine(bulb.Copy().GetHashCode());
//Console.WriteLine(DateTime.Now);

//for (int i = 0; i < 1000000; i++)
//{
//    bulb.Copy();
//}
//Console.WriteLine(DateTime.Now);
//try
//{
//    for (int y = 0; y < 100; y++)
//    {
//        for (int i = 0; i < 10000; i++) { bulb.Copy(); }
//        Process proc = Process.GetCurrentProcess();
//        Console.WriteLine(proc.PrivateMemorySize64);
//        Console.WriteLine(DateTime.Now);
//        Thread.Sleep(500);
//        Console.WriteLine(y);
//    }
//;
//}
//catch
//{
//    Console.WriteLine("err");
//    Console.ReadLine();
//}