using AGoldenCrown.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGoldenCrown
{
    public class Ruler : RulerBase
    {
        public Ruler()
        {

        }
        
        public IEnumerable<String> MessagesWithKingdoms { get; protected set; }        
        
    }
}
