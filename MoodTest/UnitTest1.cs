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
            MoodAnalyser obj = new MoodAnalyser();
            string result = obj.analyseMood("HAPPY");
            Assert.AreEqual("HAPPY", result);
        }

        [TestMethod]
        public void GivenMoodSad_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser();
            string result = obj.analyseMood("SAD");
            Assert.AreEqual("SAD", result);
        }


    }



}
