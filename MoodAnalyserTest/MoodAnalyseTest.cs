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
            MoodAnalyserClass ma = new MoodAnalyserClass("I am in Sad Mood");
            string actual = ma.AnalyseMood();
            Assert.AreEqual(actual, "sad");
        }

        //test case 1.2
        [Test]
        public void GivenAnyMessage_WhenAnalysed_ShouldReturnHappy()
        {
            MoodAnalyserClass ma = new MoodAnalyserClass("I am in happy Mood");
            string actual = ma.AnalyseMood();
            Assert.AreEqual(actual, "happy");
        }
    }
}