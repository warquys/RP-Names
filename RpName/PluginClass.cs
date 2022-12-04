using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RpName
{

    public class PluginClass : Plugin<PluginConfig>
    {
        const string TAG_FristName = "%firstName%";
        const string TAG_SecondName = "%secondName%";
        const string TAG_PlayerName = "%playerName%";
        const string TAG_Sign = "%sign%";
        const string TAG_RandomNum = "%randomNum%";
        const string TAG_RandomChar = "%randomChar%";

        public override string Author => "VT";
        public override string Name => "Rp Name";
        public override string Prefix => "Rp Name";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(5, 3, 1);
        public override PluginPriority Priority => PluginPriority.Default;
        public override bool IgnoreRequiredVersionCheck => false;

        private Random rnd = new Random();

        public static PluginClass Instance { get; set; }
        public EventsHandler EventsHandler { get; set; }

        public string RandomNum => rnd.Next(1, 9).ToString();
        public string RandomChar => ((char)rnd.Next('a', 'z')).ToString();

        public override void OnEnabled()
        {
            Instance = this;

            if (EventsHandler == null)
                EventsHandler = new EventsHandler();

            EventsHandler.AttachEvent();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            EventsHandler.DettachEvent();
            base.OnDisabled();
        }

        public string ReplaceFirst(string text, int index, int size, string replace)
        {
            if (index < 0)
            {
                return text;
            }
            return text.Substring(0, index) + replace + text.Substring(index + size);
        }

        public string GetName(RoleType id, string playerName)
        {
            if (!Config.RoleNames.TryGetValue(id, out string rule))
                return null;

            if (Config.FirstNames != null && Config.FirstNames.Any())
            {
                var index = rnd.Next(Config.FirstNames.Count);
                var firstName = Config.FirstNames[index];
                rule = Regex.Replace(rule, TAG_FristName, firstName, RegexOptions.IgnoreCase);
            }
            if (Config.SecondNames != null && Config.SecondNames.Any())
            {
                var index = rnd.Next(0, Config.SecondNames.Count);
                var secondName = Config.SecondNames[index];
                rule = Regex.Replace(rule, TAG_SecondName, secondName, RegexOptions.IgnoreCase);
            }
            if (Config.Sings != null && Config.SecondNames.Any())
            {
                var index = rnd.Next(0, Config.Sings.Count);
                var sings = Config.Sings[index];
                rule = Regex.Replace(rule, TAG_Sign, sings, RegexOptions.IgnoreCase);
            }

            rule = Regex.Replace(rule, TAG_PlayerName, playerName, RegexOptions.IgnoreCase);
            int pos;
            
            pos = rule.IndexOf(TAG_RandomNum, StringComparison.OrdinalIgnoreCase);
            while (pos >= 0)
            {
                rule = ReplaceFirst(rule, pos, TAG_RandomNum.Length, RandomNum);
                pos = rule.IndexOf(TAG_RandomNum, pos, StringComparison.OrdinalIgnoreCase);
            }
            
            pos = rule.IndexOf(TAG_RandomChar, StringComparison.OrdinalIgnoreCase);
            while (pos >= 0)
            {
                rule = ReplaceFirst(rule, pos, TAG_RandomChar.Length, RandomChar);
                pos = rule.IndexOf(TAG_RandomChar, pos, StringComparison.OrdinalIgnoreCase);
            }

            return rule;
        }
    }
}
