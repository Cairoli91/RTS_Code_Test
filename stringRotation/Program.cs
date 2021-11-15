using System;
using System.Text;

namespace stringRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputText = "MyString";
            //int rotateAmt = 4;

            // Request string from user
            Console.Write("Please enter a string of characters: ");
            string inputText = Console.ReadLine();

            // Request number from user and convert
            Console.Write("Please enter a number to rotate the string at: ");
            string inputNum = Console.ReadLine();
            int rotateAmt = Convert.ToInt32(inputNum);

            StringRotation s1 = new StringRotation();
            string newText = s1.RotateString(rotateAmt, inputText);

            Console.WriteLine(newText);


        }
    }
}
