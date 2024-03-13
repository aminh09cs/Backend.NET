using System;
namespace Unit3
{
    public class Ex2
    {
        public void DateValidation()
        {
            DateTime dateTime;
            Console.Write("Nhập ngày: ");
            string dateInput = Console.ReadLine();

            string res = DateTime.TryParse(dateInput, out dateTime)
                ? "Đúng định dạng ngày"
                : "Sai định dạng ngày rồi";
            Console.WriteLine(res);

        }
    }
}