using System.Windows;
using System.Windows.Controls;

namespace ChampionStatistics
{
    public partial class Alert : UserControl
    {
        public Alert()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
