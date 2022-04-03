using System;
namespace MoodAnalyserTesting
{
    public class MoodAnalyser
    {
        public MoodAnalyser()
        {

        }
        public string AnalyseMood(string Message)
        {
            if (Message.Contains("SAD"))
                return "SAD";
            else return "HAPPY";
        }
        public static void Main(string[] args)
        {

        }
    }
}