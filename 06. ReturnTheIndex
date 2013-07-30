/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.*/


using System;
using System.Linq;

class ReturnIndex
{
    static void Main()
    {
            int[] array = new int[] { 1,2,3,4,5,6,7,10,11,12,12,141,1 }; // 141 has index 11 :)
            Console.WriteLine("The first element that is bigger than its neighbors has index:{0}.",FirstBiggerThanNeighbors(array));
    }
    static int FirstBiggerThanNeighbors(int[] array)
    {
        int indexOfFirst = 0;
        for (int i = 1; i < array.Length-1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                indexOfFirst = i;
                break;
            }
            else
                {
                    indexOfFirst = -1;
                }
                
        }
        return indexOfFirst;
    }
}

