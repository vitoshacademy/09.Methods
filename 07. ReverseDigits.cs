/*Write a method that reverses the digits of given decimal number. Example: 256  652*/
using System;
using System.Linq;
class ReverseDigits
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ReversedDigits(number));
    }
    static int ReversedDigits(int number)
    {
        int result = 0;
        while (number > 0)
        {
            result = result * 10 + number % 10;
            number = number / 10;              
        }
        return result;
    }

}
