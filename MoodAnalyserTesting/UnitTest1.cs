using System;
using NUnit.Framework;
namespace MoodAnalyserTesting
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            string res = "";
            moodAnalyser = new MoodAnalyser(res);
        }
        //TC-1.1
        [Test]
        public void GivenMassage_When_ShoudReturnSad()
        {
            string Message = moodAnalyser.AnalyseMood("I am in SAD mood");
            Assert.AreEqual("SAD", Message);
        }
        //TC-1.2
        [Test]
        public void GivenMassage_When_ShoudReturnHappy()
        {
            string Message = moodAnalyser.AnalyseMood("I am in ANY mood");
            Assert.AreEqual("HAPPY", Message);
        }
    }
}
