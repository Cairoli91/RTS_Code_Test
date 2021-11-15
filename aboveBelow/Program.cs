using System;

namespace aboveBelow
{
    class Program
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            //int[] array = new int[] { 1, 17, 11, 4, 10, 7, 2 };
            //int[] array = new int[] { 22, 37, 100, 90, 73, 15, 56 };
            //int[] array = new int[] { 2, 4, 6, 8, 10, 12, 14 };

            string inputNum;
            Console.Write("Enter the number you wish to compare to the list: ");
            inputNum = Console.ReadLine();
            int value = Convert.ToInt32(inputNum);

            AboveBelow a1 = new AboveBelow();
            int[] result = a1.CompareValue(value, array);
            Console.WriteLine("Above: " + result[1]);
            Console.WriteLine("Below: " + result[0]);
        }
    }
}
