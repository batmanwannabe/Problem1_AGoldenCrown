using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGoldenCrown
{
    public static class Southeros
    {
        /// <summary>
        /// Hashtable as DS to store and retrieve Kingdom and Emblems.
        /// </summary>
        public static readonly Hashtable KingdomEmblems = new Hashtable
        {
            { "land", "panda" },
            { "water", "octopus" },
            { "ice", "mammoth" },
            { "air", "owl" },
            { "fire", "dragon" },
        };
    }
}
