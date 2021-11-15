using System;
namespace aboveBelow
{
    public class AboveBelow
    {
        public int[] CompareValue(int value, int[] numList)
        {
            // Array to store counts for above and below
            int[] arr = new int[2];

            foreach (int i in numList)
            {
                if (i < value)
                {
                    // Increment Below value
                    arr[0]++;
                }
                else if (i > value)
                {
                    // Increment Above value
                    arr[1]++;
                }
            }

            return (arr);

        }
    }
}
