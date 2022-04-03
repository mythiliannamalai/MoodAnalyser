using System;
namespace MoodAnalyserTesting
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

        }
    }
}