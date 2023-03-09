using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11Features
{
    public class PatternMatchingOnSpan
    {
        public void PatternMatchonSpan()
        {
            ReadOnlySpan<char> text = "Gowtham K";
            if (text is "Gowtham K")
            {
                Console.WriteLine($"Yes it is {text}");
            }
          
            //Pattern Matching 
            if(text is ['G',..])
            {
                 Console.WriteLine("Name Starts with G");
            }
        }

     

    }
}
