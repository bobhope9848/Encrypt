using System;
using System.Collections.Generic;
using System.Text;

namespace Encrypt
{
    class Calculation
    {
        public string Input { get; set; }
        public string Key { get; set; }

        public string calculate()
        {
            var finalresult = "";
            List<char> input = new List<char>();
            input.AddRange(Input.Replace(" ","").ToUpper());
            List<char> key = new List<char>();
            key.AddRange(Key.Replace(" ","").ToUpper());
            if (Input.Length > Key.Length )
            {
                for (int i = 0; i < Input.Length - Key.Length; i++)
                {
                    key.Add(key[i]);
                }
            } else if (Input.Length < Key.Length)
            {
                throw new InvalidOperationException("Message length can not be longer than key");
            }

            for (int i = 0; i < input.Count; i++)
            {
                int convinpint = input[i];
                int convkeyint = key[i];
                int move = Math.Abs(convkeyint - 65);
                int result = convinpint + move;
                char encryptresult = 'a';
                switch (result)
                {
                    case int loopresult when result > 90:
                        int newresult = loopresult - 26;
                        encryptresult = (char)newresult;
                        break;

                    case int loopresult when result <= 90:
                        encryptresult = (char)loopresult;
                        break;
                }
                finalresult += Convert.ToString(encryptresult);
                
            }
            return finalresult;

        }
        
    }
}
