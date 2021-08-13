using MoodAnalyser;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //test case 1.1
        [Test]
        public void GivenSadMessage_WhenAnalysed_ShouldReturnSad()
        {
            MoodAnalyserClass mood = new MoodAnalyserClass();
            string message = "I am in Sad Mood";
            string actual = mood.AnalyseMood(message);
            //assert
            Assert.AreEqual("sad", actual);
        }

        //test case 1.2
        [Test]
        public void GivenAnyMessage_WhenAnalysed_ShouldReturnHappy()
        {
            MoodAnalyserClass mood = new MoodAnalyserClass();
            string message = "I am in Any Mood";
            string actual = mood.AnalyseMood(message);
            //assert
            Assert.AreEqual("happy", actual);
        }
    }
}