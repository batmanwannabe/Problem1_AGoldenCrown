using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void PrintMessageResults(Ruler ruler)
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
