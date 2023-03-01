using MoodAnalyse;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void GivenHappyString_returnHappyMood()
        {
            MoodAnalyser m = new MoodAnalyser();
            string mood = m.analyseMood("I am happy");
            Assert.AreEqual(mood, "happy");
        }

        [TestMethod]
        public void GivenSadString_returnSadMood()
        {
            MoodAnalyser m = new MoodAnalyser();
            string mood = m.analyseMood("I am Sad");
            Assert.AreEqual(mood, "sad");
        }

        [TestMethod]
        public void GivenEmptyString_returnSadMood()
        {
            MoodAnalyser m = new MoodAnalyser();
            string mood = m.analyseMood("");
            Assert.AreEqual(mood, "sad");
        }

        [TestMethod]
        public void GivenNullString_returnSadMood()
        {
            MoodAnalyser m = new MoodAnalyser();
            string mood = m.analyseMood("I am good");
            Assert.AreEqual(mood, "sad");
        }
    }
}