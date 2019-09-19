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

        public static ChampionModel Parse(ChampionInfo championInfo, DDragon dDragon)
        {
            return new ChampionModel
            {
                Name = championInfo.Name,
                Stats = championInfo.Stats.ToArray(),
                Title = championInfo.Title,
                Image = new Uri(dDragon.Img.Champion(championInfo.Image.Full)),
                Lore = championInfo.Lore,
                Tag = string.Join(", ", championInfo.Tags.Select(x => x.ToString()))
            };
        }
    }
}
