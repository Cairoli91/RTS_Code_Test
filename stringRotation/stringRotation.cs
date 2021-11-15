using System;
using System.Text;

namespace stringRotation
{
    public class StringRotation
    {
        public string RotateString(int rotationNum, string inputString)
        {
            int inputLength = inputString.Length;
            StringBuilder newText = new StringBuilder();

            // Uses a count to base position off of. Modulus used to prevent errors from values greater than string length
            int rotationCount = (inputLength - (rotationNum % inputLength));


            for (int x = 0; x < inputLength; x++)
            {
                // Resets the count to 0 once it exceeds the length of the string
                if (rotationCount >= inputLength)
                    rotationCount = 0;

                // Appends current position char using the count and then increments
                newText.Append(inputString[(rotationCount)]);
                rotationCount++;

            }

            //Convert sb to string
            return newText.ToString();
        }
    }
}
