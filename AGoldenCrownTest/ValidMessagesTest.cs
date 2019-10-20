using System;
using AGoldenCrown;
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
            var ruler = new Ruler();
            Assert.AreEqual(false, ruler.IsMessageValidSecret("abc", "aaaa"));
            Assert.AreEqual(false, ruler.IsMessageValidSecret("123", "asdasdasd"));
            Assert.AreEqual(false, ruler.IsMessageValidSecret("abc", "12313"));
            Assert.AreEqual(false, ruler.IsMessageValidSecret("octopus", "Summer is coming"));
        }

        [TestMethod]
        public void CheckForValidMessage()
        {
            var ruler = new Ruler();
            Assert.AreEqual(true, ruler.IsMessageValidSecret("panda", "a1d22n333a4444p"));
            Assert.AreEqual(true, ruler.IsMessageValidSecret("owl", "oaaawaala"));
            Assert.AreEqual(true, ruler.IsMessageValidSecret("mammoth", "zmzmzmzaztzozh"));
            Assert.AreEqual(true, ruler.IsMessageValidSecret("owl", "let’s swing the sword together"));
            Assert.AreEqual(true, ruler.IsMessageValidSecret("panda", "die or play the tame of thrones"));
            Assert.AreEqual(true, ruler.IsMessageValidSecret("mammoth", "ahoy! fight for me with men and money"));
            Assert.AreEqual(true, ruler.IsMessageValidSecret("dragon", "drag on martin!"));
        }
    }
}
