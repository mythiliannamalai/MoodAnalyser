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
            moodAnalyser = new MoodAnalyser("I am in SAD mood");
            string Message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", Message);
        }
        //TC-1.2
        [Test]
        public void GivenMassage_When_ShoudReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in ANY mood");
            string Message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", Message);
        }
        //TC-2.1
        [Test]
        public void GivenMassage_When_Null_ShoudReturnHappy()
        {
            moodAnalyser = new MoodAnalyser();
            string Message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", Message);
        }
    }
}