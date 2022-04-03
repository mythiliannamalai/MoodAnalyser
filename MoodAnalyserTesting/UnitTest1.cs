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
        //TC-4.1
        [Test]
        public void MoodAnalyserClass_NameShouldReturnMood_AnalyserObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserfactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        //TC-4.2
        [Test]
        public void MoodAnalyser_Improper_ClassNameShouldThrow_MoodAnalyserException()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserfactory.CreateMoodAnalyse("MoodAnalyser.Mood", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        //TC-4.3
        [Test]
        public void MoodAnalyser_Improper_ConstructorName_ShoulThrow_MoodAnalyserException()
        {
            object obj = null;
            string expected = "Constructor not found";
            try
            {
                obj = MoodAnalyserfactory.CreateMoodAnalyse("MoodAnalyser.Moodanalyser", "AnalyserMood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

    }
}