using MoodAnalyzer;

namespace MoodAnalyzerTest
{
    public class Tests
    {
     
        MoodAnalyzerProblem mood = new MoodAnalyzerProblem();

        [Test]
        public void GivenSadMood_WhenAnalzer_ShouldReturnSad()
        {
            string result = mood.AnalseMood("I am in sad mood");

            Assert.AreEqual("SAD",result);
        }

        [Test]
        public void GivenSadMood_WhenAnalzer_ShouldReturnHappy()
        {
            string result = mood.AnalseMood("I am in happy mood");

            Assert.AreEqual("HAPPY", result);
        }
    }
}