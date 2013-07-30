using System;
class Digit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(number));
    }
    static string LastDigit(int number)
    {
        int remainder = number % 10;
        string [] Array = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        return Array[remainder];
    }
}
