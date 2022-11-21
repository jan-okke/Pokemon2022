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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokemon2022.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UIController uiController;
        public MainWindow()
        {
            InitializeComponent();
            uiController = new(this);
        }

        private void Continue(object sender, RoutedEventArgs e)
        {
            uiController.ContinueGame();
        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            uiController.NewGame();
        }

        private void Options(object sender, RoutedEventArgs e)
        {
            uiController.OptionMenu();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            uiController.Close();
        }
    }
}
