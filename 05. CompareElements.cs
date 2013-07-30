/*Write a method that checks if the element at given position in given array 
 * of integers is bigger than its two neighbors (when such exist).*/

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your number:"); // Message
        int number = int.Parse(Console.ReadLine()); // Parse to integer from string
        Console.WriteLine("Enter number of elements of the array:"); // Message
        int n = int.Parse(Console.ReadLine()); // Parse to integer from string
        Console.WriteLine("Enter each element:"); // Message
        int[] array = new int[n]; // Initialization of an array
        for (int i = 0; i < array.Length; i++) //loop for initialization
        {
            array[i] = int.Parse(Console.ReadLine()); //Reading the array
        }
        Console.WriteLine("Your number {0} exists in the array {1} times.", number, NumberOfTimes(array, number)); //Last message, using the Number of times method
    }
    public static int NumberOfTimes(int[] array, int number) //initialization of method => reading int[] and int, returning int;
    {
        int numberOfTimes = 0; //declaration of method;
        for (int i = 0; i < array.Length; i++) //loop initialization
        {
            if (array[i] == number) 
            {
                numberOfTimes++; //increasing of the counter
            }
        }
        return numberOfTimes; 

    }
}
