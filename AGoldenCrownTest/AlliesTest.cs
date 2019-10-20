using AGoldenCrown;
using DeepEqual.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGoldenCrownTest
{
    [TestClass]
    public class AlliesTest
    {
        [TestMethod]
        public void CheckForInvalidMessage()
        {
            List<string> messages = new List<string>()
            {
                "Air, “oaaawaala”",
                "Land, “a1d22n333a4444p”",
                "Ice, “zmzmzmzaztzozh”"
            };
            var allies = new List<string>
            {
                "airrr",
                "landdd",
                "ice"
            };

            var ruler = new Ruler(messages, "King Shan");

            Assert.AreEqual(false, Newtonsoft.Json.JsonConvert.SerializeObject(allies) == Newtonsoft.Json.JsonConvert.SerializeObject(ruler.Allies));
        }

        [TestMethod]
        public void CheckForValidMessage()
        {
            List<string> messages = new List<string>()
            {
                "Air, “oaaawaala”",
                "Land, “a1d22n333a4444p”",
                "Ice, “zmzmzmzaztzozh”"
            };
            var allies = new List<string>
            {
                "air",
                "land",
                "ice"
            };

            var ruler = new Ruler(messages, "King Shan");
            ruler.FindAllies();

            Assert.AreEqual(allies.Count(), ruler.Allies.Count());
            Assert.AreEqual(Newtonsoft.Json.JsonConvert.SerializeObject(allies), Newtonsoft.Json.JsonConvert.SerializeObject(ruler.Allies));
        }
    }
}
