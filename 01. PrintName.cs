/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
 * Write a program to test this method.*/


using System;
class PrintName
{
    static void Main()
    {
        PrintYourName();
    }

        static void PrintYourName()
    {
        Console.WriteLine("Please, enter your name:");
        string Name = Console.ReadLine();
        Console.WriteLine("Hello,{0}!",Name);
        return;
    }


}


