using System;
namespace MoodAnalyserTesting
{
    public class MoodAnalyser
    {
        string Message;
        public MoodAnalyser(string Message)
        {
            this.Message = Message;
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