using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGoldenCrown
{
    public class Ruler
    {
        public Ruler()
        {

        }
        public Ruler(IEnumerable<string> messages, string rulerName)
        {
            MessagesWithKingdoms = messages;
            Allies = new List<String>();
            RulerName = rulerName;
        }
        public String RulerName { get; set; }
        public IEnumerable<String> MessagesWithKingdoms { get; set; }
        public List<String> Allies { get; set; }
        public IEnumerable<String> FindAllies()
        {
            string kingdom = string.Empty;
            foreach (var i in MessagesWithKingdoms)
            {
                string[] kingdomMessage = i.Split(new[] { ' ' }, 2);
                kingdom = kingdomMessage[0].ToLower().Replace(",", "");
                switch (kingdom)
                {
                    case Southeros.Land:
                        if(IsMessageValidSecret(Southeros.Emblems[Southeros.Land], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;
                    case Southeros.Water:
                        if(IsMessageValidSecret(Southeros.Emblems[Southeros.Water], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;
                    case Southeros.Ice:
                        if(IsMessageValidSecret(Southeros.Emblems[Southeros.Ice], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;
                    case Southeros.Air:
                        if(IsMessageValidSecret(Southeros.Emblems[Southeros.Air], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;
                    case Southeros.Fire:
                        if(IsMessageValidSecret(Southeros.Emblems[Southeros.Fire], kingdomMessage[1]))
                            Allies.Add(kingdom);
                        break;
                }
            }

            return Allies;
        }
        public bool IsMessageValidSecret(string emblem, string message)
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
