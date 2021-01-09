using System;

namespace HTarray2
{
    class Program
    {
        static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value )
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 3, 4, 5, 6, 7, 8, 9 };

            int result = IndexOf(myArray, 6);

            Console.WriteLine(result);
        }
    }
}
