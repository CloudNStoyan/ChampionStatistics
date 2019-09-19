using System.IO;

namespace ChampionStatistics.RiotObject
{
    public class DDragon
    {
        private string DataDragonFolder { get; }
        private string DataDragonVersion { get; }
        public DataObject Data { get; }
        public ImgObject Img { get; }

        public DDragon(string dataDragonFolder, string version)
        {
            this.DataDragonFolder = dataDragonFolder;
            this.DataDragonVersion = version;
            this.Data = new DataObject("en_US", this);
            this.Img = new ImgObject(this);
        }

        public string Languages => File.ReadAllText(this.DataDragonFolder + "/languages.json");

        public class DataObject
        {
            private string DataFolder { get; }
            private DDragon Dragon { get; }

            public DataObject(string language, DDragon dragon)
            {
                this.DataFolder = dragon.DataDragonFolder + "/" + dragon.DataDragonVersion + "/data/" + language;
                this.Dragon = dragon;
            }

            public string Champion => File.ReadAllText(this.DataFolder + "/champion.json");
            public string ChampionFull => File.ReadAllText(this.DataFolder + "/championFull.json");
            public string Item => File.ReadAllText(this.DataFolder + "/item.json");
            public string Language => File.ReadAllText(this.DataFolder + "/language.json");
            public string Map => File.ReadAllText(this.DataFolder + "/map.json");
            public string MissionAssets => File.ReadAllText(this.DataFolder + "/mission-assets.json");
            public string ProfileIcon => File.ReadAllText(this.DataFolder + "/profileicon.json");
            public string RunesReforged => File.ReadAllText(this.DataFolder + "/runesReforged.json");
            public string Sticker => File.ReadAllText(this.DataFolder + "/sticker.json");
            public string Summoner => File.ReadAllText(this.DataFolder + "/summoner.json");
            public string SpecificChampion(string champion) => File.ReadAllText(this.DataFolder + "/champion/" + champion + ".json");
        }

        public class ImgObject
        {
            private string ImgFolder { get; }
            private DDragon Dragon { get; }
            public ImgObject(DDragon dragon)
            {
                this.Dragon = dragon;
                this.ImgFolder = Path.Combine(dragon.DataDragonFolder + "/" + dragon.DataDragonVersion + "/img");
            }

            public string Champion(string champion) => Path.Combine(this.ImgFolder + "/champion/" + champion);
            public string Item(string item) => this.ImgFolder + "/item/" + item;
            public string Map(string map) => this.ImgFolder + "/map/" + map;
            public string Mission(string mission) => this.ImgFolder + "/mission/" + mission;
            public string Passive(string passive) => this.ImgFolder + "/passive/" + passive;
            public string ProfileIcon(string profileIcon) => this.ImgFolder + "/profileicon/" + profileIcon;
            public string Spell(string spell) => this.ImgFolder + "/spell/" + spell;
            public string Sprite(string sprite) => this.ImgFolder + "/sprite/" + sprite;
        }
    }
}
