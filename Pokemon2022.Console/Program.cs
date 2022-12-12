using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Logic;
using Pokemon2022.Game.TeamLoaderExtention;
using Pokemon2022.Game.Factory;
using Pokemon2022.Console;
using Pokemon2022.Game.Extensions;

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
Console.WriteLine("Done");
Console.ReadLine();