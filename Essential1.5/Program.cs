using System;

namespace Essential1._5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] numbers =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            WriteNumbers(numbers);

            ParneNeparne(numbers[0]);
        }

        static void WriteNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void ParneNeparne(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number}: Parne");
            }
            else
            {
                Console.WriteLine($"{number}: Neparne");
            }
        }
    }
}
 //мтеод який буде приймати число і виводити на єкран парне непарне число