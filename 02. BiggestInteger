/*Write a method GetMax() with two parameters that returns the bigger of two integers. 
 * Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter 3 integers");

        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());

        int firstBiggest = 0; //counting how many times the first integer is bigger;
        int secondBiggest = 0;
        int thirdBiggest = 0;

        int biggestInt; // this would be the biggest integer;

        if (CompareTwo(firstInt, secondInt) == firstInt)
        {
            firstBiggest++;
        }
        else
        {
            secondBiggest++;
        }

        if (CompareTwo(firstInt, thirdInt) == firstInt)
        {
            firstBiggest++;
        }
        else
        {
            thirdBiggest++;
        }

        if (CompareTwo(secondInt, thirdInt) == secondInt)
        {
            secondBiggest++;
        }
        else
        {
            thirdBiggest++;
        }

        if (thirdBiggest == 2)
        {
            Console.WriteLine("The biggest integer is {0}",thirdInt);
        }
        else if (secondBiggest == 2)
        {
            Console.WriteLine("The biggest integer is {0}", secondInt);
        }
        else
        {
            Console.WriteLine("The biggest integer is {0}", firstInt);
        }

    }

    static int CompareTwo(int x,int y)
    {
       if (x>y)
      {
            return x;
	    }
       return y;
    }
}
