using AGoldenCrown.Source.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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

            var ruler = new RulerAllies(messages, "King Shan");

            Assert.AreEqual(false, Newtonsoft.Json.JsonConvert.SerializeObject(allies) == Newtonsoft.Json.JsonConvert.SerializeObject(ruler.Allies));
        }

        /// <summary>
        /// Test for valid messages with all Small leters
        /// </summary>
        [TestMethod]
        public void CheckForValidMessageCase1()
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

            var ruler = new RulerAllies(messages, "King Shan");

            Assert.AreEqual(allies.Count(), ruler.Allies.Count());
            Assert.AreEqual(Newtonsoft.Json.JsonConvert.SerializeObject(allies), Newtonsoft.Json.JsonConvert.SerializeObject(ruler.Allies));
        }

        /// <summary>
        /// Test for valid messages with mixed case
        /// </summary>
        [TestMethod]
        public void CheckForValidMessageCase2()
        {
            List<string> messages = new List<string>()
            {
                "Fire, \"Drag on Martin!\"",
                "Air, \"oaaawaala\"",
                "Land, \"Die or play the lame of thrones\""
            };
            var allies = new List<string>
            {
                "fire",
                "air",
                "land"
            };

            var ruler = new RulerAllies(messages, "King Shan");

            Assert.AreEqual(allies.Count(), ruler.Allies.Count());
            Assert.AreEqual(Newtonsoft.Json.JsonConvert.SerializeObject(allies), Newtonsoft.Json.JsonConvert.SerializeObject(ruler.Allies));
        }
    }
}