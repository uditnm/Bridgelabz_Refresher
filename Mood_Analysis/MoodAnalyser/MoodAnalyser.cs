using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyse
{
    public class MoodAnalyser
    {
        public string analyseMood(string message)
        {
            string mood = "sad";
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    mood =  "happy";
                }
                else if(message.ToLower().Contains("Sad"))
                {
                    mood = "sad";
                }
                else if(message.Equals(""))
                {
                    throw new InvalidMoodException(InvalidMoodException.ExceptionType.ENTERED_EMPTY);
                }
                else
                {
                    throw new InvalidMoodException(InvalidMoodException.ExceptionType.ENTERED_NULL);
                }
                
            }
            catch (InvalidMoodException e)
            {
                Console.WriteLine($"Message: {e.Message}");
            }

            return mood;
            
        }
    }
}
