using Pokemon2022.Game.Entities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Pokemon2022.Game.Logic;
using System.Windows.Threading;
using Pokemon2022.Game;

namespace Pokemon2022.UI
{
    /// <summary>
    /// Interaktionslogik für BattleWindow.xaml
    /// </summary>
    public partial class BattleWindow : Window
    {
        public Pokemon PlayerPokemon;
        public Pokemon OpponentPokemon;
        private BitmapImage BattleBG;
        public Battle Battle;
        private UIController UIController;
        public ActionQueue ActionQueue;
        public BattleWindow(Pokemon playerPokemon, Pokemon opponentPokemon, BitmapImage battleBG, Battle battle)
        {
            PlayerPokemon = playerPokemon;
            OpponentPokemon = opponentPokemon;
            BattleBG = battleBG;
            Battle = battle;
            ActionQueue = new();
            InitializeComponent();
            InitializeData();
            UIController = new(this);
            new Thread(() => TextUpdateThread()).Start();
        }
        private void InitializeData(bool firstTime = true)
        {
            if (firstTime)
            {
                BattleBGImage.Source = BattleBG;
                PlayerOverviewImage.Source = BitmapLoader.LoadImage("Battle\\databox_normal.png");
                OpponentOverviewImage.Source = BitmapLoader.LoadImage("Battle\\databox_normal_foe.png");
                EnemyBase.Source = BitmapLoader.GetBattleBGSprite("field_base1");
                PlayerPokemonBase.Source = BitmapLoader.GetBattleBGSprite("field_base0");
                PlayerNameBlock.Text = PlayerPokemon.Name;
                EnemyNameBlock.Text = OpponentPokemon.Name;
                PlayerPokemonImage.Source = PlayerPokemon.BackSprite;
                OpponentImage.Source = OpponentPokemon.FrontSprite; 
                OutputTextBox.Text = $"A wild {OpponentPokemon.Name} appeared!\nGo, {PlayerPokemon.Name}!";
            }
            PlayerHPBar.Value = PlayerPokemon.CurrentHP * 100 / PlayerPokemon.Stats.HP;
            PlayerHPBlock.Text = $"{PlayerPokemon.CurrentHP}/{PlayerPokemon.Stats.HP}";
            EnemyHPBar.Value = OpponentPokemon.CurrentHP * 100 / OpponentPokemon.Stats.HP;
            PlayerLevelBlock.Text = $"Lv. {PlayerPokemon.Level}";
            EnemyLevelBlock.Text = $"Lv. {OpponentPokemon.Level}";
        }
        public void Update()
        {
            InitializeData(false);
        }
        private void TextUpdateThread()
        {
            while (this.Dispatcher.Thread.IsAlive)
            {
                Thread.Sleep(10);
                ActionData? next = ActionQueue.Next();
                if (next is null) continue;
                this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, () =>
                {
                    OutputTextBox.Text = next.Text;
                    Update();
                });
                Thread.Sleep(next.Delay);
            }
        }

        private void Button_Run(object sender, RoutedEventArgs e)
        {
            if (Battle.IsTrainerBattle)
            {
                OutputTextBox.Text = "No running from a trainer battle!";
                return;
            }
            if (Battle.IsWildBattle)
            {
                if (BattleLogic.CheckWildBattleFlee(PlayerPokemon, OpponentPokemon))
                {
                    OutputTextBox.Text = "Got away safely!";
                    this.Close();
                }
            }
        }

        private void Button_Fight(object sender, RoutedEventArgs e)
        {
            new MoveChooseWindow(PlayerPokemon, UIController).Show();
        }

        private void Button_Bag(object sender, RoutedEventArgs e)
        {
            UIController.BagMenu();
        }

        private void Button_Pokemon(object sender, RoutedEventArgs e)
        {
            UIController.PokemonMenu();
        }
    }
}
