using System;
using System.Collections.Generic;

namespace MillerRabinPrimalityTest
{
    class Program
    {
        static List<int> FindPrimeFactorization(int num)
        {
            List<int> allPrimeFactors = new List<int>();

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (isPrime(i))
                    {
                        allPrimeFactors.Add(i);
                    }

                    
                    
                }
              
            }

            List<int> primeFactorization = new List<int>();

            while (!isPrime(num))
            { 
                num = num / allPrimeFactors[0];
                for (int j = 2; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        if (isPrime(j))
                        {
                            primeFactorization.Add(j);

                        }
                    }
                }

            }

            return allPrimeFactors;
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
            Console.WriteLine("Give Number!");
            int num = int.Parse(Console.ReadLine());
            List<int> primeFactors = FindPrimeFactorization(num);

            for (int i = 0; i < primeFactors.Count; i++)
            {
 
                Console.WriteLine(primeFactors[i]);
            }
            
        }
    }
}
