using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int min = number2;
            return min;
            
        }
        public int FindMinimum(int number1, int number2, float number3 )
        {
            int min = number2;
            return min;
        }
        public int FindMaximum(int number1, int number2)
        {
            int max = number1;
            return max;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            int max = (int) number3;
            return max;
        }
    }
}
