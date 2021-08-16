using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object MoodAnalyserObject(string className, string ctorName)
        {
            string pattern = @"." + ctorName + "";
            Match result = Regex.Match(className, pattern);
            //if yes create the object
            if (result.Success)
            {
                try
                {
                    Assembly asem = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = asem.GetType(className);

                    //Assembly class : getting the details or for reading about your application's assembly
                    //Activator : This class contains methods to create types of objects or obtain references 
                    
                    return Activator.CreateInstance(moodAnalyseType);
                }
                //class not found - throw exception
                catch (ArgumentNullException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.CLASS_NOT_FOUND, "Class not found");
                }
            }
            //constructor name not found - throw exception
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
            }

        }

    }
}