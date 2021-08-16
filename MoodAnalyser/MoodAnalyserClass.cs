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
                Console.WriteLine(ex);
                return "happy";
            }
        }
    }
}