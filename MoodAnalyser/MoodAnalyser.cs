using System;
namespace MoodAnalyser1
{
    public class MoodAnalyser
    {

        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
        }
        public string analyseMood()
        {
            if (this.message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }



}
