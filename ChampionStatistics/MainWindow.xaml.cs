using System.Windows;
using System.Windows.Controls;

namespace ChampionStatistics
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void InputBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = (TextBox) sender;


        }
    }
}
