using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserClass
    {
        string message;
        public MoodAnalyserClass(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try 
            { 
                message = message.ToLower();
                //FOR TC 3.1
                if (message.Equals(null))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD_EXCEPTION, "Mood should not be null.");
                }
                //FOR TC 3.2
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD_EXCEPTION, "Mood should not be empty.");

                }

                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
            }
        }
    }
}