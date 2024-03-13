using System;
using System.Text;

namespace Unit3
{
    public class Ex4
    {
        public string RevertString()
        { 
            Console.Write("Nhập 1 chuỗi: "); 
            string input = Console.ReadLine();
               
            
            StringBuilder strB = new StringBuilder(input);
            
            for (int i = 0; i < strB.Length / 2; i++)
            {
                char tempC = strB[i];
                strB[i] = strB[strB.Length - i - 1];
                strB[strB.Length - i - 1] = tempC;
            }

            return strB.ToString();

        }
    }
}