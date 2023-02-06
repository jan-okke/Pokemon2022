using Pokemon2022.Game;
using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Extensions;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Pokemon2022.UI
{
    public class UIController
    {
        private Window ActiveWindow;
        public UIController(Window activeWindow)
        {
            ActiveWindow = activeWindow;
        }
        
        public void Close()
        {
            ActiveWindow.Close();
        }
        public void NewGame()
        {
            //PokemonParty playerParty = Loader.LoadFromFile("C:\\Users\\Jan\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Data\\Teams\\falkner.txt");
            //PokemonParty enemyParty = Loader.LoadFromFile("C:\\Users\\Jan\\source\\repos\\Pokemon2022\\Pokemon2022.Game\\Data\\Teams\\bugsy.txt");
            //PokemonParty playerParty = Loader.LoadFromFile("C:\\Users\\jan-okke.rockmann\\source\\repos\\jan-okke\\Pokemon2022\\Pokemon2022.Game\\Data\\Teams\\falkner.txt");
            //PokemonParty enemyParty = Loader.LoadFromFile("C:\\Users\\jan-okke.rockmann\\source\\repos\\jan-okke\\Pokemon2022\\Pokemon2022.Game\\Data\\Teams\\bugsy.txt");
            
            //new BattleWindow(playerParty.GetFirstAlivePokemon(), enemyParty.GetFirstAlivePokemon(), BitmapLoader.GetBattleBGSprite("field_bg"), new Battle()
            //{
            //    PlayerParty = playerParty, EnemyParty = enemyParty, IsTrainerBattle = true
            //}).Show();
            //ActiveWindow.Close();
        }
        public void ContinueGame()
        {

        }
        public void OptionMenu()
        {

        }
        public void PokemonMenu()
        {

        }
        public void BagMenu()
        {

        }
        private BattleWindow GetBattleWindow()
        {
            if (ActiveWindow.GetType() != typeof(BattleWindow)) throw new NullReferenceException();
            return (BattleWindow)ActiveWindow;
        }
        public void ChooseMove(Move move)
        {
            BattleWindow ui = GetBattleWindow();
            //List<BattleState> states = BattleLogic.BattleTurn(ui.PlayerPokemon, ui.OpponentPokemon, move, GameController.RandomMove(ui.OpponentPokemon), ui.Battle);
            //foreach (BattleState state in states)
            //{
            //    ui.Update(state, 1000);
            //}
        }
        public void Update()
        {
            GetBattleWindow().Update();
        }
        public void AddActionData(ActionData data)
        {
            GetBattleWindow().ActionQueue.Add(data);
        }
    }
}
