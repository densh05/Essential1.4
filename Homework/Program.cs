using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 5, 6 }; // масив

            int number = 3; // число

            int index = 2; // місце

            
            numbers = InsertElement(numbers, number, index);

           
            WriteNumbers(numbers);
        }

        static int[] InsertElement(int[] array, int number, int index)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            newArray[index] = number;

            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            return newArray; 
        }

        static void WriteNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
