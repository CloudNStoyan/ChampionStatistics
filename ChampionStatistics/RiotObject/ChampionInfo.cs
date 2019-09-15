using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChampionStatistics.RiotObject
{
    public class ChampionInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        [JsonConverter(typeof(ParseStringConverter))]
        public int Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("skins")]
        public Skin[] Skins { get; set; }

        [JsonProperty("lore")]
        public string Lore { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("allytips")]
        public string[] Allytips { get; set; }

        [JsonProperty("enemytips")]
        public string[] Enemytips { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("partype")]
        public Partype Partype { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, double> Stats { get; set; }

        [JsonProperty("spells")]
        public Spell[] Spells { get; set; }

        [JsonProperty("passive")]
        public Passive Passive { get; set; }

        [JsonProperty("recommended")]
        public Recommended[] Recommended { get; set; }

        public static ChampionInfo[] FromJson(string json) => JsonConvert.DeserializeObject<ChampionInfo[]>(json, Converter.Settings);
    }

    public class Image
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("sprite")]
        public Sprite Sprite { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }
    }

    public class Info
    {
        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("magic")]
        public int Magic { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }
    }

    public class Passive
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }

    public class Recommended
    {
        [JsonProperty("champion")]
        public string Champion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("map")]
        public MapUnion Map { get; set; }

        [JsonProperty("mode")]
        public Mode Mode { get; set; }

        [JsonProperty("type")]
        public RecommendedType Type { get; set; }

        [JsonProperty("customTag", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomTag { get; set; }

        [JsonProperty("sortrank", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sortrank { get; set; }

        [JsonProperty("extensionPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExtensionPage { get; set; }

        [JsonProperty("useObviousCheckmark", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseObviousCheckmark { get; set; }

        [JsonProperty("customPanel")]
        public string CustomPanel { get; set; }

        [JsonProperty("blocks")]
        public Block[] Blocks { get; set; }

        [JsonProperty("requiredPerk", NullValueHandling = NullValueHandling.Ignore)]
        public string RequiredPerk { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Priority { get; set; }

        [JsonProperty("customPanelCurrencyType", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomPanelCurrencyType { get; set; }

        [JsonProperty("customPanelBuffCurrencyName", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomPanelBuffCurrencyName { get; set; }

        [JsonProperty("extenOrnnPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExtenOrnnPage { get; set; }
    }

    public class Block
    {
        [JsonProperty("type")]
        public BlockType Type { get; set; }

        [JsonProperty("recMath", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecMath { get; set; }

        [JsonProperty("recSteps", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecSteps { get; set; }

        [JsonProperty("minSummonerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinSummonerLevel { get; set; }

        [JsonProperty("maxSummonerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxSummonerLevel { get; set; }

        [JsonProperty("showIfSummonerSpell", NullValueHandling = NullValueHandling.Ignore)]
        public IfSummonerSpell? ShowIfSummonerSpell { get; set; }

        [JsonProperty("hideIfSummonerSpell", NullValueHandling = NullValueHandling.Ignore)]
        public IfSummonerSpell? HideIfSummonerSpell { get; set; }

        [JsonProperty("appendAfterSection", NullValueHandling = NullValueHandling.Ignore)]
        public string AppendAfterSection { get; set; }

        [JsonProperty("visibleWithAllOf", NullValueHandling = NullValueHandling.Ignore)]
        public Of[] VisibleWithAllOf { get; set; }

        [JsonProperty("hiddenWithAnyOf", NullValueHandling = NullValueHandling.Ignore)]
        public Of[] HiddenWithAnyOf { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public class Item
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("hideCount", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideCount { get; set; }

        [JsonProperty("hidecount", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidecount { get; set; }
    }

    public class Skin
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("num")]
        public long Num { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("chromas")]
        public bool Chromas { get; set; }
    }

    public class Spell
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("leveltip", NullValueHandling = NullValueHandling.Ignore)]
        public Leveltip Leveltip { get; set; }

        [JsonProperty("maxrank")]
        public long Maxrank { get; set; }

        [JsonProperty("cooldown")]
        public double[] Cooldown { get; set; }

        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty("cost")]
        public long[] Cost { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("datavalues")]
        public string Datavalues { get; set; }

        [JsonProperty("effect")]
        public double[][] Effect { get; set; }

        [JsonProperty("effectBurn")]
        public string[] EffectBurn { get; set; }

        [JsonProperty("vars")]
        public Var[] Vars { get; set; }

        [JsonProperty("costType")]
        public CostType CostType { get; set; }

        [JsonProperty("maxammo")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Maxammo { get; set; }

        [JsonProperty("range")]
        public long[] Range { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }
    }

    public class Leveltip
    {
        [JsonProperty("label")]
        public string[] Label { get; set; }

        [JsonProperty("effect")]
        public string[] Effect { get; set; }
    }

    public class Var
    {
        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("coeff")]
        public Coeff Coeff { get; set; }

        [JsonProperty("key")]
        public Key Key { get; set; }
    }

    public enum Group { Champion, Passive, Spell };

    public enum Sprite { Champion0Png, Champion1Png, Champion2Png, Champion3Png, Champion4Png, Passive0Png, Passive1Png, Passive2Png, Passive3Png, Passive4Png, Spell0Png, Spell10Png, Spell11Png, Spell12Png, Spell13Png, Spell14Png, Spell1Png, Spell2Png, Spell3Png, Spell4Png, Spell5Png, Spell6Png, Spell7Png, Spell8Png, Spell9Png };

    public enum Partype { BloodWell, Courage, CrimsonRush, Energy, Ferocity, Flow, Fury, Heat, Mana, None, Rage, Shield };

    public enum Of { Empty, Kaynass, Kaynslay };

    public enum IfSummonerSpell { Empty, ItemSmiteAoE, ItemTeleportCancel, OdinTrinketRevive, S5SummonerSmiteDuel, SummonerOdinPromote, SummonerPoroRecall, SummonerPoroThrow, SummonerSiegeChampSelect1, SummonerSiegeChampSelect2, SummonerSmite, SummonerSnowball, SummonerTeleport, TeleportCancel };

    public enum BlockType { AbilityScaling, Aggressive, BeginnerAdvanced, BeginnerLegendary, BeginnerLegendaryItem, BeginnerLegendaryitem, BeginnerMoreLegendaryItems, BeginnerMorelegendaryitems, BeginnerMovementSpeed, BeginnerMovementspeed, BeginnerMovespeed, BeginnerStarter, Champspecific, Consumable, Consumables, Consumablesjungle, Defensive, Defensivejungle, Early, Earlyjungle, Empty, Essential, Essentialjungle, KingPoroSnax, Kingporosnax, Npe1, Npe2, Npe3, Npe4, Odyjinx1, Odyjinx2, Odyjinx3, Odymalphite1, Odymalphite2, Odymalphite3, Odysona1, Odysona2, Odysona3, Odyyasuo1, Odyyasuo2, Odyyasuo3, Odyziggs1, Odyziggs2, Odyziggs3, Offensive, Offmeta, Ornnupgrades, Protective, Recommended, Selective, SiegeDefense, SiegeOffense, Siegedefense, Siegeoffense, Situational, Situationaljungle, Standard, Standardjungle, Starting, Startingjungle, Support, The1Buystarteritems, TypeBeginnerAdvanced, TypeBeginnerStarter };

    public enum MapEnum { Any, CityPark, CrystalScar, Ha, Odyssey, ProjectSlums, Sl, Sr, Tt };

    public enum Mode { Any, Aram, Ascension, Classic, Firstblood, Gamemodex, Intro, Kingporo, Odin, Odyssey, Project, Siege, Starguardian, Tutorial, TutorialModule2, TutorialModule3 };

    public enum RecommendedType { Riot, RiotMid, RiotSupport };

    public enum CostType { Abilityresourcename, AbilityresourcenamePerSecond, CostTypeHealth, CostTypeMana, CostTypeNoCost, CostTypeOfCurrentHealth, Empty, Energy, FuryASecond, Generates1Ferocity, Health, HealthEverySecond, Heat, Mana, ManaAllCharges, ManaPerRocket, ManaPerSecond, MaxHealthCostMana, NoCost, OfCurrentHealth, OfMaxHealth, Passive, The1Seed, TurretKitAmpCostMana };

    public enum Key { A1, A2, F1, F2, F3, F4 };

    public enum Link { Armor, Attackdamage, Bonusarmor, Bonusattackdamage, Bonushealth, Bonusspellblock, Health, SpecialBraumWArmor, SpecialBraumWmr, SpecialNautilusq, SpecialViw, Spelldamage, Stacks, Text };

    public enum Tag { Assassin, Fighter, Mage, Marksman, Support, Tank };

    public struct MapUnion
    {
        public MapEnum? Enum;
        public long? Integer;

        public static implicit operator MapUnion(MapEnum Enum) => new MapUnion { Enum = Enum };
        public static implicit operator MapUnion(long Integer) => new MapUnion { Integer = Integer };
    }

    public struct Coeff
    {
        public double? Double;
        public double[] DoubleArray;

        public static implicit operator Coeff(double Double) => new Coeff { Double = Double };
        public static implicit operator Coeff(double[] DoubleArray) => new Coeff { DoubleArray = DoubleArray };
    }

    public static class Serialize
    {
        public static string ToJson(this ChampionInfo[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                GroupConverter.Singleton,
                SpriteConverter.Singleton,
                PartypeConverter.Singleton,
                OfConverter.Singleton,
                IfSummonerSpellConverter.Singleton,
                BlockTypeConverter.Singleton,
                MapUnionConverter.Singleton,
                MapEnumConverter.Singleton,
                ModeConverter.Singleton,
                RecommendedTypeConverter.Singleton,
                CostTypeConverter.Singleton,
                CoeffConverter.Singleton,
                KeyConverter.Singleton,
                LinkConverter.Singleton,
                TagConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class GroupConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Group) || t == typeof(Group?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "champion":
                    return Group.Champion;
                case "passive":
                    return Group.Passive;
                case "spell":
                    return Group.Spell;
            }
            throw new Exception("Cannot unmarshal type Group");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Group)untypedValue;
            switch (value)
            {
                case Group.Champion:
                    serializer.Serialize(writer, "champion");
                    return;
                case Group.Passive:
                    serializer.Serialize(writer, "passive");
                    return;
                case Group.Spell:
                    serializer.Serialize(writer, "spell");
                    return;
            }
            throw new Exception("Cannot marshal type Group");
        }

        public static readonly GroupConverter Singleton = new GroupConverter();
    }

    internal class SpriteConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Sprite) || t == typeof(Sprite?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "champion0.png":
                    return Sprite.Champion0Png;
                case "champion1.png":
                    return Sprite.Champion1Png;
                case "champion2.png":
                    return Sprite.Champion2Png;
                case "champion3.png":
                    return Sprite.Champion3Png;
                case "champion4.png":
                    return Sprite.Champion4Png;
                case "passive0.png":
                    return Sprite.Passive0Png;
                case "passive1.png":
                    return Sprite.Passive1Png;
                case "passive2.png":
                    return Sprite.Passive2Png;
                case "passive3.png":
                    return Sprite.Passive3Png;
                case "passive4.png":
                    return Sprite.Passive4Png;
                case "spell0.png":
                    return Sprite.Spell0Png;
                case "spell1.png":
                    return Sprite.Spell1Png;
                case "spell10.png":
                    return Sprite.Spell10Png;
                case "spell11.png":
                    return Sprite.Spell11Png;
                case "spell12.png":
                    return Sprite.Spell12Png;
                case "spell13.png":
                    return Sprite.Spell13Png;
                case "spell14.png":
                    return Sprite.Spell14Png;
                case "spell2.png":
                    return Sprite.Spell2Png;
                case "spell3.png":
                    return Sprite.Spell3Png;
                case "spell4.png":
                    return Sprite.Spell4Png;
                case "spell5.png":
                    return Sprite.Spell5Png;
                case "spell6.png":
                    return Sprite.Spell6Png;
                case "spell7.png":
                    return Sprite.Spell7Png;
                case "spell8.png":
                    return Sprite.Spell8Png;
                case "spell9.png":
                    return Sprite.Spell9Png;
            }
            throw new Exception("Cannot unmarshal type Sprite");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Sprite)untypedValue;
            switch (value)
            {
                case Sprite.Champion0Png:
                    serializer.Serialize(writer, "champion0.png");
                    return;
                case Sprite.Champion1Png:
                    serializer.Serialize(writer, "champion1.png");
                    return;
                case Sprite.Champion2Png:
                    serializer.Serialize(writer, "champion2.png");
                    return;
                case Sprite.Champion3Png:
                    serializer.Serialize(writer, "champion3.png");
                    return;
                case Sprite.Champion4Png:
                    serializer.Serialize(writer, "champion4.png");
                    return;
                case Sprite.Passive0Png:
                    serializer.Serialize(writer, "passive0.png");
                    return;
                case Sprite.Passive1Png:
                    serializer.Serialize(writer, "passive1.png");
                    return;
                case Sprite.Passive2Png:
                    serializer.Serialize(writer, "passive2.png");
                    return;
                case Sprite.Passive3Png:
                    serializer.Serialize(writer, "passive3.png");
                    return;
                case Sprite.Passive4Png:
                    serializer.Serialize(writer, "passive4.png");
                    return;
                case Sprite.Spell0Png:
                    serializer.Serialize(writer, "spell0.png");
                    return;
                case Sprite.Spell1Png:
                    serializer.Serialize(writer, "spell1.png");
                    return;
                case Sprite.Spell10Png:
                    serializer.Serialize(writer, "spell10.png");
                    return;
                case Sprite.Spell11Png:
                    serializer.Serialize(writer, "spell11.png");
                    return;
                case Sprite.Spell12Png:
                    serializer.Serialize(writer, "spell12.png");
                    return;
                case Sprite.Spell13Png:
                    serializer.Serialize(writer, "spell13.png");
                    return;
                case Sprite.Spell14Png:
                    serializer.Serialize(writer, "spell14.png");
                    return;
                case Sprite.Spell2Png:
                    serializer.Serialize(writer, "spell2.png");
                    return;
                case Sprite.Spell3Png:
                    serializer.Serialize(writer, "spell3.png");
                    return;
                case Sprite.Spell4Png:
                    serializer.Serialize(writer, "spell4.png");
                    return;
                case Sprite.Spell5Png:
                    serializer.Serialize(writer, "spell5.png");
                    return;
                case Sprite.Spell6Png:
                    serializer.Serialize(writer, "spell6.png");
                    return;
                case Sprite.Spell7Png:
                    serializer.Serialize(writer, "spell7.png");
                    return;
                case Sprite.Spell8Png:
                    serializer.Serialize(writer, "spell8.png");
                    return;
                case Sprite.Spell9Png:
                    serializer.Serialize(writer, "spell9.png");
                    return;
            }
            throw new Exception("Cannot marshal type Sprite");
        }

        public static readonly SpriteConverter Singleton = new SpriteConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class PartypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Partype) || t == typeof(Partype?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Blood Well":
                    return Partype.BloodWell;
                case "Courage":
                    return Partype.Courage;
                case "Crimson Rush":
                    return Partype.CrimsonRush;
                case "Energy":
                    return Partype.Energy;
                case "Ferocity":
                    return Partype.Ferocity;
                case "Flow":
                    return Partype.Flow;
                case "Fury":
                    return Partype.Fury;
                case "Heat":
                    return Partype.Heat;
                case "Mana":
                    return Partype.Mana;
                case "None":
                    return Partype.None;
                case "Rage":
                    return Partype.Rage;
                case "Shield":
                    return Partype.Shield;
            }
            throw new Exception("Cannot unmarshal type Partype");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Partype)untypedValue;
            switch (value)
            {
                case Partype.BloodWell:
                    serializer.Serialize(writer, "Blood Well");
                    return;
                case Partype.Courage:
                    serializer.Serialize(writer, "Courage");
                    return;
                case Partype.CrimsonRush:
                    serializer.Serialize(writer, "Crimson Rush");
                    return;
                case Partype.Energy:
                    serializer.Serialize(writer, "Energy");
                    return;
                case Partype.Ferocity:
                    serializer.Serialize(writer, "Ferocity");
                    return;
                case Partype.Flow:
                    serializer.Serialize(writer, "Flow");
                    return;
                case Partype.Fury:
                    serializer.Serialize(writer, "Fury");
                    return;
                case Partype.Heat:
                    serializer.Serialize(writer, "Heat");
                    return;
                case Partype.Mana:
                    serializer.Serialize(writer, "Mana");
                    return;
                case Partype.None:
                    serializer.Serialize(writer, "None");
                    return;
                case Partype.Rage:
                    serializer.Serialize(writer, "Rage");
                    return;
                case Partype.Shield:
                    serializer.Serialize(writer, "Shield");
                    return;
            }
            throw new Exception("Cannot marshal type Partype");
        }

        public static readonly PartypeConverter Singleton = new PartypeConverter();
    }

    internal class OfConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Of) || t == typeof(Of?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Of.Empty;
                case "kaynass":
                    return Of.Kaynass;
                case "kaynslay":
                    return Of.Kaynslay;
            }
            throw new Exception("Cannot unmarshal type Of");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Of)untypedValue;
            switch (value)
            {
                case Of.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Of.Kaynass:
                    serializer.Serialize(writer, "kaynass");
                    return;
                case Of.Kaynslay:
                    serializer.Serialize(writer, "kaynslay");
                    return;
            }
            throw new Exception("Cannot marshal type Of");
        }

        public static readonly OfConverter Singleton = new OfConverter();
    }

    internal class IfSummonerSpellConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IfSummonerSpell) || t == typeof(IfSummonerSpell?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return IfSummonerSpell.Empty;
                case "ItemSmiteAoE":
                    return IfSummonerSpell.ItemSmiteAoE;
                case "ItemTeleportCancel":
                    return IfSummonerSpell.ItemTeleportCancel;
                case "OdinTrinketRevive":
                    return IfSummonerSpell.OdinTrinketRevive;
                case "S5_SummonerSmiteDuel":
                    return IfSummonerSpell.S5SummonerSmiteDuel;
                case "SummonerOdinPromote":
                    return IfSummonerSpell.SummonerOdinPromote;
                case "SummonerPoroRecall":
                    return IfSummonerSpell.SummonerPoroRecall;
                case "SummonerPoroThrow":
                    return IfSummonerSpell.SummonerPoroThrow;
                case "SummonerSiegeChampSelect1":
                    return IfSummonerSpell.SummonerSiegeChampSelect1;
                case "SummonerSiegeChampSelect2":
                    return IfSummonerSpell.SummonerSiegeChampSelect2;
                case "SummonerSmite":
                    return IfSummonerSpell.SummonerSmite;
                case "SummonerSnowball":
                    return IfSummonerSpell.SummonerSnowball;
                case "SummonerTeleport":
                    return IfSummonerSpell.SummonerTeleport;
                case "TeleportCancel":
                    return IfSummonerSpell.TeleportCancel;
            }
            throw new Exception("Cannot unmarshal type IfSummonerSpell");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IfSummonerSpell)untypedValue;
            switch (value)
            {
                case IfSummonerSpell.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case IfSummonerSpell.ItemSmiteAoE:
                    serializer.Serialize(writer, "ItemSmiteAoE");
                    return;
                case IfSummonerSpell.ItemTeleportCancel:
                    serializer.Serialize(writer, "ItemTeleportCancel");
                    return;
                case IfSummonerSpell.OdinTrinketRevive:
                    serializer.Serialize(writer, "OdinTrinketRevive");
                    return;
                case IfSummonerSpell.S5SummonerSmiteDuel:
                    serializer.Serialize(writer, "S5_SummonerSmiteDuel");
                    return;
                case IfSummonerSpell.SummonerOdinPromote:
                    serializer.Serialize(writer, "SummonerOdinPromote");
                    return;
                case IfSummonerSpell.SummonerPoroRecall:
                    serializer.Serialize(writer, "SummonerPoroRecall");
                    return;
                case IfSummonerSpell.SummonerPoroThrow:
                    serializer.Serialize(writer, "SummonerPoroThrow");
                    return;
                case IfSummonerSpell.SummonerSiegeChampSelect1:
                    serializer.Serialize(writer, "SummonerSiegeChampSelect1");
                    return;
                case IfSummonerSpell.SummonerSiegeChampSelect2:
                    serializer.Serialize(writer, "SummonerSiegeChampSelect2");
                    return;
                case IfSummonerSpell.SummonerSmite:
                    serializer.Serialize(writer, "SummonerSmite");
                    return;
                case IfSummonerSpell.SummonerSnowball:
                    serializer.Serialize(writer, "SummonerSnowball");
                    return;
                case IfSummonerSpell.SummonerTeleport:
                    serializer.Serialize(writer, "SummonerTeleport");
                    return;
                case IfSummonerSpell.TeleportCancel:
                    serializer.Serialize(writer, "TeleportCancel");
                    return;
            }
            throw new Exception("Cannot marshal type IfSummonerSpell");
        }

        public static readonly IfSummonerSpellConverter Singleton = new IfSummonerSpellConverter();
    }

    internal class BlockTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BlockType) || t == typeof(BlockType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return BlockType.Empty;
                case "1)buystarteritems":
                    return BlockType.The1Buystarteritems;
                case "KingPoroSnax":
                    return BlockType.KingPoroSnax;
                case "ability_scaling":
                    return BlockType.AbilityScaling;
                case "aggressive":
                    return BlockType.Aggressive;
                case "beginner_Advanced":
                    return BlockType.TypeBeginnerAdvanced;
                case "beginner_LegendaryItem":
                    return BlockType.BeginnerLegendaryItem;
                case "beginner_MoreLegendaryItems":
                    return BlockType.BeginnerMoreLegendaryItems;
                case "beginner_MovementSpeed":
                    return BlockType.BeginnerMovementSpeed;
                case "beginner_Starter":
                    return BlockType.TypeBeginnerStarter;
                case "beginner_advanced":
                    return BlockType.BeginnerAdvanced;
                case "beginner_legendary":
                    return BlockType.BeginnerLegendary;
                case "beginner_legendaryitem":
                    return BlockType.BeginnerLegendaryitem;
                case "beginner_morelegendaryitems":
                    return BlockType.BeginnerMorelegendaryitems;
                case "beginner_movementspeed":
                    return BlockType.BeginnerMovementspeed;
                case "beginner_movespeed":
                    return BlockType.BeginnerMovespeed;
                case "beginner_starter":
                    return BlockType.BeginnerStarter;
                case "champspecific":
                    return BlockType.Champspecific;
                case "consumable":
                    return BlockType.Consumable;
                case "consumables":
                    return BlockType.Consumables;
                case "consumablesjungle":
                    return BlockType.Consumablesjungle;
                case "defensive":
                    return BlockType.Defensive;
                case "defensivejungle":
                    return BlockType.Defensivejungle;
                case "early":
                    return BlockType.Early;
                case "earlyjungle":
                    return BlockType.Earlyjungle;
                case "essential":
                    return BlockType.Essential;
                case "essentialjungle":
                    return BlockType.Essentialjungle;
                case "kingporosnax":
                    return BlockType.Kingporosnax;
                case "npe1":
                    return BlockType.Npe1;
                case "npe2":
                    return BlockType.Npe2;
                case "npe3":
                    return BlockType.Npe3;
                case "npe4":
                    return BlockType.Npe4;
                case "odyjinx1":
                    return BlockType.Odyjinx1;
                case "odyjinx2":
                    return BlockType.Odyjinx2;
                case "odyjinx3":
                    return BlockType.Odyjinx3;
                case "odymalphite1":
                    return BlockType.Odymalphite1;
                case "odymalphite2":
                    return BlockType.Odymalphite2;
                case "odymalphite3":
                    return BlockType.Odymalphite3;
                case "odysona1":
                    return BlockType.Odysona1;
                case "odysona2":
                    return BlockType.Odysona2;
                case "odysona3":
                    return BlockType.Odysona3;
                case "odyyasuo1":
                    return BlockType.Odyyasuo1;
                case "odyyasuo2":
                    return BlockType.Odyyasuo2;
                case "odyyasuo3":
                    return BlockType.Odyyasuo3;
                case "odyziggs1":
                    return BlockType.Odyziggs1;
                case "odyziggs2":
                    return BlockType.Odyziggs2;
                case "odyziggs3":
                    return BlockType.Odyziggs3;
                case "offensive":
                    return BlockType.Offensive;
                case "offmeta":
                    return BlockType.Offmeta;
                case "ornnupgrades":
                    return BlockType.Ornnupgrades;
                case "protective":
                    return BlockType.Protective;
                case "recommended":
                    return BlockType.Recommended;
                case "selective":
                    return BlockType.Selective;
                case "siegeDefense":
                    return BlockType.SiegeDefense;
                case "siegeOffense":
                    return BlockType.SiegeOffense;
                case "siegedefense":
                    return BlockType.Siegedefense;
                case "siegeoffense":
                    return BlockType.Siegeoffense;
                case "situational":
                    return BlockType.Situational;
                case "situationaljungle":
                    return BlockType.Situationaljungle;
                case "standard":
                    return BlockType.Standard;
                case "standardjungle":
                    return BlockType.Standardjungle;
                case "starting":
                    return BlockType.Starting;
                case "startingjungle":
                    return BlockType.Startingjungle;
                case "support":
                    return BlockType.Support;
            }
            throw new Exception("Cannot unmarshal type BlockType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BlockType)untypedValue;
            switch (value)
            {
                case BlockType.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case BlockType.The1Buystarteritems:
                    serializer.Serialize(writer, "1)buystarteritems");
                    return;
                case BlockType.KingPoroSnax:
                    serializer.Serialize(writer, "KingPoroSnax");
                    return;
                case BlockType.AbilityScaling:
                    serializer.Serialize(writer, "ability_scaling");
                    return;
                case BlockType.Aggressive:
                    serializer.Serialize(writer, "aggressive");
                    return;
                case BlockType.TypeBeginnerAdvanced:
                    serializer.Serialize(writer, "beginner_Advanced");
                    return;
                case BlockType.BeginnerLegendaryItem:
                    serializer.Serialize(writer, "beginner_LegendaryItem");
                    return;
                case BlockType.BeginnerMoreLegendaryItems:
                    serializer.Serialize(writer, "beginner_MoreLegendaryItems");
                    return;
                case BlockType.BeginnerMovementSpeed:
                    serializer.Serialize(writer, "beginner_MovementSpeed");
                    return;
                case BlockType.TypeBeginnerStarter:
                    serializer.Serialize(writer, "beginner_Starter");
                    return;
                case BlockType.BeginnerAdvanced:
                    serializer.Serialize(writer, "beginner_advanced");
                    return;
                case BlockType.BeginnerLegendary:
                    serializer.Serialize(writer, "beginner_legendary");
                    return;
                case BlockType.BeginnerLegendaryitem:
                    serializer.Serialize(writer, "beginner_legendaryitem");
                    return;
                case BlockType.BeginnerMorelegendaryitems:
                    serializer.Serialize(writer, "beginner_morelegendaryitems");
                    return;
                case BlockType.BeginnerMovementspeed:
                    serializer.Serialize(writer, "beginner_movementspeed");
                    return;
                case BlockType.BeginnerMovespeed:
                    serializer.Serialize(writer, "beginner_movespeed");
                    return;
                case BlockType.BeginnerStarter:
                    serializer.Serialize(writer, "beginner_starter");
                    return;
                case BlockType.Champspecific:
                    serializer.Serialize(writer, "champspecific");
                    return;
                case BlockType.Consumable:
                    serializer.Serialize(writer, "consumable");
                    return;
                case BlockType.Consumables:
                    serializer.Serialize(writer, "consumables");
                    return;
                case BlockType.Consumablesjungle:
                    serializer.Serialize(writer, "consumablesjungle");
                    return;
                case BlockType.Defensive:
                    serializer.Serialize(writer, "defensive");
                    return;
                case BlockType.Defensivejungle:
                    serializer.Serialize(writer, "defensivejungle");
                    return;
                case BlockType.Early:
                    serializer.Serialize(writer, "early");
                    return;
                case BlockType.Earlyjungle:
                    serializer.Serialize(writer, "earlyjungle");
                    return;
                case BlockType.Essential:
                    serializer.Serialize(writer, "essential");
                    return;
                case BlockType.Essentialjungle:
                    serializer.Serialize(writer, "essentialjungle");
                    return;
                case BlockType.Kingporosnax:
                    serializer.Serialize(writer, "kingporosnax");
                    return;
                case BlockType.Npe1:
                    serializer.Serialize(writer, "npe1");
                    return;
                case BlockType.Npe2:
                    serializer.Serialize(writer, "npe2");
                    return;
                case BlockType.Npe3:
                    serializer.Serialize(writer, "npe3");
                    return;
                case BlockType.Npe4:
                    serializer.Serialize(writer, "npe4");
                    return;
                case BlockType.Odyjinx1:
                    serializer.Serialize(writer, "odyjinx1");
                    return;
                case BlockType.Odyjinx2:
                    serializer.Serialize(writer, "odyjinx2");
                    return;
                case BlockType.Odyjinx3:
                    serializer.Serialize(writer, "odyjinx3");
                    return;
                case BlockType.Odymalphite1:
                    serializer.Serialize(writer, "odymalphite1");
                    return;
                case BlockType.Odymalphite2:
                    serializer.Serialize(writer, "odymalphite2");
                    return;
                case BlockType.Odymalphite3:
                    serializer.Serialize(writer, "odymalphite3");
                    return;
                case BlockType.Odysona1:
                    serializer.Serialize(writer, "odysona1");
                    return;
                case BlockType.Odysona2:
                    serializer.Serialize(writer, "odysona2");
                    return;
                case BlockType.Odysona3:
                    serializer.Serialize(writer, "odysona3");
                    return;
                case BlockType.Odyyasuo1:
                    serializer.Serialize(writer, "odyyasuo1");
                    return;
                case BlockType.Odyyasuo2:
                    serializer.Serialize(writer, "odyyasuo2");
                    return;
                case BlockType.Odyyasuo3:
                    serializer.Serialize(writer, "odyyasuo3");
                    return;
                case BlockType.Odyziggs1:
                    serializer.Serialize(writer, "odyziggs1");
                    return;
                case BlockType.Odyziggs2:
                    serializer.Serialize(writer, "odyziggs2");
                    return;
                case BlockType.Odyziggs3:
                    serializer.Serialize(writer, "odyziggs3");
                    return;
                case BlockType.Offensive:
                    serializer.Serialize(writer, "offensive");
                    return;
                case BlockType.Offmeta:
                    serializer.Serialize(writer, "offmeta");
                    return;
                case BlockType.Ornnupgrades:
                    serializer.Serialize(writer, "ornnupgrades");
                    return;
                case BlockType.Protective:
                    serializer.Serialize(writer, "protective");
                    return;
                case BlockType.Recommended:
                    serializer.Serialize(writer, "recommended");
                    return;
                case BlockType.Selective:
                    serializer.Serialize(writer, "selective");
                    return;
                case BlockType.SiegeDefense:
                    serializer.Serialize(writer, "siegeDefense");
                    return;
                case BlockType.SiegeOffense:
                    serializer.Serialize(writer, "siegeOffense");
                    return;
                case BlockType.Siegedefense:
                    serializer.Serialize(writer, "siegedefense");
                    return;
                case BlockType.Siegeoffense:
                    serializer.Serialize(writer, "siegeoffense");
                    return;
                case BlockType.Situational:
                    serializer.Serialize(writer, "situational");
                    return;
                case BlockType.Situationaljungle:
                    serializer.Serialize(writer, "situationaljungle");
                    return;
                case BlockType.Standard:
                    serializer.Serialize(writer, "standard");
                    return;
                case BlockType.Standardjungle:
                    serializer.Serialize(writer, "standardjungle");
                    return;
                case BlockType.Starting:
                    serializer.Serialize(writer, "starting");
                    return;
                case BlockType.Startingjungle:
                    serializer.Serialize(writer, "startingjungle");
                    return;
                case BlockType.Support:
                    serializer.Serialize(writer, "support");
                    return;
            }
            throw new Exception("Cannot marshal type BlockType");
        }

        public static readonly BlockTypeConverter Singleton = new BlockTypeConverter();
    }

    internal class MapUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MapUnion) || t == typeof(MapUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "CityPark":
                            return new MapUnion { Enum = MapEnum.CityPark };
                        case "CrystalScar":
                            return new MapUnion { Enum = MapEnum.CrystalScar };
                        case "HA":
                            return new MapUnion { Enum = MapEnum.Ha };
                        case "Odyssey":
                            return new MapUnion { Enum = MapEnum.Odyssey };
                        case "ProjectSlums":
                            return new MapUnion { Enum = MapEnum.ProjectSlums };
                        case "SL":
                            return new MapUnion { Enum = MapEnum.Sl };
                        case "SR":
                            return new MapUnion { Enum = MapEnum.Sr };
                        case "TT":
                            return new MapUnion { Enum = MapEnum.Tt };
                        case "any":
                            return new MapUnion { Enum = MapEnum.Any };
                    }
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return new MapUnion { Integer = l };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type MapUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (MapUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case MapEnum.CityPark:
                        serializer.Serialize(writer, "CityPark");
                        return;
                    case MapEnum.CrystalScar:
                        serializer.Serialize(writer, "CrystalScar");
                        return;
                    case MapEnum.Ha:
                        serializer.Serialize(writer, "HA");
                        return;
                    case MapEnum.Odyssey:
                        serializer.Serialize(writer, "Odyssey");
                        return;
                    case MapEnum.ProjectSlums:
                        serializer.Serialize(writer, "ProjectSlums");
                        return;
                    case MapEnum.Sl:
                        serializer.Serialize(writer, "SL");
                        return;
                    case MapEnum.Sr:
                        serializer.Serialize(writer, "SR");
                        return;
                    case MapEnum.Tt:
                        serializer.Serialize(writer, "TT");
                        return;
                    case MapEnum.Any:
                        serializer.Serialize(writer, "any");
                        return;
                }
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value.ToString());
                return;
            }
            throw new Exception("Cannot marshal type MapUnion");
        }

        public static readonly MapUnionConverter Singleton = new MapUnionConverter();
    }

    internal class MapEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MapEnum) || t == typeof(MapEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CityPark":
                    return MapEnum.CityPark;
                case "CrystalScar":
                    return MapEnum.CrystalScar;
                case "HA":
                    return MapEnum.Ha;
                case "Odyssey":
                    return MapEnum.Odyssey;
                case "ProjectSlums":
                    return MapEnum.ProjectSlums;
                case "SL":
                    return MapEnum.Sl;
                case "SR":
                    return MapEnum.Sr;
                case "TT":
                    return MapEnum.Tt;
                case "any":
                    return MapEnum.Any;
            }
            throw new Exception("Cannot unmarshal type MapEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MapEnum)untypedValue;
            switch (value)
            {
                case MapEnum.CityPark:
                    serializer.Serialize(writer, "CityPark");
                    return;
                case MapEnum.CrystalScar:
                    serializer.Serialize(writer, "CrystalScar");
                    return;
                case MapEnum.Ha:
                    serializer.Serialize(writer, "HA");
                    return;
                case MapEnum.Odyssey:
                    serializer.Serialize(writer, "Odyssey");
                    return;
                case MapEnum.ProjectSlums:
                    serializer.Serialize(writer, "ProjectSlums");
                    return;
                case MapEnum.Sl:
                    serializer.Serialize(writer, "SL");
                    return;
                case MapEnum.Sr:
                    serializer.Serialize(writer, "SR");
                    return;
                case MapEnum.Tt:
                    serializer.Serialize(writer, "TT");
                    return;
                case MapEnum.Any:
                    serializer.Serialize(writer, "any");
                    return;
            }
            throw new Exception("Cannot marshal type MapEnum");
        }

        public static readonly MapEnumConverter Singleton = new MapEnumConverter();
    }

    internal class ModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Mode) || t == typeof(Mode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ARAM":
                    return Mode.Aram;
                case "ASCENSION":
                    return Mode.Ascension;
                case "CLASSIC":
                    return Mode.Classic;
                case "FIRSTBLOOD":
                    return Mode.Firstblood;
                case "GAMEMODEX":
                    return Mode.Gamemodex;
                case "INTRO":
                    return Mode.Intro;
                case "KINGPORO":
                    return Mode.Kingporo;
                case "ODIN":
                    return Mode.Odin;
                case "ODYSSEY":
                    return Mode.Odyssey;
                case "PROJECT":
                    return Mode.Project;
                case "SIEGE":
                    return Mode.Siege;
                case "STARGUARDIAN":
                    return Mode.Starguardian;
                case "TUTORIAL":
                    return Mode.Tutorial;
                case "TUTORIAL_MODULE_2":
                    return Mode.TutorialModule2;
                case "TUTORIAL_MODULE_3":
                    return Mode.TutorialModule3;
                case "any":
                    return Mode.Any;
            }
            throw new Exception("Cannot unmarshal type Mode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Mode)untypedValue;
            switch (value)
            {
                case Mode.Aram:
                    serializer.Serialize(writer, "ARAM");
                    return;
                case Mode.Ascension:
                    serializer.Serialize(writer, "ASCENSION");
                    return;
                case Mode.Classic:
                    serializer.Serialize(writer, "CLASSIC");
                    return;
                case Mode.Firstblood:
                    serializer.Serialize(writer, "FIRSTBLOOD");
                    return;
                case Mode.Gamemodex:
                    serializer.Serialize(writer, "GAMEMODEX");
                    return;
                case Mode.Intro:
                    serializer.Serialize(writer, "INTRO");
                    return;
                case Mode.Kingporo:
                    serializer.Serialize(writer, "KINGPORO");
                    return;
                case Mode.Odin:
                    serializer.Serialize(writer, "ODIN");
                    return;
                case Mode.Odyssey:
                    serializer.Serialize(writer, "ODYSSEY");
                    return;
                case Mode.Project:
                    serializer.Serialize(writer, "PROJECT");
                    return;
                case Mode.Siege:
                    serializer.Serialize(writer, "SIEGE");
                    return;
                case Mode.Starguardian:
                    serializer.Serialize(writer, "STARGUARDIAN");
                    return;
                case Mode.Tutorial:
                    serializer.Serialize(writer, "TUTORIAL");
                    return;
                case Mode.TutorialModule2:
                    serializer.Serialize(writer, "TUTORIAL_MODULE_2");
                    return;
                case Mode.TutorialModule3:
                    serializer.Serialize(writer, "TUTORIAL_MODULE_3");
                    return;
                case Mode.Any:
                    serializer.Serialize(writer, "any");
                    return;
            }
            throw new Exception("Cannot marshal type Mode");
        }

        public static readonly ModeConverter Singleton = new ModeConverter();
    }

    internal class RecommendedTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RecommendedType) || t == typeof(RecommendedType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "riot":
                    return RecommendedType.Riot;
                case "riot-mid":
                    return RecommendedType.RiotMid;
                case "riot-support":
                    return RecommendedType.RiotSupport;
            }
            throw new Exception("Cannot unmarshal type RecommendedType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RecommendedType)untypedValue;
            switch (value)
            {
                case RecommendedType.Riot:
                    serializer.Serialize(writer, "riot");
                    return;
                case RecommendedType.RiotMid:
                    serializer.Serialize(writer, "riot-mid");
                    return;
                case RecommendedType.RiotSupport:
                    serializer.Serialize(writer, "riot-support");
                    return;
            }
            throw new Exception("Cannot marshal type RecommendedType");
        }

        public static readonly RecommendedTypeConverter Singleton = new RecommendedTypeConverter();
    }

    internal class CostTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CostType) || t == typeof(CostType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return CostType.Empty;
                case " Energy":
                    return CostType.Energy;
                case " Fury a Second":
                    return CostType.FuryASecond;
                case " Health":
                    return CostType.Health;
                case " Health Every Second":
                    return CostType.HealthEverySecond;
                case " Heat":
                    return CostType.Heat;
                case " Mana":
                    return CostType.Mana;
                case " Mana Per Rocket":
                    return CostType.ManaPerRocket;
                case " Mana per Second":
                    return CostType.ManaPerSecond;
                case " Mana, all Charges":
                    return CostType.ManaAllCharges;
                case " Turret Kit &amp; {{ cost }} Mana":
                    return CostType.TurretKitAmpCostMana;
                case " {{ abilityresourcename }}":
                    return CostType.Abilityresourcename;
                case " {{ abilityresourcename }} per Second":
                    return CostType.AbilityresourcenamePerSecond;
                case "% Max Health, {{ cost }} Mana":
                    return CostType.MaxHealthCostMana;
                case "% of Current Health":
                    return CostType.OfCurrentHealth;
                case "% of current Health":
                    return CostType.CostTypeOfCurrentHealth;
                case "% of max Health":
                    return CostType.OfMaxHealth;
                case "1 Seed":
                    return CostType.The1Seed;
                case "Generates 1 Ferocity":
                    return CostType.Generates1Ferocity;
                case "Health":
                    return CostType.CostTypeHealth;
                case "Mana":
                    return CostType.CostTypeMana;
                case "No Cost":
                    return CostType.NoCost;
                case "No cost":
                    return CostType.CostTypeNoCost;
                case "Passive":
                    return CostType.Passive;
            }
            throw new Exception("Cannot unmarshal type CostType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CostType)untypedValue;
            switch (value)
            {
                case CostType.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case CostType.Energy:
                    serializer.Serialize(writer, " Energy");
                    return;
                case CostType.FuryASecond:
                    serializer.Serialize(writer, " Fury a Second");
                    return;
                case CostType.Health:
                    serializer.Serialize(writer, " Health");
                    return;
                case CostType.HealthEverySecond:
                    serializer.Serialize(writer, " Health Every Second");
                    return;
                case CostType.Heat:
                    serializer.Serialize(writer, " Heat");
                    return;
                case CostType.Mana:
                    serializer.Serialize(writer, " Mana");
                    return;
                case CostType.ManaPerRocket:
                    serializer.Serialize(writer, " Mana Per Rocket");
                    return;
                case CostType.ManaPerSecond:
                    serializer.Serialize(writer, " Mana per Second");
                    return;
                case CostType.ManaAllCharges:
                    serializer.Serialize(writer, " Mana, all Charges");
                    return;
                case CostType.TurretKitAmpCostMana:
                    serializer.Serialize(writer, " Turret Kit &amp; {{ cost }} Mana");
                    return;
                case CostType.Abilityresourcename:
                    serializer.Serialize(writer, " {{ abilityresourcename }}");
                    return;
                case CostType.AbilityresourcenamePerSecond:
                    serializer.Serialize(writer, " {{ abilityresourcename }} per Second");
                    return;
                case CostType.MaxHealthCostMana:
                    serializer.Serialize(writer, "% Max Health, {{ cost }} Mana");
                    return;
                case CostType.OfCurrentHealth:
                    serializer.Serialize(writer, "% of Current Health");
                    return;
                case CostType.CostTypeOfCurrentHealth:
                    serializer.Serialize(writer, "% of current Health");
                    return;
                case CostType.OfMaxHealth:
                    serializer.Serialize(writer, "% of max Health");
                    return;
                case CostType.The1Seed:
                    serializer.Serialize(writer, "1 Seed");
                    return;
                case CostType.Generates1Ferocity:
                    serializer.Serialize(writer, "Generates 1 Ferocity");
                    return;
                case CostType.CostTypeHealth:
                    serializer.Serialize(writer, "Health");
                    return;
                case CostType.CostTypeMana:
                    serializer.Serialize(writer, "Mana");
                    return;
                case CostType.NoCost:
                    serializer.Serialize(writer, "No Cost");
                    return;
                case CostType.CostTypeNoCost:
                    serializer.Serialize(writer, "No cost");
                    return;
                case CostType.Passive:
                    serializer.Serialize(writer, "Passive");
                    return;
            }
            throw new Exception("Cannot marshal type CostType");
        }

        public static readonly CostTypeConverter Singleton = new CostTypeConverter();
    }

    internal class CoeffConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Coeff) || t == typeof(Coeff?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Coeff { Double = doubleValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<double[]>(reader);
                    return new Coeff { DoubleArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Coeff");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Coeff)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.DoubleArray != null)
            {
                serializer.Serialize(writer, value.DoubleArray);
                return;
            }
            throw new Exception("Cannot marshal type Coeff");
        }

        public static readonly CoeffConverter Singleton = new CoeffConverter();
    }

    internal class KeyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Key) || t == typeof(Key?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "a1":
                    return Key.A1;
                case "a2":
                    return Key.A2;
                case "f1":
                    return Key.F1;
                case "f2":
                    return Key.F2;
                case "f3":
                    return Key.F3;
                case "f4":
                    return Key.F4;
            }
            throw new Exception("Cannot unmarshal type Key");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Key)untypedValue;
            switch (value)
            {
                case Key.A1:
                    serializer.Serialize(writer, "a1");
                    return;
                case Key.A2:
                    serializer.Serialize(writer, "a2");
                    return;
                case Key.F1:
                    serializer.Serialize(writer, "f1");
                    return;
                case Key.F2:
                    serializer.Serialize(writer, "f2");
                    return;
                case Key.F3:
                    serializer.Serialize(writer, "f3");
                    return;
                case Key.F4:
                    serializer.Serialize(writer, "f4");
                    return;
            }
            throw new Exception("Cannot marshal type Key");
        }

        public static readonly KeyConverter Singleton = new KeyConverter();
    }

    internal class LinkConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Link) || t == typeof(Link?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "@special.BraumWArmor":
                    return Link.SpecialBraumWArmor;
                case "@special.BraumWMR":
                    return Link.SpecialBraumWmr;
                case "@special.nautilusq":
                    return Link.SpecialNautilusq;
                case "@special.viw":
                    return Link.SpecialViw;
                case "@stacks":
                    return Link.Stacks;
                case "@text":
                    return Link.Text;
                case "armor":
                    return Link.Armor;
                case "attackdamage":
                    return Link.Attackdamage;
                case "bonusarmor":
                    return Link.Bonusarmor;
                case "bonusattackdamage":
                    return Link.Bonusattackdamage;
                case "bonushealth":
                    return Link.Bonushealth;
                case "bonusspellblock":
                    return Link.Bonusspellblock;
                case "health":
                    return Link.Health;
                case "spelldamage":
                    return Link.Spelldamage;
            }
            throw new Exception("Cannot unmarshal type Link");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Link)untypedValue;
            switch (value)
            {
                case Link.SpecialBraumWArmor:
                    serializer.Serialize(writer, "@special.BraumWArmor");
                    return;
                case Link.SpecialBraumWmr:
                    serializer.Serialize(writer, "@special.BraumWMR");
                    return;
                case Link.SpecialNautilusq:
                    serializer.Serialize(writer, "@special.nautilusq");
                    return;
                case Link.SpecialViw:
                    serializer.Serialize(writer, "@special.viw");
                    return;
                case Link.Stacks:
                    serializer.Serialize(writer, "@stacks");
                    return;
                case Link.Text:
                    serializer.Serialize(writer, "@text");
                    return;
                case Link.Armor:
                    serializer.Serialize(writer, "armor");
                    return;
                case Link.Attackdamage:
                    serializer.Serialize(writer, "attackdamage");
                    return;
                case Link.Bonusarmor:
                    serializer.Serialize(writer, "bonusarmor");
                    return;
                case Link.Bonusattackdamage:
                    serializer.Serialize(writer, "bonusattackdamage");
                    return;
                case Link.Bonushealth:
                    serializer.Serialize(writer, "bonushealth");
                    return;
                case Link.Bonusspellblock:
                    serializer.Serialize(writer, "bonusspellblock");
                    return;
                case Link.Health:
                    serializer.Serialize(writer, "health");
                    return;
                case Link.Spelldamage:
                    serializer.Serialize(writer, "spelldamage");
                    return;
            }
            throw new Exception("Cannot marshal type Link");
        }

        public static readonly LinkConverter Singleton = new LinkConverter();
    }

    internal class TagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tag) || t == typeof(Tag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Assassin":
                    return Tag.Assassin;
                case "Fighter":
                    return Tag.Fighter;
                case "Mage":
                    return Tag.Mage;
                case "Marksman":
                    return Tag.Marksman;
                case "Support":
                    return Tag.Support;
                case "Tank":
                    return Tag.Tank;
            }
            throw new Exception("Cannot unmarshal type Tag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Tag)untypedValue;
            switch (value)
            {
                case Tag.Assassin:
                    serializer.Serialize(writer, "Assassin");
                    return;
                case Tag.Fighter:
                    serializer.Serialize(writer, "Fighter");
                    return;
                case Tag.Mage:
                    serializer.Serialize(writer, "Mage");
                    return;
                case Tag.Marksman:
                    serializer.Serialize(writer, "Marksman");
                    return;
                case Tag.Support:
                    serializer.Serialize(writer, "Support");
                    return;
                case Tag.Tank:
                    serializer.Serialize(writer, "Tank");
                    return;
            }
            throw new Exception("Cannot marshal type Tag");
        }

        public static readonly TagConverter Singleton = new TagConverter();
    }
}
    