using System.IO;

namespace ChampionStatistics.RiotObject
{
    public class DDragon
    {
        private string DataDragonFolder { get; }
        private string DataDragonVersion { get; }
        public VersionDataObject VersionData { get; }
        public VersionImgObject VersionImg { get; }
        public ImgObject Img { get; }

        public DDragon(string dataDragonFolder, string version)
        {
            this.DataDragonFolder = dataDragonFolder;
            this.DataDragonVersion = version;
            this.VersionData = new VersionDataObject("en_US", this);
            this.VersionImg = new VersionImgObject(this);
            this.Img = new ImgObject(this);
        }

        public string Languages => File.ReadAllText(this.DataDragonFolder + "/languages.json");

        public class VersionDataObject
        {
            private string DataFolder { get; }
            private DDragon Dragon { get; }

            public VersionDataObject(string language, DDragon dragon)
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

        public class VersionImgObject
        {
            private string VersionImgFolder { get; }
            private DDragon Dragon { get; }
            public VersionImgObject(DDragon dragon)
            {
                this.Dragon = dragon;
                this.VersionImgFolder = Path.Combine(dragon.DataDragonFolder + "/" + dragon.DataDragonVersion + "/img");
            }

            public string Champion(string champion) => Path.Combine(this.VersionImgFolder + "/champion/" + champion);
            public string Item(string item) => this.VersionImgFolder + "/item/" + item;
            public string Map(string map) => this.VersionImgFolder + "/map/" + map;
            public string Mission(string mission) => this.VersionImgFolder + "/mission/" + mission;
            public string Passive(string passive) => this.VersionImgFolder + "/passive/" + passive;
            public string ProfileIcon(string profileIcon) => this.VersionImgFolder + "/profileicon/" + profileIcon;
            public string Spell(string spell) => this.VersionImgFolder + "/spell/" + spell;
            public string Sprite(string sprite) => this.VersionImgFolder + "/sprite/" + sprite;
        }

        public class ImgObject
        {
            private DDragon Dragon { get; }
            public ChampionFolder Champion { get; }
            private string ImgFolder { get; }

            public ImgObject(DDragon dragon)
            {
                this.Dragon = dragon;
                this.ImgFolder = Path.Combine(dragon.DataDragonFolder + "img\\");
                this.Champion = new ChampionFolder(this);
            }

            public class ChampionFolder
            {
                private ImgObject ImgObject { get; }

                public ChampionFolder(ImgObject imgObject)
                {
                    this.ImgObject = imgObject;
                }

                public string Splash(string key)
                {
                    return $"{this.ImgObject.ImgFolder}champion\\splash\\{key}";
                }
            }
        }
    }
}
