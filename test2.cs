using System;

namespace Test2
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            Calculator calculator = new Calculator();
            int a = 20;
            int b = 30;

            int A = calculator.add(a , b);
            int B = calculator.Subtract(a , b);
            
            Console.WriteLine(A);
            Console.WriteLine(B);
            
        }
    }


    public class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }

    }
}