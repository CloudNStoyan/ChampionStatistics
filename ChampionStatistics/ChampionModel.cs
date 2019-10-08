using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using ChampionStatistics.RiotObject;

namespace ChampionStatistics
{
    public class ChampionModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public Uri Image { get; set; }
        public KeyValuePair<string,double>[] Stats { get; set; }
        public string Lore { get; set; }
        public string Tag { get; set; }
        public string Tips { get; set; }
        public Uri[] Spells { get; set; }
        public Uri Passive { get; set; }
        public int SkinCount { get; set; }
        public StackPanel[] ToolTips { get; set; }

        public static ChampionModel Parse(ChampionInfo championInfo, DDragon dDragon)
        {
            return new ChampionModel
            {
                Name = championInfo.Name,
                Stats = championInfo.Stats.ToArray(),
                Title = championInfo.Title,
                Image = new Uri(dDragon.VersionImg.Champion(championInfo.Image.Full)),
                Lore = championInfo.Lore,
                Tag = string.Join(", ", championInfo.Tags.Select(x => x.ToString())),
                Tips = "Ally tips:\r\n" + string.Join("\r\n", championInfo.Allytips) + "\r\nEnemy tips:\r\n" +
                       string.Join("\r\n", championInfo.Enemytips),
                Spells = championInfo.Spells.Select(x => new Uri(dDragon.VersionImg.Spell(x.Image.Full))).ToArray(),
                Passive = new Uri(dDragon.VersionImg.Passive(championInfo.Passive.Image.Full)),
                SkinCount = championInfo.Skins.Length,
                ToolTips = ConvertToolTips(championInfo.Passive, championInfo.Spells)
            };
        }

        private static StackPanel[] ConvertToolTips(Passive passive, Spell[] spells)
        {
            var list = new List<StackPanel>();

            var stackPanel2 = new StackPanel();
            stackPanel2.Children.Add(new TextBlock {Text = passive.Description});
            list.Add(stackPanel2);

            foreach (var spell in spells)
            {
                var stackPanel = new StackPanel();

                var textBlock = new TextBlock {Text = spell.Tooltip};
                stackPanel.Children.Add(textBlock);
                list.Add(stackPanel);
            }

            return list.ToArray();
        }
    }
}
