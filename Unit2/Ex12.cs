using System;

namespace Unit2
{
    public struct Info
    {
        private int Atk;
        
        public int MyAtk
        {
            get { return Atk; }
            set { Atk = value; }
        }

        public void ShowAtk()
        {
            Console.WriteLine("This is my atk {0}", Atk);
        }
    
    }
}