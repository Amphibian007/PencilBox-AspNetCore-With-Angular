using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargerBetweenFirstAndLastArrayElement(new int[] { 6, 3, 45, 3 }));
        }
        public static int LargerBetweenFirstAndLastArrayElement(int[] myArray)
        {
            if (myArray[0] > myArray[myArray.Length - 1])
                return myArray[0];
            else
                return myArray[myArray.Length - 1];
        }
    }
}
