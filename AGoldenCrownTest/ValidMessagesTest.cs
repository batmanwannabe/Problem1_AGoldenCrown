using System;
using AGoldenCrown;
using AGoldenCrown.Source.Models;
using AGoldenCrown.Source.Statics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AGoldenCrownTest
{
    [TestClass]
    public class ValidMessagesTest
    {
        /// <summary>
        /// Specifying Lower cases only since we are using ToLower() before calling this method
        /// </summary>
        [TestMethod]
        public void CheckForInvalidMessage()
        {
            Assert.AreEqual(false, FindAllAllies.IsMessageValidSecret("abc", "aaaa"));
            Assert.AreEqual(false, FindAllAllies.IsMessageValidSecret("123", "asdasdasd"));
            Assert.AreEqual(false, FindAllAllies.IsMessageValidSecret("abc", "12313"));
            Assert.AreEqual(false, FindAllAllies.IsMessageValidSecret("octopus", "Summer is coming"));
        }

        [TestMethod]
        public void CheckForValidMessage()
        {
            Assert.AreEqual(true, FindAllAllies.IsMessageValidSecret("panda", "a1d22n333a4444p"));
            Assert.AreEqual(true, FindAllAllies.IsMessageValidSecret("owl", "oaaawaala"));
            Assert.AreEqual(true, FindAllAllies.IsMessageValidSecret("mammoth", "zmzmzmzaztzozh"));
            Assert.AreEqual(true, FindAllAllies.IsMessageValidSecret("owl", "let’s swing the sword together"));
            Assert.AreEqual(true, FindAllAllies.IsMessageValidSecret("panda", "die or play the tame of thrones"));
            Assert.AreEqual(true, FindAllAllies.IsMessageValidSecret("mammoth", "ahoy! fight for me with men and money"));
            Assert.AreEqual(true, FindAllAllies.IsMessageValidSecret("dragon", "drag on martin!"));
        }
    }
}
