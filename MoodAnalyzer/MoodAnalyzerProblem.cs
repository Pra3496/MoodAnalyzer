using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerProblem
    {
        public string AnalseMood(string message)
        {
            if (message.Contains("sad"))
            {
                return "SAD";

            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
