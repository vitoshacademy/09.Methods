/*Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Faktoriel
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(Factorial(i));
        }
    }
    static BigInteger Factorial(BigInteger number)
    {
        BigInteger productN = 1;
        for (int i = 1; i <= number; i++)
        {
            productN *= i;
        }
        return productN;
    }
}

