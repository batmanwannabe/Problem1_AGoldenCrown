using AGoldenCrown.Source.Models;
using System;
using System.Linq;

namespace AGoldenCrown.Source
{
    /// <summary>
    /// Role of this class is to Print Message Results
    /// </summary>
    public static class MessageResults
    {
        /// <summary>
        /// Prints the ruler, accepts Ruler object
        /// </summary>
        /// <param name="ruler"></param>
        public static void PrintMessageResults(RulerAllies ruler)
        {
            if (ruler.Allies.Count() > 2)
            {
                Console.WriteLine("Ruler of Westeros: " + ruler.RulerName);
                Console.WriteLine("The Allies are: ");
                foreach (var i in ruler.Allies)
                    Console.WriteLine(i);
            }
            else
                Console.WriteLine("Ruler of Westeros: None");
        }
    }
}