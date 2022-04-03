using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;
namespace MoodAnalyser
{
    //TC-3.2
    public class MoodAnalyserCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            EMPTY_MOOD,
            EMPTY_NULL,
        }
        public MoodAnalyserCustomException(ExceptionType type, string Message) : base(Message)
        {
            this.type = type;
        }
    }
}
