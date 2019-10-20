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
            var ruler = new Ruler();
            Assert.AreEqual(false, ruler.FindValidMessage("abc", "aaaa"));
            Assert.AreEqual(false, ruler.FindValidMessage("123", "asdasdasd"));
            Assert.AreEqual(false, ruler.FindValidMessage("abc", "12313"));
            Assert.AreEqual(false, ruler.FindValidMessage("octopus", "Summer is coming"));
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
            var calculatedAllies = ruler.FindAllies();

            Assert.AreEqual(allies.Count(), calculatedAllies.Count());
            Assert.AreEqual(Newtonsoft.Json.JsonConvert.SerializeObject(allies), Newtonsoft.Json.JsonConvert.SerializeObject(ruler.Allies));
        }
    }
}
