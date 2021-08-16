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

        ////test case 1.1
        //[Test]
        //public void GivenSadMessage_WhenAnalysed_ShouldReturnSad()
        //{
        //    MoodAnalyserClass mood = new MoodAnalyserClass();
        //    string message = "I am in Sad Mood";
        //    string actual = mood.AnalyseMood(message);
        //    //assert
        //    Assert.AreEqual("sad", actual);
        //}

        ////test case 1.2
        //[Test]
        //public void GivenAnyMessage_WhenAnalysed_ShouldReturnHappy()
        //{
        //    MoodAnalyserClass mood = new MoodAnalyserClass();
        //    string message = "I am in Any Mood";
        //    string actual = mood.AnalyseMood(message);
        //    //assert
        //    Assert.AreEqual("happy", actual);
        //}

        //Refactor test case 1.1
        [Test]
        public void GivenSadMessage_WhenAnalysed_ShouldReturnSad()
        {
            MoodAnalyserClass ma = new MoodAnalyserClass("I am in Sad Mood");
            string actual = ma.AnalyseMood();
            Assert.AreEqual(actual, "sad");
        }

        //Refactor test case 1.2
        [Test]
        public void GivenAnyMessage_WhenAnalysed_ShouldReturnHappy()
        {
            MoodAnalyserClass ma = new MoodAnalyserClass("I am in happy Mood");
            string actual = ma.AnalyseMood();
            Assert.AreEqual(actual, "happy");
        }

        //test case 2.1
        [Test]
        public void GivenNullMood_WhenAnalysed_ShouldReturnHappy()
        {
            //null value passed
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass(null);
            string actual = moodAnalyser.AnalyseMood();

            //assert
            Assert.AreEqual("happy", actual);
        }

        //test case 3.1
        [Test]
        public void GivenNullMood_ThrowsMoodAnalysisException()
        {
            string expected = "Mood should not be null.";
            try
            {
                string message = null;
                //act
                string actual = new MoodAnalyserClass(message).AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //test case 3.2
        [Test]
        public void GivenEmptyMood_ThrowsMoodAnalysisException()
        {
            string expected = "Mood should not be empty.";
            try
            {
                string message = "";
                //act
                string actual = new MoodAnalyserClass(message).AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}