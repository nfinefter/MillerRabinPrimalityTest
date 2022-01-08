using System;
using System.Collections.Generic;

namespace MillerRabinPrimalityTest
{
    class Program
    {
        static void RemoveAll(List<int> values, int n)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (n == values[i])
                {
                    values.RemoveAt(i);
                    i--;
                }
            }
        }

        static List<int> FindPrimeFactorization(int num)
        {
            List<int> primeFactorization = new List<int>();

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (isPrime(i))
                    {
                        num /= i;
                        primeFactorization.Add(i);
                        i--;
                    }
                }
            }

            /*
            for (int i = 0; i < primeFactorization.Count; i++)
            {
                while (!isPrime(primeFactorization[i]))
                {
                    for (int j = 2; j <= num; j++)
                    {
                        if (num % j == 0)
                        {
                            if (isPrime(j))
                            {
                                primeFactorization.Add(j);
                                j--;
                            }
                        }
                    }
                }
            }*/

            /*
             * Given a number n
             * if j is a factor, add it to result
             * factor it out (divide) from n
             * 
             * 50 = 2 * 25
             * add 2 to output
             * repeat with n / 2
             * 25 = 5*5
             * add 5 to output
             * repeat with n / 5
             */
            return primeFactorization;
        }

        static List<int> PrimeFactorizationRecursive(int num)
        {
            if (num == 1 || num == 0)
            {
                return new List<int>();
            }
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    List<int> primeFactorization = PrimeFactorizationRecursive(num / i);
                    primeFactorization.Insert(0, i);
                    return primeFactorization;
                }
            }
            //Should not be reached
            return null;
        }

        static bool isPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            /*RecursionIntro recursionIntro = new RecursionIntro();
            
            Console.WriteLine("Enter a number:");
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine(recursionIntro.Factorial(userNum));
            Console.WriteLine($"The {userNum}th Fibonacci number is {recursionIntro.Fibonacci(userNum)}");
            recursionIntro.Countdown(userNum);
            
            int[] myArray = new int[] { 1, 2, 3, 3 };
            recursionIntro.ContainsDouble(myArray);
             */

            //Console.WriteLine("---Actual Primality Stuff---");

            Console.WriteLine("Give Number!");
            int num = int.Parse(Console.ReadLine());
            List<int> primeFactors = PrimeFactorizationRecursive(num);

            for (int i = 0; i < primeFactors.Count; i++)
            {
                Console.WriteLine(primeFactors[i]);
            }
        }
    }
}
