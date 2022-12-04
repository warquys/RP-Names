using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace RpName
{
    public class PluginConfig : IConfig
    {
        [Description("If the plugin is enable or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Keep the same name when the player bc an Tuto or an Spectator ?")]
        public bool KeepNameTuto = true;
        public bool KeepNameSpectate = false;


        [Description("The role and the new name")]
        public Dictionary<RoleType, string> RoleNames { get; set; } = new Dictionary<RoleType, string>()
        {
            { RoleType.ClassD,         "D-%randomNum%%randomNum%%randomNum%%randomNum%-%randomChar%%randomChar% (%playerName%)" },
            { RoleType.Scientist,      "Dr %SecondName% %randomChar%. (%playerName%)"},
            { RoleType.NtfSergeant,    "Sergeant %secondName% (%playerName%)" },
            { RoleType.NtfCaptain,     "Captain %firstName% %SecondName% (%playerName%)"},
            { RoleType.NtfSpecialist,  "Specialist %SecondName% (%playerName%)" },
            { RoleType.NtfPrivate,     "Private %secondName% (%playerName%)" },
            { RoleType.FacilityGuard,  "Security Officer %secondName% (%playerName%)" },
            { RoleType.Scp049,         "SCP-049 (%playerName%)" },
            { RoleType.Scp079,         "SCP-079 (%playerName%)" },
            { RoleType.Scp096,         "SCP-096 (%playerName%)" },
            { RoleType.Scp0492,        "SCP-049-2 (%playerName%)" },
            { RoleType.Scp106,         "SCP-106 (%playerName%)" },
            { RoleType.Scp173,         "SCP-173 (%playerName%)" },
            { RoleType.Scp93953,       "SCP-939-53 (%playerName%)" },
            { RoleType.Scp93989,       "SCP-939-89 (%playerName%)" },
            { RoleType.ChaosConscript, "Conscript %secondName% (%playerName%)" },
            { RoleType.ChaosMarauder,  "Marauder %secondName% (%playerName%)" },
            { RoleType.ChaosRepressor, "Repressor %secondName% (%playerName%)" },
            { RoleType.ChaosRifleman,  "Rifleman %secondName% (%playerName%)" },
        };

        public List<string> FirstNames { get; set; } = new List<string>()
        {
            "James",
            "John",
            "Robert",
            "Michael",
            "William",
            "David",
            "Richard",
            "Joseph",
            "Thomas",
            "Charles",
            "Christopher",
            "Daniel",
            "Matthew",
            "Anthony",
            "Donald",
            "Mark",
            "Paul",
            "Steven",
            "Andrew",
            "Kenneth",
            "Joshua",
            "Kevin",
            "Brian",
            "George",
            "Patric",
            "Edward",
            "Ronald",
            "Timothy",
            "Jason",
            "Jeffrey",
            "Ryan",
            "Jacob",
            "Gary",
            "Nicholas",
            "Eric",
            "Jonathan",
            "Stephen",
            "Larry",
            "Justin",
            "Scott",
            "Brandon",
        };

        public List<string> SecondNames { get; set; } = new List<string>()
        {
            "Smith",
            "Johnson",
            "Williams",
            "Brown",
            "Jones",
            "Miller",
            "Davis",
            "Wilson",
            "Anderson",
            "Taylor",
            "Garcia",
            "Thomas",
            "Moore",
            "Martin",
            "Rodriguez",
            "Lee",
            "White",
            "Thompson",
            "Jackson",
            "Martinez",
            "Hyde", 
            "Hood", 
            "Hull", 
            "Hogan", 
            "Hitchens",
            "Higgins", 
            "Hodder", 
            "Huxx",
            "Hester",
            "Fleetwood", 
            "Fugger", 
            "Frost", 
            "Curry", 
            "Ambrose", 
            "Baudin",
            "Fishman"
        };

        public List<string> Sings { get; set; } = new List<string>()
        {
            "Alfa",
            "Bravo",
            "Charlie",
            "Delta",
            "Echo",
            "Foxtrot",
            "Golf",
            "Hotel",
            "India",
            "Juliett",
            "Kilo",
            "Lima",
            "Mike",
            "November",
            "Oscar",
            "Papa",
            "Quebec",
            "Romeo",
            "Sierra",
            "Tango",
            "Uniform",
            "Victor",
            "Whiskey",
            "Xray",
            "Yankee",
            "Zulu"
        };
    }
}
