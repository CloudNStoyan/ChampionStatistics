using System;
using System.Collections.Generic;
using System.Linq;
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
                Tips = "Ally tips:\r\n" + string.Join("\r\n", championInfo.Allytips) + "\r\nEnemy tips:\r\n" + string.Join("\r\n", championInfo.Enemytips),
                Spells = championInfo.Spells.Select(x => new Uri(dDragon.VersionImg.Spell(x.Image.Full))).ToArray(),
                Passive = new Uri(dDragon.VersionImg.Passive(championInfo.Passive.Image.Full)),
                SkinCount = championInfo.Skins.Length
            };
        }
    }
}
