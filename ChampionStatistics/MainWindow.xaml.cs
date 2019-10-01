using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChampionStatistics.RiotObject;
using ChampionStatistics.Static;
using Image = System.Windows.Controls.Image;
using Key = System.Windows.Input.Key;

namespace ChampionStatistics
{
    public partial class MainWindow : Window
    {
        private ChampionInfo[] Champions { get; }
        private DDragon MainDDragon { get; }

        public MainWindow()
        {
            this.InitializeComponent();
            this.Champions = ChampionInfo.FromJson(File.ReadAllText("./championInfo.json"));
            this.MainDDragon = new DDragon(Path.GetFullPath("./ddragontai-9.18.1/"), "9.18.1");

            this.InputBox.Visibility = Visibility.Visible;
            this.MainGrid.Visibility = Visibility.Hidden;
            this.InputBox.Focus();

            this.MainAlert.CloseButton.Click += (o, e) =>
            {
                this.InputBox.Visibility = Visibility.Visible;
                this.MainAlert.Visibility = Visibility.Hidden;
                this.InputBox.Focus();
            };
        }

        private void InputBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            var textbox = (TextBox)sender;
            this.SearchChampion(textbox.Text.Trim());
            textbox.Visibility = Visibility.Hidden;
        }

        private void SearchChampion(string championName)
        {
            var champion = this.Champions.FirstOrDefault(x => x.Name == championName);

            if (champion == null)
            {
                this.MainAlert.Visibility = Visibility.Visible;
                this.MainAlert.Title.Text = "Champion not found";
                this.MainAlert.TextArea.Text = "There is no champion with that name: " + championName;
                return;
            }

            this.MainGrid.Visibility = Visibility.Visible;
            this.MainGrid.DataContext = ChampionModel.Parse(champion, this.MainDDragon);

            this.SkinGallery.Children.Clear();

            var skinMargin = new Thickness(0, 10, 0, 0);

            foreach (var championSkin in champion.Skins)
            {
                string skin = this.MainDDragon.Img.Champion.Splash($"{champion.Id}_{championSkin.Num}.jpg");

                this.SkinGallery.Children.Add(new TextBlock
                {
                    Text = championSkin.Name,
                    Margin = skinMargin,
                    FontSize = 18,
                    FontFamily = FontFamilies.LucidaSans,
                    FontWeight = FontWeights.ExtraBold,
                    HorizontalAlignment = HorizontalAlignment.Center
                });

                var contextMenu = new ContextMenu();
                var menuItem = new MenuItem {Header = "Open as picture."};
                menuItem.Click += (sender, args) => Process.Start(skin);

                contextMenu.Items.Add(menuItem);

                this.SkinGallery.Children.Add(new Image
                {
                    Source = new BitmapImage(new Uri(skin)),
                    Height = 250,
                    Width = 500,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = skinMargin,
                    Stretch = Stretch.Uniform,
                    ContextMenu = contextMenu
                });
            }

            this.Stats.Children.Clear();
            var stats = this.ParseStatNames(champion.Stats.ToArray()).Select(x => new[]
            {
                new TextBlock
                {
                    Text = x.Key,
                    HorizontalAlignment = HorizontalAlignment.Left
                },
                new TextBlock
                {
                    Text = x.Value.ToString(CultureInfo.InvariantCulture),
                    HorizontalAlignment = HorizontalAlignment.Right
                }
            });

            foreach (var stat in stats)
            {
                var grid = new Grid();

                foreach (var textBlock in stat)
                {
                    grid.Children.Add(textBlock);
                }

                this.Stats.Children.Add(grid);
            }
        }

        private KeyValuePair<string, double>[] ParseStatNames(KeyValuePair<string, double>[] stats)
        {
            return stats
                .Select(keyValuePair =>
                    new KeyValuePair<string, double>(this.ConvertStatName(keyValuePair.Key), keyValuePair.Value)).ToArray();
        }

        private string ConvertStatName(string name)
        {
            switch (name)
            {
                case "hp":
                    return "Health";
                case "hpperlevel":
                    return "Health Per Level";
                case "mp":
                    return "Mana";
                case "mpperlevel":
                    return "Mana Per Level";
                case "movespeed":
                    return "Movement Speed";
                case "armor":
                    return "Armor";
                case "armorperlevel":
                    return "Armor Per Level";
                case "spellblock":
                    return "Magic Resist";
                case "spellblockperlevel":
                    return "Magic Resist Per Level";
                case "attackrange":
                    return "Range";
                case "hpregen":
                    return "Health Regen";
                case "hpregenperlevel":
                    return "Health Regen Per Level";
                case "mpregen":
                    return "Mana Regen";
                case "mpregenperlevel":
                    return "Mana Regen Per Level";
                case "crit":
                    return "Critical Strike";
                case "critperlevel":
                    return "Critical Striker Per Level";
                case "attackdamage":
                    return "Attack Damage";
                case "attackdamageperlevel":
                    return "Attack Damage Per Level";
                case "attackspeed":
                    return "Attack Speed";
                case "attackspeedperlevel":
                    return "Attack Speed Per Level";
                default:
                    return name;
            }
        }

        private void MainWindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape && this.MainGrid.Visibility == Visibility.Visible)
            {
                this.MainGrid.Visibility = Visibility.Hidden;
                this.InputBox.Visibility = Visibility.Visible;

                this.InputBox.Focus();
            }
        }
    }
}
