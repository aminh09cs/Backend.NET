using System;

namespace Unit3
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // Ex1 ex1 = new Ex1();
            // ex1.Input();
            // int numberOfDays = ex1.getDaysInMonth();
            // Console.WriteLine("Số ngày là {0}", numberOfDays);

            // Ex2 ex2 = new Ex2();
            // ex2.DateValidation();
            
            // Ex3 ex3 = new Ex3();
            // string text = ex3.GenerateString();
            // Console.WriteLine(text);

            Ex4 ex4 = new Ex4();
            string text  = ex4.RevertString();
            Console.WriteLine(text);
        }
    }
}