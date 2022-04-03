using System;
using MoodAnalyser;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyser
{
    public class MoodAnalyser
    {
        string Message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string Message)
        {
            this.Message = Message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (Message.Equals(string.Empty))
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MOOD, "Mood should not empty");
                if (Message.Contains("SAD"))
                    return "SAD";
                else return "HAPPY";
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Mood Analyser");
        }
    }
}
