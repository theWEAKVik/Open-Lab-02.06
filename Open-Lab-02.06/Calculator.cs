using System;

namespace Open_Lab_02._06
{
    public class Calculator
    {
        public bool Divisible(int number)
        {
            if(number % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
