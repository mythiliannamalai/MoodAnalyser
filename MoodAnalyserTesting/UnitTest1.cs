using System;
using MoodAnalyser;
using NUnit.Framework;
namespace MoodAnalyser
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
        //TC-3.1
        [Test]
        public void GivenMassage_When_Empty_CustemerException()
        {
            moodAnalyser = new MoodAnalyser();
            string Message = "";
            string Expected = "Mood should not empty";
            try
            {
                moodAnalyser = new MoodAnalyser(Message);
            }
            catch (MoodAnalyserCustomException Exception)
            {
                Assert.AreEqual(Expected, Exception.Message);
            }
        }
    }
}