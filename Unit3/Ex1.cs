using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System;
namespace Unit3
{
    public class Ex1
    {
        private int month { get; set; } 
        private int year  { get; set; }

        public void Input()
        {
            bool isValidInput = false;
            
            while (!isValidInput)
            {
                try
                {
                    Console.Write("Nhập tháng (trong khoảng 1 -> 12)");
                    this.month = int.Parse(Console.ReadLine());
                    
                    Console.Write("Nhập năm (trong khoảng 0 -> 9999)");
                    this.year = int.Parse(Console.ReadLine());

                    isValidInput = (this.month >= 1 && this.month <= 12) && this.year > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
        
        public int getDaysInMonth()
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}