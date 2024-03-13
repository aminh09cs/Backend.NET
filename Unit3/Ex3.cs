
using System;
using System.Text;

namespace Unit3
{
    public class Ex3
    {
        public string GenerateString()
        {
            bool isValidInput = false;
            int number = 0;
            while (!isValidInput)
            {
                try
                {
                    Console.Write("Nhập 1 số dương: ");
                    string input = Console.ReadLine();
                    if (int.Parse(input) > 0)
                    {
                        isValidInput = true;
                        number = int.Parse(input);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            
            
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                res.Append($"{i}, ");
            }
            
            res.Length -= 2;
            return res.ToString();
        }
    }
}