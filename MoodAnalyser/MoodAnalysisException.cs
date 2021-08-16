using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NULL_MOOD_EXCEPTION, EMPTY_MOOD_EXCEPTION, CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND
        }
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
