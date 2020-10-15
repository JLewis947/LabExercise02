using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double result = DoCalculation(args);
            Console.WriteLine("The answer is {0}", result);
        }

        public static double DoCalculation(string[] args)
        {
            Calculations calc = new Calculations();
            if(args[0] == "Add")
            {
                double a = double.Parse(args[1]);
                double b = double.Parse(args[2]);
                return calc.Add(a, b);
            }
            return 0;
        }
    }

    public class Calculations
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw (new ArgumentOutOfRangeException());
            }
            return a / b;
        }
    }
}
