using AGoldenCrown.Source.Statics;
using System;
using System.Collections.Generic;

namespace AGoldenCrown.Source.Models
{
    public class RulerAllies : Ruler
    {
        public RulerAllies()
        {

        }
        public RulerAllies(IEnumerable<string> messages, string rulerName)
        {
            MessagesWithKingdoms = messages;
            Allies = FindAllAllies.FindAllies(messages);
            RulerName = rulerName;
        }

        public IEnumerable<String> Allies { get; private set; }
        
    }
}
