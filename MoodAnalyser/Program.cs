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
        public string AnalyserMood()
        {
            try
            {
                if (this.Message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (this.Message.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    /// throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                /// throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
                return "HAPPY";
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Mood Analyser");
        }
    }
}
