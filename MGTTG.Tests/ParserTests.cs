using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MGTTG.Tests
{
    [TestClass]
    public class ParserTests 
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Parser();
            p.AddInput("glob is I");
            p.AddInput("prok is V");
            p.AddInput("pish is X");
            p.AddInput("tegj is L");
            p.AddInput("glob glob Silver is 34 Credits");
            p.AddInput("glob prok Gold is 57800 Credits");
            p.AddInput("pish pish Iron is 3910 Credits");
            var answer = p.AddInput("how much is pish tegj glob glob ?");
            Assert.AreEqual("pish tegj glob glob is 42",answer);
            answer = p.AddInput("how many Credits is glob prok Silver ?");
            Assert.AreEqual("glob prok Silver is 68 Credits", answer);
            answer = p.AddInput("how many Credits is glob prok Gold ?");
            Assert.AreEqual("glob prok Gold is 57800 Credits", answer);
            answer = p.AddInput("how many Credits is glob prok Iron ?");
            Assert.AreEqual("glob prok Iron is 782 Credits", answer);
            answer = p.AddInput("how much wood could a woodchuck chuck if a woodchuck could chuck wood?");
            Assert.AreEqual("I have no idea what you are talking about", answer);

        }

    }
}
