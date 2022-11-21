using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pokemon2022.UI
{
    /// <summary>
    /// Interaktionslogik für MoveChooseWindow.xaml
    /// </summary>
    public partial class MoveChooseWindow : Window
    {
        private Pokemon Pokemon;
        private UIController BattleUI;
        public MoveChooseWindow(Pokemon pokemon, UIController battleUI)
        {
            InitializeComponent();
            BattleUI = battleUI;
            Pokemon = pokemon;
            InitializeData();
        }
        private void InitializeData()
        {
            Move1Button.IsEnabled = false;
            Move2Button.IsEnabled = false;
            Move3Button.IsEnabled = false;
            Move4Button.IsEnabled = false;
            try
            {
                Move1Button.Content = Pokemon.Moves[0].Name;
                Move1Button.IsEnabled = true;
                Move2Button.Content = Pokemon.Moves[1].Name;
                Move2Button.IsEnabled = true;
                Move3Button.Content = Pokemon.Moves[2].Name;
                Move3Button.IsEnabled = true;
                Move4Button.Content = Pokemon.Moves[3].Name;
                Move4Button.IsEnabled = true;
            }
            catch { }
        }

        private void Move1Button_Click(object sender, RoutedEventArgs e)
        {
            BattleUI.ChooseMove(Pokemon.Moves[0]);
            Close();
        }

        private void Move2Button_Click(object sender, RoutedEventArgs e)
        {
            BattleUI.ChooseMove(Pokemon.Moves[1]);
            Close();
        }

        private void Move3Button_Click(object sender, RoutedEventArgs e)
        {
            BattleUI.ChooseMove(Pokemon.Moves[2]);
            Close();
        }

        private void Move4Button_Click(object sender, RoutedEventArgs e)
        {
            BattleUI.ChooseMove(Pokemon.Moves[3]);
            Close();
        }
    }
}
