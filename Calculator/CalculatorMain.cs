using System;
using System.Collections.Generic;
using System.Text;



namespace Calculator
{
    public class CalculatorMain
    {

        public static int Add(int a, int b)
        {
            int c = a / b;
            if (c > 0)
            {
                return c;
            }
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            //returns multiplication result
            return a * b;
        }

        public static float Div(int a, int b)
        {
            // return type may be of float type
            return a / b;
        }
    }
}
