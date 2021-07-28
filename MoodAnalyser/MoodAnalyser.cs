using System;
namespace MoodAnalyser1
{
    public class MoodAnalyser
    {
        private string message;
        //public MoodAnalyser(string message)
        //{
        //    this.message = message;
        //}
        //public MoodAnalyser()
        //{
        //}

        public string analyseMood(string message)
        {
            //"null"==""
            // string s = null;

            if (message.Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";


        }
    }



}
