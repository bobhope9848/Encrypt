using System;
using System.Collections.Generic;
using System.Text;

namespace Encrypt
{
    class Calculation
    {
        public string Input { get; set; }

        public void calculate()
        {
            char[] input = Input.ToCharArray();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string numbered = (string)alpha[0];
            Console.WriteLine(alpha[9]);
        }
        
    }
}
