using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser1;


namespace MoodTest
{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in happy mood");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);
        }

        [TestMethod]
        public void GivenMoodSad_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in sad mood ");
            string result = obj.analyseMood();
            Assert.AreEqual("SAD", result);
        }

    }



}
