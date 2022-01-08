using System;
using System.Collections.Generic;
using System.Text;

namespace MillerRabinPrimalityTest
{
    class RecursionIntro
    {
        public int FactorialIterative(int n)
        {
            int num = 1;
            for (int i = 0; i < n; i++)
            {
                num *= n - i;
            }
            return num;
        }

        //n! = n * (n - 1) * (n - 2) * ...
        //0! = 1! = 1
        //n! = n * (n - 1)!
        public int Factorial(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        //Fibonacci sequence:
        //1 1 2 3 5 8 13 ...
        //f(n): the nth fibonacci number
        //f(1) = 1
        //f(2) = 1
        //f(n) = f(n - 1) + f(n - 2)

        public int Fibonacci(int n)
        {
            if(n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //Countdown(5) should print:
        //5 4 3 2 1
        //Liftoff!
        //note: on separate lines
        public void Countdown(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("out of range");
            }
            if (n == 0)
            {
                Console.WriteLine("Liftoff!");
            }
            else
            {
                if (n == 1)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.Write(n + " ");
                }
                Countdown(n - 1);
            }
        }

        //Return true if the array contains the same value in adjacent spots, false otherwise
        //[1, 2, 3, 3]
        //purpose of start: don't consider indices less than start
        public bool ContainsDouble(int[] values, int start = 0)
        {
            if (start + 1 >= values.Length)
            {
                return false;
            }
            if (values[start] == values[start + 1])
            {
                return true;
            }
            return ContainsDouble(values, start + 1);
        }
    }
}
