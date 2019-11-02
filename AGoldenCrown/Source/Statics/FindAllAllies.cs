using System;
using System.Collections.Generic;
using System.Linq;

namespace AGoldenCrown.Source.Statics
{
    /// <summary>
    /// Responsibility of this class is to Find all allies for the given Messages
    /// </summary>
    public static class FindAllAllies
    {
        public static List<string> Allies { get; private set; }

        public static IEnumerable<String> FindAllies(IEnumerable<String> messages)
        {
            string kingdom;
            Allies = new List<string>();
            foreach (var i in messages)
            {
                string[] kingdomMessage = i.ToLower().Split(new[] { ' ' }, 2);
                kingdom = kingdomMessage[0].Replace(",", "");
                switch (kingdom)
                {
                    case "land":
                        if (IsMessageValidSecret((string)Southeros.KingdomEmblems["land"], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;

                    case "water":
                        if (IsMessageValidSecret((string)Southeros.KingdomEmblems["water"], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;

                    case "ice":
                        if (IsMessageValidSecret((string)Southeros.KingdomEmblems["ice"], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;

                    case "air":
                        if (IsMessageValidSecret((string)Southeros.KingdomEmblems["air"], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;

                    case "fire":
                        if (IsMessageValidSecret((string)Southeros.KingdomEmblems["fire"], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;
                }
            }

            return Allies;
        }

        public static bool IsMessageValidSecret(string emblem, string message)
        {
            foreach (var i in emblem)
            {
                if (emblem.Count(x => x.Equals(i)) > message.Count(x => x.Equals(i)))
                    return false;
            }
            return true;
        }
    }
}