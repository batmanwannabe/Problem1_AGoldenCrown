using AGoldenCrown.Source.Models;
using System;
using System.Collections.Generic;

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